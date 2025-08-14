using GearForgeXI.Models;
using GearForgeXI.Models.Dto;

namespace GearForgeXI.Services;

/// <summary>
/// Extension methods for converting between CharacterStatistics and DTOs
/// </summary>
public static class CharacterStatisticsExtensions
{
    public static async Task<CharacterStatsDto> ToDtoAsync(this CharacterStatistics stats, StatIdLookupService statLookupService)
    {
        // Get all stats from database for proper mapping
        var allStats = await statLookupService.GetAllStatsAsync();
        var statIdToNameMap = allStats.ToDictionary(s => s.Id, s => s.Name);

        var dto = new CharacterStatsDto
        {
            ActiveTraits = new List<string>(stats.ActiveTraits),
            Stats = new Dictionary<string, int>(),
            StatBreakdown = new Dictionary<string, List<StatModifierDto>>()
        };

        // Convert all stat values using database stat names
        foreach (var statValue in stats.StatValues)
        {
            if (statIdToNameMap.TryGetValue(statValue.Key, out var statName))
            {
                dto.Stats[statName] = statValue.Value;
            }
        }

        // Convert stat breakdown
        foreach (var statModifier in stats.StatModifiers)
        {
            if (statIdToNameMap.TryGetValue(statModifier.Key, out var statName))
            {
                dto.StatBreakdown[statName] = statModifier.Value
                    .Select(m => new StatModifierDto { Value = m.Value, Source = m.Source })
                    .ToList();
            }
        }

        return dto;
    }
}
