using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using GearForgeXI.Services;
using Microsoft.AspNetCore.Authorization;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterSimulationController(GearDbContext context, CharacterSimulationService simulationService, StatIdLookupService statLookupService) : ControllerBase
{
    private readonly GearDbContext _context = context;
    private readonly CharacterSimulationService _simulationService = simulationService;
    private readonly StatIdLookupService _statLookupService = statLookupService;

    /// <summary>
    /// Calculate complete character stats for a given character profile and gear set
    /// </summary>
    [HttpPost("calculate")]
    // [Authorize]
    public async Task<IActionResult> CalculateCharacterStats([FromBody] CalculateStatsRequest request)
    {
        try
        {
            // Validate character profile belongs to user
            var profile = await _context.CharacterProfiles
                .Include(p => p.CharacterJobs)
                    .ThenInclude(cj => cj.Job)
                // .FirstOrDefaultAsync(p => p.Id == request.CharacterProfileId && p.UserId == GetUserId());
                .FirstOrDefaultAsync(p => p.Id == request.CharacterProfileId);

            if (profile == null)
            {
                return NotFound("Character profile not found");
            }

            // Validate gear set belongs to user
            var gearSet = await _context.GearSets
                .Include(gs => gs.GearSetItems)
                    .ThenInclude(gsi => gsi.GearItem)
                        .ThenInclude(gi => gi.GearItemStats)
                            .ThenInclude(gis => gis.Stat)
                .FirstOrDefaultAsync(gs => gs.Id == request.GearSetId);
            // .FirstOrDefaultAsync(gs => gs.Id == request.GearSetId && gs.UserId == GetUserId());

            // Validate main job exists in character profile
            var mainJob = profile.CharacterJobs.FirstOrDefault(cj => cj.JobId == request.MainJobId);
            var subJob = profile.CharacterJobs.FirstOrDefault(cj => cj.JobId == request.SubJobId);

            if (mainJob == null)
            {
                return BadRequest("Main job not found in character profile");
            }

            if (mainJob.JobLevel < 99)
            {
                return BadRequest("Simulation only supports jobs at level 99");
            }

            // Validate subjob exists in character profile (if specified)
            if (subJob == null)
            {
                return BadRequest("Sub job not found in character profile");
            }

            // Calculate stats
            var characterStatsDto = await _simulationService.CalculateCharacterStats(profile, request.MainJobId, request.SubJobId, gearSet);

            // Convert to response DTO
            var response = new CalculateStatsResponse
            {
                CharacterName = profile.CharacterName,
                Race = profile.Race.ToString(),
                MainJob = mainJob.Job.Abbreviation,
                MainJobLevel = mainJob.JobLevel,
                MainJobMasterLevel = mainJob.MasterLevel,
                SubJob = subJob.Job.Abbreviation,
                SubJobLevel = Math.Min(49 + (mainJob.MasterLevel / 5), subJob.JobLevel),
                GearSetName = gearSet?.Name ?? "",
                Stats = characterStatsDto,
                CalculatedAt = DateTime.UtcNow
            };

            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error calculating character stats: {ex.Message}");
        }
    }

    /// <summary>
    /// Get available job configurations
    /// </summary>
    [HttpGet("job-configurations")]
    public async Task<IActionResult> GetJobConfigurations()
    {
        var configurations = await _context.JobConfigurations
            .Include(jc => jc.JobTraits)
            .Include(jc => jc.JobPointBonuses)
            .Include(jc => jc.MasterLevelBonuses)
            .Select(jc => new
            {
                JobId = jc.JobId,
                HasTraits = jc.JobTraits.Any(),
                HasJobPointBonuses = jc.JobPointBonuses.Any(),
                HasMasterLevelBonuses = jc.MasterLevelBonuses.Any()
            })
            .ToListAsync();

        return Ok(configurations);
    }


    private string GetUserId()
    {
        return User.FindFirst("sub")?.Value ?? User.FindFirst("id")?.Value ?? "";
    }
}

// DTOs for the API
public class CalculateStatsRequest
{
    public int CharacterProfileId { get; set; }
    public int MainJobId { get; set; }
    public int SubJobId { get; set; }
    public int? GearSetId { get; set; }
}

public class CalculateStatsResponse
{
    public string CharacterName { get; set; } = null!;
    public string Race { get; set; } = null!;
    public string MainJob { get; set; } = null!;
    public int MainJobLevel { get; set; }
    public int MainJobMasterLevel { get; set; }
    public string? SubJob { get; set; }
    public int? SubJobLevel { get; set; }
    public string GearSetName { get; set; } = null!;
    public CharacterStatsDto Stats { get; set; } = null!;
    public DateTime CalculatedAt { get; set; }
}