using GearForgeXI.Models;
using GearForgeXI.Services;

namespace GearForgeXI.Services;

/// <summary>
/// Service to build job configurations using database stat IDs
/// This replaces the static string-based job configurations
/// </summary>
public class JobConfigurationBuilder
{
    private readonly StatIdLookupService _statLookupService;

    public JobConfigurationBuilder(StatIdLookupService statLookupService)
    {
        _statLookupService = statLookupService;
    }

    /// <summary>
    /// Build job configurations with proper stat IDs from database
    /// </summary>
    public async Task<Dictionary<int, JobStaticData>> BuildJobConfigurationsAsync()
    {
        // Get all the stat IDs we'll need
        var statIds = await _statLookupService.GetStatIdsByNamesAsync(
            // Core stats
            "STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR",
            // Combat stats
            "Attack", "Accuracy", "Defense", "Evasion", "RangedAttack", "RangedAccuracy",
            "DA", "TA", "QA", "GearHaste", "StoreTP", "DualWield", "CritRate",
            // Magic stats
            "MagicAttack", "MagicAccuracy", "MagicDefense", "MagicEvasion",
            "MagicBurstDamage", "CurePotency", "FastCast",
            // Defensive stats
            "DT", "PDT", "MDT",
            // Weapon skills
            "WeaponSkillDamage", "WeaponSkillAccuracy",
            // Other
            "SubtleBlow", "MartialArts", "Counter", "Enmity"
        );

        var configs = new Dictionary<int, JobStaticData>();

        // Helper method to safely get stat ID
        int GetStatId(string statName) => statIds.TryGetValue(statName, out var id) ? id : 0;

        // WAR - Warrior
        configs[1] = new JobStaticData
        {
            Traits = new List<JobTrait>
            {
                new() { Name = "Fencer V", Level = 99, StatModifiers = { [GetStatId("Fencer")] = 5 } },
                new() { Name = "Double Attack V", Level = 99, StatModifiers = { [GetStatId("Double Attack")] = 28 } },
                new() { Name = "Shield Defense Bonus III", Level = 80, StatModifiers = { [GetStatId("Shield Def. Bonus")] = 6 } }
            },
            JobPointBonuses = new()
            {
                [GetStatId("Defense")] = 10,
                [GetStatId("Attack")] = 10,
                [GetStatId("RangedAttack")] = 10,
                [GetStatId("Evasion")] = 5,
                [GetStatId("Accuracy")] = 5,
                [GetStatId("RangedAccuracy")] = 10
            },
            MasterLevelBonuses = new()
            {
                [GetStatId("STR")] = 50,
                [GetStatId("DEX")] = 50,
                [GetStatId("VIT")] = 50,
                [GetStatId("AGI")] = 50,
                [GetStatId("INT")] = 50,
                [GetStatId("MND")] = 50,
                [GetStatId("CHR")] = 50
            }
        };

        // MNK - Monk
        configs[2] = new JobStaticData
        {
            Traits = new List<JobTrait>
            {
                new() { Name = "Subtle Blow I", Level = 5, StatModifiers = { [GetStatId("SubtleBlow")] = 5 } },
            },
            JobPointBonuses = new()
            {

            },
            MasterLevelBonuses = new()
            {
                [GetStatId("STR")] = 50,
                [GetStatId("DEX")] = 50,
                [GetStatId("VIT")] = 50,
                [GetStatId("AGI")] = 50,
                [GetStatId("INT")] = 50,
                [GetStatId("MND")] = 50,
                [GetStatId("CHR")] = 50
            }
        };

        // BLM
        configs[4] = new JobStaticData
        {
            Traits = new List<JobTrait>
            {

            },
            JobPointBonuses = new()
            {

            },
            MasterLevelBonuses = new()
            {
                [GetStatId("STR")] = 50,
                [GetStatId("DEX")] = 50,
                [GetStatId("VIT")] = 50,
                [GetStatId("AGI")] = 50,
                [GetStatId("INT")] = 50,
                [GetStatId("MND")] = 50,
                [GetStatId("CHR")] = 50
            }
        };

        // BST
        configs[9] = new JobStaticData
        {
            Traits = new List<JobTrait>
            {

            },
            JobPointBonuses = new()
            {

            },
            MasterLevelBonuses = new()
            {
                [GetStatId("STR")] = 50,
                [GetStatId("DEX")] = 50,
                [GetStatId("VIT")] = 50,
                [GetStatId("AGI")] = 50,
                [GetStatId("INT")] = 50,
                [GetStatId("MND")] = 50,
                [GetStatId("CHR")] = 50
            }
        };

        return configs;
    }
}
