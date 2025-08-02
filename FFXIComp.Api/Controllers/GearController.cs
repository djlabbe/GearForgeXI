using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GearController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetGear([FromQuery] string? job, [FromQuery] string? slot)
    {
        var jobNormalized = job?.Trim().ToUpper();
        var slotNormalized = slot?.Trim().ToLower();

        var query = _context.GearItems
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
                Stats = g.GearStats.Select(s => new GearStatDto
                {
                    Name = s.Name,
                    Value = s.Value
                }).ToList(),
                Jobs = g.GearItemJobs.Select(j => j.Job.Abbreviation).ToList(),
                Slots = g.GearItemSlots.Select(s => s.GearSlot.Name).ToList()
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
                Stats = g.GearStats
                    .Select(s => new GearStatDto
                    {
                        Name = s.Name,
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
}
