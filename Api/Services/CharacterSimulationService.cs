using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Services;

public class CharacterSimulationService(StatIdLookupService statIdLookupService, GearDbContext context)
{
    private readonly StatIdLookupService _statIdLookupService = statIdLookupService;
    private readonly GearDbContext _context = context;

    #region Constants and Data Tables

    /// <summary>
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

        // Get job configurations from database
        var mainJobConfig = await GetJobConfigurationAsync(mainJob.Id);
        var subJobConfig = await GetJobConfigurationAsync(subJob.Id);

        await ApplyBaseStats(characterStatistics, profile.Race, mainJob, subJob, mainJobConfig, subJobConfig);

        await ApplyMerits(characterStatistics);

        ApplyMainJobTraits(characterStatistics, mainJob, mainJobConfig);

        ApplySubJobTraits(characterStatistics, subJob, subJobConfig);

        ApplyJobPointBonuses(characterStatistics, mainJob, mainJobConfig);

        ApplyMasterLevelBonuses(characterStatistics, mainJob, mainJobConfig);

        ApplyGearStats(characterStatistics, gearSet);

        // Build and return the response DTO
        return await characterStatistics.ToDtoAsync(_statIdLookupService);
    }

    #endregion

    #region Private Stat Calculation Methods

    /// <summary>
    /// Applies base character stats using race, job, and subjob calculations
    /// </summary>
    private async Task ApplyBaseStats(CharacterStatistics stats, Race race, CharacterJob mainJob, CharacterJob subJob, JobConfiguration mainJobConfig, JobConfiguration subJobConfig)
    {
        var raceCode = ConvertRaceToCode(race);

        // Apply race stats directly using database configuration
        var raceConfig = await GetRaceConfigurationAsync(raceCode);
        foreach (var baseStat in raceConfig.RaceBaseStats)
        {
            if (baseStat.Value > 0)
            {
                stats.AddModifier(baseStat.StatId, baseStat.Value, $"Race: {raceCode}");
            }
        }

        // Apply main job stats directly using database configuration
        foreach (var baseStat in mainJobConfig.JobBaseStats)
        {
            if (baseStat.Value > 0)
            {
                stats.AddModifier(baseStat.StatId, baseStat.Value, $"Main Job: {ConvertJobIdToCode(mainJob.Id)}");
            }
        }

        // Calculate effective subjob level based on main job master level
        var effectiveSubJobLevel = Math.Min(49 + (mainJob.MasterLevel / 5), subJob.JobLevel);
        var levelRatio = (double)effectiveSubJobLevel / 99.0;

        // Apply subjob stats directly using database configuration
        foreach (var baseStat in subJobConfig.JobBaseStats)
        {
            var subJobValue = (int)(baseStat.Value * levelRatio * 0.5); // 50% of scaled base stats
            if (subJobValue > 0)
            {
                stats.AddModifier(baseStat.StatId, subJobValue, $"Sub Job: {ConvertJobIdToCode(subJob.Id)}");
            }
        }
    }

    /// <summary>
    /// Apply merit points to core stats (15 points each)
    /// </summary>
    private async Task ApplyMerits(CharacterStatistics stats)
    {
        // Get core stat IDs from database
        var coreStatIds = await _statIdLookupService.GetStatIdsByNamesAsync("STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR");

        foreach (var (statName, statId) in coreStatIds)
        {
            stats.AddModifier(statId, 15, "Merit Points");
        }
    }

    /// <summary>
    /// Apply main job traits based on character job level and database configuration
    /// Only applies the highest tier of each trait that the character qualifies for
    /// </summary>
    private static void ApplyMainJobTraits(CharacterStatistics stats, CharacterJob mainJob, JobConfiguration mainJobConfig)
    {
        var highestTierTraits = GetHighestTierTraits(mainJobConfig.JobTraits.ToList(), mainJob.JobLevel);
        foreach (var trait in highestTierTraits)
        {
            stats.AddModifier(trait.StatId, trait.Value, $"Main Job Trait: {trait.Name}");
            stats.ActiveTraits.Add($"Main: {trait.Name}");
        }
    }

    /// <summary>
    /// Apply subjob traits based on character subjob level and database configuration
    /// Only applies the highest tier of each trait that the character qualifies for
    /// </summary>
    private static void ApplySubJobTraits(CharacterStatistics stats, CharacterJob subJob, JobConfiguration subJobConfig)
    {
        var highestTierTraits = GetHighestTierTraits(subJobConfig.JobTraits.ToList(), subJob.JobLevel);
        foreach (var trait in highestTierTraits)
        {
            stats.AddModifier(trait.StatId, trait.Value, $"Sub Job Trait: {trait.Name}");
            stats.ActiveTraits.Add($"Sub: {trait.Name}");
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
    private static void ApplyJobPointBonuses(CharacterStatistics stats, CharacterJob mainJob, JobConfiguration mainJobConfig)
    {
        if (mainJob.IsMastered)
        {
            // Apply main job point bonuses (full effectiveness if mastered)
            foreach (var bonus in mainJobConfig.JobPointBonuses)
            {
                stats.AddModifier(bonus.StatId, bonus.Value, "Main Job Points");
            }
        }
    }

    /// <summary>
    /// Apply master level bonuses scaled by current master level
    /// </summary>
    private static void ApplyMasterLevelBonuses(CharacterStatistics stats, CharacterJob mainJob, JobConfiguration mainJobConfig)
    {
        if (mainJob.MasterLevel > 0)
        {
            // Apply main job master level bonuses (scaled by ML)
            foreach (var bonus in mainJobConfig.MasterLevelBonuses)
            {
                // Scale bonus based on current master level (ML0-50)
                var scaledValue = bonus.Value * mainJob.MasterLevel / 50;
                if (scaledValue > 0)
                {
                    stats.AddModifier(bonus.StatId, scaledValue, $"Main ML{mainJob.MasterLevel}");
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

    /// <summary>
    /// Get job configuration from database with all related data
    /// Throws exception if configuration is not found (indicates data integrity issue)
    /// </summary>
    private async Task<JobConfiguration> GetJobConfigurationAsync(int jobId)
    {
        return await _context.JobConfigurations
            .Include(jc => jc.JobBaseStats)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobTraits)
                .ThenInclude(jt => jt.Stat)
            .Include(jc => jc.JobPointBonuses)
                .ThenInclude(jpb => jpb.Stat)
            .Include(jc => jc.MasterLevelBonuses)
                .ThenInclude(mlb => mlb.Stat)
            .FirstAsync(jc => jc.JobId == jobId);
    }

    /// <summary>
    /// Get race configuration from database with all related data
    /// Throws exception if configuration is not found (indicates data integrity issue)
    /// </summary>
    private async Task<RaceConfiguration> GetRaceConfigurationAsync(string raceAbbreviation)
    {
        return await _context.RaceConfigurations
            .Include(rc => rc.RaceBaseStats)
                .ThenInclude(rbs => rbs.Stat)
            .FirstAsync(rc => rc.Abbreviation == raceAbbreviation);
    }

    #endregion
}
