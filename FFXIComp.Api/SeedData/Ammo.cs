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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 7 },
                        new GearStat { Name = "Dex", Value = 7 },
                        new GearStat { Name = "Vit", Value = 7 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 15 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Str", Value = 8 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "DT", Value = -3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicDamage", Value = 21 },
                        new GearStat { Name = "Int", Value = 11 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 23 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 6 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 5 },
                        new GearStat { Name = "Attack", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 4 },
                        new GearStat { Name = "MagicAccuracy", Value = 8 },
                        new GearStat { Name = "MagicAttack", Value = 4 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "Attack", Value = 13 },
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "Str", Value = 14 },
                        new GearStat { Name = "GearHaste", Value = 4 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "CritRate", Value = 2 },
                        new GearStat { Name = "CritDamage", Value = 6 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Chr", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 2 },
                        new GearStat { Name = "Accuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Int", Value = 5 },
                        new GearStat { Name = "Attack", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "StoreTP", Value = -3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = -10 },
                        new GearStat { Name = "MagicCritRateII", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "CritDamage", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 3 },
                        new GearStat { Name = "Mnd", Value = 3 },
                        new GearStat { Name = "OccultAcumen", Value = 7 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "StoreTP", Value = 2 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 5 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DA", Value = 1 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 245 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 999 },
                        new GearStat { Name = "Delay", Value = 999 },
                        new GearStat { Name = "Dex", Value = 150 },
                        new GearStat { Name = "Str", Value = 150 },
                        new GearStat { Name = "Attack", Value = 150 },
                        new GearStat { Name = "RangedAttack", Value = 150 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 999 },
                        new GearStat { Name = "Delay", Value = 999 },
                        new GearStat { Name = "Mnd", Value = 150 },
                        new GearStat { Name = "Int", Value = 150 },
                        new GearStat { Name = "MagicAttack", Value = 150 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 77 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 12 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 108 },
                        new GearStat { Name = "Delay", Value = 192 },
                        new GearStat { Name = "RangedAttack", Value = 12 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 80 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 89 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 },
                        new GearStat { Name = "RangedAttack", Value = 25 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 277 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 300 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 300 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 40 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 110 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 110 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 101 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 25 },
                        new GearStat { Name = "RangedAttack", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 289 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "RangedAttack", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 220 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 145 },
                        new GearStat { Name = "Delay", Value = 192 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "Barrage", Value = 1 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 116 },
                        new GearStat { Name = "Delay", Value = 90 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Agi", Value = 20 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dmg", Value = 315 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Agi", Value = 20 }
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

