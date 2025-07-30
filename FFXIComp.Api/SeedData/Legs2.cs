using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Legs2SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Zoar Subligar +1 R15",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "war" },
                        new GearItemJob { JobName = "rdm" },
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "pld" },
                        new GearItemJob { JobName = "drk" },
                        new GearItemJob { JobName = "bst" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "rng" },
                        new GearItemJob { JobName = "sam" },
                        new GearItemJob { JobName = "nin" },
                        new GearItemJob { JobName = "drg" },
                        new GearItemJob { JobName = "blu" },
                        new GearItemJob { JobName = "cor" },
                        new GearItemJob { JobName = "dnc" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvastion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = -5 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Jhakri Slops +2",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "blm" },
                        new GearItemJob { JobName = "rdm" },
                        new GearItemJob { JobName = "blu" },
                        new GearItemJob { JobName = "sch" },
                        new GearItemJob { JobName = "geo" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 13 },
                        new GearStat { Name = "MagicEvastion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 14 },
                        new GearStat { Name = "Int", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "StoreTP", Value = 9 }
                    }
                },
                new GearItem
                {
                    Name = "Lethargy Fuseau +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "rdm" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvastion", Value = 162 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 38 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "MagicDamage", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Lethargy Fuseau +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "rdm" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvastion", Value = 152 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "MagicDamage", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Peltast's Cuissots +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "drg" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Crit Damage", Value = 13 }
                    }
                },
                new GearItem
                {
                    Name = "Peltast's Cuissots +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "drg" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Crit Damage", Value = 12 }
                    }
                },
                new GearItem
                {
                    Name = "Ayanmo Cosciales +2",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "whm" },
                        new GearItemJob { JobName = "rdm" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "blu" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvastion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 9 }
                    }
                },
                new GearItem
                {
                    Name = "Arbatel Pants +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "sch" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 168 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 53 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 99 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "MagicDamage", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Arbatel Pants +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "sch" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 158 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 89 },
                        new GearStat { Name = "MagicAttack", Value = 48 },
                        new GearStat { Name = "MagicDamage", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Boii Cuisses +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "war" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 8 },
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "Fencer", Value = 4 },
                        new GearStat { Name = "PDL", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 100 }
                    }
                },
                new GearItem
                {
                    Name = "Boii Cuisses +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "war" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 8 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "Fencer", Value = 3 },
                        new GearStat { Name = "PDL", Value = 7 }
                    }
                },
                new GearItem
                {
                    Name = "Kasuga Haidate +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "sam" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "Hasso+ JA Haste", Value = 3 }
                    }
                },
                new GearItem
                {
                    Name = "Kasuga Haidate +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "sam" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Dex", Value = 14 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "Hasso+ JA Haste", Value = 3 }
                    }
                },
                new GearItem
                {
                    Name = "Chasseur's Culottes +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "cor" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvastion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 45 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "RangedAccuracy", Value = 63 },
                        new GearStat { Name = "RangedAttack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 12 }
                    }
                },
                new GearItem
                {
                    Name = "Chasseur's Culottes +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "cor" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 81 },
                        new GearStat { Name = "MagicEvastion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "RangedAccuracy", Value = 53 },
                        new GearStat { Name = "RangedAttack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 11 }
                    }
                },
                new GearItem
                {
                    Name = "Fili Rhingrave +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "brd" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvastion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Fili Rhingrave +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "brd" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvastion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Darraigner's Brais",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "rng" },
                        new GearItemJob { JobName = "cor" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 38 },
                        new GearStat { Name = "MagicEvastion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 11 },
                        new GearStat { Name = "RangedAttack", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Crit Damage", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Meghanada Chausses +2",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "rng" },
                        new GearItemJob { JobName = "bst" },
                        new GearItemJob { JobName = "cor" },
                        new GearItemJob { JobName = "dnc" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 41 },
                        new GearStat { Name = "MagicEvastion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "RangedAccuracy", Value = 49 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Oshosi Trousers +1",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "cor" },
                        new GearItemJob { JobName = "rng" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 54 },
                        new GearStat { Name = "MagicEvastion", Value = 131 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 43 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 46 },
                        new GearStat { Name = "MagicAccuracy", Value = 51 },
                        new GearStat { Name = "True Shot", Value = 5 },
                        new GearStat { Name = "Double Shot", Value = 7 },
                        new GearStat { Name = "Triple Shot", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Lustratio Subligar +1 R15A",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "war" },
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "pld" },
                        new GearItemJob { JobName = "drk" },
                        new GearItemJob { JobName = "bst" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "drg" },
                        new GearItemJob { JobName = "dnc" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 8 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Attack", Value = 58 },
                        new GearStat { Name = "DA", Value = 3 }
                    }
                },
                new GearItem
                {
                    Name = "Lustratio Subligar +1 R15B",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "war" },
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "pld" },
                        new GearItemJob { JobName = "drk" },
                        new GearItemJob { JobName = "bst" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "drg" },
                        new GearItemJob { JobName = "dnc" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 0 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Attack", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    }
                },
                new GearItem
                {
                    Name = "Skulker's Culottes +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "thf" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvastion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Dex", Value = 18 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    }
                },
                new GearItem
                {
                    Name = "Skulker's Culottes +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "thf" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 87 },
                        new GearStat { Name = "MagicEvastion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 13 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Bhikku Hose +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "mnk" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvastion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -14 },
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 7 },
                        new GearStat { Name = "Kick Attacks", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Bhikku Hose +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "mnk" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvastion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 7 },
                        new GearStat { Name = "Kick Attacks", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 9 }
                    }
                },
                new GearItem
                {
                    Name = "Maculele Tights +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "dnc" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 107 },
                        new GearStat { Name = "MagicEvastion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "Dagger Skill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "PDL", Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Maculele Tights +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "dnc" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvastion", Value = 105 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "Dagger Skill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "PDL", Value = 7 }
                    }
                },
                new GearItem
                {
                    Name = "Nukumi Quijotes +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "bst" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 53 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 8 }
                    }
                },
                new GearItem
                {
                    Name = "Nukumi Quijotes +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "bst" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 48 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 8 }
                    }
                },
                new GearItem
                {
                    Name = "Azimuth Tights +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "geo" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 168 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 55 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "MagicDamage", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Azimuth Tights +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "geo" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvastion", Value = 158 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 50 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "MagicDamage", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Chevalier's Cuisses +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "pld" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvastion", Value = 136 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 43 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 41 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 22 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Chevalier's Cuisses +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "pld" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvastion", Value = 126 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 45 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Amini Bragues +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "rng" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvastion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 45 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "RangedAccuracy", Value = 63 },
                        new GearStat { Name = "RangedAttack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "True Shot", Value = 8 },
                        new GearStat { Name = "StoreTP", Value = 12 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Amini Bragues +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "rng" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 81 },
                        new GearStat { Name = "MagicEvastion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "RangedAccuracy", Value = 53 },
                        new GearStat { Name = "RangedAttack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "True Shot", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Erilaz Leg Guards +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "run" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvastion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -13 },
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 31 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 22 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "GearHaste", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Erilaz Leg Guards +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "run" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 79 },
                        new GearStat { Name = "MagicEvastion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 38 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Karagoz Pantaloni +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "pup" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 49 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvastion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Martial Arts", Value = 11 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Pet:Accuracy", Value = 63 },
                        new GearStat { Name = "Pet:Ranged Accuracy", Value = 63 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 63 },
                        new GearStat { Name = "Automaton Skill", Value = 33 }
                    }
                },
                new GearItem
                {
                    Name = "Karagoz Pantaloni +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "pup" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 44 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvastion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Martial Arts", Value = 11 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Pet:Accuracy", Value = 53 },
                        new GearStat { Name = "Pet:Ranged Accuracy", Value = 53 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 53 },
                        new GearStat { Name = "Automaton Skill", Value = 28 }
                    }
                },
                new GearItem
                {
                    Name = "Hashishin Tayt +3",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "blu" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvastion", Value = 162 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 42 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 43 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 63 },
                        new GearStat { Name = "Attack", Value = 63 },
                        new GearStat { Name = "MagicAccuracy", Value = 63 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Hashishin Tayt +2",
                    GearItemJobs =  new List<GearItemJob> { new GearItemJob { JobName = "blu" } },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvastion", Value = 152 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 37 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "Int", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 53 },
                        new GearStat { Name = "MagicAccuracy", Value = 53 },
                        new GearStat { Name = "MagicAttack", Value = 48 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Volte Tights",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "war" },
                        new GearItemJob { JobName = "mnk" },
                        new GearItemJob { JobName = "rdm" },
                        new GearItemJob { JobName = "thf" },
                        new GearItemJob { JobName = "pld" },
                        new GearItemJob { JobName = "drk" },
                        new GearItemJob { JobName = "bst" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "rng" },
                        new GearItemJob { JobName = "sam" },
                        new GearItemJob { JobName = "nin" },
                        new GearItemJob { JobName = "drg" },
                        new GearItemJob { JobName = "blu" },
                        new GearItemJob { JobName = "cor" },
                        new GearItemJob { JobName = "pup" },
                        new GearItemJob { JobName = "dnc" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 46 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 7 },
                        new GearStat { Name = "Chr", Value = 11 },
                        new GearStat { Name = "Accuracy", Value = 38 },
                        new GearStat { Name = "RangedAccuracy", Value = 38 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvastion", Value = 107 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "Subtle Blow", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 9 }
                    }
                },
                new GearItem
                {
                    Name = "Mallquis Trews +2",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "blm" },
                        new GearItemJob { JobName = "sch" },
                        new GearItemJob { JobName = "geo" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 14 },
                        new GearStat { Name = "Int", Value = 57 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 55 },
                        new GearStat { Name = "Evasion", Value = 24 },
                        new GearStat { Name = "MagicEvastion", Value = 86 },
                        new GearStat { Name = "MagicAttack", Value = 15 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 }
                    }
                },
                new GearItem
                {
                    Name = "Perdition Slops",
                    GearItemJobs =  new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "whm" },
                        new GearItemJob { JobName = "blm" },
                        new GearItemJob { JobName = "rdm" },
                        new GearItemJob { JobName = "brd" },
                        new GearItemJob { JobName = "smn" },
                        new GearItemJob { JobName = "blu" },
                        new GearItemJob { JobName = "pup" },
                        new GearItemJob { JobName = "sch" },
                        new GearItemJob { JobName = "geo" },
                        new GearItemJob { JobName = "run" }
                    },
                    Slot = "Legs",
GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Evasion", Value = 27 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "MagicAttack", Value = 13 },
                        new GearStat { Name = "MagicEvastion", Value = 107 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "Occult Acumen", Value = 30 }
                    }
                }
            };
        }
    }
}
