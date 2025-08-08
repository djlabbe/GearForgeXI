using GearForgeXI.Models;

namespace GearForgeXI.SeedData
{
    public static class MainH2HSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
new GearItem
                {
                    Name = "Karambit",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 180 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 1, Value = 20 },
                        new GearItemStat { StatId = 2, Value = 20 },
                        new GearItemStat { StatId = 3, Value = 20 },
                        new GearItemStat { StatId = 43, Value = 40 },
                        new GearItemStat { StatId = 44, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 40 },
                        new GearItemStat { StatId = 8, Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 19} }
                },
                new GearItem
                {
                    Name = "Godhands R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 221 },
                        new GearItemStat { StatId = 41, Value = 138 },
                        new GearItemStat { StatId = 70, Value = 155 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 57, Value = 500 },
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Godhands",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 197 },
                        new GearItemStat { StatId = 41, Value = 138 },
                        new GearItemStat { StatId = 70, Value = 155 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 57, Value = 500 },
                        new GearItemStat { StatId = 43, Value = 0 },
                        new GearItemStat { StatId = 68, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Glanzfaust R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 199 },
                        new GearItemStat { StatId = 41, Value = 126 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Glanzfaust",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 170 },
                        new GearItemStat { StatId = 41, Value = 126 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 43, Value = 0 },
                        new GearItemStat { StatId = 68, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Verethragna R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 70 },
                        new GearItemStat { StatId = 2, Value = 20 },
                        new GearItemStat { StatId = 42, Value = 178 },
                        new GearItemStat { StatId = 41, Value = 81 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Verethragna",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 50 },
                        new GearItemStat { StatId = 2, Value = 0 },
                        new GearItemStat { StatId = 42, Value = 158 },
                        new GearItemStat { StatId = 41, Value = 81 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Spharai R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 206 },
                        new GearItemStat { StatId = 41, Value = 116 },
                        new GearItemStat { StatId = 44, Value = 60 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Spharai",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 182 },
                        new GearItemStat { StatId = 41, Value = 116 },
                        new GearItemStat { StatId = 44, Value = 60 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R0",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 2, Value = 15 },
                        new GearItemStat { StatId = 42, Value = 165 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 43, Value = 40 },
                        new GearItemStat { StatId = 44, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 40 },
                        new GearItemStat { StatId = 8, Value = 255 },
                        new GearItemStat { StatId = 231, Value = 242 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 53, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 2, Value = 15 },
                        new GearItemStat { StatId = 42, Value = 180 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 43, Value = 40 },
                        new GearItemStat { StatId = 44, Value = 60 },
                        new GearItemStat { StatId = 68, Value = 40 },
                        new GearItemStat { StatId = 8, Value = 255 },
                        new GearItemStat { StatId = 231, Value = 242 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 53, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R20",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 2, Value = 15 },
                        new GearItemStat { StatId = 42, Value = 182 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 43, Value = 45 },
                        new GearItemStat { StatId = 44, Value = 65 },
                        new GearItemStat { StatId = 68, Value = 45 },
                        new GearItemStat { StatId = 8, Value = 255 },
                        new GearItemStat { StatId = 231, Value = 242 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 53, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R25",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 2, Value = 15 },
                        new GearItemStat { StatId = 42, Value = 183 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 43, Value = 50 },
                        new GearItemStat { StatId = 44, Value = 70 },
                        new GearItemStat { StatId = 68, Value = 50 },
                        new GearItemStat { StatId = 8, Value = 255 },
                        new GearItemStat { StatId = 231, Value = 242 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 53, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R30",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 2, Value = 15 },
                        new GearItemStat { StatId = 42, Value = 185 },
                        new GearItemStat { StatId = 41, Value = 96 },
                        new GearItemStat { StatId = 43, Value = 55 },
                        new GearItemStat { StatId = 44, Value = 75 },
                        new GearItemStat { StatId = 68, Value = 55 },
                        new GearItemStat { StatId = 8, Value = 255 },
                        new GearItemStat { StatId = 231, Value = 242 },
                        new GearItemStat { StatId = 59, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 54, Value = 5 },
                        new GearItemStat { StatId = 53, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Kenkonken R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 168 },
                        new GearItemStat { StatId = 41, Value = 79 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 66, Value = 55 },
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Kenkonken",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 144 },
                        new GearItemStat { StatId = 41, Value = 79 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 228 },
                        new GearItemStat { StatId = 66, Value = 55 },
                        new GearItemStat { StatId = 43, Value = 0 },
                        new GearItemStat { StatId = 68, Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} }
                },

                new GearItem
                {
                    Name = "Xiucoatl R25",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 204 },
                        new GearItemStat { StatId = 41, Value = 121 },
                        new GearItemStat { StatId = 43, Value = 50 },
                        new GearItemStat { StatId = 68, Value = 50 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 255 },
                        new GearItemStat { StatId = 54, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Sagitta R25",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 204 },
                        new GearItemStat { StatId = 41, Value = 121 },
                        new GearItemStat { StatId = 43, Value = 50 },
                        new GearItemStat { StatId = 68, Value = 50 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Hepatizon Baghnakhs",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 159 },
                        new GearItemStat { StatId = 41, Value = 81 },
                        new GearItemStat { StatId = 1, Value = 15 },
                        new GearItemStat { StatId = 3, Value = 15 },
                        new GearItemStat { StatId = 43, Value = 32 },
                        new GearItemStat { StatId = 8, Value = 242 },
                        new GearItemStat { StatId = 231, Value = 188 },
                        new GearItemStat { StatId = 55, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 19} }
                },
                 new GearItem
                {
                    Name = "Comeuppances +1 R15",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 163 },
                        new GearItemStat { StatId = 41, Value = 79 },
                        new GearItemStat { StatId = 1, Value = 20 },
                        new GearItemStat { StatId = 2, Value = 20 },
                        new GearItemStat { StatId = 43, Value = 81 },
                        new GearItemStat { StatId = 8, Value = 242 },
                        new GearItemStat { StatId = 231, Value = 188 },
                        new GearItemStat { StatId = 51, Value = 12 },
                        new GearItemStat { StatId = 47, Value = 4 },
                        new GearItemStat { StatId = 50, Value = 10 },
                        new GearItemStat { StatId = 68, Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                 new GearItem
                {
                    Name = "Dragon Fangs",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 188 },
                        new GearItemStat { StatId = 41, Value = 126 },
                        new GearItemStat { StatId = 2, Value = 30 },
                        new GearItemStat { StatId = 43, Value = 40 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Varga Purnikawa V",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 213 },
                        new GearItemStat { StatId = 41, Value = 116 },
                        new GearItemStat { StatId = 1, Value = 35 },
                        new GearItemStat { StatId = 2, Value = 35 },
                        new GearItemStat { StatId = 45, Value = 15 },
                        new GearItemStat { StatId = 8, Value = 277 },
                        new GearItemStat { StatId = 231, Value = 277 },
                        new GearItemStat { StatId = 43, Value = 35 },
                        new GearItemStat { StatId = 68, Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Varga Purnikawa IV",
                    GearItemCategoryId = 3, // H2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { StatId = 42, Value = 202 },
                        new GearItemStat { StatId = 41, Value = 116 },
                        new GearItemStat { StatId = 1, Value = 30 },
                        new GearItemStat { StatId = 2, Value = 30 },
                        new GearItemStat { StatId = 45, Value = 12 },
                        new GearItemStat { StatId = 8, Value = 269 },
                        new GearItemStat { StatId = 231, Value = 269 },
                        new GearItemStat { StatId = 43, Value = 30 },
                        new GearItemStat { StatId = 68, Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
            };
        }
    }
}