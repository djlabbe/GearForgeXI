using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class GripSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Alber Strap",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 69, Value = 7 },
                        new GearItemStat { StatId = 47, Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Rigorous Grip +1",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 4 },
                        new GearItemStat { StatId = 44, Value = 13 },
                        new GearItemStat { StatId = 43, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Rigorous Grip +1 R15",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 19 },
                        new GearItemStat { StatId = 44, Value = 43 },
                        new GearItemStat { StatId = 43, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Utu Grip",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 44, Value = 30 },
                        new GearItemStat { StatId = 64, Value = 10, }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Niobid Strap",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 5 },
                        new GearItemStat { StatId = 68, Value = 5 },
                        new GearItemStat { StatId = 69, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Enki Strap",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 5, Value = 10 },
                        new GearItemStat { StatId = 6, Value = 10 },
                        new GearItemStat { StatId = 68, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Khonsu",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 98, Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Refined Grip +1",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 98, Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                 new GearItem
                {
                    Name = "Refined Grip +1 R15",
                    GearItemCategoryId = 5, // Grip category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 2 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 98, Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
            };
        }
    }
}
