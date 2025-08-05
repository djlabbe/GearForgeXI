using FFXIComp.Api.Models;
using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GearController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet("slots")]
    public async Task<IActionResult> GetAvailableSlots()
    {
        var slots = await _context.GearSlots
            .OrderBy(s => s.Name)
            .Select(s => s.Name)
            .ToListAsync();

        return Ok(slots);
    }

    [HttpGet]
    public async Task<IActionResult> GetGear([FromQuery] string? job, [FromQuery] string? slot)
    {
        var jobNormalized = job?.Trim().ToUpper();
        var slotNormalized = slot?.Trim().ToLower();

        var query = _context.GearItems
            .Include(g => g.GearItemStats)
                .ThenInclude(gis => gis.Stat)
            .Include(g => g.GearItemJobs)
                .ThenInclude(gj => gj.Job)
            .Include(g => g.GearItemSlots)
                .ThenInclude(gs => gs.GearSlot)
            .Include(g => g.Category)
            .Where(g =>
                (string.IsNullOrWhiteSpace(jobNormalized) ||
                    g.GearItemJobs.Any(j => j.Job.Abbreviation == jobNormalized) ||
                    g.GearItemJobs.Count == 0) &&
                (string.IsNullOrWhiteSpace(slotNormalized) ||
                    g.GearItemSlots.Any(s => s.GearSlot.Name.ToLower() == slotNormalized)))
            .OrderBy(g => g.Name)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Stats = g.GearItemStats.Select(s => new GearStatDto
                {
                    Name = s.Stat.Name,
                    DisplayName = s.Stat.DisplayName,
                    Category = s.Stat.Category,
                    Description = s.Stat.Description,
                    Value = s.Value
                }).ToList(),
                Jobs = g.GearItemJobs.Select(j => j.Job.Abbreviation).ToList(),
                Slots = g.GearItemSlots.Select(s => s.GearSlot.Name).ToList(),
            });

        var result = await query.ToListAsync();
        return Ok(result);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetGearItem(int id)
    {
        var itemDto = await _context.GearItems
            .Where(g => g.Id == id)
            .Select(g => new GearItemDto
            {
                Id = g.Id,
                Name = g.Name,
                Category = g.Category != null ? g.Category.Name : null,
                Stats = g.GearItemStats
                    .Select(s => new GearStatDto
                    {
                        Name = s.Stat.Name,
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

        return itemDto is null ? NotFound() : Ok(itemDto);
    }

    [HttpPut("{id}/slots")]
    public async Task<IActionResult> UpdateGearItemSlots(int id, [FromBody] GearItemSlotUpdateDto dto)
    {
        var gearItem = await _context.GearItems
            .Include(g => g.GearItemSlots)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (gearItem == null)
            return NotFound($"GearItem with ID {id} not found.");

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


}
