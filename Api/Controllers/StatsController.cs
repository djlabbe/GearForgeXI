
using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatsController : ControllerBase
{
    private readonly GearDbContext _context;

    public StatsController(GearDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStats([FromQuery] string? category)
    {
        var query = _context.Stats.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            var normalized = category.Trim().ToLower();
            query = query.Where(s => s.Category != null && s.Category.ToLower() == normalized);
        }

        var stats = await query
            .OrderBy(s => s.Category)
            .ThenBy(s => s.DisplayName ?? s.Name)
            .Select(s => new StatDto
            {
                Id = s.Id,
                Name = s.Name,
                DisplayName = s.DisplayName,
                Category = s.Category,
                Description = s.Description
            })
            .ToListAsync();

        return Ok(stats);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStat(int id, [FromBody] StatDto statDto)
    {
        if (id != statDto.Id)
        {
            return BadRequest("ID mismatch between route and body");
        }

        var existingStat = await _context.Stats.FindAsync(id);
        if (existingStat == null)
        {
            return NotFound($"Stat with ID {id} not found");
        }

        // Update the properties
        existingStat.Name = statDto.Name;
        existingStat.DisplayName = statDto.DisplayName;
        existingStat.Category = statDto.Category;
        existingStat.Description = statDto.Description;

        try
        {
            await _context.SaveChangesAsync();
            return Ok(new StatDto
            {
                Id = existingStat.Id,
                Name = existingStat.Name,
                DisplayName = existingStat.DisplayName,
                Category = existingStat.Category,
                Description = existingStat.Description
            });
        }
        catch (DbUpdateConcurrencyException)
        {
            // Check if the stat still exists
            if (!await _context.Stats.AnyAsync(s => s.Id == id))
            {
                return NotFound($"Stat with ID {id} was deleted by another process");
            }
            throw;
        }
    }
}
