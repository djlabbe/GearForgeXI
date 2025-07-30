using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Hands2SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Pillager's Armlets +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 92 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "DualWield", Value = 5 },
                        new GearStat { Name = "TrickAttackBonus", Value = 20 },
                        new GearStat { Name = "CritDamage", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                },
                new GearItem
                {
                    Name = "Pitre Dastanas +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "Pet:GearHaste", Value = 7 },
                        new GearStat { Name = "Pet:SubtleBlow", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Pitre Dastanas +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "Pet:GearHaste", Value = 7 },
                        new GearStat { Name = "Pet:SubtleBlow", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Armlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Armlets +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Finger Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Finger Gauntlets +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 51 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "PetMDT", Value = -11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Sakonji Kote +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 81 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Sakonji Kote +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 91 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "PDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 44 },
                        new GearStat { Name = "MagicAttack", Value = 0 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 21 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 48 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicDamage", Value = 46 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Totemic Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Totemic Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "Pet:GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Vishap Finger Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Vishap Finger Gauntlets +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 71 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Vitiation Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 57 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 46 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Vitiation Gloves +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 46 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 97 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Wakido Kote +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "MagicEvasion", Value = 46 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "HassoPlusJAHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Wakido Kote +4",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 45 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "MagicAccuracy", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 71 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "HassoPlusJAHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Adhemar Wristbands +1 A",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 56 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 32 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Adhemar Wristbands +1 B",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 56 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 7 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 32 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Adhemar Wristbands +1 C",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "RangedAttack", Value = 20 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Flamma Manopolas +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 48 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 46 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 8 },
                        new GearStat { Name = "Int", Value = 7 },
                        new GearStat { Name = "Mnd", Value = 24 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Floral Gauntlets",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvasion", Value = 37 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "MDT", Value = -4 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 12 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "RangedAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "DualWield", Value = 5 },
                        new GearStat { Name = "TA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Herculean Gloves",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 41 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "PDT", Value = -2 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 8 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 12 },
                        new GearStat { Name = "RangedAccuracy", Value = 12 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "TA", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Hizamaru Kote +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 7 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Kendatsuba Tekko +1",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 8 },
                        new GearStat { Name = "Evasion", Value = 51 },
                        new GearStat { Name = "MagicEvasion", Value = 90 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 14 },
                        new GearStat { Name = "Dex", Value = 62 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "RangedAccuracy", Value = 44 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Malignance Gloves",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 56 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 24 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 12 },
                        new GearStat { Name = "PDL", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Mummu Wrists +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 49 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 53 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "RangedAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Ratri Gadlings +1",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 51 },
                        new GearStat { Name = "MagicEvasion", Value = 90 },
                        new GearStat { Name = "MagicDefense", Value = 0 },
                        new GearStat { Name = "DT", Value = 10 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "MagicAccuracy", Value = 44 },
                        new GearStat { Name = "ScytheSkill", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Ryuo Tekko +1 A",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvasion", Value = 32 },
                        new GearStat { Name = "MagicDefense", Value = 1 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "RangedAccuracy", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "CritDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Ryuo Tekko +1 D",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvasion", Value = 32 },
                        new GearStat { Name = "MagicDefense", Value = 1 },
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 58 },
                        new GearStat { Name = "RangedAccuracy", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "CritDamage", Value = 5 },
                        new GearStat { Name = "DA", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sulevia's Gauntlets +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 16 },
                        new GearStat { Name = "MagicEvasion", Value = 37 },
                        new GearStat { Name = "MagicDefense", Value = 0 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 47 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "DA", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Tatenashi Gote +1 R15",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvasion", Value = 32 },
                        new GearStat { Name = "MagicDefense", Value = 1 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 61 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "Zanshin", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Hattori Tekko +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 79 },
                        new GearStat { Name = "MagicEvasion", Value = 103 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 55 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 24 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "RangedAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "NinjutsuMagicAttack", Value = 18 },
                        new GearStat { Name = "MagicBurstDamage", Value = 15 },
                        new GearStat { Name = "FutaeBonus", Value = 28 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hattori Tekko +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "NinjutsuMagicAttack", Value = 16 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "FutaeBonus", Value = 26 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Heathen's Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 72 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GreatSwordSkill", Value = 28 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Heathen's Gauntlets +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GreatSwordSkill", Value = 23 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Amalric Gages +1A",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 19 },
                        new GearStat { Name = "MagicEvasion", Value = 48 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 23 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "blu" } }
                },
                new GearItem
                {
                    Name = "Ea Cuffs +1",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 37 },
                        new GearStat { Name = "MagicEvasion", Value = 101 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 7 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 23 },
                        new GearStat { Name = "MagicAccuracy", Value = 49 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Wicce Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 47 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 57 },
                        new GearStat { Name = "MagicDamage", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Wicce Gloves +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvasion", Value = 88 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Jhakri Cuffs +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 13 },
                        new GearStat { Name = "MagicEvasion", Value = 32 },
                        new GearStat { Name = "MagicDefense", Value = 1 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 0 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Lethargy Gantherots +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 87 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 50 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Lethargy Gantherots +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 77 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 47 },
                        new GearStat { Name = "MagicDamage", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                }
            };
        }
    }
}
