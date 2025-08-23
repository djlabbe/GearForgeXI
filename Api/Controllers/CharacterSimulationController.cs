using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using GearForgeXI.Services;
using Microsoft.AspNetCore.Authorization;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterSimulationController(GearDbContext context, CharacterSimulationService simulationService) : ControllerBase
{
    private readonly GearDbContext _context = context;
    private readonly CharacterSimulationService _simulationService = simulationService;

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

            if (mainJob == null)
            {
                return BadRequest("Main job not found in character profile");
            }

            if (mainJob.JobLevel < 99)
            {
                return BadRequest("Simulation only supports jobs at level 99");
            }

            if (request.SubJobId != null)
            {
                var subJob = profile.CharacterJobs.FirstOrDefault(cj => cj.JobId == request.SubJobId);
                if (subJob == null)
                {
                    return BadRequest("Sub job not found in character profile");
                }
            }

            // Calculate stats
            var characterSimulation = await _simulationService.CalculateCharacterStats(profile, request.MainJobId, request.SubJobId, gearSet);

            return Ok(characterSimulation);
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
    public int? SubJobId { get; set; }
    public int? GearSetId { get; set; }
}





