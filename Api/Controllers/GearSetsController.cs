using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GearSetsController(
    GearDbContext context
) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetUserGearSets()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var gearSets = await _context.GearSets
            .AsNoTracking()
            .Include(gs => gs.Job) // Include Job navigation property
            .Include(gs => gs.GearSetItems)
                .ThenInclude(gss => gss.GearItem)
                    .ThenInclude(gi => gi.GearItemStats)
                        .ThenInclude(gis => gis.Stat)
            .Include(gs => gs.GearSetItems)
                .ThenInclude(gss => gss.GearItem)
                    .ThenInclude(gi => gi.GearItemJobs)
                        .ThenInclude(gij => gij.Job)
            .Include(gs => gs.GearSetItems)
                .ThenInclude(gss => gss.GearItem)
                    .ThenInclude(gi => gi.GearItemSlots)
                        .ThenInclude(gis => gis.GearSlot)
            .Include(gs => gs.GearSetItems)
                .ThenInclude(gss => gss.GearItem)
                    .ThenInclude(gi => gi.Category)
            .Where(gs => gs.UserId == userId)
            .Select(gs => new GearSetDto
            {
                Id = gs.Id,
                Name = gs.Name,
                Description = gs.Description,
                JobId = gs.JobId,
                Job = new JobDto
                {
                    Id = gs.Job.Id,
                    Abbreviation = gs.Job.Abbreviation,
                    FullName = gs.Job.FullName,
                    CanDualWield = gs.Job.CanDualWield
                },
                GearSetItems = gs.GearSetItems.Select(gss => new GearSetItemDto
                {
                    Id = gss.Id,
                    Position = gss.Position.ToString(),
                    GearItem = new GearItemDto
                    {
                        Id = gss.GearItem.Id,
                        Name = gss.GearItem.Name,
                        Category = gss.GearItem.Category != null ? gss.GearItem.Category.Name : null,
                        Rank = gss.GearItem.Rank,
                        Path = gss.GearItem.Path,
                        Verified = gss.GearItem.Verified,
                        Stats = gss.GearItem.GearItemStats.Select(gis => new GearStatDto
                        {
                            Name = gis.Stat.Name,
                            DisplayName = gis.Stat.DisplayName,
                            Category = gis.Stat.Category != null ? gis.Stat.Category.ToString() : null,
                            Description = gis.Stat.Description,
                            Value = gis.Value
                        }).ToList(),
                        Jobs = gss.GearItem.GearItemJobs.Select(gij => gij.Job.Abbreviation).ToList(),
                        Slots = gss.GearItem.GearItemSlots.Select(gis => gis.GearSlot.Name).ToList()
                    }
                }).ToList()
            })
            .ToListAsync();

        return Ok(gearSets);
    }


    [HttpPost]
    public async Task<IActionResult> CreateGearSet(CreateGearSetDto dto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var gearSet = new GearSet
        {
            Name = dto.Name,
            Description = dto.Description,
            UserId = userId,
            JobId = dto.JobId
        };

        // Add the gear set first to get the ID
        _context.GearSets.Add(gearSet);
        await _context.SaveChangesAsync();

        // Create gear set slots if provided
        if (dto.GearSetSlots.Any())
        {
            foreach (var slotDto in dto.GearSetSlots)
            {
                var gearSetSlot = new GearSetItem
                {
                    GearSetId = gearSet.Id,
                    GearItemId = slotDto.GearItemId,
                    Position = (SetPosition)Enum.Parse(typeof(SetPosition), slotDto.Position)
                };

                _context.GearSetItems.Add(gearSetSlot);
            }

            await _context.SaveChangesAsync();
        }

        // Return simple DTO with empty slots list
        return Ok(new GearSetDto
        {
            Id = gearSet.Id,
            Name = gearSet.Name,
            Description = gearSet.Description,
            GearSetItems = new List<GearSetItemDto>()
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGearSet(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var gearSetDto = await _context.GearSets
            .Where(gs => gs.Id == id && gs.UserId == userId)
            .Select(gs => new GearSetDto
            {
                Id = gs.Id,
                Name = gs.Name,
                Description = gs.Description,
                GearSetItems = gs.GearSetItems.Select(gss => new GearSetItemDto
                {
                    Id = gss.Id,
                    Position = gss.Position.ToString(),
                    GearItem = gss.GearItem != null ? new GearItemDto
                    {
                        Id = gss.GearItem.Id,
                        Name = gss.GearItem.Name,
                        Category = gss.GearItem.Category != null ? gss.GearItem.Category.Name : null,
                        Rank = gss.GearItem.Rank,
                        Path = gss.GearItem.Path,
                        Verified = gss.GearItem.Verified,
                        Stats = gss.GearItem.GearItemStats.Select(gis => new GearStatDto
                        {
                            Name = gis.Stat.Name,
                            DisplayName = gis.Stat.DisplayName,
                            Category = gis.Stat.Category != null ? gis.Stat.Category.ToString() : null,
                            Description = gis.Stat.Description,
                            Value = gis.Value
                        }).ToList(),
                        Jobs = gss.GearItem.GearItemJobs.Select(gij => gij.Job.Abbreviation).ToList(),
                        Slots = gss.GearItem.GearItemSlots.Select(gis => gis.GearSlot.Name).ToList()
                    } : null
                }).ToList()
            })
            .FirstOrDefaultAsync();

        if (gearSetDto == null) return NotFound();

        return Ok(gearSetDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateGearSet(int id, CreateGearSetDto dto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        // Find the existing gear set
        var existingGearSet = await _context.GearSets
            .Include(gs => gs.GearSetItems)
            .FirstOrDefaultAsync(gs => gs.Id == id && gs.UserId == userId);

        if (existingGearSet == null) return NotFound();

        // Update basic properties
        existingGearSet.Name = dto.Name;
        existingGearSet.Description = dto.Description;
        existingGearSet.JobId = dto.JobId;

        // Remove all existing gear set items
        _context.GearSetItems.RemoveRange(existingGearSet.GearSetItems);

        // Add new gear set items if provided
        if (dto.GearSetSlots.Any())
        {
            foreach (var slotDto in dto.GearSetSlots)
            {
                var gearSetItem = new GearSetItem
                {
                    GearSetId = existingGearSet.Id,
                    GearItemId = slotDto.GearItemId,
                    Position = (SetPosition)Enum.Parse(typeof(SetPosition), slotDto.Position)
                };

                _context.GearSetItems.Add(gearSetItem);
            }
        }

        await _context.SaveChangesAsync();

        // Return the updated gear set with full details
        var updatedGearSetDto = await _context.GearSets
            .Where(gs => gs.Id == id)
            .Select(gs => new GearSetDto
            {
                Id = gs.Id,
                Name = gs.Name,
                Description = gs.Description,
                JobId = gs.JobId,
                Job = new JobDto
                {
                    Id = gs.Job.Id,
                    FullName = gs.Job.FullName,
                    Abbreviation = gs.Job.Abbreviation,
                    CanDualWield = gs.Job.CanDualWield
                },
                GearSetItems = gs.GearSetItems.Select(gss => new GearSetItemDto
                {
                    Id = gss.Id,
                    Position = gss.Position.ToString(),
                    GearItem = gss.GearItem != null ? new GearItemDto
                    {
                        Id = gss.GearItem.Id,
                        Name = gss.GearItem.Name,
                        Category = gss.GearItem.Category != null ? gss.GearItem.Category.Name : null,
                        Rank = gss.GearItem.Rank,
                        Path = gss.GearItem.Path,
                        Verified = gss.GearItem.Verified,
                        Stats = gss.GearItem.GearItemStats.Select(gis => new GearStatDto
                        {
                            Name = gis.Stat.Name,
                            DisplayName = gis.Stat.DisplayName,
                            Category = gis.Stat.Category != null ? gis.Stat.Category.ToString() : null,
                            Description = gis.Stat.Description,
                            Value = gis.Value
                        }).ToList(),
                        Jobs = gss.GearItem.GearItemJobs.Select(gij => gij.Job.Abbreviation).ToList(),
                        Slots = gss.GearItem.GearItemSlots.Select(gis => gis.GearSlot.Name).ToList()
                    } : null
                }).ToList()
            })
            .FirstOrDefaultAsync();

        return Ok(updatedGearSetDto);
    }

}

