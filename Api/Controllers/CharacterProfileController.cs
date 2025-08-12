using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class CharacterProfileController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetCharacterProfiles()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profiles = await _context.CharacterProfiles
            .AsNoTracking()
            .Include(cp => cp.CharacterJobs)
                .ThenInclude(cj => cj.Job)
            .Where(cp => cp.UserId == userId)
            .Select(cp => new CharacterProfileDto
            {
                Id = cp.Id,
                CharacterName = cp.CharacterName,
                Server = cp.Server.ToString(),
                Race = cp.Race != null ? cp.Race.ToString() : null,
                CreatedAt = cp.CreatedAt,
                UpdatedAt = cp.UpdatedAt,
                CharacterJobs = cp.CharacterJobs.Select(cj => new CharacterJobDto
                {
                    Id = cj.Id,
                    Job = new JobDto
                    {
                        Id = cj.Job.Id,
                        Abbreviation = cj.Job.Abbreviation,
                        FullName = cj.Job.FullName,
                        CanDualWield = cj.Job.CanDualWield
                    },
                    JobLevel = cj.JobLevel,
                    MasterLevel = cj.MasterLevel,
                    UpdatedAt = cj.UpdatedAt
                }).ToList()
            })
            .ToListAsync();

        return Ok(profiles);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacterProfile(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profile = await _context.CharacterProfiles
            .AsNoTracking()
            .Include(cp => cp.CharacterJobs)
                .ThenInclude(cj => cj.Job)
            .Where(cp => cp.Id == id && cp.UserId == userId)
            .FirstOrDefaultAsync();

        if (profile == null) return NotFound();

        var profileDto = new CharacterProfileDto
        {
            Id = profile.Id,
            CharacterName = profile.CharacterName,
            Server = profile.Server.ToString(),
            Race = profile.Race?.ToString(),
            CreatedAt = profile.CreatedAt,
            UpdatedAt = profile.UpdatedAt,
            CharacterJobs = profile.CharacterJobs.Select(cj => new CharacterJobDto
            {
                Id = cj.Id,
                Job = new JobDto
                {
                    Id = cj.Job.Id,
                    Abbreviation = cj.Job.Abbreviation,
                    FullName = cj.Job.FullName,
                    CanDualWield = cj.Job.CanDualWield
                },
                JobLevel = cj.JobLevel,
                MasterLevel = cj.MasterLevel,
                UpdatedAt = cj.UpdatedAt
            }).ToList()
        };

        return Ok(profileDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCharacterProfile(CreateCharacterProfileDto dto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profile = new CharacterProfile
        {
            UserId = userId,
            CharacterName = dto.CharacterName,
            Server = (Server)dto.Server,
            Race = dto.Race.HasValue ? (Race)dto.Race.Value : null,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        _context.CharacterProfiles.Add(profile);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCharacterProfile), new { id = profile.Id }, new { id = profile.Id });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCharacterProfile(int id, UpdateCharacterProfileDto dto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profile = await _context.CharacterProfiles
            .Where(cp => cp.Id == id && cp.UserId == userId)
            .FirstOrDefaultAsync();

        if (profile == null) return NotFound();

        // Update only provided fields
        if (!string.IsNullOrWhiteSpace(dto.CharacterName))
            profile.CharacterName = dto.CharacterName;

        if (dto.Server.HasValue)
            profile.Server = (Server)dto.Server.Value;

        if (dto.Race.HasValue)
            profile.Race = (Race)dto.Race.Value;

        profile.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacterProfile(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profile = await _context.CharacterProfiles
            .Where(cp => cp.Id == id && cp.UserId == userId)
            .FirstOrDefaultAsync();

        if (profile == null) return NotFound();

        _context.CharacterProfiles.Remove(profile);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{profileId}/character-jobs")]
    public async Task<IActionResult> UpdateCharacterJobs(int profileId, List<UpdateCharacterJobDto> characterJobs)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return Unauthorized();

        var profile = await _context.CharacterProfiles
            .Where(cp => cp.Id == profileId && cp.UserId == userId)
            .FirstOrDefaultAsync();

        if (profile == null) return NotFound();

        // Validate all job IDs exist
        var jobIds = characterJobs.Select(cj => cj.JobId).ToList();
        var existingJobIds = await _context.Jobs
            .Where(j => jobIds.Contains(j.Id))
            .Select(j => j.Id)
            .ToListAsync();

        if (jobIds.Except(existingJobIds).Any())
            return BadRequest("One or more invalid job IDs provided");

        // Get existing character jobs for this profile
        var existingCharacterJobs = await _context.CharacterJobs
            .Where(cj => cj.CharacterProfileId == profileId)
            .ToListAsync();

        foreach (var dto in characterJobs)
        {
            var existing = existingCharacterJobs.FirstOrDefault(cj => cj.JobId == dto.JobId);

            if (existing != null)
            {
                // Update existing
                existing.JobLevel = dto.JobLevel;
                existing.MasterLevel = dto.MasterLevel;
                existing.UpdatedAt = DateTime.UtcNow;
            }
            else
            {
                // Create new
                var newCharacterJob = new CharacterJob
                {
                    CharacterProfileId = profileId,
                    JobId = dto.JobId,
                    JobLevel = dto.JobLevel,
                    MasterLevel = dto.MasterLevel,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _context.CharacterJobs.Add(newCharacterJob);
            }
        }
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
