using GearForgeXI.Models;

namespace GearForgeXI.Services;

/// <summary>
/// Service for calculating complete character statistics by combining character profile, 
/// job data, and gear sets. Uses database Stat entities for type safety.
/// </summary>
public class CharacterSimulationService
{
    private readonly StatIdLookupService _statLookupService;
    private readonly JobConfigurationBuilder _jobConfigBuilder;
    private Dictionary<int, JobStaticData>? _jobConfigurations;

    public CharacterSimulationService(StatIdLookupService statLookupService, JobConfigurationBuilder jobConfigBuilder)
    {
        _statLookupService = statLookupService;
        _jobConfigBuilder = jobConfigBuilder;
    }

    /// <summary>
    /// Calculates complete character stats for a given character profile, job selection, and gear set
    /// </summary>
    public async Task<CharacterStatistics> CalculateStatsAsync(CharacterProfile profile, int mainJobId, int subJobId, GearSet? gearSet)
    {
        var stats = new CharacterStatistics();

        // Ensure job configurations are loaded
        if (_jobConfigurations == null)
        {
            _jobConfigurations = await _jobConfigBuilder.BuildJobConfigurationsAsync();
        }

        // Get stat IDs for core stats (for race bonuses)
        var coreStatIds = await _statLookupService.GetStatIdsByNamesAsync("STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR");

        // 1. Apply base stats from race
        ApplyRaceStats(stats, profile.Race, coreStatIds);

        // 2. Apply merit points (assume max merits for all stats)
        ApplyMerits(stats, coreStatIds);

        // 3. Apply main job contributions
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        if (mainJob != null)
        {
            await ApplyJobStatsAsync(stats, mainJob, isMainJob: true);
        }

        // 4. Apply subjob contributions 
        var subJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == subJobId);
        if (subJob != null)
        {
            await ApplyJobStatsAsync(stats, subJob, isMainJob: false);
        }


        // 5. Apply gear stats
        if (gearSet != null)
        {
            ApplyGearStats(stats, gearSet);
        }

        return stats;
    }

    /// <summary>
    /// Applies base racial statistics using database stat IDs
    /// </summary>
    private void ApplyRaceStats(CharacterStatistics stats, Race race, Dictionary<string, int> coreStatIds)
    {
        // Helper method to safely get stat ID
        int GetStatId(string statName) => coreStatIds.TryGetValue(statName, out var id) ? id : 0;

        // FFXI racial stats at level 99 (based on official stat differences)
        // Values are relative bonuses compared to the lowest racial value for each stat
        switch (race)
        {
            case Race.HumeMale:
            case Race.HumeFemale:
                // Hume: STR=6, DEX=3, VIT=6, AGI=6, INT=6, MND=3, CHR=6
                stats.AddModifier(GetStatId("STR"), 6, "Race");
                stats.AddModifier(GetStatId("DEX"), 3, "Race");
                stats.AddModifier(GetStatId("VIT"), 6, "Race");
                stats.AddModifier(GetStatId("AGI"), 6, "Race");
                stats.AddModifier(GetStatId("INT"), 6, "Race");
                stats.AddModifier(GetStatId("MND"), 3, "Race");
                stats.AddModifier(GetStatId("CHR"), 6, "Race");
                break;
            case Race.ElvaanMale:
            case Race.ElvaanFemale:
                // Elvaan: STR=11, DEX=0, VIT=6, AGI=0, INT=0, MND=8, CHR=6
                stats.AddModifier(GetStatId("STR"), 11, "Race");
                stats.AddModifier(GetStatId("DEX"), 0, "Race");
                stats.AddModifier(GetStatId("VIT"), 6, "Race");
                stats.AddModifier(GetStatId("AGI"), 0, "Race");
                stats.AddModifier(GetStatId("INT"), 0, "Race");
                stats.AddModifier(GetStatId("MND"), 8, "Race");
                stats.AddModifier(GetStatId("CHR"), 6, "Race");
                break;
            case Race.TarutaruMale:
            case Race.TarutaruFemale:
                // Tarutaru: STR=0, DEX=3, VIT=0, AGI=9, INT=13, MND=0, CHR=6
                stats.AddModifier(GetStatId("STR"), 0, "Race");
                stats.AddModifier(GetStatId("DEX"), 3, "Race");
                stats.AddModifier(GetStatId("VIT"), 0, "Race");
                stats.AddModifier(GetStatId("AGI"), 9, "Race");
                stats.AddModifier(GetStatId("INT"), 13, "Race");
                stats.AddModifier(GetStatId("MND"), 0, "Race");
                stats.AddModifier(GetStatId("CHR"), 6, "Race");
                break;
            case Race.MithraFemale:
                // Mithra: STR=3, DEX=10, VIT=0, AGI=11, INT=6, MND=0, CHR=0
                stats.AddModifier(GetStatId("STR"), 3, "Race");
                stats.AddModifier(GetStatId("DEX"), 10, "Race");
                stats.AddModifier(GetStatId("VIT"), 0, "Race");
                stats.AddModifier(GetStatId("AGI"), 11, "Race");
                stats.AddModifier(GetStatId("INT"), 6, "Race");
                stats.AddModifier(GetStatId("MND"), 0, "Race");
                stats.AddModifier(GetStatId("CHR"), 0, "Race");
                break;
            case Race.GalkanMale:
                // Galka: STR=9, DEX=3, VIT=11, AGI=3, INT=3, MND=3, CHR=0
                stats.AddModifier(GetStatId("STR"), 9, "Race");
                stats.AddModifier(GetStatId("DEX"), 3, "Race");
                stats.AddModifier(GetStatId("VIT"), 11, "Race");
                stats.AddModifier(GetStatId("AGI"), 3, "Race");
                stats.AddModifier(GetStatId("INT"), 3, "Race");
                stats.AddModifier(GetStatId("MND"), 3, "Race");
                stats.AddModifier(GetStatId("CHR"), 0, "Race");
                break;
        }
    }

    /// <summary>
    /// Applies merit point bonuses to core stats
    /// Assumes maximum merit allocation (15 points) to each stat
    /// </summary>
    private void ApplyMerits(CharacterStatistics stats, Dictionary<string, int> coreStatIds)
    {
        // Helper method to safely get stat ID
        int GetStatId(string statName) => coreStatIds.TryGetValue(statName, out var id) ? id : 0;

        // Apply maximum merit bonuses (15 points each) to all core stats
        stats.AddModifier(GetStatId("STR"), 15, "Merit Points");
        stats.AddModifier(GetStatId("DEX"), 15, "Merit Points");
        stats.AddModifier(GetStatId("VIT"), 15, "Merit Points");
        stats.AddModifier(GetStatId("AGI"), 15, "Merit Points");
        stats.AddModifier(GetStatId("INT"), 15, "Merit Points");
        stats.AddModifier(GetStatId("MND"), 15, "Merit Points");
        stats.AddModifier(GetStatId("CHR"), 15, "Merit Points");
    }

    /// <summary>
    /// Applies all job-related statistics (traits, job points, master levels)
    /// Assumes main job is always level 99, subjob can vary but still gets master level scaling
    /// </summary>
    private async Task ApplyJobStatsAsync(CharacterStatistics stats, CharacterJob characterJob, bool isMainJob)
    {
        if (_jobConfigurations == null || !_jobConfigurations.TryGetValue(characterJob.JobId, out var jobConfig))
            return;

        // Main jobs are always level 99, subjobs can vary but cap at 59
        var effectiveLevel = isMainJob ? 99 : Math.Min(characterJob.JobLevel, 59);

        // Apply base job stats at level 99 (or effective level for subjob)
        await ApplyJobLevelStatsAsync(stats, characterJob.JobId, effectiveLevel, isMainJob);

        // Apply ALL job traits (since we're assuming level 99 for main job)
        ApplyJobTraits(stats, jobConfig, effectiveLevel, isMainJob);

        // Apply job point bonuses (only if mastered)
        if (isMainJob && characterJob.IsMastered)
        {
            ApplyJobPointBonuses(stats, jobConfig.JobPointBonuses);
        }

        // Apply master level bonuses
        if (isMainJob && characterJob.MasterLevel > 0)
        {
            ApplyMasterLevelBonuses(stats, jobConfig.MasterLevelBonuses, characterJob.MasterLevel);
        }
    }

    /// <summary>
    /// Applies base stat growth from job levels using database stat IDs
    /// Simplified since main jobs are always 99, subjobs can vary
    /// </summary>
    private async Task ApplyJobLevelStatsAsync(CharacterStatistics stats, int jobId, int level, bool isMainJob)
    {
        // Get stat IDs for job level bonuses
        var statIds = await _statLookupService.GetStatIdsByNamesAsync("STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR");

        // Helper method to safely get stat ID
        int GetStatId(string statName) => statIds.TryGetValue(statName, out var id) ? id : 0;

        // Fixed stat bonuses for level 99 jobs (or scaled for subjobs)
        var multiplier = isMainJob ? 1.0 : 0.5; // Subjobs contribute less

        var source = isMainJob ? "Job Level (99)" : $"Subjob Level ({level})";

        // Fixed stat bonuses per job at level 99
        switch (jobId)
        {
            case 1: // WAR
                stats.AddModifier(GetStatId("STR"), (int)(121 * multiplier), source);
                stats.AddModifier(GetStatId("DEX"), (int)(123 * multiplier), source);
                stats.AddModifier(GetStatId("VIT"), (int)(117 * multiplier), source);
                stats.AddModifier(GetStatId("AGI"), (int)(126 * multiplier), source);
                stats.AddModifier(GetStatId("INT"), (int)(121 * multiplier), source);
                stats.AddModifier(GetStatId("MND"), (int)(111 * multiplier), source);
                stats.AddModifier(GetStatId("CHR"), (int)(117 * multiplier), source);
                break;
            case 2: // MNK
                stats.AddModifier(GetStatId("STR"), (int)(117 * multiplier), source);
                stats.AddModifier(GetStatId("DEX"), (int)(125 * multiplier), source);
                stats.AddModifier(GetStatId("VIT"), (int)(124 * multiplier), source);
                stats.AddModifier(GetStatId("AGI"), (int)(117 * multiplier), source);
                stats.AddModifier(GetStatId("INT"), (int)(118 * multiplier), source);
                stats.AddModifier(GetStatId("MND"), (int)(117 * multiplier), source);
                stats.AddModifier(GetStatId("CHR"), (int)(117 * multiplier), source);
                break;
            // Add more jobs as needed
            default:
                stats.AddModifier(GetStatId("STR"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("DEX"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("VIT"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("AGI"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("INT"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("MND"), (int)(70 * multiplier), source);
                stats.AddModifier(GetStatId("CHR"), (int)(70 * multiplier), source);
                break;
        }
    }

    /// <summary>
    /// Applies job traits based on character level using database stat IDs
    /// </summary>
    private void ApplyJobTraits(CharacterStatistics stats, JobStaticData jobConfig, int level, bool isMainJob)
    {
        var source = isMainJob ? "Job Trait" : "Subjob Trait";

        foreach (var trait in jobConfig.Traits.Where(t => t.Level <= level))
        {
            foreach (var modifier in trait.StatModifiers)
            {
                stats.AddModifier(modifier.Key, modifier.Value, $"{source}: {trait.Name}");
            }

            stats.ActiveTraits.Add(trait.Name);
        }
    }

    /// <summary>
    /// Applies job point bonuses (all-or-nothing when mastered) using database stat IDs
    /// </summary>
    private void ApplyJobPointBonuses(CharacterStatistics stats, Dictionary<int, int> jobPointBonuses)
    {
        foreach (var bonus in jobPointBonuses)
        {
            stats.AddModifier(bonus.Key, bonus.Value, "Job Points");
        }
    }

    /// <summary>
    /// Applies master level bonuses based on current master level using database stat IDs
    /// </summary>
    private void ApplyMasterLevelBonuses(CharacterStatistics stats, Dictionary<int, int> masterLevelBonuses, int masterLevel)
    {
        foreach (var bonus in masterLevelBonuses)
        {
            var value = (int)(bonus.Value * masterLevel);  // Bonuses scale linearly with master level (0-50)
            stats.AddModifier(bonus.Key, value, $"Master Level ({masterLevel})");
        }
    }

    /// <summary>
    /// Applies all gear set statistics using existing GearItemStat entities
    /// </summary>
    private void ApplyGearStats(CharacterStatistics stats, GearSet gearSet)
    {
        foreach (var gearSetItem in gearSet.GearSetItems)
        {
            if (gearSetItem.GearItem?.GearItemStats != null)
            {
                foreach (var gearStat in gearSetItem.GearItem.GearItemStats)
                {
                    if (gearStat.Value.HasValue)
                    {
                        stats.AddModifier(gearStat.StatId, gearStat.Value.Value, $"Gear: {gearSetItem.GearItem.Name}");
                    }
                }
            }
        }
    }
}
