using GearForgeXI.Models;
using GearForgeXI;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Services;

/// <summary>
/// Loads SkillRankMappings from the database once at startup and caches them for use throughout the app.
/// </summary>
public class SkillRankMappingCache(GearDbContext dbContext)
{
    public IReadOnlyList<SkillRankMapping> SkillRankMappings { get; } = dbContext.SkillRankMappings.AsNoTracking().ToList();
}
