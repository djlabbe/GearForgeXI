using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData;

public static class AmmoSeedData
{
    public static List<GearItem> GetItems()
    {
        return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Aurgelmir Orb +1",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
                    {
                        new GearItemSlot { GearSlotId = 4 }
                    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 7 },
                        new GearItemStat { StatId = 2, Value = 7 },
                        new GearItemStat { StatId = 3, Value = 7 },
                        new GearItemStat { StatId = 44, Value = 10 },
                        new GearItemStat { StatId = 50, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 10 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Cath Palug Stone",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 2, Value = 10 },
                        new GearItemStat { StatId = 4, Value = 10 },
                        new GearItemStat { StatId = 43, Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Coiste Bodhar R0",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 47, Value = 3 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Coiste Bodhar R15",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 15 },
                        new GearItemStat { StatId = 47, Value = 3 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Coiste Bodhar R20",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 15 },
                        new GearItemStat { StatId = 1, Value = 5 },
                        new GearItemStat { StatId = 47, Value = 3 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Coiste Bodhar R25",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 15 },
                        new GearItemStat { StatId = 1, Value = 8 },
                        new GearItemStat { StatId = 2, Value = 5 },
                        new GearItemStat { StatId = 47, Value = 3 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Coiste Bodhar R30",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 15 },
                        new GearItemStat { StatId = 1, Value = 10 },
                        new GearItemStat { StatId = 2, Value = 5 },
                        new GearItemStat { StatId = 47, Value = 3 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 10 }
                    }
                },
                new GearItem
                {
                    Name = "Crepuscular Pebble",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 3 },
                        new GearItemStat { StatId = 3, Value = 3 },
                        new GearItemStat { StatId = 56, Value = 3 },
                        new GearItemStat { StatId = 98, Value = -3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ghastly Tathlum +1 R15",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 70, Value = 21 },
                        new GearItemStat { StatId = 5, Value = 11 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Knobkierrie",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 23 },
                        new GearItemStat { StatId = 54, Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Oshasha's Treatise",
                     GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 5 },
                        new GearItemStat { StatId = 44, Value = 5 },
                        new GearItemStat { StatId = 54, Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Pemphredo Tathlum",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 5, Value = 4 },
                        new GearItemStat { StatId = 68, Value = 8 },
                        new GearItemStat { StatId = 69, Value = 4 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Seeth. Bomblet +1 R15",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 13 },
                        new GearItemStat { StatId = 44, Value = 13 },
                        new GearItemStat { StatId = 69, Value = 7 },
                        new GearItemStat { StatId = 1, Value = 14 },
                        new GearItemStat { StatId = 59, Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 22},
                        new GearItemJob { JobId= 6 }
                    }
                },
                new GearItem
                {
                    Name = "Yetshila +1",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 45, Value = 2 },
                        new GearItemStat { StatId = 46, Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Voluspa Tathlum",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 5 },
                        new GearItemStat { StatId = 2, Value = 5 },
                        new GearItemStat { StatId = 7, Value = 5 },
                        new GearItemStat { StatId = 43, Value = 10 },
                        new GearItemStat { StatId = 44, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 18},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Amar Cluster",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 2 },
                        new GearItemStat { StatId = 43, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 3 },
                        new GearItemJob { JobId= 4 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 10 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 15},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 18},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 20},
                        new GearItemJob { JobId= 21},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Floestone",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 3 },
                        new GearItemStat { StatId = 5, Value = 5 },
                        new GearItemStat { StatId = 44, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 3 },
                        new GearItemJob { JobId= 4 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 10 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 15},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 18},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 20},
                        new GearItemJob { JobId= 21},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Hasty Pinion +1",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 44, Value = 10 },
                        new GearItemStat { StatId = 43, Value = 10 },
                        new GearItemStat { StatId = 59, Value = 2 },
                        new GearItemStat { StatId = 50, Value = -3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Sroda Tathlum",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 68, Value = -10 },
                        new GearItemStat { StatId = 72, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 4 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 20},
                        new GearItemJob { JobId= 21}
                    }
                },
                new GearItem
                {
                    Name = "Neo Animator",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 43, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 18}
                    }
                },
                new GearItem
                {
                    Name = "Charis Feather",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 2, Value = 5 },
                        new GearItemStat { StatId = 46, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 19}
                    }
                },
                new GearItem
                {
                    Name = "Seraphic Ampulla",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 5, Value = 3 },
                        new GearItemStat { StatId = 6, Value = 3 },
                        new GearItemStat { StatId = 129, Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 3 },
                        new GearItemJob { JobId= 4 },
                        new GearItemJob { JobId= 15},
                        new GearItemJob { JobId= 18},
                        new GearItemJob { JobId= 20},
                        new GearItemJob { JobId= 21}
                    }
                },
                new GearItem
                {
                    Name = "White Tathlum",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 50, Value = 2 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ginsen",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 5 },
                        new GearItemStat { StatId = 44, Value = 10 },
                        new GearItemStat { StatId = 50, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 2 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 10 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 14},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 19},
                        new GearItemJob { JobId= 22}
                    }
                },
                new GearItem
                {
                    Name = "Vanir Battery",
                    GearItemCategoryId = 13, // Ammo category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 94, Value = 4 },
                        new GearItemStat { StatId = 47, Value = 1 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Living Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 245 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 68, Value = 25 },
                        new GearItemStat { StatId = 69, Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 17}
                    }
                },
                new GearItem
                {
                    Name = "Test Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 999 },
                        new GearItemStat { StatId = 41, Value = 999 },
                        new GearItemStat { StatId = 2, Value = 150 },
                        new GearItemStat { StatId = 1, Value = 150 },
                        new GearItemStat { StatId = 44, Value = 150 },
                        new GearItemStat { StatId = 111, Value = 150 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Test Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 999 },
                        new GearItemStat { StatId = 41, Value = 999 },
                        new GearItemStat { StatId = 6, Value = 150 },
                        new GearItemStat { StatId = 5, Value = 150 },
                        new GearItemStat { StatId = 69, Value = 150 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Beryllium Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 77 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 13}
                    }
                },
                new GearItem
                {
                    Name = "Beryllium Bolt",
                    GearItemCategoryId = 11, // Bolt category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 108 },
                        new GearItemStat { StatId = 41, Value = 192 },
                        new GearItemStat { StatId = 111, Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Raetic Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 80 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 1 },
                        new GearItemJob { JobId= 4 },
                        new GearItemJob { JobId= 5 },
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 7 },
                        new GearItemJob { JobId= 8 },
                        new GearItemJob { JobId= 9 },
                        new GearItemJob { JobId= 10 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 15},
                        new GearItemJob { JobId= 16},
                        new GearItemJob { JobId= 20}
                    }
                },
                new GearItem
                {
                    Name = "Yoichi's Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 89 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 35 },
                        new GearItemStat { StatId = 111, Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 12}
                    }
                },
                new GearItem
                {
                    Name = "Devastating Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 277 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 110, Value = 35 },
                        new GearItemStat { StatId = 68, Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Chrono Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 300 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 110, Value = 20 },
                        new GearItemStat { StatId = 111, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Hauksbok Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 300 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 4, Value = 10 },
                        new GearItemStat { StatId = 69, Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 17},
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Hauksbok Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 110 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 1, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 20 },
                        new GearItemStat { StatId = 110, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Chrono Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 110 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 20 },
                        new GearItemStat { StatId = 111, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Artemis's Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 101 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 25 },
                        new GearItemStat { StatId = 111, Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Eradicating Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 289 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 110, Value = 30 },
                        new GearItemStat { StatId = 111, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Decimating Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 220 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 110, Value = 10 },
                        new GearItemStat { StatId = 111, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 6 },
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 13},
                        new GearItemJob { JobId= 17}
                    }
                },
                new GearItem
                {
                    Name = "Quelling Bolt",
                    GearItemCategoryId = 11, // Bolt category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 145 },
                        new GearItemStat { StatId = 41, Value = 192 },
                        new GearItemStat { StatId = 110, Value = 30 },
                        new GearItemStat { StatId = 111, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 },
                        new GearItemStat { StatId = 69, Value = 30 },
                        new GearItemStat { StatId = 112, Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Bayeux Arrow",
                    GearItemCategoryId = 10, // Arrow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 116 },
                        new GearItemStat { StatId = 41, Value = 90 },
                        new GearItemStat { StatId = 110, Value = 30 },
                        new GearItemStat { StatId = 1, Value = 20 },
                        new GearItemStat { StatId = 4, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11}
                    }
                },
                new GearItem
                {
                    Name = "Bayeux Bullet",
                    GearItemCategoryId = 12, // Bullet category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 4 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 315 },
                        new GearItemStat { StatId = 41, Value = 240 },
                        new GearItemStat { StatId = 110, Value = 30 },
                        new GearItemStat { StatId = 2, Value = 20 },
                        new GearItemStat { StatId = 4, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobId= 11},
                        new GearItemJob { JobId= 17}
                    }
                }
            };
    }
}

