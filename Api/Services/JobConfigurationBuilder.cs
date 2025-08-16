using GearForgeXI.Models;
using GearForgeXI.Services;

namespace GearForgeXI.Services;

/// <summary>
/// Service to build job configurations using database stat IDs
/// This replaces the static string-based job configurations
/// </summary>
public class JobConfigurationBuilder(StatIdLookupService statLookupService)
{
    private readonly StatIdLookupService _statLookupService = statLookupService;

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
            "DA", "TA", "QA", "DoubleAttack", "GearHaste", "StoreTP", "DualWield", "CritRate", "CritDamage",
            // Health/MP stats
            "HP", "MP",
            // Magic stats
            "MagicAttack", "MagicAccuracy", "MagicDefense", "MagicEvasion",
            "MagicBurstDamage", "CurePotency", "FastCast",
            // Defensive stats
            "DT", "PDT", "MDT", "ShieldDefBonus", "ShieldMastery",
            // Weapon skills
            "WeaponSkillDamage", "WeaponSkillAccuracy",
            // Warrior-specific traits
            "ResistVirus", "Smite", "PhysicalDamageLimit", "Fencer",
            // Other
            "SubtleBlow", "MartialArts", "Counter", "Enmity"
        );

        var configs = new Dictionary<int, JobStaticData>();

        // Helper method to safely get stat ID
        int GetStatId(string statName) => statIds.TryGetValue(statName, out var id) ? id : 0;

        // WAR - Warrior
        configs[1] = new JobStaticData
        {
            Traits =
            [
                new() { Name = "Defense Bonus I", Level = 10, StatModifiers = { [GetStatId("Defense")] = 10 } },
                new() { Name = "Resist Virus I", Level = 15, StatModifiers = { [GetStatId("ResistVirus")] = 10 } },
                new() { Name = "Double Attack I", Level = 25, StatModifiers = { [GetStatId("DoubleAttack")] = 10 } },
                new() { Name = "Max HP Boost I", Level = 30, StatModifiers = { [GetStatId("HP")] = 30 } },
                new() { Name = "Attack Bonus I", Level = 30, StatModifiers = { [GetStatId("Attack")] = 10 } },
                new() { Name = "Resist Virus II", Level = 35, StatModifiers = { [GetStatId("ResistVirus")] = 15 } },
                new() { Name = "Smite I", Level = 35, StatModifiers = { [GetStatId("Smite")] = 10 } },
                new() { Name = "Damage Limit+ I", Level = 40, StatModifiers = { [GetStatId("PhysicalDamageLimit")] = 10 } },
                new() { Name = "Fencer I", Level = 45, StatModifiers = { [GetStatId("Fencer")] = 1 } },
                new() { Name = "Defense Bonus II", Level = 45, StatModifiers = { [GetStatId("Defense")] = 22 } },
                new() { Name = "Double Attack II", Level = 50, StatModifiers = { [GetStatId("DoubleAttack")] = 12 } },
                new() { Name = "Max HP Boost II", Level = 50, StatModifiers = { [GetStatId("HP")] = 60 } },
                new() { Name = "Resist Virus III", Level = 50, StatModifiers = { [GetStatId("ResistVirus")] = 20 } },
                new() { Name = "Fencer II", Level = 58, StatModifiers = { [GetStatId("Fencer")] = 2 } },
                new() { Name = "Attack Bonus II", Level = 65, StatModifiers = { [GetStatId("Attack")] = 22 } },
                new() { Name = "Smite II", Level = 65, StatModifiers = { [GetStatId("Smite")] = 15 } },
                new() { Name = "Resist Virus IV", Level = 70, StatModifiers = { [GetStatId("ResistVirus")] = 25 } },
                new() { Name = "Max HP Boost III", Level = 70, StatModifiers = { [GetStatId("HP")] = 120 } },
                new() { Name = "Fencer III", Level = 71, StatModifiers = { [GetStatId("Fencer")] = 3 } },
                new() { Name = "Double Attack III", Level = 75, StatModifiers = { [GetStatId("DoubleAttack")] = 14 } },
                new() { Name = "Crit. Atk. Bonus I", Level = 78, StatModifiers = { [GetStatId("CritDamage")] = 5 } },
                new() { Name = "Shield Def. Bonus I", Level = 80, StatModifiers = { [GetStatId("ShieldDefBonus")] = 2 } },
                new() { Name = "Shield Mastery I", Level = 80, StatModifiers = { [GetStatId("ShieldMastery")] = 10 } },
                new() { Name = "Damage Limit+ II", Level = 80, StatModifiers = { [GetStatId("PhysicalDamageLimit")] = 10 } },
                new() { Name = "Resist Virus V", Level = 81, StatModifiers = { [GetStatId("ResistVirus")] = 30 } },
                new() { Name = "Fencer IV", Level = 84, StatModifiers = { [GetStatId("Fencer")] = 4 } },
                new() { Name = "Double Attack IV", Level = 85, StatModifiers = { [GetStatId("DoubleAttack")] = 16 } },
                new() { Name = "Defense Bonus III", Level = 86, StatModifiers = { [GetStatId("Defense")] = 35 } },
                new() { Name = "Crit. Atk. Bonus I", Level = 86, StatModifiers = { [GetStatId("CritDamage")] = 8 } },
                new() { Name = "Shield Mastery II", Level = 87, StatModifiers = { [GetStatId("ShieldMastery")] = 20 } },
                new() { Name = "Shield Def. Bonus II", Level = 88, StatModifiers = { [GetStatId("ShieldDefBonus")] = 4 } },
                new() { Name = "Max HP Boost IV", Level = 90, StatModifiers = { [GetStatId("HP")] = 180 } },
                new() { Name = "Attack Bonus III", Level = 91, StatModifiers = { [GetStatId("Attack")] = 35 } },
                new() { Name = "Shield Mastery III", Level = 93, StatModifiers = { [GetStatId("ShieldMastery")] = 30 } },
                new() { Name = "Smite III", Level = 95, StatModifiers = { [GetStatId("Smite")] = 20 } },
                new() { Name = "Fencer V", Level = 97, StatModifiers = { [GetStatId("Fencer")] = 5 } },
                new() { Name = "Double Attack V", Level = 99, StatModifiers = { [GetStatId("DoubleAttack")] = 18 } },
                new() { Name = "Shield Defense Bonus III", Level = 99, StatModifiers = { [GetStatId("ShieldDefBonus")] = 6 } }
            ],
            JobPointBonuses = new()
            {
                // [GetStatId("Defense")] = 10,
                // [GetStatId("Attack")] = 10,
                // [GetStatId("RangedAttack")] = 10,
                // [GetStatId("Evasion")] = 5,
                // [GetStatId("Accuracy")] = 5,
                // [GetStatId("RangedAccuracy")] = 10
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

        // WHM - White Mage
        configs[3] = new JobStaticData
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

        // RDM - Red Mage
        configs[5] = new JobStaticData
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

        // THF
        configs[6] = new JobStaticData
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

        // PLD
        configs[7] = new JobStaticData
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

        // DRK
        configs[8] = new JobStaticData
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

        configs[10] = new JobStaticData
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

        configs[11] = new JobStaticData
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

        configs[12] = new JobStaticData
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

        configs[13] = new JobStaticData
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

        configs[14] = new JobStaticData
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

        configs[15] = new JobStaticData
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

        configs[16] = new JobStaticData
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

        configs[17] = new JobStaticData
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

        configs[18] = new JobStaticData
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

        configs[19] = new JobStaticData
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

        configs[20] = new JobStaticData
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

        configs[21] = new JobStaticData
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

        configs[2] = new JobStaticData
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
