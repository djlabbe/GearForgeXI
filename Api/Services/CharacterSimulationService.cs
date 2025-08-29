using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Services;


// TODO:
// --Merits other than Core stats.
// --Ambu cape augments
// --Base HP
// --Core stats from subjob
public class CharacterSimulationService(StatIdLookupService statIdLookupService, GearDbContext context, SkillRankMappingCache skillRankMappingCache)
{
    private readonly StatIdLookupService _statIdLookupService = statIdLookupService;
    private readonly GearDbContext _context = context;
    private readonly SkillRankMappingCache _skillRankMappingCache = skillRankMappingCache;

    #region Constants and Data Tables

    /// <summary>
    #endregion

    #region Public Methods

    /// <summary>
    /// Main method to calculate character stats using FFXI stat system
    /// </summary>
    public async Task<CharacterSimulation> CalculateCharacterStats(CalculateStatsRequest request, ApplicationUser currentUser)
    {
        var characterStatistics = new CharacterStatistics();

        var gearSet = await _context.GearSets
                   .Include(gs => gs.GearSetItems)
                       .ThenInclude(gsi => gsi.GearItem)
                           .ThenInclude(gi => gi.GearItemStats)
                               .ThenInclude(gis => gis.Stat)
                     .FirstOrDefaultAsync(gs => gs.Id == request.GearSetId);
        //  .FirstOrDefaultAsync(gs => gs.Id == request.GearSetId && gs.UserId == currentUser.Id);

        // Get job configurations from database
        var mainJobConfig = await GetJobConfigurationAsync(request.MainJobId);
        var subJobConfig = request.SubJobId.HasValue ? await GetJobConfigurationAsync(request.SubJobId.Value) : null;
        var subJobLevel = request.SubJobId.HasValue ? 49 + (request.MasterLevel / 5) : (int?)null;

        var raceConfig = await GetRaceConfigurationAsync(request.RaceId);

        ApplyBaseStats(characterStatistics, raceConfig, request.MasterLevel, mainJobConfig, subJobLevel, subJobConfig);

        ApplyCombatSkills(characterStatistics, mainJobConfig, subJobLevel, subJobConfig);

        await ApplyMerits(characterStatistics);

        ApplyJobTraits(characterStatistics, mainJobConfig, subJobLevel, subJobConfig);

        ApplyJobPointBonuses(characterStatistics, mainJobConfig);

        ApplyJobGifts(characterStatistics, mainJobConfig);

        ApplyMasterLevelBonuses(characterStatistics, request.MasterLevel, mainJobConfig);

        ApplyGearStats(characterStatistics, gearSet);

        // Build the response
        var allStats = await _statIdLookupService.GetAllStatsAsync();
        var statIdToNameMap = allStats.ToDictionary(s => s.Id, s => s.Name);

        var stats = new Dictionary<string, int>();
        var statBreakdown = new Dictionary<string, List<StatModifierDto>>();

        // Define the desired stat order for consistent JSON output
        var desiredStatOrder = new[] { "STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR" };

        // Convert stat values in the desired order first (core stats)
        foreach (var statName in desiredStatOrder)
        {
            var statId = statIdToNameMap.FirstOrDefault(kvp => kvp.Value == statName).Key;
            if (statId != 0 && characterStatistics.StatValues.TryGetValue(statId, out var value))
            {
                stats[statName] = value;
            }
        }

        // Then add any remaining stats (non-core stats) in alphabetical order
        var remainingStats = characterStatistics.StatValues
            .Where(sv => statIdToNameMap.TryGetValue(sv.Key, out var name) && !desiredStatOrder.Contains(name))
            .OrderBy(sv => statIdToNameMap[sv.Key])
            .ToList();

        foreach (var statValue in remainingStats)
        {
            if (statIdToNameMap.TryGetValue(statValue.Key, out var statName))
            {
                stats[statName] = statValue.Value;
            }
        }

        // Convert stat breakdown in the same order
        foreach (var statName in desiredStatOrder)
        {
            var statId = statIdToNameMap.FirstOrDefault(kvp => kvp.Value == statName).Key;
            if (statId != 0 && characterStatistics.StatModifiers.TryGetValue(statId, out var modifiers))
            {
                statBreakdown[statName] = modifiers
                    .Select(m => new StatModifierDto { Value = m.Value, Source = m.Source })
                    .ToList();
            }
        }

        // Then add any remaining stat breakdowns in alphabetical order
        var remainingBreakdowns = characterStatistics.StatModifiers
            .Where(sm => statIdToNameMap.TryGetValue(sm.Key, out var name) && !desiredStatOrder.Contains(name))
            .OrderBy(sm => statIdToNameMap[sm.Key])
            .ToList();

        foreach (var statModifier in remainingBreakdowns)
        {
            if (statIdToNameMap.TryGetValue(statModifier.Key, out var statName))
            {
                statBreakdown[statName] = statModifier.Value
                    .Select(m => new StatModifierDto { Value = m.Value, Source = m.Source })
                    .ToList();
            }
        }

        // MH Acc + Attack
        var mhWeaponSkillName = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Main)?.GearItem?.GearItemStats
            .Where(gis => gis.Stat.Name.Contains("Skill")).Select(gis => gis.Stat.Name).FirstOrDefault();

        if (gearSet == null || gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Main) == null)
        {
            mhWeaponSkillName = "Hand-to-Hand Skill";
        }

        var primaryAccuracy = 0;
        var primaryAttack = 0;

        if (mhWeaponSkillName != null)
        {
            var totalDex = stats.TryGetValue("DEX", out var dex) ? dex : 0;
            var mhWeaponSkill = stats.TryGetValue(mhWeaponSkillName!, out var mhSkillValue) ? mhSkillValue : 0;
            var bonusAcc = stats.TryGetValue("Accuracy", out var acc) ? acc : 0;

            var accuracyFromDex = CalculateAccuracyFromDex(totalDex);
            var accuracyFromSkill = CalculateAccuracyFromSkill(mhWeaponSkill);

            primaryAccuracy = CalculatePrimaryAccuracy(accuracyFromDex, accuracyFromSkill, bonusAcc);

            var totalStr = stats.TryGetValue("STR", out var str) ? str : 0;
            var bonusAttack = stats.TryGetValue("Attack", out var attack) ? attack : 0;
            primaryAttack = CalculateAttack(mhWeaponSkill, totalStr, bonusAttack);
        }

        // OH Acc
        var ohWeaponSkillName = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Sub)?.GearItem?.GearItemStats
           .Where(gis => gis.Stat.Name.Contains("Skill") && gis.Stat.Name != "Shield Skill").Select(gis => gis.Stat.Name).FirstOrDefault();


        var auxiliaryAccuracy = 0;
        var auxiliaryAttack = 0;
        if (ohWeaponSkillName != null)
        {
            var totalDex = stats.TryGetValue("DEX", out var dex) ? dex : 0;
            var ohWeaponSkill = stats.TryGetValue(ohWeaponSkillName!, out var ohSkillValue) ? ohSkillValue : 0;
            var bonusAcc = stats.TryGetValue("Accuracy", out var acc) ? acc : 0;

            var accuracyFromDex = CalculateAccuracyFromDex(totalDex);
            var accuracyFromSkill = CalculateAccuracyFromSkill(ohWeaponSkill);

            auxiliaryAccuracy = CalculatePrimaryAccuracy(accuracyFromDex, accuracyFromSkill, bonusAcc);

            var totalStr = stats.TryGetValue("STR", out var str) ? str : 0;
            auxiliaryAttack = CalculateAuxiliaryAttack(ohWeaponSkill, totalStr);
        }


        // Evasion
        var agi = stats.TryGetValue("AGI", out var agiValue) ? agiValue : 0;
        var evasionFromAgi = CalculateEvasionFromAgi(agi);
        var evasionSkill = stats.TryGetValue("Evasion Skill", out var evasionSkillValue) ? evasionSkillValue : 0;
        var evasionFromSkill = CalculateEvasionFromSkill(evasionSkill);
        var evasion = stats.TryGetValue("Evasion", out var evasionValue) ? evasionValue : 0;
        var totalEvasion = CalculateEvasion(evasionFromAgi, evasionFromSkill, evasion);

        // Defense
        var vit = stats.TryGetValue("VIT", out var vitValue) ? vitValue : 0;
        var level = 99; // Assuming level 99 for calculation
        var baseDefense = CalculateBaseDefense(vit, level);
        var bonusDefense = stats.TryGetValue("Defense", out var defenseValue) ? defenseValue : 0;
        var totalDefense = baseDefense + bonusDefense;

        var simulation = new CharacterSimulation
        {
            // CharacterName = profile.CharacterName,
            Race = raceConfig.Abbreviation,
            MainJob = mainJobConfig.Job.FullName,
            MainJobLevel = 99,
            MasterLevel = request.MasterLevel,
            SubJob = subJobConfig?.Job.FullName,
            SubJobLevel = subJobLevel,
            GearSetName = gearSet?.Name,
            Gear = new GearSetResponse()
            {
                Main = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Main)?.GearItem?.Name,
                Sub = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Sub)?.GearItem?.Name,
                Range = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Range)?.GearItem?.Name,
                Ammo = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Ammo)?.GearItem?.Name,
                Head = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Head)?.GearItem?.Name,
                Neck = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Neck)?.GearItem?.Name,
                Ear1 = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Ear1)?.GearItem?.Name,
                Ear2 = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Ear2)?.GearItem?.Name,
                Body = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Body)?.GearItem?.Name,
                Hands = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Hands)?.GearItem?.Name,
                Ring1 = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Ring1)?.GearItem?.Name,
                Ring2 = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Ring2)?.GearItem?.Name,
                Back = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Back)?.GearItem?.Name,
                Waist = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Waist)?.GearItem?.Name,
                Legs = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Legs)?.GearItem?.Name,
                Feet = gearSet?.GearSetItems.FirstOrDefault(gsi => gsi.Position == SetPosition.Feet)?.GearItem?.Name
            },
            DerivedStats = new DerivedStats()
            {
                PrimaryAccuracy = primaryAccuracy,
                PrimaryAttack = primaryAttack,
                AuxiliaryAccuracy = auxiliaryAccuracy,
                AuxiliaryAttack = auxiliaryAttack,
                TotalEvasion = totalEvasion,
                TotalDefense = totalDefense
            },
            ActiveTraits = [.. characterStatistics.ActiveTraits],
            Stats = stats,
            StatBreakdown = statBreakdown,
            CalculatedAt = DateTime.UtcNow,
        };

        return simulation;
    }

    #endregion

    #region Private Stat Calculation Methods

    /// <summary>
    /// Applies base character stats using race, job, and subjob calculations
    /// </summary>
    private void ApplyBaseStats(CharacterStatistics stats, RaceConfiguration raceConfig, int masterLevel, JobConfiguration mainJobConfig, int? subJobLevel, JobConfiguration? subJobConfig)
    {
        // Apply race stats directly using database configuration

        foreach (var baseStat in raceConfig.RaceBaseStats)
        {
            if (baseStat.Value > 0)
            {
                stats.AddModifier(baseStat.StatId, baseStat.Value, $"Race: {raceConfig.Abbreviation}");
            }
        }

        // Apply main job stats directly using database configuration
        foreach (var baseStat in mainJobConfig.JobBaseStats)
        {
            stats.AddModifier(baseStat.StatId, baseStat.MaxValue, $"Main Job: {ConvertJobIdToCode(mainJobConfig.JobId)}");
        }

        // TODO: Some stats are still +/- 1. I think usually -1 due to changing scaling at higher subjob levels 58/59?
        if (subJobConfig != null && subJobLevel.HasValue && subJobLevel > 0)
        {
            // Calculate effective subjob level based on main job master level
            var effectiveSubJobLevel = Math.Min(49 + (masterLevel / 5), subJobLevel.Value);

            foreach (var baseStat in subJobConfig.JobBaseStats)
            {
                int baseValue;
                double multiplier;

                switch (baseStat.BaseStatRank)
                {
                    case BaseStatRank.A:
                        baseValue = 5;
                        multiplier = 0.50;
                        break;
                    case BaseStatRank.B:
                        baseValue = 4;
                        multiplier = 0.45;
                        break;
                    case BaseStatRank.C:
                        baseValue = 4;
                        multiplier = 0.40;
                        break;
                    case BaseStatRank.D:
                        baseValue = 3;
                        multiplier = 0.35;
                        break;
                    case BaseStatRank.E:
                        baseValue = 3;
                        multiplier = 0.30;
                        break;
                    case BaseStatRank.F:
                        baseValue = 2;
                        multiplier = 0.25;
                        break;
                    case BaseStatRank.G:
                        baseValue = 2;
                        multiplier = 0.20;
                        break;
                    default:
                        baseValue = 0;
                        multiplier = 0;
                        break;
                }

                var subJobValue = (int)Math.Floor(baseValue + (effectiveSubJobLevel - 1) * multiplier) / 2;

                if (subJobValue > 0)
                {
                    stats.AddModifier(baseStat.StatId, subJobValue, $"Sub Job: {ConvertJobIdToCode(subJobConfig.JobId)}");
                }
            }
        }
    }

    /// <summary>
    /// Apply combat skills using SkillRankMapping table to lookup numeric values
    /// </summary>
    private void ApplyCombatSkills(CharacterStatistics stats, JobConfiguration mainJobConfig, int? subJobLevel, JobConfiguration? subJobConfig)
    {
        // Use cached SkillRankMappings for efficient lookup
        var skillRankMappings = _skillRankMappingCache.SkillRankMappings;

        // Create lookup dictionary for faster access: (SkillRank, Level) -> SkillValue
        var skillLookup = skillRankMappings
            .ToDictionary(srm => (srm.SkillRank, srm.Level), srm => srm.SkillValue);

        // Collect all skills from main job and sub job
        var allSkills = new Dictionary<int, (int value, string source)>();

        // Process main job skills
        foreach (var jobBaseSkill in mainJobConfig.JobBaseSkills)
        {
            var skillValue = GetSkillValue(skillLookup, jobBaseSkill.SkillRank, 99); // Assume 99 always
            if (skillValue > 0)
            {
                allSkills[jobBaseSkill.StatId] = (skillValue, $"Main Job: {ConvertJobIdToCode(mainJobConfig.JobId)}");
            }
        }

        if (subJobLevel != null && subJobConfig != null)
        {
            // Process sub job skills - only take higher value if skill exists on both jobs
            foreach (var jobBaseSkill in subJobConfig.JobBaseSkills)
            {
                // Sub job level is capped at 49 + (main job master level / 5) or sub job level, whichever is lower
                var skillValue = GetSkillValue(skillLookup, jobBaseSkill.SkillRank, subJobLevel.Value);

                if (skillValue > 0)
                {
                    // If main job already has this skill, take the higher value
                    if (allSkills.ContainsKey(jobBaseSkill.StatId))
                    {
                        if (skillValue > allSkills[jobBaseSkill.StatId].value)
                        {
                            allSkills[jobBaseSkill.StatId] = (skillValue, $"Sub Job: {ConvertJobIdToCode(subJobConfig.JobId)}");
                        }
                        // If main job value is higher or equal, keep it (no change needed)
                    }
                    else
                    {
                        // Sub job has a skill that main job doesn't have
                        allSkills[jobBaseSkill.StatId] = (skillValue, $"Sub Job: {ConvertJobIdToCode(subJobConfig.JobId)}");
                    }
                }
            }
        }

        // Apply all collected skills to character stats
        foreach (var kvp in allSkills)
        {
            stats.AddModifier(kvp.Key, kvp.Value.value, kvp.Value.source);
        }
    }

    /// <summary>
    /// Helper method to lookup skill value from the mapping table
    /// </summary>
    private static int GetSkillValue(Dictionary<(SkillRank, int), int> skillLookup, SkillRank skillRank, int level)
    {
        // Ensure level is within valid range
        level = Math.Max(1, Math.Min(99, level));

        if (skillLookup.TryGetValue((skillRank, level), out var skillValue))
        {
            return skillValue;
        }

        // If exact level not found (shouldn't happen with complete data), return 0
        return 0;
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

        var hpStatId = await _statIdLookupService.GetStatIdByNameAsync("HP") ?? throw new InvalidOperationException("HP stat ID not found");
        stats.AddModifier(hpStatId, 150, "Merit Points");

        var mpStatId = await _statIdLookupService.GetStatIdByNameAsync("MP") ?? throw new InvalidOperationException("MP stat ID not found");
        stats.AddModifier(mpStatId, 150, "Merit Points");

        var skillStatIds = await _statIdLookupService.GetStatIdsByNamesAsync(
            "Hand-to-Hand Skill",
            "Dagger Skill",
            "Sword Skill",
            "Great Sword Skill",
            "Axe Skill",
            "Great Axe Skill",
            "Scythe Skill",
            "Polearm Skill",
            "Katana Skill",
            "Great Katana Skill",
            "Club Skill",
            "Staff Skill",
            "Archery Skill",
            "Marksmanship Skill",
            "Throwing Skill",
            "Guarding Skill",
            "Evasion Skill",
            "Shield Skill",
            "Parrying Skill",
            "Divine Magic Skill",
            "Healing Magic Skill",
            "Enhancing Magic Skill",
            "Enfeebling Magic Skill",
            "Elemental Magic Skill",
            "Dark Magic Skill",
            "Summoning Magic Skill",
            "Ninjutsu Skill",
            "Singing Skill",
            "String Instrument Skill",
            "Wind Instrument Skill",
            "Blue Magic Skill",
            "Geomancy Skill",
            "Handbell Skill"
            );

        if (skillStatIds.Count != 33)
        {
            throw new InvalidOperationException("Not all skill stat IDs found");
        }

        // Apply all collected skills to character stats
        foreach (var (statName, statId) in skillStatIds)
        {
            stats.AddModifier(statId, 16, "Merit Points");
        }
    }

    /// <summary>
    /// Apply job traits from both main job and sub job, ensuring no duplicate traits
    /// Sub job traits are only applied if main job doesn't have the same trait at same or higher tier
    /// </summary>
    private static void ApplyJobTraits(CharacterStatistics stats, JobConfiguration mainJobConfig, int? subJobLevel, JobConfiguration? subJobConfig)
    {
        // Get highest tier traits for main job
        var mainJobTraits = GetHighestTierTraits(mainJobConfig.JobTraits.ToList(), 99);


        // Apply all main job traits first
        foreach (var trait in mainJobTraits)
        {
            stats.AddModifier(trait.StatId, trait.Value, $"Main Job Trait: {trait.Name}");
            stats.ActiveTraits.Add($"Main: {trait.Name}");
        }

        if (subJobLevel == null || subJobConfig == null)
        {
            return; // No sub job to process
        }

        // Get highest tier traits for sub job
        var subJobTraits = GetHighestTierTraits(subJobConfig.JobTraits.ToList(), subJobLevel.Value);

        // Apply sub job traits only if they don't conflict with main job traits
        foreach (var subTrait in subJobTraits)
        {
            var subTraitBaseName = GetTraitBaseName(subTrait.Name);

            // Check if main job has the same trait family
            var conflictingMainTrait = mainJobTraits.FirstOrDefault(mainTrait =>
                GetTraitBaseName(mainTrait.Name) == subTraitBaseName);

            if (conflictingMainTrait == null)
            {
                // No conflict - add the sub job trait
                stats.AddModifier(subTrait.StatId, subTrait.Value, $"Sub Job Trait: {subTrait.Name}");
                stats.ActiveTraits.Add($"Sub: {subTrait.Name}");
            }
            else
            {
                // There's a conflict - only add sub job trait if it's higher tier than main job trait
                var subTraitTier = GetTraitTier(subTrait.Name);
                var mainTraitTier = GetTraitTier(conflictingMainTrait.Name);

                if (subTraitTier > mainTraitTier)
                {
                    // Remove the lower tier main job trait effect
                    stats.AddModifier(conflictingMainTrait.StatId, -conflictingMainTrait.Value, $"Replaced by Sub Job Trait: {subTrait.Name}");
                    stats.ActiveTraits.Remove($"Main: {conflictingMainTrait.Name}");

                    // Add the higher tier sub job trait
                    stats.AddModifier(subTrait.StatId, subTrait.Value, $"Sub Job Trait: {subTrait.Name}");
                    stats.ActiveTraits.Add($"Sub: {subTrait.Name}");
                }
                // If main job trait is same or higher tier, do nothing (keep main job trait)
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
    /// Extracts the tier number from a trait name
    /// e.g., "Double Attack III" -> 3, "Double Attack" -> 1
    /// </summary>
    private static int GetTraitTier(string traitName)
    {
        var tierMap = new Dictionary<string, int>
        {
            { " I", 1 }, { " II", 2 }, { " III", 3 }, { " IV", 4 }, { " V", 5 },
            { " VI", 6 }, { " VII", 7 }, { " VIII", 8 }, { " IX", 9 }, { " X", 10 }
        };

        foreach (var (indicator, tier) in tierMap)
        {
            if (traitName.EndsWith(indicator))
            {
                return tier;
            }
        }

        // If no tier indicator found, assume it's tier 1
        return 1;
    }

    /// <summary>
    /// Apply job point bonuses for mastered jobs
    /// </summary>
    private static void ApplyJobPointBonuses(CharacterStatistics stats, JobConfiguration mainJobConfig)
    {
        // Apply main job point bonuses (full effectiveness if mastered)
        foreach (var bonus in mainJobConfig.JobPointBonuses)
        {
            stats.AddModifier(bonus.StatId, bonus.Value, "Main Job Points");
        }
    }

    /// <summary>
    /// Apply job gifts for characters at master level 1 or higher
    /// </summary>
    private static void ApplyJobGifts(CharacterStatistics stats, JobConfiguration mainJobConfig)
    {
        // Apply all job gifts if character is at least master level 1
        foreach (var gift in mainJobConfig.JobGifts)
        {
            stats.AddModifier(gift.StatId, gift.Value, $"Job Gift: {gift.Stat.DisplayName ?? gift.Stat.Name}");
        }
    }

    /// <summary>
    /// Apply master level bonuses scaled by current master level
    /// </summary>
    private static void ApplyMasterLevelBonuses(CharacterStatistics stats, int masterLevel, JobConfiguration mainJobConfig)
    {

        // Apply main job master level bonuses (scaled by ML)
        foreach (var bonus in mainJobConfig.MasterLevelBonuses)
        {
            // Scale bonus based on current master level (ML1-50)
            var scaledValue = bonus.Value * masterLevel;
            stats.AddModifier(bonus.StatId, scaledValue, $"Main ML{masterLevel}");
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
            .Include(jc => jc.Job)
            .Include(jc => jc.JobBaseStats)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobBaseSkills)
                .ThenInclude(jbs => jbs.Stat)
            .Include(jc => jc.JobTraits)
                .ThenInclude(jt => jt.Stat)
            .Include(jc => jc.JobPointBonuses)
                .ThenInclude(jpb => jpb.Stat)
            .Include(jc => jc.JobGifts)
                .ThenInclude(jg => jg.Stat)
            .Include(jc => jc.MasterLevelBonuses)
                .ThenInclude(mlb => mlb.Stat)
            .AsNoTracking()
            .AsSplitQuery()
            .FirstAsync(jc => jc.JobId == jobId);
    }

    /// <summary>
    /// Get race configuration from database with all related data
    /// Throws exception if configuration is not found (indicates data integrity issue)
    /// </summary>
    private async Task<RaceConfiguration> GetRaceConfigurationAsync(int id)
    {
        return await _context.RaceConfigurations
            .Include(rc => rc.RaceBaseStats)
                .ThenInclude(rbs => rbs.Stat)
            .FirstAsync(rc => rc.Id == id);
    }

    public static int CalculatePrimaryAccuracy(int accFromDex, int accFromSkill, int bonusAcc)
    {
        return accFromDex + accFromSkill + bonusAcc;
    }

    public static int CalculateEvasion(int agi, int evasionSkill, int evasion)
    {
        var evasionFromAgi = (int)Math.Floor(agi * 0.75);
        return evasionFromAgi + evasionSkill + evasion;
    }

    public static int CalculateAccuracyFromDex(int dex)
    {
        return (int)Math.Floor(dex * 0.75);
    }

    public static int CalculateEvasionFromAgi(int agi)
    {
        return (int)Math.Floor(agi * 0.75);
    }

    public static int CalculateAccuracyFromSkill(int skill)
    {
        if (skill <= 200)
        {
            return skill;
        }
        else if (skill > 200 && skill <= 400)
        {
            return (int)Math.Floor((skill - 200) * 0.9) + 200;
        }
        else if (skill > 400 && skill <= 600)
        {
            return (int)Math.Floor((skill - 400) * 0.8) + 380;
        }
        else // Skill > 600
        {
            return (int)Math.Floor((skill - 600) * 0.9) + 540;
        }
    }

    public static int CalculateEvasionFromSkill(int skill)
    {
        if (skill <= 200)
        {
            return skill;
        }
        else if (skill > 200 && skill <= 400)
        {
            return (int)Math.Floor((skill - 200) * 0.9) + 200;
        }
        else if (skill > 400 && skill <= 600)
        {
            return (int)Math.Floor((skill - 400) * 0.8) + 380;
        }
        else // Skill > 600
        {
            return (int)Math.Floor((skill - 600) * 0.9) + 540;
        }
    }

    public static int CalculateBaseDefense(int vit, int level)
    {
        return (int)Math.Floor(vit * 1.5) + level + 18 + (int)Math.Floor((level - 89) * 0.5);
    }

    public static int CalculateAttack(int combatSkill, int str, int bonusAttack)
    {
        return 8 + combatSkill + str + bonusAttack;
    }


    public static int CalculateAuxiliaryAttack(int combatSkill, int str)
    {
        return 8 + combatSkill + (int)Math.Floor(str * 0.5);
    }

    #endregion
}
