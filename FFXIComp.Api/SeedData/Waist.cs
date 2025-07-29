using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class WaistSeedData
    {
        public static List<GearItem> GetItems()
        {
            var allJobs = new List<GearItemJob>
            {
                new GearItemJob { JobName = "war" },
                new GearItemJob { JobName = "mnk" },
                new GearItemJob { JobName = "whm" },
                new GearItemJob { JobName = "blm" },
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
                new GearItemJob { JobName = "smn" },
                new GearItemJob { JobName = "blu" },
                new GearItemJob { JobName = "cor" },
                new GearItemJob { JobName = "pup" },
                new GearItemJob { JobName = "dnc" },
                new GearItemJob { JobName = "sch" },
                new GearItemJob { JobName = "geo" },
                new GearItemJob { JobName = "run" }
            };

            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Eschan Stone",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "MagicAccuracy", Value = 7 },
                        new GearStat { Name = "MagicAttack", Value = 7 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Fotia Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 10 },
                        new GearStat { Name = "ConserveTP", Value = 7 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Grunfeld Rope",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "DA", Value = 2 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Hachirin-no-Obi",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DayWeatherBonus", Value = 1 },
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Ioskeha Belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 17 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Kentarch Belt +1 R15",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 14 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Orpheus's Sash",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "ElementalBonus", Value = 15 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Reiki Yotai",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Sailfi Belt +1 R15",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "Attack", Value = 14 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Windbuffet Belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 2 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "QA", Value = 2 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Skrymir Cord +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 7 },
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "MagicDamage", Value = 35 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Sacro Cord",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 8 },
                        new GearStat { Name = "Mnd", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 8 },
                        new GearStat { Name = "MagicAttack", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Acuity Belt +1 R15",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Luminary Sash",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Yemaya Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 7 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Prosilio Belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Attack", Value = 28 },
                        new GearStat { Name = "DA", Value = -5 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 5 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Kwahu kachina belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 8 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Tellen Belt R0",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Tellen Belt R15",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Tellen Belt R20",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Tellen Belt R25",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Tellen Belt R30",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Moonbow Belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "TA", Value = 8 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "SubtleBlowII", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Gerdr Belt +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 7 },
                        new GearStat { Name = "Agi", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "DualWield", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Gerdr Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "DualWield", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Cornelia's Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 10 },
                        new GearStat { Name = "Str", Value = 10 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Goading Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Tempus Fugit +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Ninurta's Sash",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 6 },
                        new GearStat { Name = "Attack", Value = 6 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Sweordfaetels +1",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 18 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Oneiros Rope",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "StoreTP", Value = 2 },
                        new GearStat { Name = "OccultAcumen", Value = 20 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Olseni Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = -5 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = allJobs
                },
                new GearItem
                {
                    Name = "Ponente Sash",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 4 },
                        new GearStat { Name = "Agi", Value = 9 },
                        new GearStat { Name = "RangedAttack", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Null Belt",
                    Slot = "Waist",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "MagicDefense", Value = 3 }
                    },
                    GearItemJobs = allJobs
                }
            };
        }
    }
}
