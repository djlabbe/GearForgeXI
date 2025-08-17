using GearForgeXI.Models.Dto;
using GearForgeXI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatsController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetAllStats([FromQuery] string? category)
    {
        var query = _context.Stats.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            // Try to parse the category string to enum for filtering
            if (Enum.TryParse<StatCategory>(category, true, out var categoryEnum))
            {
                query = query.Where(s => s.Category == categoryEnum);
            }
            else
            {
                // If parsing fails, return empty result
                query = query.Where(s => false);
            }
        }

        var stats = await query
            .OrderBy(s => s.Category)
            .ThenBy(s => s.DisplayName ?? s.Name)
            .Select(s => new StatDto
            {
                Id = s.Id,
                Name = s.Name,
                DisplayName = s.DisplayName,
                AlternateName1 = s.AlternateName1,
                AlternateName2 = s.AlternateName2,
                Category = s.Category != null ? s.Category.ToString() : null,
                Description = s.Description,
                IsBaseStat = s.IsBaseStat,
                GearItemCount = s.GearItemStats.Count,
            })
            .ToListAsync();

        return Ok(stats);
    }

    /// <summary>
    /// Get only base stats (STR, DEX, VIT, AGI, INT, MND, CHR) for use in race/job configurations
    /// </summary>
    [HttpGet("base")]
    public async Task<IActionResult> GetBaseStats()
    {
        var baseStats = await _context.Stats
            .Where(s => s.IsBaseStat)
            .OrderBy(s => s.Id)
            .Select(s => new StatDto
            {
                Id = s.Id,
                Name = s.Name,
                DisplayName = s.DisplayName,
                AlternateName1 = s.AlternateName1,
                AlternateName2 = s.AlternateName2,
                Category = s.Category != null ? s.Category.ToString() : null,
                Description = s.Description,
                IsBaseStat = s.IsBaseStat,
                GearItemCount = s.GearItemStats.Count,
            })
            .ToListAsync();

        return Ok(baseStats);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
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
        existingStat.AlternateName1 = statDto.AlternateName1;
        existingStat.AlternateName2 = statDto.AlternateName2;

        // Convert string category to enum
        if (string.IsNullOrWhiteSpace(statDto.Category))
        {
            existingStat.Category = null;
        }
        else if (Enum.TryParse<StatCategory>(statDto.Category, true, out var categoryEnum))
        {
            existingStat.Category = categoryEnum;
        }
        else
        {
            return BadRequest($"Invalid category: {statDto.Category}. Valid categories are: {string.Join(", ", Enum.GetNames<StatCategory>())}");
        }

        existingStat.Description = statDto.Description;
        existingStat.IsBaseStat = statDto.IsBaseStat;

        try
        {
            await _context.SaveChangesAsync();
            return Ok(new StatDto
            {
                Id = existingStat.Id,
                Name = existingStat.Name,
                DisplayName = existingStat.DisplayName,
                AlternateName1 = existingStat.AlternateName1,
                AlternateName2 = existingStat.AlternateName2,
                Category = existingStat.Category?.ToString(),
                Description = existingStat.Description,
                IsBaseStat = existingStat.IsBaseStat
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

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateStat([FromBody] StatDto statDto)
    {
        // Check if a stat with the same name already exists
        var existingStat = await _context.Stats
            .FirstOrDefaultAsync(s => s.Name.ToLower() == statDto.Name.ToLower());

        if (existingStat != null)
        {
            return Conflict($"A stat with the name '{statDto.Name}' already exists");
        }

        var newStat = new Stat
        {
            Name = statDto.Name,
            DisplayName = statDto.DisplayName,
            AlternateName1 = statDto.AlternateName1,
            AlternateName2 = statDto.AlternateName2,
            Description = statDto.Description,
            IsBaseStat = statDto.IsBaseStat
        };

        // Convert string category to enum
        if (!string.IsNullOrWhiteSpace(statDto.Category))
        {
            if (Enum.TryParse<StatCategory>(statDto.Category, true, out var categoryEnum))
            {
                newStat.Category = categoryEnum;
            }
            else
            {
                return BadRequest($"Invalid category: {statDto.Category}. Valid categories are: {string.Join(", ", Enum.GetNames<StatCategory>())}");
            }
        }

        _context.Stats.Add(newStat);
        await _context.SaveChangesAsync();

        var createdStatDto = new StatDto
        {
            Id = newStat.Id,
            Name = newStat.Name,
            DisplayName = newStat.DisplayName,
            AlternateName1 = newStat.AlternateName1,
            AlternateName2 = newStat.AlternateName2,
            Category = newStat.Category?.ToString(),
            Description = newStat.Description,
            IsBaseStat = newStat.IsBaseStat
        };

        return CreatedAtAction(nameof(GetAllStats), new { id = newStat.Id }, createdStatDto);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteStat(int id)
    {
        var existingStat = await _context.Stats.FindAsync(id);
        if (existingStat == null)
        {
            return NotFound($"Stat with ID {id} not found");
        }

        // Check if any gear items reference this stat
        var hasGearItemReferences = await _context.GearItemStats
            .AnyAsync(gis => gis.StatId == id);

        if (hasGearItemReferences)
        {
            return Conflict($"Cannot delete stat '{existingStat.Name}' because it is referenced by one or more gear items. Remove all references before deleting.");
        }

        _context.Stats.Remove(existingStat);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpGet("categories")]
    public IActionResult GetStatCategories()
    {
        var categories = Enum.GetNames<StatCategory>()
            .ToArray();

        return Ok(categories);
    }
}
