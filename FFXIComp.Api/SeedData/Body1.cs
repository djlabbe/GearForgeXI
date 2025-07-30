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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
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
                        new GearStat { Name = "PetDA", Value = 5 },
                        new GearStat { Name = "PetGearHaste", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
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
                        new GearStat { Name = "PetGearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
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
                        new GearStat { Name = "PetGearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                }
            };
        }
    }
}
