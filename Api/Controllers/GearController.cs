using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GearController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    // Helper method to get current user ID
    private string? GetCurrentUserId()
    {
        return User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }

    // Helper method to check if current user is admin
    private bool IsCurrentUserAdmin()
    {
        return User.IsInRole("Admin");
    }

    // Helper method to check if user can access/modify a gear item
    private bool CanUserModifyGearItem(GearItem gearItem)
    {
        // Admins can modify all items
        if (IsCurrentUserAdmin()) return true;

        // Users can only modify their own custom items
        var currentUserId = GetCurrentUserId();
        return !string.IsNullOrEmpty(currentUserId) &&
               gearItem.CreatedByUserId == currentUserId;
    }

    [HttpGet("slots")]
    [ResponseCache(Duration = 3600)] // Cache for 1 hour - slots rarely change
    public async Task<IActionResult> GetAvailableSlots()
    {
        var slots = await _context.GearSlots
            .AsNoTracking()
            .OrderBy(s => s.Id)
            .Select(s => s.Name)
            .ToListAsync();

        return Ok(slots);
    }

    [HttpGet("slots/mapping")]
    [ResponseCache(Duration = 3600)] // Cache for 1 hour - slot mappings rarely change
    public async Task<IActionResult> GetSlotMapping()
    {
        var slots = await _context.GearSlots
            .AsNoTracking()
            .OrderBy(s => s.Id)
            .Select(s => new { Id = s.Id, Name = s.Name })
            .ToListAsync();

        return Ok(slots);
    }

    [HttpGet("categories")]
    [ResponseCache(Duration = 3600)] // Cache for 1 hour - categories rarely change
    public async Task<IActionResult> GetAvailableCategories()
    {
        var categories = await _context.GearItemCategories
            .OrderBy(c => c.Name)
            .Select(c => c.Name)
            .ToListAsync();

        return Ok(categories);
    }

    // Helper method to map position names to database slot names
    private static string MapPositionToSlotName(string position)
    {
        var normalized = position.Trim().ToLower();
        return normalized switch
        {
            "ear" => "earrings",
            "ring" => "rings",
            _ => normalized
        };
    }

    [HttpGet]
    public async Task<IActionResult> GetGear([FromQuery] string? job, [FromQuery] string? slot, [FromQuery] int? statId)
    {
        var currentUserId = GetCurrentUserId();
        var isAdmin = IsCurrentUserAdmin();

        // Handle stat-only filtering for admin pages
        if (statId.HasValue && string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(slot))
        {
            // Build the base query with minimal includes for better performance
            IQueryable<GearItem> gearQuery = _context.GearItems
                .AsNoTracking()
                .Where(g => g.GearItemStats.Any(gis => gis.StatId == statId.Value));

            // Apply user filtering upfront to reduce dataset
            if (!isAdmin && !string.IsNullOrEmpty(currentUserId))
            {
                // Non-admins: system items OR their own custom items
                gearQuery = gearQuery.Where(g => g.CreatedByUserId == null || g.CreatedByUserId == currentUserId);
            }
            else if (!isAdmin)
            {
                // Anonymous users: only system items
                gearQuery = gearQuery.Where(g => g.CreatedByUserId == null);
            }

            var gearItems = await gearQuery
                .Include(g => g.Category)
                .OrderBy(g => g.Name)
                .ThenBy(g => g.Rank ?? int.MinValue)
                .ThenBy(g => g.Path)
                .Select(g => new GearItemDto
                {
                    Id = g.Id,
                    Name = g.Name,
                    Category = g.Category != null ? g.Category.Name : null,
                    Rank = g.Rank,
                    Path = g.Path,
                    Verified = g.Verified,
                    IsCustom = g.CreatedByUserId != null,
                    CreatedByUserId = isAdmin ? g.CreatedByUserId : null, // Only expose to admins
                    Stats = new List<GearStatDto>(), // Empty for admin view
                    Jobs = new List<string>(),       // Empty for admin view
                    Slots = new List<string>()       // Empty for admin view
                })
                .ToListAsync();

            return Ok(gearItems);
        }

        // Original job+slot filtering logic
        if (string.IsNullOrWhiteSpace(job))
            return BadRequest("Job parameter is required.");

        if (string.IsNullOrWhiteSpace(slot))
            return BadRequest("Slot parameter is required.");

        var jobNormalized = job.Trim().ToUpper();
        var slotNormalized = MapPositionToSlotName(slot);

        // Build base query with user filtering applied early
        IQueryable<GearItem> query = _context.GearItems.AsNoTracking();

        // Apply user filtering first to reduce dataset size
        if (!isAdmin && !string.IsNullOrEmpty(currentUserId))
        {
            // Non-admins: system items OR their own custom items
            query = query.Where(g => g.CreatedByUserId == null || g.CreatedByUserId == currentUserId);
        }
        else if (!isAdmin)
        {
            // Anonymous users: only system items
            query = query.Where(g => g.CreatedByUserId == null);
        }

        // Apply job and slot filtering
        query = query.Where(g =>
            (g.GearItemJobs.Any(j => j.Job.Abbreviation == jobNormalized) ||
             g.GearItemJobs.Count == 0) &&
            g.GearItemSlots.Any(s => s.GearSlot.Name.ToLower() == slotNormalized));

        var gearResult = await query
            .Include(g => g.GearItemStats)
                .ThenInclude(gis => gis.Stat)
            .Include(g => g.GearItemJobs)
                .ThenInclude(gj => gj.Job)
            .Include(g => g.GearItemSlots)
                .ThenInclude(gs => gs.GearSlot)
            .Include(g => g.Category)
            .OrderBy(g => g.Name)
                .ThenBy(g => g.Rank ?? int.MinValue)
                .ThenBy(g => g.Path)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.CreatedByUserId != null,
                CreatedByUserId = isAdmin ? g.CreatedByUserId : null, // Only expose to admins
                Stats = g.GearItemStats.Select(s => new GearStatDto
                {
                    Name = s.Stat.Name,
                    DisplayName = s.Stat.DisplayName,
                    Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                    Description = s.Stat.Description,
                    Value = s.Value
                }).ToList(),
                Jobs = g.GearItemJobs.Select(j => j.Job.Abbreviation).ToList(),
                Slots = g.GearItemSlots.Select(s => s.GearSlot.Name).ToList(),
            })
            .ToListAsync();

        return Ok(gearResult);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetGearItem(int id)
    {
        var currentUserId = GetCurrentUserId();
        var isAdmin = IsCurrentUserAdmin();

        var gearItem = await _context.GearItems
            .AsNoTracking()
            .Where(g => g.Id == id)
            .FirstOrDefaultAsync();

        if (gearItem == null)
            return NotFound();

        // Check permissions
        if (!isAdmin && gearItem.CreatedByUserId != null && gearItem.CreatedByUserId != currentUserId)
        {
            return NotFound(); // Hide existence of custom items from other users
        }

        var itemDto = await _context.GearItems
            .Where(g => g.Id == id)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.IsCustom,
                CreatedByUserId = g.CreatedByUserId,
                Stats = g.GearItemStats
                    .Select(s => new GearStatDto
                    {
                        Name = s.Stat.Name,
                        DisplayName = s.Stat.DisplayName,
                        Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                        Description = s.Stat.Description,
                        Value = s.Value
                    }).ToList(),
                Jobs = g.GearItemJobs
                    .Select(j => j.Job.Abbreviation)
                    .ToList(),
                Slots = g.GearItemSlots
                    .Select(s => s.GearSlot.Name)
                    .ToList()
            })
            .FirstOrDefaultAsync();

        return Ok(itemDto);
    }

    [HttpPost]
    [Authorize] // Allow authenticated users (both admins and regular users)
    public async Task<IActionResult> CreateGearItem([FromBody] CreateGearItemDto dto)
    {
        var currentUserId = GetCurrentUserId();
        var isAdmin = IsCurrentUserAdmin();

        // Only authenticated users can create items
        if (string.IsNullOrEmpty(currentUserId))
            return Unauthorized();

        // Validate required fields
        if (string.IsNullOrWhiteSpace(dto.Name))
            return BadRequest("Name is required.");

        if (dto.Slots.Count == 0)
            return BadRequest("At least one slot must be specified.");

        // Check if gear item with this combination already exists
        // For system items (admin), check all items
        // For custom items (user), only check their own items
        var trimmedName = dto.Name.Trim();
        IQueryable<GearItem> existingQuery = _context.GearItems
            .Where(g => g.Name.ToLower() == trimmedName.ToLower() &&
                       g.Rank == dto.Rank &&
                       g.Path == dto.Path);

        if (!isAdmin)
        {
            // For users, only check against system items and their own custom items
            existingQuery = existingQuery.Where(g => g.CreatedByUserId == null ||
                                                    g.CreatedByUserId == currentUserId);
        }

        var existingItem = await existingQuery.FirstOrDefaultAsync();

        if (existingItem != null)
        {
            var identifier = trimmedName;
            if (dto.Rank.HasValue) identifier += $" R{dto.Rank}";
            if (!string.IsNullOrEmpty(dto.Path)) identifier += $" {dto.Path}";
            return BadRequest($"Gear item '{identifier}' already exists.");
        }

        // Validate slots exist
        var slotNames = dto.Slots.Select(s => s.Trim().ToLower()).ToList();
        var validSlots = await _context.GearSlots
            .Where(gs => slotNames.Contains(gs.Name.ToLower()))
            .ToListAsync();

        if (validSlots.Count != slotNames.Count)
        {
            var foundNames = validSlots.Select(s => s.Name.ToLower());
            var missing = slotNames.Except(foundNames);
            return BadRequest($"Invalid slot(s): {string.Join(", ", missing)}");
        }

        // Validate slot assignment rules (same as update method)
        if (slotNames.Count > 1)
        {
            var hasMain = slotNames.Contains("main");
            var hasSub = slotNames.Contains("sub");

            if (!(hasMain && hasSub && slotNames.Count == 2))
            {
                return BadRequest("A gear item can only have one slot, except it can have both 'Main' and 'Sub' slots.");
            }
        }

        // Validate jobs exist (if any specified)
        List<Job> validJobs = [];
        if (dto.Jobs.Count > 0)
        {
            var jobAbbreviations = dto.Jobs.Select(j => j.Trim().ToUpper()).ToList();
            validJobs = await _context.Jobs
                .Where(j => jobAbbreviations.Contains(j.Abbreviation))
                .ToListAsync();

            if (validJobs.Count != jobAbbreviations.Count)
            {
                var foundAbbreviations = validJobs.Select(j => j.Abbreviation);
                var missing = jobAbbreviations.Except(foundAbbreviations);
                return BadRequest($"Invalid job(s): {string.Join(", ", missing)}");
            }
        }

        // Validate stats exist (if any specified)
        List<Stat> validStats = [];
        if (dto.Stats.Count > 0)
        {
            var statNames = dto.Stats.Select(s => s.StatName.Trim().ToLower()).ToList();

            // Check for duplicate stats in the request
            var duplicateStats = statNames.GroupBy(s => s)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (duplicateStats.Count > 0)
            {
                return BadRequest($"Duplicate stat(s) in request: {string.Join(", ", duplicateStats)}. Each stat can only be specified once per item.");
            }

            var uniqueStatNames = statNames.Distinct().ToList();
            validStats = await _context.Stats
                .Where(s => uniqueStatNames.Contains(s.Name.ToLower()))
                .ToListAsync();

            if (validStats.Count != uniqueStatNames.Count)
            {
                var foundNames = validStats.Select(s => s.Name.ToLower());
                var missing = uniqueStatNames.Except(foundNames);
                return BadRequest($"Invalid stat(s): {string.Join(", ", missing)}");
            }
        }

        // Validate category exists (if specified)
        GearItemCategory? category = null;
        if (!string.IsNullOrWhiteSpace(dto.CategoryName))
        {
            category = await _context.GearItemCategories
                .FirstOrDefaultAsync(c => c.Name.ToLower() == dto.CategoryName.Trim().ToLower());

            if (category == null)
                return BadRequest($"Category '{dto.CategoryName}' not found.");
        }

        // Create the gear item
        var gearItem = new GearItem
        {
            Name = dto.Name.Trim(),
            GearItemCategoryId = category?.Id,
            Rank = dto.Rank,
            Path = dto.Path,
            Verified = isAdmin ? (dto.Verified ?? false) : false, // Only admins can create verified items
            CreatedByUserId = isAdmin ? null : currentUserId // System item if admin, custom item if user
        };

        _context.GearItems.Add(gearItem);
        await _context.SaveChangesAsync(); // Save to get the ID

        // Add slots
        foreach (var slot in validSlots)
        {
            _context.GearItemSlots.Add(new GearItemSlot
            {
                GearItemId = gearItem.Id,
                GearSlotId = slot.Id
            });
        }

        // Add jobs
        foreach (var job in validJobs)
        {
            _context.GearItemJobs.Add(new GearItemJob
            {
                GearItemId = gearItem.Id,
                JobId = job.Id
            });
        }

        // Add stats
        foreach (var statDto in dto.Stats)
        {
            var stat = validStats.First(s => s.Name.ToLower() == statDto.StatName.Trim().ToLower());
            _context.GearItemStats.Add(new GearItemStat
            {
                GearItemId = gearItem.Id,
                StatId = stat.Id,
                Value = statDto.Value
            });
        }

        await _context.SaveChangesAsync();

        // Return the created item with full details
        var createdItemDto = await _context.GearItems
            .Where(g => g.Id == gearItem.Id)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.IsCustom,
                CreatedByUserId = g.CreatedByUserId,
                Stats = g.GearItemStats
                    .Select(s => new GearStatDto
                    {
                        Name = s.Stat.Name,
                        DisplayName = s.Stat.DisplayName,
                        Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                        Description = s.Stat.Description,
                        Value = s.Value
                    }).ToList(),
                Jobs = g.GearItemJobs
                    .Select(j => j.Job.Abbreviation)
                    .ToList(),
                Slots = g.GearItemSlots
                    .Select(s => s.GearSlot.Name)
                    .ToList()
            })
            .FirstOrDefaultAsync();

        return CreatedAtAction(nameof(GetGearItem), new { id = gearItem.Id }, createdItemDto);
    }

    [HttpPut("{id}/slots")]
    [Authorize] // Allow authenticated users
    public async Task<IActionResult> UpdateGearItemSlots(int id, [FromBody] GearItemSlotUpdateDto dto)
    {
        var gearItem = await _context.GearItems
            .Include(g => g.GearItemSlots)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (gearItem == null)
            return NotFound($"GearItem with ID {id} not found.");

        // Check permissions
        if (!CanUserModifyGearItem(gearItem))
            return Forbid("You can only modify system items as an admin or your own custom items.");

        // Validate that all slots exist
        var allSlotNames = dto.Slots.Select(s => s.Trim().ToLower()).ToList();

        if (allSlotNames.Count == 0)
            return BadRequest("At least one slot must be specified.");

        var validSlots = await _context.GearSlots
            .Where(gs => allSlotNames.Contains(gs.Name.ToLower()))
            .ToListAsync();

        if (validSlots.Count != allSlotNames.Count)
        {
            var foundNames = validSlots.Select(s => s.Name.ToLower());
            var missing = allSlotNames.Except(foundNames);
            return BadRequest($"Invalid slot(s): {string.Join(", ", missing)}");
        }

        // Validate slot assignment rules
        var slotNames = validSlots.Select(s => s.Name.ToLower()).ToList();

        // Check if gear item can only have one slot, except it can have both "Main" and "Sub"
        if (slotNames.Count > 1)
        {
            // Only allow multiple slots if they are exactly "main" and "sub"
            var hasMain = slotNames.Contains("main");
            var hasSub = slotNames.Contains("sub");

            if (!(hasMain && hasSub && slotNames.Count == 2))
            {
                return BadRequest("A gear item can only have one slot, except it can have both 'Main' and 'Sub' slots.");
            }
        }

        // Remove old slots
        _context.GearItemSlots.RemoveRange(gearItem.GearItemSlots);

        // Add new slots
        foreach (var slot in validSlots)
        {
            _context.GearItemSlots.Add(new GearItemSlot
            {
                GearItemId = id,
                GearSlotId = slot.Id
            });
        }

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}/category")]
    [Authorize] // Allow authenticated users
    public async Task<IActionResult> UpdateGearItemCategory(int id, [FromBody] GearItemCategoryUpdateDto dto)
    {
        var gearItem = await _context.GearItems
            .FirstOrDefaultAsync(g => g.Id == id);

        if (gearItem == null)
            return NotFound($"GearItem with ID {id} not found.");

        // Check permissions
        if (!CanUserModifyGearItem(gearItem))
            return Forbid("You can only modify system items as an admin or your own custom items.");

        // If categoryName is null or empty, remove the category
        if (string.IsNullOrWhiteSpace(dto.CategoryName))
        {
            gearItem.GearItemCategoryId = null;
        }
        else
        {
            // Find the category by name
            var category = await _context.GearItemCategories
                .FirstOrDefaultAsync(c => c.Name.ToLower() == dto.CategoryName.Trim().ToLower());

            if (category == null)
                return BadRequest($"Category '{dto.CategoryName}' not found.");

            gearItem.GearItemCategoryId = category.Id;
        }

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}")]
    [Authorize] // Allow authenticated users
    public async Task<IActionResult> UpdateGearItem(int id, [FromBody] CreateGearItemDto dto)
    {
        var currentUserId = GetCurrentUserId();
        var isAdmin = IsCurrentUserAdmin();

        // Validate required fields
        if (string.IsNullOrWhiteSpace(dto.Name))
            return BadRequest("Name is required.");

        if (dto.Slots.Count == 0)
            return BadRequest("At least one slot must be specified.");

        // Check if gear item exists
        var gearItem = await _context.GearItems
            .Include(g => g.GearItemSlots)
            .Include(g => g.GearItemJobs)
            .Include(g => g.GearItemStats)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (gearItem == null)
            return NotFound($"GearItem with ID {id} not found.");

        // Check permissions
        if (!CanUserModifyGearItem(gearItem))
            return Forbid("You can only modify system items as an admin or your own custom items.");

        // Check if updating would create a duplicate with the composite key (Name, Rank, Path)
        var trimmedName = dto.Name.Trim();
        var wouldBeDuplicate = gearItem.Name.ToLower() != trimmedName.ToLower() ||
                              gearItem.Rank != dto.Rank ||
                              gearItem.Path != dto.Path;

        if (wouldBeDuplicate)
        {
            IQueryable<GearItem> existingQuery = _context.GearItems
                .Where(g => g.Id != id &&
                           g.Name.ToLower() == trimmedName.ToLower() &&
                           g.Rank == dto.Rank &&
                           g.Path == dto.Path);

            if (!isAdmin && gearItem.IsCustom)
            {
                // For custom items, only check against system items and their own custom items
                existingQuery = existingQuery.Where(g => g.CreatedByUserId == null ||
                                                        g.CreatedByUserId == currentUserId);
            }

            var existingItem = await existingQuery.FirstOrDefaultAsync();

            if (existingItem != null)
            {
                var identifier = trimmedName;
                if (dto.Rank.HasValue) identifier += $" R{dto.Rank}";
                if (!string.IsNullOrEmpty(dto.Path)) identifier += $" {dto.Path}";
                return BadRequest($"Gear item '{identifier}' already exists.");
            }
        }

        // Validate slots exist
        var slotNames = dto.Slots.Select(s => s.Trim().ToLower()).ToList();
        var validSlots = await _context.GearSlots
            .Where(gs => slotNames.Contains(gs.Name.ToLower()))
            .ToListAsync();

        if (validSlots.Count != slotNames.Count)
        {
            var foundNames = validSlots.Select(s => s.Name.ToLower());
            var missing = slotNames.Except(foundNames);
            return BadRequest($"Invalid slot(s): {string.Join(", ", missing)}");
        }

        // Validate slot assignment rules
        if (slotNames.Count > 1)
        {
            var hasMain = slotNames.Contains("main");
            var hasSub = slotNames.Contains("sub");

            if (!(hasMain && hasSub && slotNames.Count == 2))
            {
                return BadRequest("A gear item can only have one slot, except it can have both 'Main' and 'Sub' slots.");
            }
        }

        // Validate jobs exist (if any specified)
        List<Job> validJobs = [];
        if (dto.Jobs.Count > 0)
        {
            var jobAbbreviations = dto.Jobs.Select(j => j.Trim().ToUpper()).ToList();
            validJobs = await _context.Jobs
                .Where(j => jobAbbreviations.Contains(j.Abbreviation))
                .ToListAsync();

            if (validJobs.Count != jobAbbreviations.Count)
            {
                var foundAbbreviations = validJobs.Select(j => j.Abbreviation);
                var missing = jobAbbreviations.Except(foundAbbreviations);
                return BadRequest($"Invalid job(s): {string.Join(", ", missing)}");
            }
        }

        // Validate stats exist (if any specified)
        List<Stat> validStats = [];
        if (dto.Stats.Count > 0)
        {
            var statNames = dto.Stats.Select(s => s.StatName.Trim().ToLower()).ToList();

            // Check for duplicate stats in the request
            var duplicateStats = statNames.GroupBy(s => s)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (duplicateStats.Count > 0)
            {
                return BadRequest($"Duplicate stat(s) in request: {string.Join(", ", duplicateStats)}. Each stat can only be specified once per item.");
            }

            var uniqueStatNames = statNames.Distinct().ToList();
            validStats = await _context.Stats
                .Where(s => uniqueStatNames.Contains(s.Name.ToLower()))
                .ToListAsync();

            if (validStats.Count != uniqueStatNames.Count)
            {
                var foundNames = validStats.Select(s => s.Name.ToLower());
                var missing = uniqueStatNames.Except(foundNames);
                return BadRequest($"Invalid stat(s): {string.Join(", ", missing)}");
            }
        }

        // Validate category exists (if specified)
        GearItemCategory? category = null;
        if (!string.IsNullOrWhiteSpace(dto.CategoryName))
        {
            category = await _context.GearItemCategories
                .FirstOrDefaultAsync(c => c.Name.ToLower() == dto.CategoryName.Trim().ToLower());

            if (category == null)
                return BadRequest($"Category '{dto.CategoryName}' not found.");
        }

        // Update the gear item properties
        gearItem.Name = trimmedName;
        gearItem.GearItemCategoryId = category?.Id;
        gearItem.Rank = dto.Rank;
        gearItem.Path = dto.Path;

        // Only admins can modify the verified flag
        if (isAdmin)
        {
            gearItem.Verified = dto.Verified ?? false;
        }
        // Users cannot modify the verified status of their custom items

        // Remove existing slots, jobs, and stats
        _context.GearItemSlots.RemoveRange(gearItem.GearItemSlots);
        _context.GearItemJobs.RemoveRange(gearItem.GearItemJobs);
        _context.GearItemStats.RemoveRange(gearItem.GearItemStats);

        // Add new slots
        foreach (var slot in validSlots)
        {
            _context.GearItemSlots.Add(new GearItemSlot
            {
                GearItemId = gearItem.Id,
                GearSlotId = slot.Id
            });
        }

        // Add new jobs
        foreach (var job in validJobs)
        {
            _context.GearItemJobs.Add(new GearItemJob
            {
                GearItemId = gearItem.Id,
                JobId = job.Id
            });
        }

        // Add new stats
        foreach (var statDto in dto.Stats)
        {
            var stat = validStats.First(s => s.Name.ToLower() == statDto.StatName.Trim().ToLower());
            _context.GearItemStats.Add(new GearItemStat
            {
                GearItemId = gearItem.Id,
                StatId = stat.Id,
                Value = statDto.Value
            });
        }

        await _context.SaveChangesAsync();

        // Return the updated item with full details
        var updatedItemDto = await _context.GearItems
            .Where(g => g.Id == gearItem.Id)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.IsCustom,
                CreatedByUserId = g.CreatedByUserId,
                Stats = g.GearItemStats
                    .Select(s => new GearStatDto
                    {
                        Name = s.Stat.Name,
                        DisplayName = s.Stat.DisplayName,
                        Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                        Description = s.Stat.Description,
                        Value = s.Value
                    }).ToList(),
                Jobs = g.GearItemJobs
                    .Select(j => j.Job.Abbreviation)
                    .ToList(),
                Slots = g.GearItemSlots
                    .Select(s => s.GearSlot.Name)
                    .ToList()
            })
            .FirstOrDefaultAsync();

        return Ok(updatedItemDto);
    }

    [HttpDelete("{id}")]
    [Authorize] // Allow authenticated users
    public async Task<IActionResult> DeleteGearItem(int id)
    {
        var gearItem = await _context.GearItems
            .Include(g => g.GearItemStats)
            .Include(g => g.GearItemJobs)
            .Include(g => g.GearItemSlots)
            .Where(g => g.Id == id)
            .FirstOrDefaultAsync();

        if (gearItem == null)
            return NotFound($"Gear item with ID {id} not found.");

        // Check permissions
        if (!CanUserModifyGearItem(gearItem))
            return Forbid("You can only delete system items as an admin or your own custom items.");

        // Check if this gear item is being used in any gear sets
        var isUsedInGearSets = await _context.GearSetItems
            .AnyAsync(gsi => gsi.GearItemId == id);

        if (isUsedInGearSets)
            return BadRequest("Cannot delete gear item as it is currently being used in one or more gear sets.");

        // Remove related entities first
        _context.GearItemStats.RemoveRange(gearItem.GearItemStats);
        _context.GearItemJobs.RemoveRange(gearItem.GearItemJobs);
        _context.GearItemSlots.RemoveRange(gearItem.GearItemSlots);

        // Remove the gear item itself
        _context.GearItems.Remove(gearItem);

        await _context.SaveChangesAsync();

        return NoContent();
    }

    // New endpoint for users to get their custom items
    [HttpGet("custom")]
    [Authorize] // Authenticated users only
    public async Task<IActionResult> GetMyCustomGearItems()
    {
        var currentUserId = GetCurrentUserId();
        if (string.IsNullOrEmpty(currentUserId))
            return Unauthorized();

        var customItems = await _context.GearItems
            .AsNoTracking()
            .Include(g => g.Category)
            .Include(g => g.GearItemStats)
                .ThenInclude(gis => gis.Stat)
            .Include(g => g.GearItemJobs)
                .ThenInclude(gj => gj.Job)
            .Include(g => g.GearItemSlots)
                .ThenInclude(gs => gs.GearSlot)
            .Where(g => g.CreatedByUserId == currentUserId)
            .OrderBy(g => g.Name)
                .ThenBy(g => g.Rank ?? int.MinValue)
                .ThenBy(g => g.Path)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.IsCustom,
                CreatedByUserId = g.CreatedByUserId,
                Stats = g.GearItemStats.Select(s => new GearStatDto
                {
                    Name = s.Stat.Name,
                    DisplayName = s.Stat.DisplayName,
                    Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                    Description = s.Stat.Description,
                    Value = s.Value
                }).ToList(),
                Jobs = g.GearItemJobs.Select(j => j.Job.Abbreviation).ToList(),
                Slots = g.GearItemSlots.Select(s => s.GearSlot.Name).ToList(),
            })
            .ToListAsync();

        return Ok(customItems);
    }

    // New endpoint for admins to get all custom items
    [HttpGet("custom/all")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllCustomGearItems()
    {
        var customItems = await _context.GearItems
            .AsNoTracking()
            .Include(g => g.Category)
            .Include(g => g.CreatedByUser)
            .Include(g => g.GearItemStats)
                .ThenInclude(gis => gis.Stat)
            .Include(g => g.GearItemJobs)
                .ThenInclude(gj => gj.Job)
            .Include(g => g.GearItemSlots)
                .ThenInclude(gs => gs.GearSlot)
            .Where(g => g.CreatedByUserId != null)
            .OrderBy(g => g.CreatedByUser!.UserName)
                .ThenBy(g => g.Name)
                .ThenBy(g => g.Rank ?? int.MinValue)
                .ThenBy(g => g.Path)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Rank = g.Rank,
                Path = g.Path,
                Verified = g.Verified,
                IsCustom = g.IsCustom,
                CreatedByUserId = g.CreatedByUserId,
                Stats = g.GearItemStats.Select(s => new GearStatDto
                {
                    Name = s.Stat.Name,
                    DisplayName = s.Stat.DisplayName,
                    Category = s.Stat.Category != null ? s.Stat.Category.ToString() : null,
                    Description = s.Stat.Description,
                    Value = s.Value
                }).ToList(),
                Jobs = g.GearItemJobs.Select(j => j.Job.Abbreviation).ToList(),
                Slots = g.GearItemSlots.Select(s => s.GearSlot.Name).ToList(),
            })
            .ToListAsync();

        return Ok(customItems);
    }
}