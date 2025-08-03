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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 5, Value = 13 },
                        new GearItemStat { Id = 6, Value = 13 },
                        new GearItemStat { Id = 68, Value = 38 },
                        new GearItemStat { Id = 69, Value = 38 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 15 },
                        new GearItemStat { Id = 44, Value = 15 },
                        new GearItemStat { Id = 99, Value = -10 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 20 },
                        new GearItemStat { Id = 44, Value = 20 },
                        new GearItemStat { Id = 65, Value = 1 },
                        new GearItemStat { Id = 54, Value = 7 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 110, Value = 20 },
                        new GearItemStat { Id = 111, Value = 20 },
                        new GearItemStat { Id = 50, Value = 3 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 69, Value = 20 },
                        new GearItemStat { Id = 70, Value = 75 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 98, Value = -10 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 214, Value = -50 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 35 },
                        new GearItemStat { Id = 44, Value = 35 },
                        new GearItemStat { Id = 98, Value = -8 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 3, Value = 30 },
                        new GearItemStat { Id = 6, Value = 30 },
                        new GearItemStat { Id = 91, Value = 30 },
                        new GearItemStat { Id = 93, Value = 30 },
                        new GearItemStat { Id = 214, Value = -20 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 3, Value = 35 },
                        new GearItemStat { Id = 6, Value = 35 },
                        new GearItemStat { Id = 91, Value = 35 },
                        new GearItemStat { Id = 93, Value = 35 },
                        new GearItemStat { Id = 214, Value = -25 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 3, Value = 25 }
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
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 3, Value = 30 },
                        new GearItemStat { Id = 43, Value = 40 },
                        new GearItemStat { Id = 68, Value = 40 },
                        new GearItemStat { Id = 69, Value = 30 },
                        new GearItemStat { Id = 91, Value = 30 },
                        new GearItemStat { Id = 93, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 } }
                }
            };
        }
    }
}
