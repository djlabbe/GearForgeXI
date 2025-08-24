using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GearForgeXI.Models;
using GearForgeXI.Services;

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
            // Validate request
            if (request == null)
            {
                return BadRequest("Request body is required");
            }

            // Validate required fields
            if (request.MainJobId <= 0)
            {
                return BadRequest("MainJobId is required and must be greater than 0");
            }

            if (request.RaceId <= 0)
            {
                return BadRequest("RaceId is required and must be greater than 0");
            }

            if (request.MasterLevel < 0 || request.MasterLevel > 50)
            {
                return BadRequest("MasterLevel must be between 0 and 50");
            }

            // Log the request for debugging
            Console.WriteLine($"Processing request: RaceId={request.RaceId}, MainJobId={request.MainJobId}, MasterLevel={request.MasterLevel}, SubJobId={request.SubJobId}, GearSetId={request.GearSetId}");

            // Calculate stats
            var characterSimulation = await _simulationService.CalculateCharacterStats(request, null!);

            return Ok(characterSimulation);
        }
        catch (Exception ex)
        {
            // Log full exception details
            Console.WriteLine($"Exception in CalculateCharacterStats: {ex}");
            return StatusCode(500, new
            {
                message = "Error calculating character stats",
                error = ex.Message,
                stackTrace = ex.StackTrace,
                innerException = ex.InnerException?.Message
            });
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






