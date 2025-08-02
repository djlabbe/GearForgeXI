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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "DA", Value = 2 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 4 },
                        new GearStat { Name = "Attack", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "WSC(Dex)", Value = 10, }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 5 },
                        new GearStat { Name = "MagicAttack", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -3 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
            };
        }
    }
}
