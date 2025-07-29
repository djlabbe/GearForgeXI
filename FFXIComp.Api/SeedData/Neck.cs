using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class NeckSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Abyssal Bead Necklace +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "STR", Value = 25 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "drk" }
                    }
                },
                new GearItem
                {
                    Name = "Abyssal Bead Necklace +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "STR", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "drk" }
                    }
                },
                new GearItem
                {
                    Name = "Baetyl Pendant",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 13 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Caro Necklace",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "STR", Value = 6 },
                        new GearStat { Name = "DEX", Value = 6 },
                        new GearStat { Name = "Attack", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Fotia Gorget",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 10 },
                        new GearStat { Name = "ftp", Value = 1 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Ninja Nodowa +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "RangedAccuracy", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "DEX", Value = 15 },
                        new GearStat { Name = "AGI", Value = 15 },
                        new GearStat { Name = "Daken", Value = 25 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Ninja Nodowa +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "DEX", Value = 12 },
                        new GearStat { Name = "AGI", Value = 12 },
                        new GearStat { Name = "Daken", Value = 20 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Rep. Platinum Medal",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "STR", Value = 10 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Samurai's Nodowa +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 14 },
                        new GearStat { Name = "STR", Value = 25 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Samurai's Nodowa +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "STR", Value = 20 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Sanctity Necklace",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Sibyl Scarf",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Warder's Charm +1 R15",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Sorcerer's Stole +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 15 },
                        new GearStat { Name = "MND", Value = 15 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicBurstAccuracy", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 7 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Sorcerer's Stole +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 12 },
                        new GearStat { Name = "MND", Value = 12 },
                        new GearStat { Name = "MagicBurstDamage", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "MagicBurstAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 5 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Quanpur Necklace",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "EarthElementalBonus", Value = 5 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" }
                    }
                },
                new GearItem
                {
                    Name = "Mizukage-no-Kubikazari",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 4 },
                        new GearStat { Name = "MND", Value = 4 },
                        new GearStat { Name = "MagicAttack", Value = 8 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "brd" }
                    }
                },
                new GearItem
                {
                    Name = "Duelist's Torque +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "INT", Value = 15 },
                        new GearStat { Name = "MND", Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Duelist's Torque +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "INT", Value = 12 },
                        new GearStat { Name = "MND", Value = 12 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" } }
                },
                new GearItem
                {
                    Name = "Dragoon's collar +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "Attack", Value = 25 },
                        new GearStat { Name = "STR", Value = 15 },
                        new GearStat { Name = "VIT", Value = 15 },
                        new GearStat { Name = "PDL", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 4 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Dragoon's collar +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "STR", Value = 12 },
                        new GearStat { Name = "VIT", Value = 12 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 3 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Cleric's Torque +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 15 },
                        new GearStat { Name = "MND", Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                },
                new GearItem
                {
                    Name = "Cleric's Torque +1 R20",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "INT", Value = 12 },
                        new GearStat { Name = "MND", Value = 12 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                },
                new GearItem
                {
                    Name = "Lissome Necklace",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 8 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "DA", Value = 1 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" }
                    }
                },
                new GearItem
                {
                    Name = "Marked Gorget",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "AGI", Value = 3 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "StoreTP", Value = 2 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" }, new GearItemJob { JobName = "run" }
                    }
                },
                new GearItem
                {
                    Name = "Argute Stole +2 R25",
                    Slot = "Neck",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "INT", Value = 15 },
                        new GearStat { Name = "MND", Value = 15 },
                        new GearStat { Name = "Magic Damage", Value = 25 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
                },
                new GearItem { Name = "Argute Stole +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "MagicBurstDamage", Value = 7 }, new GearStat { Name = "INT", Value = 12 }, new GearStat { Name = "MND", Value = 12 }, new GearStat { Name = "Magic Damage", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } } },
                new GearItem { Name = "Warrior's Bead Necklace +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Attack", Value = 25 }, new GearStat { Name = "Fencer", Value = 1 }, new GearStat { Name = "DA", Value = 7 }, new GearStat { Name = "STR", Value = 15 }, new GearStat { Name = "DEX", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } } },
                new GearItem { Name = "Warrior's Bead Necklace +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "Attack", Value = 20 }, new GearStat { Name = "Fencer", Value = 1 }, new GearStat { Name = "DA", Value = 6 }, new GearStat { Name = "STR", Value = 12 }, new GearStat { Name = "DEX", Value = 12 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } } },
                new GearItem { Name = "Iskur Gorget", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "RangedAccuracy", Value = 30 }, new GearStat { Name = "RangedAttack", Value = 30 }, new GearStat { Name = "StoreTP", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "cor" } } },
                new GearItem { Name = "Commodore Charm +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "RangedAccuracy", Value = 25 }, new GearStat { Name = "STR", Value = 15 }, new GearStat { Name = "AGI", Value = 15 }, new GearStat { Name = "MagicAttack", Value = 7 }, new GearStat { Name = "Magic Damage", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } } },
                new GearItem { Name = "Commodore Charm +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "RangedAccuracy", Value = 20 }, new GearStat { Name = "STR", Value = 12 }, new GearStat { Name = "AGI", Value = 12 }, new GearStat { Name = "MagicAttack", Value = 6 }, new GearStat { Name = "Magic Damage", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "cor" } } },
                new GearItem { Name = "Bard's Charm +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "QA", Value = 3 }, new GearStat { Name = "DEX", Value = 25 }, new GearStat { Name = "CHR", Value = 25 }, new GearStat { Name = "PDL", Value = 10 }, new GearStat { Name = "StoreTP", Value = 7 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } } },
                new GearItem { Name = "Bard's Charm +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "QA", Value = 2 }, new GearStat { Name = "DEX", Value = 20 }, new GearStat { Name = "CHR", Value = 20 }, new GearStat { Name = "PDL", Value = 8 }, new GearStat { Name = "StoreTP", Value = 6 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } } },
                new GearItem { Name = "Assassin's Gorget +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "TA Damage%", Value = 5 }, new GearStat { Name = "DEX", Value = 15 }, new GearStat { Name = "AGI", Value = 15 }, new GearStat { Name = "TA", Value = 4 }, new GearStat { Name = "Evasion", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } } },
                new GearItem { Name = "Assassin's Gorget +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "TA Damage%", Value = 4 }, new GearStat { Name = "DEX", Value = 12 }, new GearStat { Name = "AGI", Value = 12 }, new GearStat { Name = "TA", Value = 3 }, new GearStat { Name = "Evasion", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } } },
                new GearItem { Name = "Monk's Nodowa +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "Kick Attacks DMG", Value = 20 }, new GearStat { Name = "DEX", Value = 15 }, new GearStat { Name = "MND", Value = 15 }, new GearStat { Name = "Kick Attacks", Value = 25 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } } },
                new GearItem { Name = "Monk's Nodowa +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Kick Attacks DMG", Value = 15 }, new GearStat { Name = "DEX", Value = 12 }, new GearStat { Name = "MND", Value = 12 }, new GearStat { Name = "Kick Attacks", Value = 20 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } } },
                new GearItem { Name = "Etoile Gorget +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "DEX", Value = 25 }, new GearStat { Name = "CHR", Value = 25 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } } },
                new GearItem { Name = "Etoile Gorget +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "DEX", Value = 20 }, new GearStat { Name = "CHR", Value = 20 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } } },
                new GearItem { Name = "Beastmaster collar +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "STR", Value = 15 }, new GearStat { Name = "DEX", Value = 15 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } } },
                new GearItem { Name = "Beastmaster collar +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "STR", Value = 12 }, new GearStat { Name = "DEX", Value = 12 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } } },
                new GearItem { Name = "Bagua Charm +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 30 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } } },
                new GearItem { Name = "Bagua Charm +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "geo" } } },
                new GearItem { Name = "Knight's bead necklace +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "VIT", Value = 15 }, new GearStat { Name = "MND", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pld" } } },
                new GearItem { Name = "Knight's bead necklace +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "VIT", Value = 12 }, new GearStat { Name = "MND", Value = 12 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pld" } } },
                new GearItem { Name = "Scout's Gorget +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "AGI", Value = 25 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } } },
                new GearItem { Name = "Scout's Gorget +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "AGI", Value = 20 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rng" } } },
                new GearItem { Name = "Mirage Stole +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "STR", Value = 25 }, new GearStat { Name = "DEX", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "CritRate", Value = 5 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } } },
                new GearItem { Name = "Mirage Stole +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "STR", Value = 20 }, new GearStat { Name = "DEX", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "CritRate", Value = 4 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } } },
                new GearItem { Name = "Puppetmaster's Collar +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "AGI", Value = 15 }, new GearStat { Name = "DEX", Value = 15 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } } },
                new GearItem { Name = "Puppetmaster's Collar +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "AGI", Value = 12 }, new GearStat { Name = "DEX", Value = 12 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "pup" } } },
                new GearItem { Name = "Futhark Torque +2 R25", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "STR", Value = 15 }, new GearStat { Name = "MND", Value = 15 }, new GearStat { Name = "Magic Evasion", Value = 30 }, new GearStat { Name = "DT", Value = -7 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } } },
                new GearItem { Name = "Futhark Torque +1 R20", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "STR", Value = 12 }, new GearStat { Name = "MND", Value = 12 }, new GearStat { Name = "Magic Evasion", Value = 25 }, new GearStat { Name = "DT", Value = -6 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "run" } } },
                new GearItem { Name = "Saevus Pendant +1", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = -6 }, new GearStat { Name = "MagicAttack", Value = 18 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } } },
                new GearItem { Name = "Clotharius Torque", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 8 }, new GearStat { Name = "RangedAccuracy", Value = 8 }, new GearStat { Name = "TA", Value = 1 }, new GearStat { Name = "Subtle Blow", Value = 8 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Combatant's Torque", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 4 }, new GearStat { Name = "Dagger Skill", Value = 15 }, new GearStat { Name = "Sword Skill", Value = 15 }, new GearStat { Name = "Hand-to-HandSkill", Value = 15 }, new GearStat { Name = "GreatSwordSkill", Value = 15 }, new GearStat { Name = "AxeSkill", Value = 15 }, new GearStat { Name = "GreatAxeSkill", Value = 15 }, new GearStat { Name = "ScytheSkill", Value = 15 }, new GearStat { Name = "PolearmSkill", Value = 15 }, new GearStat { Name = "KatanaSkill", Value = 15 }, new GearStat { Name = "GreatKatanaSkill", Value = 15 }, new GearStat { Name = "ClubSkill", Value = 15 }, new GearStat { Name = "StaffSkill", Value = 15 }, new GearStat { Name = "MarksmanshipSkill", Value = 15 }, new GearStat { Name = "ThrowingSkill", Value = 15 }, new GearStat { Name = "ArcherySkill", Value = 15 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Anu Torque", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "Attack", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } } },
                new GearItem { Name = "Vim Torque +1 R15", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 10 }, new GearStat { Name = "Accuracy", Value = 15 }, new GearStat { Name = "Regain", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drg" } } },
                new GearItem { Name = "Canto Necklace +1 R15", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "CHR", Value = 21 }, new GearStat { Name = "MagicAccuracy", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } } },
                new GearItem { Name = "Loricate Torque +1 R15", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "DT", Value = -6 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Moonlight Nodowa", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Zanshin", Value = 10 }, new GearStat { Name = "StoreTP", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" } } },
                new GearItem { Name = "Moepapa Medal", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "DEX", Value = 6 }, new GearStat { Name = "AGI", Value = 6 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Null Loop", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 50 }, new GearStat { Name = "MagicAccuracy", Value = 50 }, new GearStat { Name = "RangedAccuracy", Value = 50 }, new GearStat { Name = "DT", Value = -5 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Shulmanu Collar", Slot = "Neck", GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "Attack", Value = 20 }, new GearStat { Name = "DA", Value = 3 }, new GearStat { Name = "Pet:Accuracy", Value = 20 }, new GearStat { Name = "Pet:Attack", Value = 20 }, new GearStat { Name = "Pet:DA", Value = 5 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "pup" } } },
            };
        }
    }
}