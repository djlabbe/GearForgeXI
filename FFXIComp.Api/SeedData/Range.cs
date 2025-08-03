using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class RangeSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Antitail +1 R15",
                    GearItemCategoryId = 15, // Thrown category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 71 },
                        new GearItemStat { Id = 41, Value = 252 },
                        new GearItemStat { Id = 111, Value = 21 },
                        new GearStat { Name = "Throwing Skill", Value = 242 },
                        new GearItemStat { Id = 110, Value = 21 },
                        new GearItemStat { Id = 47, Value = 6 },
                        new GearStat { Name = "Magic Evasion", Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Date Shuriken",
                    GearItemCategoryId = 15, // Thrown category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 125 },
                        new GearItemStat { Id = 41, Value = 192 },
                        new GearItemStat { Id = 91, Value = 5 },
                        new GearItemStat { Id = 43, Value = 5 },
                        new GearItemStat { Id = 110, Value = 5 },
                        new GearStat { Name = "Throwing Skill", Value = 242 },
                        new GearItemStat { Id = 2, Value = 5 },
                        new GearItemStat { Id = 4, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Happo Shuriken",
                    GearItemCategoryId = 15, // Thrown category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 99 },
                        new GearItemStat { Id = 41, Value = 188 },
                        new GearItemStat { Id = 43, Value = 6 },
                        new GearItemStat { Id = 44, Value = 6 },
                        new GearItemStat { Id = 110, Value = 11 },
                        new GearStat { Name = "Throwing Skill", Value = 228 },
                        new GearItemStat { Id = 45, Value = 2 }
                    }
                },
                new GearItem
                {
                    Name = "Seki Shuriken",
                    GearItemCategoryId = 15, // Thrown category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 101 },
                        new GearItemStat { Id = 41, Value = 192 },
                        new GearItemStat { Id = 44, Value = 13 },
                        new GearItemStat { Id = 50, Value = 2 },
                        new GearStat { Name = "Throwing Skill", Value = 242 }
                    }
                },
                new GearItem
                {
                    Name = "Donar Gun",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13}, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 103 },
                        new GearItemStat { Id = 41, Value = 548 },
                        new GearItemStat { Id = 21, Value = 228 },
                        new GearItemStat { Id = 2, Value = 5 },
                        new GearItemStat { Id = 4, Value = 5 },
                        new GearStat { Name = "Thunder Elemental Bonus", Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Ullr",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 20, Value = 250 },
                        new GearItemStat { Id = 42, Value = 178 },
                        new GearItemStat { Id = 41, Value = 360 },
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 2, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 110, Value = 40 },
                        new GearItemStat { Id = 111, Value = 30 },
                        new GearItemStat { Id = 68, Value = 40 }
                    }
                },
                new GearItem
                {
                    Name = "Yoichinoyumi R15",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 310 },
                        new GearItemStat { Id = 41, Value = 524 },
                        new GearItemStat { Id = 110, Value = 60 },
                        new GearItemStat { Id = 111, Value = 45 },
                        new GearItemStat { Id = 20, Value = 269 },
                        new GearItemStat { Id = 45, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Yoichinoyumi",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 303 },
                        new GearItemStat { Id = 41, Value = 524 },
                        new GearItemStat { Id = 110, Value = 60 },
                        new GearItemStat { Id = 111, Value = 45 },
                        new GearItemStat { Id = 20, Value = 269 },
                        new GearItemStat { Id = 45, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Armageddon R15",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 20 },
                        new GearItemStat { Id = 4, Value = 70 },
                        new GearItemStat { Id = 42, Value = 151 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 }
                    }
                },
                new GearItem
                {
                    Name = "Armageddon",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 50 },
                        new GearItemStat { Id = 42, Value = 143 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 }
                    }
                },
                new GearItem
                {
                    Name = "Fomalhaut R15",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 176 },
                        new GearItemStat { Id = 41, Value = 600 },
                        new GearItemStat { Id = 110, Value = 30 },
                        new GearItemStat { Id = 68, Value = 70 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 50, Value = 10 },
                        new GearItemStat { Id = 57, Value = 500 }
                    }
                },
                new GearItem
                {
                    Name = "Fomalhaut",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 167 },
                        new GearItemStat { Id = 41, Value = 600 },
                        new GearItemStat { Id = 68, Value = 40 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 50, Value = 10 },
                        new GearItemStat { Id = 57, Value = 500 }
                    }
                },
                new GearItem
                {
                    Name = "Death Penalty R15",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 110, Value = 30 },
                        new GearItemStat { Id = 68, Value = 30 },
                        new GearItemStat { Id = 42, Value = 107 },
                        new GearItemStat { Id = 41, Value = 480 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearStat { Name = "QuickDrawDamage%", Value = 60 },
                        new GearItemStat { Id = 194, Value = 60 }
                    }
                },
                new GearItem
                {
                    Name = "Death Penalty",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 101 },
                        new GearItemStat { Id = 41, Value = 480 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearStat { Name = "QuickDrawDamage%", Value = 60 },
                        new GearItemStat { Id = 194, Value = 60 }
                    }
                },
                new GearItem
                {
                    Name = "Ataktos",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17}, new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 53 },
                        new GearItemStat { Id = 41, Value = 600 },
                        new GearItemStat { Id = 57, Value = 1000 }
                    }
                },
                new GearItem
                {
                    Name = "Molybdosis",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 25 },
                        new GearItemStat { Id = 42, Value = 103 },
                        new GearItemStat { Id = 41, Value = 480 },
                        new GearItemStat { Id = 111, Value = 45 },
                        new GearItemStat { Id = 69, Value = 30 },
                        new GearItemStat { Id = 21, Value = 242 },
                        new GearItemStat { Id = 46, Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Gandiva R15",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 20 },
                        new GearItemStat { Id = 2, Value = 70 },
                        new GearItemStat { Id = 42, Value = 293 },
                        new GearItemStat { Id = 41, Value = 490 },
                        new GearItemStat { Id = 20, Value = 269 }
                    }
                },
                new GearItem
                {
                    Name = "Gandiva",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 2, Value = 50 },
                        new GearItemStat { Id = 42, Value = 286 },
                        new GearItemStat { Id = 41, Value = 490 },
                        new GearItemStat { Id = 20, Value = 269 }
                    }
                },
                new GearItem
                {
                    Name = "Fail-not R15",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 337 },
                        new GearItemStat { Id = 41, Value = 600 },
                        new GearItemStat { Id = 68, Value = 70 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 20, Value = 269 },
                        new GearItemStat { Id = 50, Value = 10 },
                        new GearItemStat { Id = 57, Value = 500 },
                        new GearItemStat { Id = 110, Value = 30 }
                    }
                },
                new GearItem
                {
                    Name = "Fail-not",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 330 },
                        new GearItemStat { Id = 41, Value = 600 },
                        new GearItemStat { Id = 68, Value = 40 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 20, Value = 269 },
                        new GearItemStat { Id = 50, Value = 10 },
                        new GearItemStat { Id = 57, Value = 500 }
                    }
                },
                new GearItem
                {
                    Name = "Accipiter",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 94 },
                        new GearItemStat { Id = 41, Value = 524 },
                        new GearItemStat { Id = 57, Value = 1000 }
                    }
                },
                new GearItem
                {
                    Name = "Annihilator R15",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 155 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 110, Value = 60 },
                        new GearItemStat { Id = 111, Value = 45 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 50, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Annihilator",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 143 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 110, Value = 60 },
                        new GearItemStat { Id = 111, Value = 45 },
                        new GearItemStat { Id = 70, Value = 155 },
                        new GearItemStat { Id = 21, Value = 269 }
                    }
                },
                new GearItem
                {
                    Name = "Gastraphetes R15",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 181 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 50 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 68, Value = 30 },
                        new GearItemStat { Id = 204, Value = 70 }
                    }
                },
                new GearItem
                {
                    Name = "Gastraphetes",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 176 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 20 },
                        new GearItemStat { Id = 70, Value = 217 },
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 204, Value = 70 }
                    }
                },
                new GearItem
                {
                    Name = "Exalted Crossbow +1",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 42, Value = 111 },
                        new GearItemStat { Id = 41, Value = 227 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 110, Value = 37 },
                        new GearItemStat { Id = 21, Value = 242 }
                    }
                },
                new GearItem
                {
                    Name = "Mpaca's Bow R0",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 42, Value = 271 },
                        new GearItemStat { Id = 41, Value = 540 },
                        new GearItemStat { Id = 110, Value = 40 },
                        new GearItemStat { Id = 111, Value = 30 },
                        new GearItemStat { Id = 20, Value = 255 },
                        new GearItemStat { Id = 187, Value = 5 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 68, Value = 0 }
                    }
                },
                new GearItem
                {
                    Name = "Mpaca's Bow R15",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 42, Value = 286 },
                        new GearItemStat { Id = 41, Value = 540 },
                        new GearItemStat { Id = 110, Value = 40 },
                        new GearItemStat { Id = 111, Value = 60 },
                        new GearItemStat { Id = 20, Value = 255 },
                        new GearItemStat { Id = 187, Value = 5 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 68, Value = 0 }
                    }
                },
                new GearItem
                {
                    Name = "Mpaca's Bow R20",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 42, Value = 288 },
                        new GearItemStat { Id = 41, Value = 540 },
                        new GearItemStat { Id = 110, Value = 45 },
                        new GearItemStat { Id = 111, Value = 65 },
                        new GearItemStat { Id = 20, Value = 255 },
                        new GearItemStat { Id = 187, Value = 5 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 68, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Mpaca's Bow R25",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 42, Value = 290 },
                        new GearItemStat { Id = 41, Value = 540 },
                        new GearItemStat { Id = 110, Value = 50 },
                        new GearItemStat { Id = 111, Value = 70 },
                        new GearItemStat { Id = 20, Value = 255 },
                        new GearItemStat { Id = 187, Value = 5 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 68, Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Mpaca's Bow R30",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 1, Value = 15 },
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 42, Value = 292 },
                        new GearItemStat { Id = 41, Value = 540 },
                        new GearItemStat { Id = 110, Value = 55 },
                        new GearItemStat { Id = 111, Value = 75 },
                        new GearItemStat { Id = 20, Value = 255 },
                        new GearItemStat { Id = 187, Value = 5 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 68, Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Gleti's Crossbow R0",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 6, Value = 15 },
                        new GearItemStat { Id = 42, Value = 115 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 40 },
                        new GearItemStat { Id = 111, Value = 30 },
                        new GearItemStat { Id = 21, Value = 255 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 45, Value = 5 },
                        new GearItemStat { Id = 54, Value = 10 },
                        new GearItemStat { Id = 68, Value = 0 }
                    }
                },
                new GearItem
                {
                    Name = "Gleti's Crossbow R15",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 6, Value = 15 },
                        new GearItemStat { Id = 42, Value = 120 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 40 },
                        new GearItemStat { Id = 111, Value = 60 },
                        new GearItemStat { Id = 21, Value = 255 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 45, Value = 5 },
                        new GearItemStat { Id = 54, Value = 10 },
                        new GearItemStat { Id = 68, Value = 0 }
                    }
                },
                new GearItem
                {
                    Name = "Gleti's Crossbow R20",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 6, Value = 15 },
                        new GearItemStat { Id = 42, Value = 121 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 45 },
                        new GearItemStat { Id = 111, Value = 65 },
                        new GearItemStat { Id = 21, Value = 255 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 45, Value = 5 },
                        new GearItemStat { Id = 54, Value = 10 },
                        new GearItemStat { Id = 68, Value = 5 }
                    }
                },
                new GearItem
                {
                    Name = "Gleti's Crossbow R25",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 6, Value = 15 },
                        new GearItemStat { Id = 42, Value = 123 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 50 },
                        new GearItemStat { Id = 111, Value = 70 },
                        new GearItemStat { Id = 21, Value = 255 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 45, Value = 5 },
                        new GearItemStat { Id = 54, Value = 10 },
                        new GearItemStat { Id = 68, Value = 10 }
                    }
                },
                new GearItem
                {
                    Name = "Gleti's Crossbow R30",
                    GearItemCategoryId = 8, // Crossbow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 4, Value = 15 },
                        new GearItemStat { Id = 6, Value = 15 },
                        new GearItemStat { Id = 42, Value = 124 },
                        new GearItemStat { Id = 41, Value = 432 },
                        new GearItemStat { Id = 110, Value = 55 },
                        new GearItemStat { Id = 111, Value = 75 },
                        new GearItemStat { Id = 21, Value = 255 },
                        new GearItemStat { Id = 50, Value = 5 },
                        new GearItemStat { Id = 45, Value = 5 },
                        new GearItemStat { Id = 54, Value = 10 },
                        new GearItemStat { Id = 68, Value = 15 }
                    }
                },
                new GearItem
                {
                    Name = "Earp V",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 21, Value = 277 },
                        new GearItemStat { Id = 42, Value = 162 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 2, Value = 35 },
                        new GearItemStat { Id = 4, Value = 35 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 277 },
                        new GearItemStat { Id = 45, Value = 15 },
                        new GearItemStat { Id = 68, Value = 35 },
                        new GearItemStat { Id = 110, Value = 35 }
                    }
                },
                new GearItem
                {
                    Name = "Earp IV",
                    GearItemCategoryId = 9, // Gun category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 21, Value = 269 },
                        new GearItemStat { Id = 42, Value = 151 },
                        new GearItemStat { Id = 41, Value = 582 },
                        new GearItemStat { Id = 2, Value = 30 },
                        new GearItemStat { Id = 4, Value = 30 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 269 },
                        new GearItemStat { Id = 45, Value = 12 },
                        new GearItemStat { Id = 68, Value = 30 },
                        new GearItemStat { Id = 110, Value = 30 }
                    }
                },
                new GearItem
                {
                    Name = "Pinaka V",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 20, Value = 277 },
                        new GearItemStat { Id = 42, Value = 324 },
                        new GearItemStat { Id = 41, Value = 524 },
                        new GearItemStat { Id = 1, Value = 35 },
                        new GearItemStat { Id = 4, Value = 35 },
                        new GearItemStat { Id = 50, Value = 10 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 277 },
                        new GearItemStat { Id = 68, Value = 35 },
                        new GearItemStat { Id = 110, Value = 35 }
                    }
                },
                new GearItem
                {
                    Name = "Pinaka IV",
                    GearItemCategoryId = 7, // Bow category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 3 }
    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 20, Value = 269 },
                        new GearItemStat { Id = 42, Value = 309 },
                        new GearItemStat { Id = 41, Value = 524 },
                        new GearItemStat { Id = 1, Value = 30 },
                        new GearItemStat { Id = 4, Value = 30 },
                        new GearItemStat { Id = 50, Value = 7 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 269 },
                        new GearItemStat { Id = 68, Value = 30 },
                        new GearItemStat { Id = 110, Value = 30 }
                    }
                }
            };
        }
    }
}
