using GearForgeXI.Models;
using GearForgeXI.Models.Dto;

namespace GearForgeXI.Services;

public class CharacterSimulationService(StatIdLookupService statIdLookupService, JobConfigurationBuilder jobConfigurationBuilder)
{
    private readonly StatIdLookupService _statIdLookupService = statIdLookupService;
    private readonly JobConfigurationBuilder _jobConfigurationBuilder = jobConfigurationBuilder;

    #region Constants and Data Tables

    /// <summary>
    /// Core stat names in the order they appear in stat tables
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

    #endregion

    #region Public Methods

    /// <summary>
    /// Main method to calculate character stats using FFXI stat system
    /// </summary>
    public async Task<CharacterStatsDto> CalculateCharacterStats(CharacterProfile profile, int mainJobId, int subJobId, GearSet? gearSet = null)
    {
        var mainJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == mainJobId);
        var subJob = profile.CharacterJobs.FirstOrDefault(j => j.JobId == subJobId);

        if (mainJob == null)
        {
            throw new ArgumentException("Main job not found in character profile");
        }

        if (subJob == null)
        {
            throw new ArgumentException("Sub job not found in character profile");
        }

        var characterStatistics = new CharacterStatistics();

        // Get core stat IDs from database for mapping
        var coreStatIds = await _statIdLookupService.GetStatIdsByNamesAsync("STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR");

        // Get job configurations for traits and bonuses
        var jobConfigurations = await _jobConfigurationBuilder.BuildJobConfigurationsAsync();

        ApplyBaseStats(characterStatistics, profile.Race, mainJob, subJob, coreStatIds);

        ApplyMerits(characterStatistics, coreStatIds);

        ApplyJobTraits(characterStatistics, mainJob, subJob, jobConfigurations);

        ApplyJobPointBonuses(characterStatistics, mainJob, jobConfigurations);

        ApplyMasterLevelBonuses(characterStatistics, mainJob, jobConfigurations);

        ApplyGearStats(characterStatistics, gearSet);

        // Build and return the response DTO
        return await characterStatistics.ToDtoAsync(_statIdLookupService);
    }

    #endregion

    #region Private Stat Calculation Methods

    /// <summary>
    /// Applies base character stats using race, job, and subjob calculations
    /// </summary>
    private void ApplyBaseStats(CharacterStatistics stats, Race race, CharacterJob mainJob, CharacterJob subJob, Dictionary<string, int> coreStatIds)
    {
        var raceCode = ConvertRaceToCode(race);
        var mainJobCode = ConvertJobIdToCode(mainJob.Id);
        var subJobCode = ConvertJobIdToCode(subJob.Id);

        var raceStats = CalculateRaceStats(raceCode);
        ApplyStatCategory(stats, raceStats, coreStatIds, statName => $"Race: {raceCode}");

        var mainJobStats = CalculateMainJobStats(mainJobCode);
        ApplyStatCategory(stats, mainJobStats, coreStatIds, statName => $"Main Job: {mainJobCode}");

        // Calculate effective subjob level based on main job master level
        var effectiveSubJobLevel = Math.Min(49 + (mainJob.MasterLevel / 5), subJob.JobLevel);
        var subJobStats = CalculateSubJobStats(subJobCode, effectiveSubJobLevel);
        ApplyStatCategory(stats, subJobStats, coreStatIds, statName => $"Sub Job: {subJobCode}");
    }

    /// <summary>
    /// Helper method to apply a category of stats with consistent logic
    /// </summary>
    private void ApplyStatCategory(CharacterStatistics stats, Dictionary<string, int> statValues,
        Dictionary<string, int> coreStatIds, Func<string, string> sourceNameGenerator)
    {
        foreach (var (statName, value) in statValues)
        {
            if (coreStatIds.TryGetValue(statName, out var statId) && statId > 0 && value > 0)
            {
                stats.AddModifier(statId, value, sourceNameGenerator(statName));
            }
        }
    }

    /// <summary>
    /// Calculate race-based stat bonuses
    /// </summary>
    private static Dictionary<string, int> CalculateRaceStats(string race)
    {
        if (!_raceStatBonuses.ContainsKey(race))
            throw new ArgumentException($"Invalid race: {race}");

        var raceStats = new Dictionary<string, int>();
        for (int i = 0; i < _statNames.Length; i++)
        {
            raceStats[_statNames[i]] = _raceStatBonuses[race][i];
        }
        return raceStats;
    }

    /// <summary>
    /// Calculate main job base stats at level 99
    /// </summary>
    private static Dictionary<string, int> CalculateMainJobStats(string mainJob)
    {
        if (!_jobBaseStats.ContainsKey(mainJob))
            throw new ArgumentException($"Invalid main job: {mainJob}");

        var mainJobStats = new Dictionary<string, int>();
        for (int i = 0; i < _statNames.Length; i++)
        {
            mainJobStats[_statNames[i]] = _jobBaseStats[mainJob][i];
        }
        return mainJobStats;
    }

    // Master Level 50 RNG / Sub 59 WAR - sub job adds 17/13/11/14/8/8/10
    // Master Level 48 DRK / Sub 58 WAR - sub job adds 17/13/11/13/8/8/10
    // Master Level 42 SCH / Sub 57 WAR - sub job adds 16/13/11/13/8/8/9

    // Master Level 48 DRK / Sub 58 BLM - sub job adds 8/13/8/13/17/10/11
    // Master Level 42 SCH / Sub 57 BLM - sub job adds 8/12/8/13/16/7/11

    private static Dictionary<string, int> CalculateSubJobStats(string subJob, int subJobLevel)
    {
        var subJobStats = new Dictionary<string, int>();

        return subJobStats;
    }

    /// <summary>
    /// Apply merit points to core stats (15 points each)
    /// </summary>
    private static void ApplyMerits(CharacterStatistics stats, Dictionary<string, int> coreStatIds)
    {
        foreach (var (statName, statId) in coreStatIds)
        {
            stats.AddModifier(statId, 15, "Merit Points");
        }
    }

    /// <summary>
    /// Apply job traits based on character job levels and configurations
    /// Only applies the highest tier of each trait that the character qualifies for
    /// </summary>
    private static void ApplyJobTraits(CharacterStatistics stats, CharacterJob mainJob, CharacterJob subJob, Dictionary<int, JobStaticData> jobConfigurations)
    {
        // Apply main job traits (level 99, highest tier only)
        if (jobConfigurations.TryGetValue(mainJob.Id, out var mainJobConfig))
        {
            var highestTierTraits = GetHighestTierTraits(mainJobConfig.Traits, mainJob.JobLevel);
            foreach (var trait in highestTierTraits)
            {
                foreach (var (statId, value) in trait.StatModifiers)
                {
                    stats.AddModifier(statId, value, $"Main Job Trait: {trait.Name}");
                }
                stats.ActiveTraits.Add($"Main: {trait.Name}");
            }
        }

        // Apply subjob traits (highest tier only, based on subjob level)
        if (jobConfigurations.TryGetValue(subJob.Id, out var subJobConfig))
        {
            var highestTierTraits = GetHighestTierTraits(subJobConfig.Traits, subJob.JobLevel);
            foreach (var trait in highestTierTraits)
            {
                foreach (var (statId, value) in trait.StatModifiers)
                {
                    stats.AddModifier(statId, value, $"Sub Job Trait: {trait.Name}");
                }
                stats.ActiveTraits.Add($"Sub: {trait.Name}");
            }
        }
    }

    /// <summary>
    /// Gets the highest tier of each trait family that the character qualifies for
    /// </summary>
    private static List<JobTrait> GetHighestTierTraits(List<JobTrait> allTraits, int characterLevel)
    {
        var result = new List<JobTrait>();

        // Group traits by their base name (removing tier indicators like " I", " II", etc.)
        var traitFamilies = allTraits
            .Where(t => t.Level <= characterLevel)
            .GroupBy(t => GetTraitBaseName(t.Name))
            .ToList();

        foreach (var family in traitFamilies)
        {
            // Get the highest level trait in this family
            var highestTrait = family
                .OrderByDescending(t => t.Level)
                .First();

            result.Add(highestTrait);
        }

        return result;
    }

    /// <summary>
    /// Extracts the base trait name by removing tier indicators
    /// e.g., "Double Attack III" -> "Double Attack"
    /// </summary>
    private static string GetTraitBaseName(string traitName)
    {
        // Remove common tier indicators
        var tierIndicators = new[] { " I", " II", " III", " IV", " V", " VI", " VII", " VIII", " IX", " X" };

        foreach (var indicator in tierIndicators)
        {
            if (traitName.EndsWith(indicator))
            {
                return traitName.Substring(0, traitName.Length - indicator.Length);
            }
        }

        return traitName;
    }

    /// <summary>
    /// Apply job point bonuses for mastered jobs
    /// </summary>
    private void ApplyJobPointBonuses(CharacterStatistics stats, CharacterJob mainJob, Dictionary<int, JobStaticData> jobConfigurations)
    {
        if (jobConfigurations.TryGetValue(mainJob.Id, out var mainJobConfig))
        {
            // Apply main job point bonuses (full effectiveness if mastered)
            if (mainJob.IsMastered)
            {
                foreach (var (statId, value) in mainJobConfig.JobPointBonuses)
                {
                    stats.AddModifier(statId, value, "Main Job Points");
                }
            }
        }
    }

    /// <summary>
    /// Apply master level bonuses scaled by current master level
    /// </summary>
    private static void ApplyMasterLevelBonuses(CharacterStatistics stats, CharacterJob mainJob, Dictionary<int, JobStaticData> jobConfigurations)
    {
        if (jobConfigurations.TryGetValue(mainJob.Id, out var mainJobConfig))
        {
            // Apply main job master level bonuses (scaled by ML)
            if (mainJob.MasterLevel > 0)
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
        else
        {
            throw new InvalidOperationException($"No job configuration found for job ID {mainJob.Id}");
        }
    }

    /// <summary>
    /// Apply gear stats from the equipped gear set
    /// </summary>
    private static void ApplyGearStats(CharacterStatistics stats, GearSet? gearSet)
    {
        if (gearSet == null)
        {
            return; // No gear set provided, nothing to apply
        }

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

    #endregion

    #region Utility Methods

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

    #endregion
}
