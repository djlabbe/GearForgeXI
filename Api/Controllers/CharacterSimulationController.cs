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
            if (!profile.CharacterJobs.Any(cj => cj.JobId == request.MainJobId))
            {
                return BadRequest("Main job not found in character profile");
            }

            // Validate subjob exists in character profile (if specified)
            if (!profile.CharacterJobs.Any(cj => cj.JobId == request.SubJobId))
            {
                return BadRequest("Sub job not found in character profile");
            }

            // Calculate stats
            var characterStats = await _simulationService.CalculateStatsAsync(profile, request.MainJobId, request.SubJobId, gearSet);

            // Convert to response DTO
            var response = new CalculateStatsResponse
            {
                CharacterName = profile.CharacterName,
                Race = profile.Race.ToString(),
                MainJob = profile.CharacterJobs.First(cj => cj.JobId == request.MainJobId).Job.Abbreviation,
                MainJobLevel = profile.CharacterJobs.First(cj => cj.JobId == request.MainJobId).JobLevel,
                MainJobMasterLevel = profile.CharacterJobs.First(cj => cj.JobId == request.MainJobId).MasterLevel,
                SubJob = profile.CharacterJobs.First(cj => cj.JobId == request.SubJobId).Job.Abbreviation,
                SubJobLevel = profile.CharacterJobs.First(cj => cj.JobId == request.SubJobId).JobLevel,
                GearSetName = gearSet?.Name ?? "",
                Stats = await characterStats.ToDtoAsync(_statLookupService),
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
    /// Example calculation with mock data for testing purposes
    /// </summary>
    [HttpGet("example")]
    public async Task<IActionResult> GetExampleCalculation()
    {
        try
        {
            // Create a mock character profile for demonstration
            var mockProfile = new CharacterProfile
            {
                Id = 0,
                CharacterName = "Example Character",
                Race = Race.HumeMale,
                UserId = "example",
                CharacterJobs = new List<CharacterJob>
                {
                    new() { JobId = 1, JobLevel = 99, MasterLevel = 25 }, // WAR - Always 99
                    new() { JobId = 6, JobLevel = 45, MasterLevel = 10 }   // THF subjob with master levels
                }
            };

            // Create a mock gear set (empty for this example)
            var mockGearSet = new GearSet
            {
                Id = 0,
                Name = "Example Gear Set",
                UserId = "example",
                JobId = 1,
                GearSetItems = new List<GearSetItem>()
            };

            // Calculate stats
            var characterStats = await _simulationService.CalculateStatsAsync(mockProfile, 1, 6, mockGearSet);

            var response = new
            {
                Message = "Simplified character simulation - main jobs are always level 99",
                Character = new
                {
                    Name = mockProfile.CharacterName,
                    Race = mockProfile.Race.ToString(),
                    MainJob = "WAR (99/25)", // Always level 99, Master Level 25
                    SubJob = "THF (45/10)"   // Subjob can vary, with master levels
                },
                GearSet = new
                {
                    Name = mockGearSet.Name,
                    ItemCount = mockGearSet.GearSetItems.Count
                },
                Stats = await characterStats.ToDtoAsync(_statLookupService),
                Notes = new[]
                {
                    "SIMPLIFIED SYSTEM: Main jobs are always treated as level 99",
                    "WAR gets all job traits, job point bonuses (since mastered), and scaled master level bonuses",
                    "THF subjob at level 45 with 10 master levels - gets reduced benefits",
                    "Subjobs can have master levels and get reduced job point bonuses if mastered",
                    "No gear equipped in this example, so only job/race stats are shown",
                    "Job level calculations are now fixed bonuses rather than per-level scaling"
                }
            };

            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error generating example: {ex.Message}");
        }
    }

    /// <summary>
    /// Get available job configurations
    /// </summary>
    [HttpGet("job-configurations")]
    public IActionResult GetJobConfigurations()
    {
        var configurations = JobConfigurations.GetConfiguredJobIds()
            .Select(jobId => new
            {
                JobId = jobId,
                HasTraits = JobConfigurations.GetJobConfiguration(jobId)?.Traits.Count > 0,
                HasJobPointBonuses = JobConfigurations.GetJobConfiguration(jobId)?.JobPointBonuses.Count > 0,
                HasMasterLevelBonuses = JobConfigurations.GetJobConfiguration(jobId)?.MasterLevelBonuses.Count > 0
            });

        return Ok(configurations);
    }

    /// <summary>
    /// Get detailed job configuration for a specific job
    /// </summary>
    [HttpGet("job-configurations/{jobId}")]
    public async Task<IActionResult> GetJobConfiguration(int jobId)
    {
        var job = await _context.Jobs.FindAsync(jobId);
        if (job == null)
        {
            return NotFound("Job not found");
        }

        var config = JobConfigurations.GetJobConfiguration(jobId);
        if (config == null)
        {
            return NotFound("Job configuration not found");
        }

        var response = new
        {
            Job = new { job.Id, job.Abbreviation, job.FullName, job.CanDualWield },
            Traits = config.Traits.Select(t => new { t.Name, t.Level, t.StatModifiers }),
            JobPointBonuses = config.JobPointBonuses,
            MasterLevelBonuses = config.MasterLevelBonuses
        };

        return Ok(response);
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