using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Hands1SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Agoge Mufflers +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 63 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Fencer", Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Agoge Mufflers +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 52 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 103 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Fencer", Value = 1 },
                        new GearStat { Name = "PDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 11 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 71 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 11 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Ankusa Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ankusa Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PetPDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Arcadian Bracers +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 38 },
                        new GearStat { Name = "RangedAttack", Value = 79 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Arcadian Bracers +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 44 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 43 },
                        new GearStat { Name = "RangedAttack", Value = 89 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Archmage's Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 23 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Accuracy", Value = 38 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Archmage's Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 41 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Atrophy Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Atrophy Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 46 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 48 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Bagua Mitaines +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Bagua Mitaines +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Bihu Cuffs +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 44 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Bihu Cuffs +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 49 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDT", Value = -5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Brioso Cuffs +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "MagicAccuracy", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Brioso Cuffs +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 41 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Fallen's Finger Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 77 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicAttack", Value = 62 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Fallen's Finger Gauntlets +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 48 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 87 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Foire Dastanas +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Evasion", Value = 52 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PetAccuracy", Value = 42 },
                        new GearStat { Name = "PetGearHaste", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Foire Dastanas +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 71 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PetAccuracy", Value = 58 },
                        new GearStat { Name = "PetRangedAccuracy", Value = 58 },
                        new GearStat { Name = "PetMagicAccuracy", Value = 58 },
                        new GearStat { Name = "PetGearHaste", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Futhark Mitons +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 81 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Futhark Mitons +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 91 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Hachiya Tekko +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "RangedAccuracy", Value = 48 },
                        new GearStat { Name = "RangedAttack", Value = 48 },
                        new GearStat { Name = "ThrowingSkill", Value = 14 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Daken", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hachiya Tekko +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "RangedAccuracy", Value = 58 },
                        new GearStat { Name = "RangedAttack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 71 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "ThrowingSkill", Value = 15 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Daken", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 54 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Horos Bangles +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 24 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 74 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Horos Bangles +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 24 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 84 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Gants +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "SubtleBlow", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Gants +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Lanun Gants +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 44 },
                        new GearStat { Name = "RangedAttack", Value = 76 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Lanun Gants +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 44 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 49 },
                        new GearStat { Name = "RangedAttack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Bazubands +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 44 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Bazubands +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 11 },
                        new GearStat { Name = "Evasion", Value = 37 },
                        new GearStat { Name = "MagicEvasion", Value = 37 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 44 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 44 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
                },
                new GearItem
                {
                    Name = "Maxixi Bangles +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 54 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Maxixi Bangles +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 28 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Tekko +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 79 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Tekko +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 89 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Orion Bracers +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 48 },
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Barrage", Value = 3 },
                        new GearStat { Name = "BarrageRangedAccuracy", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Orion Bracers +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "RangedAccuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Barrage", Value = 3 },
                        new GearStat { Name = "BarrageRangedAccuracy", Value = 32 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Piety Mitts +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                },
                new GearItem
                {
                    Name = "Piety Mitts +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                },
                new GearItem
                {
                    Name = "Pillager's Armlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Evasion", Value = 54 },
                        new GearStat { Name = "MagicEvasion", Value = 67 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "TrickAttackBonus", Value = 20 },
                        new GearStat { Name = "CritDamage", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                }
            };
        }
    }
}
