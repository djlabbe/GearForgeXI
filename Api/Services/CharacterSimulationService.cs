using GearForgeXI.Models;
using GearForgeXI.Models.Dto;

namespace GearForgeXI.Services;

public class CharacterSimulationService(StatIdLookupService statIdLookupService, JobConfigurationBuilder jobConfigurationBuilder)
{
    private readonly StatIdLookupService _statIdLookupService = statIdLookupService;
    private readonly JobConfigurationBuilder _jobConfigurationBuilder = jobConfigurationBuilder;

    /// <summary>
    /// Core stat names in the order they appear in ranking tables
    /// </summary>
    private static readonly string[] _statNames = ["STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR"];

    /// <summary>
    /// Fixed race stat bonuses: STR, DEX, VIT, AGI, INT, MND, CHR
    /// Based on FFXI racial stat differences
    /// </summary>
    private static readonly Dictionary<string, int[]> _raceStatBonuses = new()
    {
        { "GAL", new[] { 9, 3, 11, 3, 3, 3, 0 } },  // Galka
        { "ELV", new[] { 11, 0, 6, 0, 0, 8, 6 } },  // Elvaan  
        { "HUM", new[] { 6, 3, 6, 6, 6, 3, 6 } },   // Hume
        { "MIT", new[] { 3, 10, 0, 11, 6, 0, 0 } }, // Mithra
        { "TAR", new[] { 0, 3, 0, 9, 13, 0, 6 } }   // Tarutaru
    };

    /// <summary>
    /// Job base stats at level 99: STR, DEX, VIT, AGI, INT, MND, CHR
    /// Based on actual FFXI job stat observations by the author
    /// </summary>
    private static readonly Dictionary<string, int[]> _jobBaseStats = new()
    {
        { "WAR", new[] { 76, 75, 72, 72, 63, 66, 66 } },
        { "MNK", new[] { 72, 77, 79, 63, 60, 72, 66 } },
        { "WHM", new[] { 69, 66, 72, 66, 66, 79, 72 } },
        { "BLM", new[] { 63, 75, 66, 72, 77, 69, 69 } },
        { "RDM", new[] { 69, 72, 69, 66, 72, 75, 69 } },
        { "THF", new[] { 69, 79, 72, 74, 72, 63, 60 } },
        { "PLD", new[] { 74, 69, 79, 60, 60, 75, 72 } },
        { "DRK", new[] { 76, 75, 75, 69, 72, 63, 60 } },
        { "BST", new[] { 69, 75, 72, 63, 66, 69, 76 } },
        { "BRD", new[] { 69, 72, 72, 63, 69, 72, 74 } },
        { "RNG", new[] { 66, 72, 72, 76, 66, 72, 66 } },
        { "SAM", new[] { 72, 75, 75, 69, 66, 69, 69 } },
        { "NIN", new[] { 72, 77, 75, 74, 69, 63, 63 } },
        { "DRG", new[] { 74, 72, 75, 69, 63, 69, 72 } },
        { "SMN", new[] { 63, 69, 66, 69, 74, 77, 74 } },
        { "BLU", new[] { 66, 69, 69, 66, 66, 69, 66 } },
        { "COR", new[] { 66, 75, 69, 74, 72, 69, 66 } },
        { "PUP", new[] { 66, 77, 72, 72, 66, 66, 72 } },
        { "DNC", new[] { 69, 75, 69, 74, 63, 66, 74 } },
        { "SCH", new[] { 63, 72, 69, 69, 74, 72, 72 } },
        { "GEO", new[] { 63, 72, 72, 66, 74, 77, 66 } },
        { "RUN", new[] { 72, 72, 69, 74, 69, 72, 63 } }
    };

    /// <summary>
    /// Main method to calculate character stats using FFXI ranking system
    /// </summary>
    public async Task<CharacterStatsDto> CalculateCharacterStats(CharacterProfile profile, int mainJobId, int subJobId, GearSet? gearSet = null)
    {
        var stats = new CharacterStatistics();

        // Get core stat IDs from database for mapping
        var coreStatIds = await _statIdLookupService.GetStatIdsByNamesAsync("STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR");

        // Get job configurations for traits and bonuses
        var jobConfigurations = await _jobConfigurationBuilder.BuildJobConfigurationsAsync();

        // Apply base stats first using FFXI ranking system
        ApplyBaseStats(stats, profile, mainJobId, subJobId, coreStatIds);

        // Apply merits (15 points each for core stats)
        ApplyMerits(stats, coreStatIds);

        // Apply master level bonuses
        ApplyMasterLevelBonuses(stats, profile, mainJobId, jobConfigurations);

        // Apply job traits
        ApplyJobTraits(stats, profile, mainJobId, subJobId, jobConfigurations);

        // Apply job point bonuses
        ApplyJobPointBonuses(stats, profile, mainJobId, subJobId, jobConfigurations);

        // Apply gear stats if gear set is provided
        if (gearSet != null)
        {
            ApplyGearStats(stats, gearSet);
        }

        // Build and return the response DTO
        return await stats.ToDtoAsync(_statIdLookupService);
    }

    /// <summary>
    /// Applies base character stats using the FFXI ranking system
    /// Uses race + main job + subjob level calculations from the ranking tables
    /// </summary>
    private void ApplyBaseStats(CharacterStatistics stats, CharacterProfile profile, int mainJobId, int subJobId, Dictionary<string, int> coreStatIds)
    {
        // Helper method to safely get stat ID
        int GetStatId(string statName) => coreStatIds.TryGetValue(statName, out var id) ? id : 0;

        // Get the main job and subjob data
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        var subJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == subJobId);

        if (mainJob == null) return;

        // Convert race enum to string code
        var raceCode = ConvertRaceToCode(profile.Race);
        var mainJobCode = ConvertJobIdToCode(mainJobId);
        var subJobCode = subJob != null ? ConvertJobIdToCode(subJobId) : null;

        // Calculate base stats using the FFXI ranking system
        var (raceStats, mainJobStats, subJobStats) = CalculateBaseStatsBreakdown(
            raceCode,
            mainJobCode,
            mainJob.JobLevel,
            subJobCode,
            subJob?.JobLevel ?? 0);

        // Apply main job stats
        foreach (var (statName, value) in mainJobStats)
        {
            var statId = GetStatId(statName);
            if (statId > 0 && value > 0)
            {
                stats.AddModifier(statId, value, $"Main Job: {mainJobCode}");
            }
        }

        // Apply subjob stats (if any)
        if (subJob != null)
        {
            foreach (var (statName, value) in subJobStats)
            {
                var statId = GetStatId(statName);
                if (statId > 0 && value > 0)
                {
                    stats.AddModifier(statId, value, $"Sub Job: {subJobCode}");
                }
            }
        }

        // Apply race stats
        foreach (var (statName, value) in raceStats)
        {
            var statId = GetStatId(statName);
            if (statId > 0 && value > 0)
            {
                stats.AddModifier(statId, value, $"Race: {profile.Race}");
            }
        }
    }

    /// <summary>
    /// Calculates base character stats using the FFXI ranking system with separate components
    /// Formula: RaceStats + JobStats + SubJobStats
    /// Where each component = floor(Scale * (Level-1) + Base)
    /// SubJob component is further divided by 2 with special rounding
    /// Returns (raceStats, mainJobStats, subJobStats) separately for transparency
    /// </summary>
    private (Dictionary<string, int> raceStats, Dictionary<string, int> mainJobStats, Dictionary<string, int> subJobStats)
        CalculateBaseStatsBreakdown(string race, string mainJob, int mainLevel, string? subJob = null, int subLevel = 0)
    {
        var raceStats = new Dictionary<string, int>();
        var mainJobStats = new Dictionary<string, int>();
        var subJobStats = new Dictionary<string, int>();

        // Validate inputs
        if (!_raceStatBonuses.ContainsKey(race))
            throw new ArgumentException($"Invalid race: {race}");

        if (!_jobBaseStats.ContainsKey(mainJob))
            throw new ArgumentException($"Invalid main job: {mainJob}");

        // Calculate stats for each core stat
        for (int i = 0; i < _statNames.Length; i++)
        {
            var statName = _statNames[i];

            // Race stats: Use fixed bonuses from the race table
            var raceStatValue = _raceStatBonuses[race][i];
            raceStats[statName] = raceStatValue;

            // Main job stats: Use job-specific base stats
            var mainJobStatValue = _jobBaseStats[mainJob][i];
            mainJobStats[statName] = mainJobStatValue;

            // Sub job stats: Level-based bonus system
            // No stats for level 49 or below
            // +1 all stats for every 2 levels between 50-59
            int subJobStatValue = 0;
            // if (subLevel > 49 && subLevel <= 59)
            // {
            //     // Calculate bonus: (level - 49) / 2
            //     subJobStatValue = (subLevel - 49) / 2;
            // }
            subJobStats[statName] = subJobStatValue;
        }

        return (raceStats, mainJobStats, subJobStats);
    }

    /// <summary>
    /// Apply merit points to core stats (15 points each)
    /// </summary>
    private void ApplyMerits(CharacterStatistics stats, Dictionary<string, int> coreStatIds)
    {
        foreach (var (statName, statId) in coreStatIds)
        {
            stats.AddModifier(statId, 15, "Merit Points");
        }
    }

    /// <summary>
    /// Apply job traits based on character job levels and configurations
    /// </summary>
    private void ApplyJobTraits(CharacterStatistics stats, CharacterProfile profile, int mainJobId, int subJobId, Dictionary<int, JobStaticData> jobConfigurations)
    {
        // Apply main job traits (level 99, all traits active)
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        if (mainJob != null && jobConfigurations.TryGetValue(mainJobId, out var mainJobConfig))
        {
            foreach (var trait in mainJobConfig.Traits)
            {
                // All traits are active for level 99 main jobs
                foreach (var (statId, value) in trait.StatModifiers)
                {
                    stats.AddModifier(statId, value, $"Main Job Trait: {trait.Name}");
                }
                stats.ActiveTraits.Add($"Main: {trait.Name}");
            }
        }

        // Apply subjob traits (reduced effectiveness)
        var subJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == subJobId);
        if (subJob != null && jobConfigurations.TryGetValue(subJobId, out var subJobConfig))
        {
            foreach (var trait in subJobConfig.Traits.Where(t => t.Level <= subJob.JobLevel))
            {
                foreach (var (statId, value) in trait.StatModifiers)
                {
                    // Subjob traits are at 50% effectiveness
                    var subJobValue = value / 2;
                    if (subJobValue > 0)
                    {
                        stats.AddModifier(statId, subJobValue, $"Sub Job Trait: {trait.Name}");
                    }
                }
                stats.ActiveTraits.Add($"Sub: {trait.Name}");
            }
        }
    }

    /// <summary>
    /// Apply job point bonuses for mastered jobs
    /// </summary>
    private void ApplyJobPointBonuses(CharacterStatistics stats, CharacterProfile profile, int mainJobId, int subJobId, Dictionary<int, JobStaticData> jobConfigurations)
    {
        // Apply main job point bonuses (full effectiveness if mastered)
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        if (mainJob != null && mainJob.IsMastered && jobConfigurations.TryGetValue(mainJobId, out var mainJobConfig))
        {
            foreach (var (statId, value) in mainJobConfig.JobPointBonuses)
            {
                stats.AddModifier(statId, value, "Main Job Points");
            }
        }

        // Apply subjob point bonuses (50% effectiveness if mastered)
        var subJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == subJobId);
        if (subJob != null && subJob.IsMastered && jobConfigurations.TryGetValue(subJobId, out var subJobConfig))
        {
            foreach (var (statId, value) in subJobConfig.JobPointBonuses)
            {
                var subJobValue = value / 2;
                if (subJobValue > 0)
                {
                    stats.AddModifier(statId, subJobValue, "Sub Job Points");
                }
            }
        }
    }

    /// <summary>
    /// Apply master level bonuses scaled by current master level
    /// </summary>
    private void ApplyMasterLevelBonuses(CharacterStatistics stats, CharacterProfile profile, int mainJobId, Dictionary<int, JobStaticData> jobConfigurations)
    {
        // Apply main job master level bonuses (scaled by ML)
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        if (mainJob != null && mainJob.MasterLevel > 0 && jobConfigurations.TryGetValue(mainJobId, out var mainJobConfig))
        {
            foreach (var (statId, maxValue) in mainJobConfig.MasterLevelBonuses)
            {
                // Scale bonus based on current master level (ML0-50)
                var scaledValue = maxValue * mainJob.MasterLevel / 50;
                if (scaledValue > 0)
                {
                    stats.AddModifier(statId, scaledValue, $"Main ML{mainJob.MasterLevel}");
                }
            }
        }
    }

    /// <summary>
    /// Apply gear stats from the equipped gear set
    /// </summary>
    private void ApplyGearStats(CharacterStatistics stats, GearSet gearSet)
    {
        foreach (var gearSetItem in gearSet.GearSetItems.Where(gsi => gsi.GearItem != null))
        {
            var item = gearSetItem.GearItem;
            var position = gearSetItem.Position.ToString();

            foreach (var gearStat in item.GearItemStats)
            {
                if (gearStat.Value.HasValue && gearStat.Value.Value != 0)
                {
                    var source = $"{position}: {item.Name}";
                    stats.AddModifier(gearStat.StatId, gearStat.Value.Value, source);
                }
            }
        }
    }

    /// <summary>
    /// Converts Race enum to string code for lookup tables
    /// </summary>
    private string ConvertRaceToCode(Race race)
    {
        return race switch
        {
            Race.HumeMale or Race.HumeFemale => "HUM",
            Race.ElvaanMale or Race.ElvaanFemale => "ELV",
            Race.TarutaruMale or Race.TarutaruFemale => "TAR",
            Race.MithraFemale => "MIT",
            Race.GalkanMale => "GAL",
            _ => throw new ArgumentException($"Unknown race: {race}")
        };
    }

    /// <summary>
    /// Converts Job ID to string code for lookup tables
    /// Maps database job IDs to FFXI job codes
    /// </summary>
    private string ConvertJobIdToCode(int jobId)
    {
        return jobId switch
        {
            1 => "WAR",
            2 => "MNK",
            3 => "WHM",
            4 => "BLM",
            5 => "RDM",
            6 => "THF",
            7 => "PLD",
            8 => "DRK",
            9 => "BST",
            10 => "BRD",
            11 => "RNG",
            12 => "SAM",
            13 => "NIN",
            14 => "DRG",
            15 => "SMN",
            16 => "BLU",
            17 => "COR",
            18 => "PUP",
            19 => "DNC",
            20 => "SCH",
            21 => "GEO",
            22 => "RUN",
            _ => throw new ArgumentException($"Unknown job ID: {jobId}")
        };
    }
}
