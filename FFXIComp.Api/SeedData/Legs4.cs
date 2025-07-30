using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Legs4SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Desultor Tassets (Barrage)",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 2 },
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "Barrage", Value = 1 },
                        new GearStat { Name = "RangedAccuracy", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Carmine Cuisses +1D",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 47 },
                        new GearStat { Name = "DualWield", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 27 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Augury Cuisses +1 R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 27 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Attack", Value = 76 },
                        new GearStat { Name = "MagicAttack", Value = 46 },
                        new GearStat { Name = "Evasion", Value = 27 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "DA", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Turms Subligar +1",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 37 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 51 },
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R15A",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R15B",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 49 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 49 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R15C",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R20A",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 9 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R20B",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 9 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R20C",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 25 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R25A",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 65 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 65 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R25B",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 11 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R25C",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 54 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 4 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R30A",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 70 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 13 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R30B",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 58 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Nyame Flanchard R30C",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 59 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 35 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ikenga's Trousers R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Trousers R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Trousers R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Trousers R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 41 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Trousers R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "PDL", Value = 6 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Gleti's Breeches R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 14 },
                        new GearStat { Name = "SubtleBlow", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Breeches R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 14 },
                        new GearStat { Name = "SubtleBlow", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Breeches R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 14 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Breeches R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 14 },
                        new GearStat { Name = "SubtleBlow", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Breeches R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 3 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 37 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "TA", Value = 5 },
                        new GearStat { Name = "PDT", Value = -8 },
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 14 },
                        new GearStat { Name = "SubtleBlow", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Cuisses R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Cuisses R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "SkillchainBonus", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Cuisses R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "SkillchainBonus", Value = 10 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Cuisses R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 51 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "SkillchainBonus", Value = 13 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Cuisses R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "SkillchainBonus", Value = 15 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 9 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Hose R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 13 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Hose R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 13 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Hose R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 13 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Hose R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 13 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Hose R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "PDT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 85 },
                        new GearStat { Name = "MagicEvasion", Value = 106 },
                        new GearStat { Name = "MagicDefense", Value = 13 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Agwu's Slops R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Slops R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Slops R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Slops R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Slops R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 54 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Pants R0",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Pants R15",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "BloodPactDamage", Value = 4 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Pants R20",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "BloodPactDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Pants R25",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "BloodPactDamage", Value = 7 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Pants R30",
                    Slot = "Legs",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 9 },
                        new GearStat { Name = "BloodPactDamage", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Evasion", Value = 58 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                }
            };
        }
    }
}
