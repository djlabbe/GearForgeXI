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
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 8 }
                    }
                },
                new GearItem
                {
                    Name = "Abyssal Bead Necklace +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 8 }
                    }
                },
                new GearItem
                {
                    Name = "Baetyl Pendant",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 13 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Caro Necklace",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 6 },
                        new GearStat { Name = "Attack", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Fotia Gorget",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
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
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "RangedAccuracy", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Daken", Value = 25 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} }
                },
                new GearItem
                {
                    Name = "Ninja Nodowa +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Agi", Value = 12 },
                        new GearStat { Name = "Daken", Value = 20 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} }
                },
                new GearItem
                {
                    Name = "Rep. Platinum Medal",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Samurai's Nodowa +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 14 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "PDL", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Samurai's Nodowa +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "PDL", Value = 8 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Sanctity Necklace",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
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
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Warder's Charm +1 R15",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Sorcerer's Stole +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicBurstAccuracy", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 7 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Sorcerer's Stole +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "MagicBurstDamage", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "MagicBurstAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 5 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Quanpur Necklace",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "EarthElementalBonus", Value = 5 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Mizukage-no-Kubikazari",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 4 },
                        new GearStat { Name = "Mnd", Value = 4 },
                        new GearStat { Name = "MagicAttack", Value = 8 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Duelist's Torque +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 5 } }
                },
                new GearItem
                {
                    Name = "Duelist's Torque +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 12 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 5 } }
                },
                new GearItem
                {
                    Name = "Dragoon's collar +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 25 },
                        new GearStat { Name = "Attack", Value = 25 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "PDL", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 4 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Dragoon's collar +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "CritRate", Value = 3 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Cleric's Torque +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 } }
                },
                new GearItem
                {
                    Name = "Cleric's Torque +1 R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 12 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 } }
                },
                new GearItem
                {
                    Name = "Lissome Necklace",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 8 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "DA", Value = 1 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Marked Gorget",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "StoreTP", Value = 2 },
                    },
                    GearItemJobs = new List<GearItemJob> {
                        new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Argute Stole +2 R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "MagicDamage", Value = 25 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem { Name = "Argute Stole +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "MagicBurstDamage", Value = 7 }, new GearStat { Name = "Int", Value = 12 }, new GearStat { Name = "Mnd", Value = 12 }, new GearStat { Name = "MagicDamage", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} } },
                new GearItem { Name = "Warrior's Bead Necklace +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Attack", Value = 25 }, new GearStat { Name = "Fencer", Value = 1 }, new GearStat { Name = "DA", Value = 7 }, new GearStat { Name = "Str", Value = 15 }, new GearStat { Name = "Dex", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } } },
                new GearItem { Name = "Warrior's Bead Necklace +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "Attack", Value = 20 }, new GearStat { Name = "Fencer", Value = 1 }, new GearStat { Name = "DA", Value = 6 }, new GearStat { Name = "Str", Value = 12 }, new GearStat { Name = "Dex", Value = 12 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } } },
                new GearItem { Name = "Iskur Gorget", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "RangedAccuracy", Value = 30 }, new GearStat { Name = "RangedAttack", Value = 30 }, new GearStat { Name = "StoreTP", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 17} } },
                new GearItem { Name = "Commodore Charm +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "RangedAccuracy", Value = 25 }, new GearStat { Name = "Str", Value = 15 }, new GearStat { Name = "Agi", Value = 15 }, new GearStat { Name = "MagicAttack", Value = 7 }, new GearStat { Name = "MagicDamage", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} } },
                new GearItem { Name = "Commodore Charm +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "RangedAccuracy", Value = 20 }, new GearStat { Name = "Str", Value = 12 }, new GearStat { Name = "Agi", Value = 12 }, new GearStat { Name = "MagicAttack", Value = 6 }, new GearStat { Name = "MagicDamage", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} } },
                new GearItem { Name = "Bard's Charm +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "QA", Value = 3 }, new GearStat { Name = "Dex", Value = 25 }, new GearStat { Name = "Chr", Value = 25 }, new GearStat { Name = "PDL", Value = 10 }, new GearStat { Name = "StoreTP", Value = 7 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 10 } } },
                new GearItem { Name = "Bard's Charm +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "QA", Value = 2 }, new GearStat { Name = "Dex", Value = 20 }, new GearStat { Name = "Chr", Value = 20 }, new GearStat { Name = "PDL", Value = 8 }, new GearStat { Name = "StoreTP", Value = 6 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 10 } } },
                new GearItem { Name = "Assassin's Gorget +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "TA Damage%", Value = 5 }, new GearStat { Name = "Dex", Value = 15 }, new GearStat { Name = "Agi", Value = 15 }, new GearStat { Name = "TA", Value = 4 }, new GearStat { Name = "Evasion", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 6 } } },
                new GearItem { Name = "Assassin's Gorget +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "TA Damage%", Value = 4 }, new GearStat { Name = "Dex", Value = 12 }, new GearStat { Name = "Agi", Value = 12 }, new GearStat { Name = "TA", Value = 3 }, new GearStat { Name = "Evasion", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 6 } } },
                new GearItem { Name = "Monk's Nodowa +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "Kick Attacks DMG", Value = 20 }, new GearStat { Name = "Dex", Value = 15 }, new GearStat { Name = "Mnd", Value = 15 }, new GearStat { Name = "Kick Attacks", Value = 25 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } } },
                new GearItem { Name = "Monk's Nodowa +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Kick Attacks DMG", Value = 15 }, new GearStat { Name = "Dex", Value = 12 }, new GearStat { Name = "Mnd", Value = 12 }, new GearStat { Name = "Kick Attacks", Value = 20 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } } },
                new GearItem { Name = "Etoile Gorget +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Dex", Value = 25 }, new GearStat { Name = "Chr", Value = 25 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 19} } },
                new GearItem { Name = "Etoile Gorget +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Dex", Value = 20 }, new GearStat { Name = "Chr", Value = 20 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 19} } },
                new GearItem { Name = "Beastmaster collar +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Str", Value = 15 }, new GearStat { Name = "Dex", Value = 15 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 9 } } },
                new GearItem { Name = "Beastmaster collar +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Str", Value = 12 }, new GearStat { Name = "Dex", Value = 12 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 9 } } },
                new GearItem { Name = "Bagua Charm +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 30 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 21} } },
                new GearItem { Name = "Bagua Charm +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = 25 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 21} } },
                new GearItem { Name = "Knight's bead necklace +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Vit", Value = 15 }, new GearStat { Name = "Mnd", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } } },
                new GearItem { Name = "Knight's bead necklace +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Vit", Value = 12 }, new GearStat { Name = "Mnd", Value = 12 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } } },
                new GearItem { Name = "Scout's Gorget +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Agi", Value = 25 }, new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} } },
                new GearItem { Name = "Scout's Gorget +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Agi", Value = 20 }, new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} } },
                new GearItem { Name = "Mirage Stole +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "MagicAccuracy", Value = 25 }, new GearStat { Name = "Str", Value = 25 }, new GearStat { Name = "Dex", Value = 25 }, new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "CritRate", Value = 5 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 16} } },
                new GearItem { Name = "Mirage Stole +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "MagicAccuracy", Value = 20 }, new GearStat { Name = "Str", Value = 20 }, new GearStat { Name = "Dex", Value = 20 }, new GearStat { Name = "StoreTP", Value = 6 }, new GearStat { Name = "CritRate", Value = 4 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 16} } },
                new GearItem { Name = "Puppetmaster's Collar +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 30 }, new GearStat { Name = "Agi", Value = 15 }, new GearStat { Name = "Dex", Value = 15 }, new GearStat { Name = "PDL", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} } },
                new GearItem { Name = "Puppetmaster's Collar +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Agi", Value = 12 }, new GearStat { Name = "Dex", Value = 12 }, new GearStat { Name = "PDL", Value = 8 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} } },
                new GearItem { Name = "Futhark Torque +2 R25", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Str", Value = 15 }, new GearStat { Name = "Mnd", Value = 15 }, new GearStat { Name = "MagicEvasion", Value = 30 }, new GearStat { Name = "DT", Value = -7 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} } },
                new GearItem { Name = "Futhark Torque +1 R20", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Str", Value = 12 }, new GearStat { Name = "Mnd", Value = 12 }, new GearStat { Name = "MagicEvasion", Value = 25 }, new GearStat { Name = "DT", Value = -6 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} } },
                new GearItem { Name = "Saevus Pendant +1", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "MagicAccuracy", Value = -6 }, new GearStat { Name = "MagicAttack", Value = 18 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} } },
                new GearItem { Name = "Clotharius Torque", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 8 }, new GearStat { Name = "RangedAccuracy", Value = 8 }, new GearStat { Name = "TA", Value = 1 }, new GearStat { Name = "SubtleBlow", Value = 8 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Combatant's Torque", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 4 }, new GearStat { Name = "DaggerSkill", Value = 15 }, new GearStat { Name = "SwordSkill", Value = 15 }, new GearStat { Name = "Hand-to-HandSkill", Value = 15 }, new GearStat { Name = "GreatSwordSkill", Value = 15 }, new GearStat { Name = "AxeSkill", Value = 15 }, new GearStat { Name = "GreatAxeSkill", Value = 15 }, new GearStat { Name = "ScytheSkill", Value = 15 }, new GearStat { Name = "PolearmSkill", Value = 15 }, new GearStat { Name = "KatanaSkill", Value = 15 }, new GearStat { Name = "GreatKatanaSkill", Value = 15 }, new GearStat { Name = "ClubSkill", Value = 15 }, new GearStat { Name = "StaffSkill", Value = 15 }, new GearStat { Name = "MarksmanshipSkill", Value = 15 }, new GearStat { Name = "ThrowingSkill", Value = 15 }, new GearStat { Name = "ArcherySkill", Value = 15 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Anu Torque", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 7 }, new GearStat { Name = "Attack", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} } },
                new GearItem { Name = "Vim Torque +1 R15", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "StoreTP", Value = 10 }, new GearStat { Name = "Accuracy", Value = 15 }, new GearStat { Name = "Regain", Value = 20 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 14} } },
                new GearItem { Name = "Canto Necklace +1 R15", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Chr", Value = 21 }, new GearStat { Name = "MagicAccuracy", Value = 15 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 10 } } },
                new GearItem { Name = "Loricate Torque +1 R15", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "DT", Value = -6 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Moonlight Nodowa", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 25 }, new GearStat { Name = "Zanshin", Value = 10 }, new GearStat { Name = "StoreTP", Value = 10 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13} } },
                new GearItem { Name = "Moepapa Medal", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Dex", Value = 6 }, new GearStat { Name = "Agi", Value = 6 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Null Loop", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 50 }, new GearStat { Name = "MagicAccuracy", Value = 50 }, new GearStat { Name = "RangedAccuracy", Value = 50 }, new GearStat { Name = "DT", Value = -5 } }, GearItemJobs = new List<GearItemJob>() },
                new GearItem { Name = "Shulmanu Collar", GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 6 }
    }, GearStats = new List<GearStat> { new GearStat { Name = "Accuracy", Value = 20 }, new GearStat { Name = "Attack", Value = 20 }, new GearStat { Name = "DA", Value = 3 }, new GearStat { Name = "Pet:Accuracy", Value = 20 }, new GearStat { Name = "Pet:Attack", Value = 20 }, new GearStat { Name = "Pet:DA", Value = 5 } }, GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 18} } },
            };
        }
    }
}