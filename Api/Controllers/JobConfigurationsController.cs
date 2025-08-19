using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatDto = GearForgeXI.Models.Dto.StatDto;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // Add authorization as needed for admin operations
public class JobConfigurationsController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    /// <summary>
    /// Get all job configurations with their related data
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobConfigurationDto>>> GetJobConfigurations()
    {
        var jobConfigurations = await _context.JobConfigurations
            .Include(jc => jc.Job)
            .Include(jc => jc.JobBaseStats)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobTraits)
                .ThenInclude(jt => jt.Stat)
            .Include(jc => jc.JobPointBonuses)
                .ThenInclude(jpb => jpb.Stat)
            .Include(jc => jc.JobGifts)
                .ThenInclude(jg => jg.Stat)
            .Include(jc => jc.MasterLevelBonuses)
                .ThenInclude(mlb => mlb.Stat)
            .ToListAsync();

        var result = jobConfigurations.Select(jc => new JobConfigurationDto
        {
            Id = jc.Id,
            JobId = jc.JobId,
            Job = new JobDto
            {
                Id = jc.Job.Id,
                FullName = jc.Job.FullName,
                Abbreviation = jc.Job.Abbreviation,
                CanDualWield = jc.Job.CanDualWield
            },
            JobBaseStats = jc.JobBaseStats.Select(jbs => new JobBaseStatDto
            {
                Id = jbs.Id,
                JobConfigurationId = jbs.JobConfigurationId,
                StatId = jbs.StatId,
                Stat = new StatDto
                {
                    Id = jbs.Stat.Id,
                    Name = jbs.Stat.Name,
                    DisplayName = jbs.Stat.DisplayName
                },
                Value = jbs.Value
            }).ToList(),
            JobTraits = jc.JobTraits.Select(jt => new JobTraitDto
            {
                Id = jt.Id,
                JobConfigurationId = jt.JobConfigurationId,
                Name = jt.Name,
                Level = jt.Level,
                StatId = jt.StatId,
                Stat = new StatDto
                {
                    Id = jt.Stat.Id,
                    Name = jt.Stat.Name,
                    DisplayName = jt.Stat.DisplayName
                },
                Value = jt.Value
            }).ToList(),
            JobPointBonuses = jc.JobPointBonuses.Select(jpb => new JobPointBonusDto
            {
                Id = jpb.Id,
                JobConfigurationId = jpb.JobConfigurationId,
                StatId = jpb.StatId,
                Stat = new StatDto
                {
                    Id = jpb.Stat.Id,
                    Name = jpb.Stat.Name,
                    DisplayName = jpb.Stat.DisplayName
                },
                Value = jpb.Value
            }).ToList(),
            JobGifts = jc.JobGifts.Select(jg => new JobGiftDto
            {
                Id = jg.Id,
                JobConfigurationId = jg.JobConfigurationId,
                StatId = jg.StatId,
                Stat = new StatDto
                {
                    Id = jg.Stat.Id,
                    Name = jg.Stat.Name,
                    DisplayName = jg.Stat.DisplayName
                },
                Value = jg.Value
            }).ToList(),
            MasterLevelBonuses = jc.MasterLevelBonuses.Select(mlb => new MasterLevelBonusDto
            {
                Id = mlb.Id,
                JobConfigurationId = mlb.JobConfigurationId,
                StatId = mlb.StatId,
                Stat = new StatDto
                {
                    Id = mlb.Stat.Id,
                    Name = mlb.Stat.Name,
                    DisplayName = mlb.Stat.DisplayName
                },
                Value = mlb.Value
            }).ToList()
        }).ToList();

        return result;
    }

    /// <summary>
    /// Get a specific job configuration by ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<JobConfigurationDto>> GetJobConfiguration(int id)
    {
        var jobConfiguration = await _context.JobConfigurations
            .Include(jc => jc.Job)
            .Include(jc => jc.JobBaseStats)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobTraits)
                .ThenInclude(jt => jt.Stat)
            .Include(jc => jc.JobPointBonuses)
                .ThenInclude(jpb => jpb.Stat)
            .Include(jc => jc.JobGifts)
                .ThenInclude(jg => jg.Stat)
            .Include(jc => jc.MasterLevelBonuses)
                .ThenInclude(mlb => mlb.Stat)
            .FirstOrDefaultAsync(jc => jc.Id == id);

        if (jobConfiguration == null)
        {
            return NotFound();
        }

        var result = new JobConfigurationDto
        {
            Id = jobConfiguration.Id,
            JobId = jobConfiguration.JobId,
            Job = new Models.Dto.JobDto
            {
                Id = jobConfiguration.Job.Id,
                FullName = jobConfiguration.Job.FullName,
                Abbreviation = jobConfiguration.Job.Abbreviation,
                CanDualWield = jobConfiguration.Job.CanDualWield
            },
            JobBaseStats = jobConfiguration.JobBaseStats.Select(jbs => new JobBaseStatDto
            {
                Id = jbs.Id,
                JobConfigurationId = jbs.JobConfigurationId,
                StatId = jbs.StatId,
                Stat = new StatDto
                {
                    Id = jbs.Stat.Id,
                    Name = jbs.Stat.Name,
                    DisplayName = jbs.Stat.DisplayName
                },
                Value = jbs.Value
            }).ToList(),
            JobTraits = jobConfiguration.JobTraits.Select(jt => new JobTraitDto
            {
                Id = jt.Id,
                JobConfigurationId = jt.JobConfigurationId,
                Name = jt.Name,
                Level = jt.Level,
                StatId = jt.StatId,
                Stat = new StatDto
                {
                    Id = jt.Stat.Id,
                    Name = jt.Stat.Name,
                    DisplayName = jt.Stat.DisplayName
                },
                Value = jt.Value
            }).ToList(),
            JobPointBonuses = jobConfiguration.JobPointBonuses.Select(jpb => new JobPointBonusDto
            {
                Id = jpb.Id,
                JobConfigurationId = jpb.JobConfigurationId,
                StatId = jpb.StatId,
                Stat = new StatDto
                {
                    Id = jpb.Stat.Id,
                    Name = jpb.Stat.Name,
                    DisplayName = jpb.Stat.DisplayName
                },
                Value = jpb.Value
            }).ToList(),
            MasterLevelBonuses = jobConfiguration.MasterLevelBonuses.Select(mlb => new MasterLevelBonusDto
            {
                Id = mlb.Id,
                JobConfigurationId = mlb.JobConfigurationId,
                StatId = mlb.StatId,
                Stat = new StatDto
                {
                    Id = mlb.Stat.Id,
                    Name = mlb.Stat.Name,
                    DisplayName = mlb.Stat.DisplayName
                },
                Value = mlb.Value
            }).ToList()
        };

        return result;
    }

    /// <summary>
    /// Get a job configuration by job ID
    /// </summary>
    [HttpGet("by-job/{jobId}")]
    public async Task<ActionResult<JobConfigurationDto>> GetJobConfigurationByJobId(int jobId)
    {
        var jobConfiguration = await _context.JobConfigurations
            .Include(jc => jc.Job)
            .Include(jc => jc.JobBaseStats)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobTraits)
                .ThenInclude(jts => jts.Stat)
            .Include(jc => jc.JobPointBonuses)
                .ThenInclude(jpb => jpb.Stat)
            .Include(jc => jc.JobGifts)
                .ThenInclude(jg => jg.Stat)
            .Include(jc => jc.MasterLevelBonuses)
                .ThenInclude(mlb => mlb.Stat)
            .FirstOrDefaultAsync(jc => jc.JobId == jobId);

        if (jobConfiguration == null)
        {
            return NotFound();
        }

        var result = new JobConfigurationDto
        {
            Id = jobConfiguration.Id,
            JobId = jobConfiguration.JobId,
            Job = new GearForgeXI.Models.Dto.JobDto
            {
                Id = jobConfiguration.Job.Id,
                FullName = jobConfiguration.Job.FullName,
                Abbreviation = jobConfiguration.Job.Abbreviation,
                CanDualWield = jobConfiguration.Job.CanDualWield
            },
            JobBaseStats = jobConfiguration.JobBaseStats.Select(jbs => new JobBaseStatDto
            {
                Id = jbs.Id,
                JobConfigurationId = jbs.JobConfigurationId,
                StatId = jbs.StatId,
                Stat = new StatDto
                {
                    Id = jbs.Stat.Id,
                    Name = jbs.Stat.Name,
                    DisplayName = jbs.Stat.DisplayName
                },
                Value = jbs.Value
            }).ToList(),
            JobTraits = jobConfiguration.JobTraits.Select(jt => new JobTraitDto
            {
                Id = jt.Id,
                JobConfigurationId = jt.JobConfigurationId,
                Name = jt.Name,
                Level = jt.Level,
                StatId = jt.StatId,
                Stat = new StatDto
                {
                    Id = jt.Stat.Id,
                    Name = jt.Stat.Name,
                    DisplayName = jt.Stat.DisplayName
                },
                Value = jt.Value
            }).ToList(),
            JobPointBonuses = jobConfiguration.JobPointBonuses.Select(jpb => new JobPointBonusDto
            {
                Id = jpb.Id,
                JobConfigurationId = jpb.JobConfigurationId,
                StatId = jpb.StatId,
                Stat = new StatDto
                {
                    Id = jpb.Stat.Id,
                    Name = jpb.Stat.Name,
                    DisplayName = jpb.Stat.DisplayName
                },
                Value = jpb.Value
            }).ToList(),
            MasterLevelBonuses = jobConfiguration.MasterLevelBonuses.Select(mlb => new MasterLevelBonusDto
            {
                Id = mlb.Id,
                JobConfigurationId = mlb.JobConfigurationId,
                StatId = mlb.StatId,
                Stat = new StatDto
                {
                    Id = mlb.Stat.Id,
                    Name = mlb.Stat.Name,
                    DisplayName = mlb.Stat.DisplayName
                },
                Value = mlb.Value
            }).ToList()
        };

        return result;
    }

    /// <summary>
    /// Delete a job configuration
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteJobConfiguration(int id)
    {
        var jobConfiguration = await _context.JobConfigurations.FindAsync(id);
        if (jobConfiguration == null)
        {
            return NotFound();
        }

        _context.JobConfigurations.Remove(jobConfiguration);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #region Job Base Stats Management

    /// <summary>
    /// Add a base stat to a job configuration
    /// </summary>
    [HttpPost("{id}/base-stats")]
    public async Task<ActionResult<JobBaseStatDto>> AddJobBaseStat(int id, CreateJobBaseStatDto createDto)
    {
        // Verify the job configuration exists
        if (!await _context.JobConfigurations.AnyAsync(jc => jc.Id == id))
        {
            return NotFound("Job configuration not found");
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
            return BadRequest("Only base stats (STR, DEX, VIT, AGI, INT, MND, CHR) can be used for job base stats");
        }

        // Check if this job already has this stat
        if (await _context.JobBaseStats.AnyAsync(jbs => jbs.JobConfigurationId == id && jbs.StatId == createDto.StatId))
        {
            return BadRequest("This job already has a base stat for this stat type");
        }

        var jobBaseStat = new JobBaseStat
        {
            JobConfigurationId = id,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.JobBaseStats.Add(jobBaseStat);
        await _context.SaveChangesAsync();

        var result = new JobBaseStatDto
        {
            Id = jobBaseStat.Id,
            JobConfigurationId = jobBaseStat.JobConfigurationId,
            StatId = jobBaseStat.StatId,
            Stat = new StatDto
            {
                Id = stat.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = jobBaseStat.Value
        };

        return CreatedAtAction(nameof(GetJobConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a base stat for a job configuration
    /// </summary>
    [HttpPut("{jobConfigId}/base-stats/{statId}")]
    public async Task<IActionResult> UpdateJobBaseStat(int jobConfigId, int statId, [FromBody] int value)
    {
        var jobBaseStat = await _context.JobBaseStats
            .FirstOrDefaultAsync(jbs => jbs.JobConfigurationId == jobConfigId && jbs.StatId == statId);

        if (jobBaseStat == null)
        {
            return NotFound();
        }

        jobBaseStat.Value = value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a base stat from a job configuration
    /// </summary>
    [HttpDelete("{jobConfigId}/base-stats/{statId}")]
    public async Task<IActionResult> DeleteJobBaseStat(int jobConfigId, int statId)
    {
        var jobBaseStat = await _context.JobBaseStats
            .FirstOrDefaultAsync(jbs => jbs.JobConfigurationId == jobConfigId && jbs.StatId == statId);

        if (jobBaseStat == null)
        {
            return NotFound();
        }

        _context.JobBaseStats.Remove(jobBaseStat);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #endregion

    #region Job Traits Management

    /// <summary>
    /// Add a trait to a job configuration
    /// </summary>
    [HttpPost("{id}/traits")]
    public async Task<ActionResult<JobTraitDto>> AddJobTrait(int id, CreateJobTraitDto createDto)
    {
        // Verify the job configuration exists
        if (!await _context.JobConfigurations.AnyAsync(jc => jc.Id == id))
        {
            return NotFound("Job configuration not found");
        }

        var jobTrait = new JobTrait
        {
            JobConfigurationId = id,
            Name = createDto.Name,
            Level = createDto.Level ?? 1,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.JobTraits.Add(jobTrait);
        await _context.SaveChangesAsync();

        // Load the stat for the response
        var stat = await _context.Stats.FindAsync(createDto.StatId);

        var result = new JobTraitDto
        {
            Id = jobTrait.Id,
            JobConfigurationId = jobTrait.JobConfigurationId,
            Name = jobTrait.Name,
            Level = jobTrait.Level,
            StatId = jobTrait.StatId,
            Stat = new StatDto
            {
                Id = stat!.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = jobTrait.Value
        };

        return CreatedAtAction(nameof(GetJobConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a job trait
    /// </summary>
    [HttpPut("{jobConfigId}/traits/{traitId}")]
    public async Task<IActionResult> UpdateJobTrait(int jobConfigId, int traitId, UpdateJobTraitDto updateDto)
    {
        var jobTrait = await _context.JobTraits
            .FirstOrDefaultAsync(jt => jt.JobConfigurationId == jobConfigId && jt.Id == traitId);

        if (jobTrait == null)
        {
            return NotFound();
        }

        jobTrait.Name = updateDto.Name;
        jobTrait.Level = updateDto.Level ?? jobTrait.Level;
        jobTrait.StatId = updateDto.StatId;
        jobTrait.Value = updateDto.Value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a trait from a job configuration
    /// </summary>
    [HttpDelete("{jobConfigId}/traits/{traitId}")]
    public async Task<IActionResult> DeleteJobTrait(int jobConfigId, int traitId)
    {
        var jobTrait = await _context.JobTraits
            .FirstOrDefaultAsync(jt => jt.JobConfigurationId == jobConfigId && jt.Id == traitId);

        if (jobTrait == null)
        {
            return NotFound();
        }

        _context.JobTraits.Remove(jobTrait);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #endregion

    #region Job Point Bonuses Management

    /// <summary>
    /// Add a job point bonus to a job configuration
    /// </summary>
    [HttpPost("{id}/job-point-bonuses")]
    public async Task<ActionResult<JobPointBonusDto>> AddJobPointBonus(int id, CreateJobPointBonusDto createDto)
    {
        // Verify the job configuration exists
        if (!await _context.JobConfigurations.AnyAsync(jc => jc.Id == id))
        {
            return NotFound("Job configuration not found");
        }

        // Verify the stat exists
        var stat = await _context.Stats.FindAsync(createDto.StatId);
        if (stat == null)
        {
            return BadRequest("Invalid stat ID");
        }

        // Check if this job already has this stat
        if (await _context.JobPointBonuses.AnyAsync(jpb => jpb.JobConfigurationId == id && jpb.StatId == createDto.StatId))
        {
            return BadRequest("This job already has a job point bonus for this stat type");
        }

        var jobPointBonus = new JobPointBonus
        {
            JobConfigurationId = id,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.JobPointBonuses.Add(jobPointBonus);
        await _context.SaveChangesAsync();

        var result = new JobPointBonusDto
        {
            Id = jobPointBonus.Id,
            JobConfigurationId = jobPointBonus.JobConfigurationId,
            StatId = jobPointBonus.StatId,
            Stat = new StatDto
            {
                Id = stat.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = jobPointBonus.Value
        };

        return CreatedAtAction(nameof(GetJobConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a job point bonus
    /// </summary>
    [HttpPut("{jobConfigId}/job-point-bonuses/{statId}")]
    public async Task<IActionResult> UpdateJobPointBonus(int jobConfigId, int statId, [FromBody] int value)
    {
        var jobPointBonus = await _context.JobPointBonuses
            .FirstOrDefaultAsync(jpb => jpb.JobConfigurationId == jobConfigId && jpb.StatId == statId);

        if (jobPointBonus == null)
        {
            return NotFound();
        }

        jobPointBonus.Value = value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a job point bonus from a job configuration
    /// </summary>
    [HttpDelete("{jobConfigId}/job-point-bonuses/{statId}")]
    public async Task<IActionResult> DeleteJobPointBonus(int jobConfigId, int statId)
    {
        var jobPointBonus = await _context.JobPointBonuses
            .FirstOrDefaultAsync(jpb => jpb.JobConfigurationId == jobConfigId && jpb.StatId == statId);

        if (jobPointBonus == null)
        {
            return NotFound();
        }

        _context.JobPointBonuses.Remove(jobPointBonus);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #endregion

    #region Job Gifts Management

    /// <summary>
    /// Add a job gift to a job configuration
    /// </summary>
    [HttpPost("{id}/job-gifts")]
    public async Task<ActionResult<JobGiftDto>> AddJobGift(int id, CreateJobGiftDto createDto)
    {
        // Verify the job configuration exists
        if (!await _context.JobConfigurations.AnyAsync(jc => jc.Id == id))
        {
            return NotFound("Job configuration not found");
        }

        // Verify the stat exists
        var stat = await _context.Stats.FindAsync(createDto.StatId);
        if (stat == null)
        {
            return BadRequest("Invalid stat ID");
        }

        // Check if this job already has this stat
        if (await _context.JobGifts.AnyAsync(jg => jg.JobConfigurationId == id && jg.StatId == createDto.StatId))
        {
            return BadRequest("This job already has a job gift for this stat type");
        }

        var jobGift = new JobGift
        {
            JobConfigurationId = id,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.JobGifts.Add(jobGift);
        await _context.SaveChangesAsync();

        var result = new JobGiftDto
        {
            Id = jobGift.Id,
            JobConfigurationId = jobGift.JobConfigurationId,
            StatId = jobGift.StatId,
            Stat = new StatDto
            {
                Id = stat.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = jobGift.Value
        };

        return CreatedAtAction(nameof(GetJobConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a job gift
    /// </summary>
    [HttpPut("{jobConfigId}/job-gifts/{statId}")]
    public async Task<IActionResult> UpdateJobGift(int jobConfigId, int statId, [FromBody] int value)
    {
        var jobGift = await _context.JobGifts
            .FirstOrDefaultAsync(jg => jg.JobConfigurationId == jobConfigId && jg.StatId == statId);

        if (jobGift == null)
        {
            return NotFound();
        }

        jobGift.Value = value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a job gift from a job configuration
    /// </summary>
    [HttpDelete("{jobConfigId}/job-gifts/{statId}")]
    public async Task<IActionResult> DeleteJobGift(int jobConfigId, int statId)
    {
        var jobGift = await _context.JobGifts
            .FirstOrDefaultAsync(jg => jg.JobConfigurationId == jobConfigId && jg.StatId == statId);

        if (jobGift == null)
        {
            return NotFound();
        }

        _context.JobGifts.Remove(jobGift);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #endregion

    #region Master Level Bonuses Management

    /// <summary>
    /// Add a master level bonus to a job configuration
    /// </summary>
    [HttpPost("{id}/master-level-bonuses")]
    public async Task<ActionResult<MasterLevelBonusDto>> AddMasterLevelBonus(int id, CreateMasterLevelBonusDto createDto)
    {
        // Verify the job configuration exists
        if (!await _context.JobConfigurations.AnyAsync(jc => jc.Id == id))
        {
            return NotFound("Job configuration not found");
        }

        // Verify the stat exists
        var stat = await _context.Stats.FindAsync(createDto.StatId);
        if (stat == null)
        {
            return BadRequest("Invalid stat ID");
        }

        // Check if this job already has this stat
        if (await _context.MasterLevelBonuses.AnyAsync(mlb => mlb.JobConfigurationId == id && mlb.StatId == createDto.StatId))
        {
            return BadRequest("This job already has a master level bonus for this stat type");
        }

        var masterLevelBonus = new MasterLevelBonus
        {
            JobConfigurationId = id,
            StatId = createDto.StatId,
            Value = createDto.Value
        };

        _context.MasterLevelBonuses.Add(masterLevelBonus);
        await _context.SaveChangesAsync();

        var result = new MasterLevelBonusDto
        {
            Id = masterLevelBonus.Id,
            JobConfigurationId = masterLevelBonus.JobConfigurationId,
            StatId = masterLevelBonus.StatId,
            Stat = new StatDto
            {
                Id = stat.Id,
                Name = stat.Name,
                DisplayName = stat.DisplayName
            },
            Value = masterLevelBonus.Value
        };

        return CreatedAtAction(nameof(GetJobConfiguration), new { id = id }, result);
    }

    /// <summary>
    /// Update a master level bonus
    /// </summary>
    [HttpPut("{jobConfigId}/master-level-bonuses/{statId}")]
    public async Task<IActionResult> UpdateMasterLevelBonus(int jobConfigId, int statId, [FromBody] int value)
    {
        var masterLevelBonus = await _context.MasterLevelBonuses
            .FirstOrDefaultAsync(mlb => mlb.JobConfigurationId == jobConfigId && mlb.StatId == statId);

        if (masterLevelBonus == null)
        {
            return NotFound();
        }

        masterLevelBonus.Value = value;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Remove a master level bonus from a job configuration
    /// </summary>
    [HttpDelete("{jobConfigId}/master-level-bonuses/{statId}")]
    public async Task<IActionResult> DeleteMasterLevelBonus(int jobConfigId, int statId)
    {
        var masterLevelBonus = await _context.MasterLevelBonuses
            .FirstOrDefaultAsync(mlb => mlb.JobConfigurationId == jobConfigId && mlb.StatId == statId);

        if (masterLevelBonus == null)
        {
            return NotFound();
        }

        _context.MasterLevelBonuses.Remove(masterLevelBonus);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    #endregion
}
