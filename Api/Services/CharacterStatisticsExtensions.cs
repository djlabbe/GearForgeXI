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

        // Define the desired stat order for consistent JSON output
        var desiredStatOrder = new[] { "STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR" };

        // Convert stat values in the desired order first (core stats)
        foreach (var statName in desiredStatOrder)
        {
            var statId = statIdToNameMap.FirstOrDefault(kvp => kvp.Value == statName).Key;
            if (statId != 0 && stats.StatValues.TryGetValue(statId, out var value))
            {
                dto.Stats[statName] = value;
            }
        }

        // Then add any remaining stats (non-core stats) in alphabetical order
        var remainingStats = stats.StatValues
            .Where(sv => statIdToNameMap.TryGetValue(sv.Key, out var name) && !desiredStatOrder.Contains(name))
            .OrderBy(sv => statIdToNameMap[sv.Key])
            .ToList();

        foreach (var statValue in remainingStats)
        {
            if (statIdToNameMap.TryGetValue(statValue.Key, out var statName))
            {
                dto.Stats[statName] = statValue.Value;
            }
        }

        // Convert stat breakdown in the same order
        foreach (var statName in desiredStatOrder)
        {
            var statId = statIdToNameMap.FirstOrDefault(kvp => kvp.Value == statName).Key;
            if (statId != 0 && stats.StatModifiers.TryGetValue(statId, out var modifiers))
            {
                dto.StatBreakdown[statName] = modifiers
                    .Select(m => new StatModifierDto { Value = m.Value, Source = m.Source })
                    .ToList();
            }
        }

        // Then add any remaining stat breakdowns in alphabetical order
        var remainingBreakdowns = stats.StatModifiers
            .Where(sm => statIdToNameMap.TryGetValue(sm.Key, out var name) && !desiredStatOrder.Contains(name))
            .OrderBy(sm => statIdToNameMap[sm.Key])
            .ToList();

        foreach (var statModifier in remainingBreakdowns)
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
