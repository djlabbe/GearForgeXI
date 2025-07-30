using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Body3SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pld" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pld" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } }
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
                        new GearStat { Name = "PetAccuracy", Value = 64 },
                        new GearStat { Name = "PetRangedAccuracy", Value = 64 },
                        new GearStat { Name = "PetMagicAccuracy", Value = 64 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
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
                        new GearStat { Name = "PetAccuracy", Value = 54 },
                        new GearStat { Name = "PetRangedAccuracy", Value = 54 },
                        new GearStat { Name = "PetMagicAccuracy", Value = 54 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "drg" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drg" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Twilight Cloak",
                    Slot = "Body",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                }
            };
        }
    }
}
