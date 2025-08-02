using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class ShieldSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Ammurapi Shield",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 13 },
                        new GearStat { Name = "Mnd", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 38 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Genmei Shield",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "PDT", Value = -10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Blurred Shield +1",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "Fencer", Value = 1 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Nusku Shield",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Culminus",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 75 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Sacro Bulwark",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Aegis",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MDT2", Value = -50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Srivatsa",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "DT", Value = -8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Duban",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "MDT2", Value = -20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Duban V",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Evasion", Value = 35 },
                        new GearStat { Name = "MagicEvasion", Value = 35 },
                        new GearStat { Name = "MDT2", Value = -25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Ochain",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Diamond Aspis",
                    GearItemCategoryId = 4, // Shield category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 } }
                }
            };
        }
    }
}
