using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetJobs()
    {
        var query = _context.Jobs
           .Select(j => new JobDto
           {
               Id = j.Id,
               Abbreviation = j.Abbreviation,
               FullName = j.FullName,
               CanDualWield = j.CanDualWield
           });

        var jobs = await query.OrderBy(j => j.Id).ToListAsync();
        return Ok(jobs);
    }

    /// <summary>
    /// Get a specific job by ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<JobDto>> GetJob(int id)
    {
        var job = await _context.Jobs
            .Where(j => j.Id == id)
            .Select(j => new JobDto
            {
                Id = j.Id,
                Abbreviation = j.Abbreviation,
                FullName = j.FullName,
                CanDualWield = j.CanDualWield
            })
            .FirstOrDefaultAsync();

        if (job == null)
        {
            return NotFound($"Job with ID {id} not found.");
        }

        return Ok(job);
    }

    /// <summary>
    /// Create a new job (Admin only)
    /// </summary>
    [HttpPost]
    [Authorize] // Add specific admin role authorization as needed
    public async Task<ActionResult<JobDto>> CreateJob(CreateJobDto createJobDto)
    {
        // Check if abbreviation already exists
        if (await _context.Jobs.AnyAsync(j => j.Abbreviation.ToLower() == createJobDto.Abbreviation.ToLower()))
        {
            return BadRequest($"A job with abbreviation '{createJobDto.Abbreviation}' already exists.");
        }

        var job = new Job
        {
            Abbreviation = createJobDto.Abbreviation,
            FullName = createJobDto.FullName,
            CanDualWield = createJobDto.CanDualWield
        };

        _context.Jobs.Add(job);
        await _context.SaveChangesAsync();

        var jobDto = new JobDto
        {
            Id = job.Id,
            Abbreviation = job.Abbreviation,
            FullName = job.FullName,
            CanDualWield = job.CanDualWield
        };

        return CreatedAtAction(nameof(GetJob), new { id = job.Id }, jobDto);
    }

    /// <summary>
    /// Update an existing job (Admin only)
    /// </summary>
    [HttpPut("{id}")]
    [Authorize] // Add specific admin role authorization as needed
    public async Task<IActionResult> UpdateJob(int id, UpdateJobDto updateJobDto)
    {
        var job = await _context.Jobs.FindAsync(id);
        if (job == null)
        {
            return NotFound($"Job with ID {id} not found.");
        }

        // Check if abbreviation already exists for a different job
        if (await _context.Jobs.AnyAsync(j => j.Id != id && j.Abbreviation.ToLower() == updateJobDto.Abbreviation.ToLower()))
        {
            return BadRequest($"A job with abbreviation '{updateJobDto.Abbreviation}' already exists.");
        }

        job.Abbreviation = updateJobDto.Abbreviation;
        job.FullName = updateJobDto.FullName;
        job.CanDualWield = updateJobDto.CanDualWield;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _context.Jobs.AnyAsync(j => j.Id == id))
            {
                return NotFound($"Job with ID {id} not found.");
            }
            throw;
        }

        return NoContent();
    }

    /// <summary>
    /// Delete a job (Admin only)
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize] // Add specific admin role authorization as needed
    public async Task<IActionResult> DeleteJob(int id)
    {
        var job = await _context.Jobs.FindAsync(id);
        if (job == null)
        {
            return NotFound($"Job with ID {id} not found.");
        }

        // Check if job is referenced by other entities
        var hasGearItemJobs = await _context.GearItemJobs.AnyAsync(gij => gij.JobId == id);
        var hasGearSets = await _context.GearSets.AnyAsync(gs => gs.JobId == id);
        var hasCharacterJobs = await _context.CharacterJobs.AnyAsync(cj => cj.JobId == id);
        var hasJobConfiguration = await _context.JobConfigurations.AnyAsync(jc => jc.JobId == id);

        if (hasGearItemJobs || hasGearSets || hasCharacterJobs || hasJobConfiguration)
        {
            return BadRequest("Cannot delete job because it is referenced by other entities. " +
                "Please remove all references before deleting the job.");
        }

        _context.Jobs.Remove(job);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    /// <summary>
    /// Check if a job abbreviation is available (for validation)
    /// </summary>
    [HttpGet("check-abbreviation/{abbreviation}")]
    public async Task<ActionResult<bool>> CheckAbbreviationAvailable(string abbreviation, [FromQuery] int? excludeId = null)
    {
        var query = _context.Jobs.Where(j => j.Abbreviation.ToLower() == abbreviation.ToLower());

        if (excludeId.HasValue)
        {
            query = query.Where(j => j.Id != excludeId.Value);
        }

        var exists = await query.AnyAsync();
        return Ok(!exists); // Return true if available (not exists)
    }
}
