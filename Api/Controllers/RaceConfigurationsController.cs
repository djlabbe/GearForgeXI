using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // Add authorization as needed for admin operations
public class RaceConfigurationsController : ControllerBase
{
    private readonly GearDbContext _context;

    public RaceConfigurationsController(GearDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Get all race configurations with their base stats
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RaceConfigurationDto>>> GetRaceConfigurations()
    {
        var raceConfigurations = await _context.RaceConfigurations
            .Include(rc => rc.RaceBaseStats)
                .ThenInclude(rbs => rbs.Stat)
            .ToListAsync();

        var result = raceConfigurations.Select(rc => new RaceConfigurationDto
        {
            Id = rc.Id,
            Name = rc.Name,
            Abbreviation = rc.Abbreviation,
            RaceBaseStats = rc.RaceBaseStats.Select(rbs => new RaceBaseStatDto
            {
                Id = rbs.Id,
                RaceConfigurationId = rbs.RaceConfigurationId,
                StatId = rbs.StatId,
                Stat = new StatDto
                {
                    Id = rbs.Stat.Id,
                    Name = rbs.Stat.Name,
                    DisplayName = rbs.Stat.DisplayName
                },
                Value = rbs.Value
            }).ToList()
        }).ToList();

        return result;
    }

    /// <summary>
    /// Get a specific race configuration by ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<RaceConfigurationDto>> GetRaceConfiguration(int id)
    {
        var raceConfiguration = await _context.RaceConfigurations
            .Include(rc => rc.RaceBaseStats)
                .ThenInclude(rbs => rbs.Stat)
            .FirstOrDefaultAsync(rc => rc.Id == id);

        if (raceConfiguration == null)
        {
            return NotFound();
        }

        var result = new RaceConfigurationDto
        {
            Id = raceConfiguration.Id,
            Name = raceConfiguration.Name,
            Abbreviation = raceConfiguration.Abbreviation,
            RaceBaseStats = raceConfiguration.RaceBaseStats.Select(rbs => new RaceBaseStatDto
            {
                Id = rbs.Id,
                RaceConfigurationId = rbs.RaceConfigurationId,
                StatId = rbs.StatId,
                Stat = new StatDto
                {
                    Id = rbs.Stat.Id,
                    Name = rbs.Stat.Name,
                    DisplayName = rbs.Stat.DisplayName
                },
                Value = rbs.Value
            }).ToList()
        };

        return result;
    }

    /// <summary>
    /// Get a race configuration by abbreviation (e.g., "HUM", "ELV")
    /// </summary>
    [HttpGet("by-abbreviation/{abbreviation}")]
    public async Task<ActionResult<RaceConfigurationDto>> GetRaceConfigurationByAbbreviation(string abbreviation)
    {
        var raceConfiguration = await _context.RaceConfigurations
            .Include(rc => rc.RaceBaseStats)
                .ThenInclude(rbs => rbs.Stat)
            .FirstOrDefaultAsync(rc => rc.Abbreviation == abbreviation);

        if (raceConfiguration == null)
        {
            return NotFound();
        }

        var result = new RaceConfigurationDto
        {
            Id = raceConfiguration.Id,
            Name = raceConfiguration.Name,
            Abbreviation = raceConfiguration.Abbreviation,
            RaceBaseStats = raceConfiguration.RaceBaseStats.Select(rbs => new RaceBaseStatDto
            {
                Id = rbs.Id,
                RaceConfigurationId = rbs.RaceConfigurationId,
                StatId = rbs.StatId,
                Stat = new StatDto
                {
                    Id = rbs.Stat.Id,
                    Name = rbs.Stat.Name,
                    DisplayName = rbs.Stat.DisplayName
                },
                Value = rbs.Value
            }).ToList()
        };

        return result;
    }

    /// <summary>
    /// Create a new race configuration
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<RaceConfigurationDto>> CreateRaceConfiguration(RaceConfiguration raceConfiguration)
    {
        // Validate that abbreviation is unique
        if (await _context.RaceConfigurations.AnyAsync(rc => rc.Abbreviation == raceConfiguration.Abbreviation))
        {
            return BadRequest($"Race configuration with abbreviation '{raceConfiguration.Abbreviation}' already exists.");
        }

        // Validate that name is unique
        if (await _context.RaceConfigurations.AnyAsync(rc => rc.Name == raceConfiguration.Name))
        {
            return BadRequest($"Race configuration with name '{raceConfiguration.Name}' already exists.");
        }

        _context.RaceConfigurations.Add(raceConfiguration);
        await _context.SaveChangesAsync();

        var result = new RaceConfigurationDto
        {
            Id = raceConfiguration.Id,
            Name = raceConfiguration.Name,
            Abbreviation = raceConfiguration.Abbreviation,
            RaceBaseStats = new List<RaceBaseStatDto>()
        };

        return CreatedAtAction(nameof(GetRaceConfiguration), new { id = raceConfiguration.Id }, result);
    }

    /// <summary>
    /// Update an existing race configuration
    /// </summary>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRaceConfiguration(int id, RaceConfiguration raceConfiguration)
    {
        if (id != raceConfiguration.Id)
        {
            return BadRequest("ID mismatch");
        }

        // Check if the race configuration exists
        var existingRace = await _context.RaceConfigurations.FindAsync(id);
        if (existingRace == null)
        {
            return NotFound();
        }

        // Validate that abbreviation is unique (excluding current record)
        if (await _context.RaceConfigurations.AnyAsync(rc => rc.Abbreviation == raceConfiguration.Abbreviation && rc.Id != id))
        {
            return BadRequest($"Race configuration with abbreviation '{raceConfiguration.Abbreviation}' already exists.");
        }

        // Validate that name is unique (excluding current record)
        if (await _context.RaceConfigurations.AnyAsync(rc => rc.Name == raceConfiguration.Name && rc.Id != id))
        {
            return BadRequest($"Race configuration with name '{raceConfiguration.Name}' already exists.");
        }

        // Update the properties
        existingRace.Name = raceConfiguration.Name;
        existingRace.Abbreviation = raceConfiguration.Abbreviation;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!RaceConfigurationExists(id))
            {
                return NotFound();
            }
            throw;
        }

        return NoContent();
    }

    /// <summary>
    /// Delete a race configuration
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRaceConfiguration(int id)
    {
        var raceConfiguration = await _context.RaceConfigurations.FindAsync(id);
        if (raceConfiguration == null)
        {
            return NotFound();
        }

        _context.RaceConfigurations.Remove(raceConfiguration);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Add a base stat to a race configuration
    /// </summary>
    [HttpPost("{id}/base-stats")]
    public async Task<ActionResult<RaceBaseStatDto>> AddRaceBaseStat(int id, CreateRaceBaseStatDto createDto)
    {
        // Verify the race configuration exists
        if (!await _context.RaceConfigurations.AnyAsync(rc => rc.Id == id))
        {
            return NotFound("Race configuration not found");
        }

        // Verify the stat exists
        var stat = await _context.Stats.FindAsync(createDto.StatId);
        if (stat == null)
        {
            return BadRequest("Invalid stat ID");
        }

        // Verify the stat is a base stat (STR, DEX, VIT, AGI, INT, MND, CHR)
        if (!stat.IsBaseStat)
        {
            return BadRequest("Only base stats (STR, DEX, VIT, AGI, INT, MND, CHR) can be used for race base stats");
        }

        // Check if this race already has this stat
        if (await _context.RaceBaseStats.AnyAsync(rbs => rbs.RaceConfigurationId == id && rbs.StatId == createDto.StatId))
        {
            return BadRequest("This race already has a base stat for this stat type");
        }

        var raceBaseStat = new RaceBaseStat
        {
            RaceConfigurationId = id,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.RaceBaseStats.Add(raceBaseStat);
        await _context.SaveChangesAsync();

        var result = new RaceBaseStatDto
        {
            Id = raceBaseStat.Id,
            RaceConfigurationId = raceBaseStat.RaceConfigurationId,
            StatId = raceBaseStat.StatId,
            Stat = new StatDto
            {
                Id = stat.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = raceBaseStat.Value
        };

        return CreatedAtAction(nameof(GetRaceConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a base stat for a race configuration
    /// </summary>
    [HttpPut("{raceId}/base-stats/{statId}")]
    public async Task<IActionResult> UpdateRaceBaseStat(int raceId, int statId, [FromBody] int value)
    {
        var raceBaseStat = await _context.RaceBaseStats
            .FirstOrDefaultAsync(rbs => rbs.RaceConfigurationId == raceId && rbs.StatId == statId);

        if (raceBaseStat == null)
        {
            return NotFound();
        }

        raceBaseStat.Value = value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a base stat from a race configuration
    /// </summary>
    [HttpDelete("{raceId}/base-stats/{statId}")]
    public async Task<IActionResult> DeleteRaceBaseStat(int raceId, int statId)
    {
        var raceBaseStat = await _context.RaceBaseStats
            .FirstOrDefaultAsync(rbs => rbs.RaceConfigurationId == raceId && rbs.StatId == statId);

        if (raceBaseStat == null)
        {
            return NotFound();
        }

        _context.RaceBaseStats.Remove(raceBaseStat);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool RaceConfigurationExists(int id)
    {
        return _context.RaceConfigurations.Any(e => e.Id == id);
    }
}
