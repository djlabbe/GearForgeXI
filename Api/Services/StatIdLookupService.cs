using Microsoft.EntityFrameworkCore;
using GearForgeXI.Models;

namespace GearForgeXI.Services;

/// <summary>
/// Service to manage stat ID lookups and job configurations
/// This bridges the gap between static job data and dynamic database stats
/// </summary>
public class StatIdLookupService(GearDbContext context)
{
    private readonly GearDbContext _context = context;
    private Dictionary<string, int>? _statNameToIdCache;

    /// <summary>
    /// Get stat ID by name, with caching for performance
    /// </summary>
    public async Task<int?> GetStatIdByNameAsync(string statName)
    {
        if (_statNameToIdCache == null)
        {
            await RefreshCacheAsync();
        }

        return _statNameToIdCache!.TryGetValue(statName.ToUpper(), out var id) ? id : null;
    }

    /// <summary>
    /// Get multiple stat IDs by names
    /// </summary>
    public async Task<Dictionary<string, int>> GetStatIdsByNamesAsync(params string[] statNames)
    {
        if (_statNameToIdCache == null)
        {
            await RefreshCacheAsync();
        }

        var result = new Dictionary<string, int>();
        foreach (var statName in statNames)
        {
            if (_statNameToIdCache!.TryGetValue(statName.ToUpper(), out var id))
            {
                result[statName] = id;
            }
        }
        return result;
    }

    /// <summary>
    /// Refresh the stat name to ID cache
    /// </summary>
    public async Task RefreshCacheAsync()
    {
        var stats = await _context.Stats.ToListAsync();
        _statNameToIdCache = new Dictionary<string, int>();

        foreach (var stat in stats)
        {
            // Add primary name
            _statNameToIdCache[stat.Name.ToUpper()] = stat.Id;

            // Add alternate names if they exist
            if (!string.IsNullOrEmpty(stat.AlternateName1))
                _statNameToIdCache[stat.AlternateName1.ToUpper()] = stat.Id;
            if (!string.IsNullOrEmpty(stat.AlternateName2))
                _statNameToIdCache[stat.AlternateName2.ToUpper()] = stat.Id;
        }
    }

    /// <summary>
    /// Get all stats for dropdown/selection purposes
    /// </summary>
    public async Task<List<Stat>> GetAllStatsAsync()
    {
        return await _context.Stats.OrderBy(s => s.Category).ThenBy(s => s.Name).ToListAsync();
    }
}
