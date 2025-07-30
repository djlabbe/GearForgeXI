using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Body1SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Agoge Lorica +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 36 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 85 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Agoge Lorica +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 95 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Cyclas +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Cyclas +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 65 },
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Ankusa Jackcoat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Ankusa Jackcoat +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:DA", Value = 5 },
                        new GearStat { Name = "Pet:GearHaste", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Arcadian Jerkin +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DoubleShotDamage", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Arcadian Jerkin +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DoubleShotDamage", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Archmage's Coat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 46 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Archmage's Coat +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 25 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Assimilator's Jubbah +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Assimilator's Jubbah +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 109 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Bagua Tunic +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Bagua Tunic +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 66 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Bihu Justaucorps +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "PDT", Value = -7 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 92 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Bihu Justaucorps +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 44 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 45 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "Attack", Value = 102 },
                        new GearStat { Name = "MagicAccuracy", Value = 59 },
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "PDT", Value = -7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Brioso Justaucorps +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Brioso Justaucorps +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 36 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 45 },
                        new GearStat { Name = "Accuracy", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 74 },
                        new GearStat { Name = "Evasion", Value = 104 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Fallen's Cuirass +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 82 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 68 },
                        new GearStat { Name = "MagicAttack", Value = 61 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 27 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Fallen's Cuirass +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 44 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 92 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 63 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 108 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 27 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Foire Tobe +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 57 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "Pet:GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Foire Tobe +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 67 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 67 },
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "Pet:GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Hachiya Chainmail +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hachiya Chainmail +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 10 },
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Cyclas +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Cyclas +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 113 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DT", Value = -5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Horos Casaque +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Horos Casaque +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "PDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Ignominy Cuirass +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 68 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 46 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Ignominy Cuirass +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 46 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 101 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Frac +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 45 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 57 },
                        new GearStat { Name = "RangedAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "Recycle", Value = 19 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Frac +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 50 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 67 },
                        new GearStat { Name = "RangedAttack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 67 },
                        new GearStat { Name = "Evasion", Value = 109 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Recycle", Value = 19 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Lanun Frac +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "RangedAttack", Value = 83 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 61 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Lanun Frac +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "RangedAttack", Value = 93 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 64 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "PDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Jubbah +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 49 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Jubbah +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Maxixi Casaque +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 79 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Maxixi Casaque +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 66 },
                        new GearStat { Name = "Attack", Value = 38 },
                        new GearStat { Name = "MagicAccuracy", Value = 66 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Chainmail +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 51 },
                        new GearStat { Name = "Attack", Value = 87 },
                        new GearStat { Name = "RangedAccuracy", Value = 47 },
                        new GearStat { Name = "RangedAttack", Value = 79 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 9 },
                        new GearStat { Name = "Daken", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Chainmail +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 97 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "RangedAttack", Value = 89 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 113 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 9 },
                        new GearStat { Name = "Daken", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Orion Jerkin +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 41 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Orion Jerkin +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 45 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "RangedAccuracy", Value = 70 },
                        new GearStat { Name = "RangedAttack", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 22 },
                        new GearStat { Name = "Evasion", Value = 109 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Pedagogy Gown +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Piety Bliaut +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Piety Bliaut +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Pillager's Vest +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 79 },
                        new GearStat { Name = "MagicEvasion", Value = 94 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 7 },
                        new GearStat { Name = "CritDamage", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pillager's Vest +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 7 },
                        new GearStat { Name = "CritDamage", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pitre Tobe +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:Accuracy", Value = 50 },
                        new GearStat { Name = "PetAttack", Value = 60 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 50 },
                        new GearStat { Name = "PetRangedAttack", Value = 60 },
                        new GearStat { Name = "PetStoreTP", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Pitre Tobe +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 113 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:Accuracy", Value = 55 },
                        new GearStat { Name = "PetAttack", Value = 70 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 55 },
                        new GearStat { Name = "PetRangedAttack", Value = 70 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 55 },
                        new GearStat { Name = "PetStoreTP", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Vest +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 46 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 45 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TrickAttackBonus", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "CritDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Vest +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 46 },
                        new GearStat { Name = "Dex", Value = 46 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 45 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TrickAttackBonus", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "CritDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Mail +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 80 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Mail +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 90 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 101 },
                        new GearStat { Name = "MagicEvasion", Value = 113 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Pummeler's Lorica +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Pummeler's Lorica +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 37 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 104 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Sakonji Domaru +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 80 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Sakonji Domaru +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 90 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 113 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Coat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 48 },
                        new GearStat { Name = "MagicAttack", Value = 0 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Coat +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 36 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 44 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 50 },
                        new GearStat { Name = "Evasion", Value = 101 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Totemic Jackcoat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Totemic Jackcoat +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 109 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:DT", Value = -10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Vishap Mail +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 57 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Vishap Mail +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 36 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 67 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 67 },
                        new GearStat { Name = "Evasion", Value = 101 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Vitiation Tabard +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Vitiation Tabard +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Wakido Domaru +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 61 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 57 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Wakido Domaru +4",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 36 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 67 },
                        new GearStat { Name = "MagicAccuracy", Value = 67 },
                        new GearStat { Name = "Evasion", Value = 101 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Abnoba Kaftan",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 22 },
                        new GearStat { Name = "Attack", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "CritDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Adhemar Jacket +1 A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 },
                        new GearStat { Name = "RangedAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Adhemar Jacket +1 B",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 },
                        new GearStat { Name = "RangedAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Adhemar Jacket +1 C",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agony Jerkin +1 R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 49 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Attack", Value = 83 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Accuracy", Value = 14 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Ashera Harness",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 90 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "DT", Value = -7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Dagon Breastplate",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlowII", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 1 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Flamma Korazin +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 17 },
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "StoreTP", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Gyve Doublet",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 41 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "MagicAttack", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Herculean Vest",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Hizamaru Haramaki +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 28 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Kendatsuba Samue +1",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 12 },
                        new GearStat { Name = "Evasion", Value = 70 },
                        new GearStat { Name = "MagicEvasion", Value = 117 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 37 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 47 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Malignance Tabard",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Int", Value = 19 },
                        new GearStat { Name = "Mnd", Value = 24 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Mummu Jacket +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "RangedAccuracy", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Ratri Breastplate +1",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 70 },
                        new GearStat { Name = "MagicEvasion", Value = 117 },
                        new GearStat { Name = "MagicDefense", Value = 0 },
                        new GearStat { Name = "DT", Value = 14 },
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "MagicAccuracy", Value = 47 },
                        new GearStat { Name = "ScytheSkill", Value = 56 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Ryuo Domaru +1 A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 59 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 19 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 57 },
                        new GearStat { Name = "Attack", Value = 37 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Samnuha Coat",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 23 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 5 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Sulevia's Platemail +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 59 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 41 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 1 },
                        new GearStat { Name = "SkillchainBonus", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Tatenashi Haramaki +1 R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 59 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "TA", Value = 5 },
                        new GearStat { Name = "Zanshin", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Hattori Ningi +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "RangedAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hattori Ningi +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "RangedAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Heathen's Cuirass +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 103 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Heathen's Cuirass +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Amalric Doublet +1A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 33 },
                        new GearStat { Name = "MagicEvasion", Value = 91 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Ea Houppelande +1",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 128 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 44 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Wicce Coat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 141 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 50 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 59 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 },
                        new GearStat { Name = "MagicDamage", Value = 34 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Wicce Coat +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 131 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 45 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 4 },
                        new GearStat { Name = "MagicDamage", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Jhakri Robe +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 33 },
                        new GearStat { Name = "MagicEvasion", Value = 53 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 50 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "MagicAttack", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Lethargy Sayon +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 136 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "DT", Value = -14 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "MagicDamage", Value = 34 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Lethargy Sayon +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 81 },
                        new GearStat { Name = "MagicEvasion", Value = 126 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 49 },
                        new GearStat { Name = "MagicDamage", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Peltast's Plackart +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 14 },
                        new GearStat { Name = "PDL", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Peltast's Plackart +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "PDL", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Ayanmo Corazza +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Arbatel Gown +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 141 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 50 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 59 },
                        new GearStat { Name = "MagicDamage", Value = 34 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Arbatel Gown +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 131 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 45 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "MagicDamage", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Boii Lorica +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -14 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GreatAxeSkill", Value = 21 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Boii Lorica +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GreatAxeSkill", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Kasuga Domaru +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -14 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GreatKatanaSkill", Value = 21 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 14 },
                        new GearStat { Name = "Zanshin", Value = 16 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Kasuga Domaru +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GreatKatanaSkill", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "Zanshin", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Frac +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "RangedAccuracy", Value = 64 },
                        new GearStat { Name = "RangedAttack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TripleShot", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Frac +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "RangedAccuracy", Value = 54 },
                        new GearStat { Name = "RangedAttack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TripleShot", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Fili Hongreline +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 136 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 48 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Fili Hongreline +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 126 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Meghanada Cuirie +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 19 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 46 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "CritDamage", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Oshosi Vest +1",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 65 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 47 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "DoubleShot", Value = 8 },
                        new GearStat { Name = "TripleShot", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Skulker's Vest +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 51 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "DaggerSkill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Skulker's Vest +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 46 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "DaggerSkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Bhikku Cyclas +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "MartialArts", Value = 8 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Bhikku Cyclas +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "MartialArts", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Maculele Casaque +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 14 },
                        new GearStat { Name = "Evasion", Value = 115 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -14 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 11 },
                        new GearStat { Name = "StrikingCritRate", Value = 70 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Maculele Casaque +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 13 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 11 },
                        new GearStat { Name = "StrikingCritRate", Value = 65 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Nukumi Gausape +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "AxeSkill", Value = 21 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Nukumi Gausape +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "AxeSkill", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Azimuth Coat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 141 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 59 },
                        new GearStat { Name = "MagicDamage", Value = 34 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 28 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Azimuth Coat +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 131 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 29 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "MagicDamage", Value = 24 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Cuirass +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 52 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Cuirass +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 27 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Amini Caban +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "RangedAccuracy", Value = 64 },
                        new GearStat { Name = "RangedAttack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "PDL", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Amini Caban +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "RangedAccuracy", Value = 54 },
                        new GearStat { Name = "RangedAttack", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "PDL", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Nisroch Jerkin",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 90 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Cohort Cloak +1 R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 156 },
                        new GearStat { Name = "MagicDefense", Value = 12 },
                        new GearStat { Name = "Str", Value = 55 },
                        new GearStat { Name = "Dex", Value = 55 },
                        new GearStat { Name = "Vit", Value = 55 },
                        new GearStat { Name = "Agi", Value = 55 },
                        new GearStat { Name = "Int", Value = 76 },
                        new GearStat { Name = "Mnd", Value = 76 },
                        new GearStat { Name = "Chr", Value = 68 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 34 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 118 },
                        new GearStat { Name = "MagicAttack", Value = 100 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Carmine Scale Mail +1 R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 42 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "Attack", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Erilaz Surcoat +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Erilaz Surcoat +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 87 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Karagoz Farsetto +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Pet:Accuracy", Value = 64 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 64 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 64 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Karagoz Farsetto +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Pet:Accuracy", Value = 54 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 54 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 54 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Hashishin Mintan +3",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 136 },
                        new GearStat { Name = "MagicDefense", Value = 11 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 45 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "Attack", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Hashishin Mintan +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 81 },
                        new GearStat { Name = "MagicEvasion", Value = 126 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 54 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 49 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Hjarrandi Breastplate",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 47 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 51 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 29 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Sacro Breastplate",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 96 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 12 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Volte Harness",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 39 },
                        new GearStat { Name = "RangedAccuracy", Value = 39 },
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Mallquis Saio +2",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 54 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "MagicDamage", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicAttack", Value = 15 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DT", Value = -8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Merlinic Jubbah (Occult Acumen)",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvasion", Value = 91 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDT", Value = -2 },
                        new GearStat { Name = "OccultAcumen", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Crepuscular Cloak",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 60 },
                        new GearStat { Name = "Dex", Value = 55 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 80 },
                        new GearStat { Name = "Mnd", Value = 64 },
                        new GearStat { Name = "Chr", Value = 61 },
                        new GearStat { Name = "Accuracy", Value = 85 },
                        new GearStat { Name = "MagicAccuracy", Value = 85 },
                        new GearStat { Name = "MagicAttack", Value = 85 },
                        new GearStat { Name = "Evasion", Value = 155 },
                        new GearStat { Name = "MagicEvasion", Value = 231 },
                        new GearStat { Name = "MagicDefense", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Twilight Cloak",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Turms Harness +1",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Evasion", Value = 98 },
                        new GearStat { Name = "MagicEvasion", Value = 128 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Nyame Mail R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R15A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R15B",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 50 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R15C",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 25 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R20A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R20B",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R20C",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 3 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R25A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 65 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 65 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R25B",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R25C",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 35 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R30A",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 70 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 15 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R30B",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 45 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 13 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Mail R30C",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 47 },
                        new GearStat { Name = "Chr", Value = 45 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 40 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 7 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Ikenga's Vest R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Vest R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "TPBonus", Value = 150 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Vest R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "TPBonus", Value = 170 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Vest R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "TPBonus", Value = 190 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Vest R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "TPBonus", Value = 200 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Gleti's Cuirass R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DA", Value = 0 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 102 },
                        new GearStat { Name = "MagicDefense", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Cuirass R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 102 },
                        new GearStat { Name = "MagicDefense", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Cuirass R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 102 },
                        new GearStat { Name = "MagicDefense", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Cuirass R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 102 },
                        new GearStat { Name = "MagicDefense", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Cuirass R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DA", Value = 10 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 102 },
                        new GearStat { Name = "MagicDefense", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Breastplate R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Breastplate R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Breastplate R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Breastplate R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Breastplate R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Doublet R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Doublet R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Doublet R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Doublet R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Doublet R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Agwu's Robe R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 83 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Robe R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 83 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Robe R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 83 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Robe R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "MagicDamage", Value = 25 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 83 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Robe R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 83 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Robe R0",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Robe R15",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Robe R20",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Robe R25",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Robe R30",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                }
            };
        }
    }
}
