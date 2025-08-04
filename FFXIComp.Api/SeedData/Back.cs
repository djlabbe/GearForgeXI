using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class BackSeedData
    {
        public static List<GearItem> GetItems()
        {
            var items = new List<GearItem>
            {
                new GearItem
                {
                    Name = "Takaha Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 15 },
                        new GearItemStat { Id = 44, Value = 15 },
                        new GearItemStat { Id = 1, Value = 5 },
                        new GearItemStat { Id = 50, Value = 13 },
                        new GearItemStat { Id = 52, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Null Shawl",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 50 },
                        new GearItemStat { Id = 110, Value = 50 },
                        new GearItemStat { Id = 68, Value = 50 },
                        new GearItemStat { Id = 91, Value = 50 },
                        new GearItemStat { Id = 93, Value = 50 },
                        new GearItemStat { Id = 47, Value = 7 },
                        new GearItemStat { Id = 50, Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Cichol's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 61, Value = 20 },
                        new GearItemStat { Id = 131, Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Segomo's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 135, Value = 10 },
                        new GearItemStat { Id = 136, Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Alaunus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 141, Value = 10 },
                        new GearItemStat { Id = 142, Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 } }
                },
                new GearItem
                {
                    Name = "Taranus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 77, Value = 5 },
                        new GearItemStat { Id = 147, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Sucellos's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 179, Value = 10 },
                        new GearItemStat { Id = 76, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 5 } }
                },
                new GearItem
                {
                    Name = "Toutatis's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 150, Value = 10 },
                        new GearItemStat { Id = 185, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 6 } }
                },
                new GearItem
                {
                    Name = "Rudianos's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 20 },
                        new GearItemStat { Id = 80, Value = 5 },
                        new GearItemStat { Id = 97, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Ankou's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 156, Value = 15 },
                        new GearItemStat { Id = 157, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Artio's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 158, Value = 30 },
                        new GearItemStat { Id = 159, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Intarabus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 160, Value = 1 },
                        new GearItemStat { Id = 161, Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 10 } }
                },
                new GearItem
                {
                    Name = "Belenus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 162, Value = 2 },
                        new GearItemStat { Id = 163, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} }
                },
                new GearItem
                {
                    Name = "Smertrios's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 164, Value = 8 },
                        new GearItemStat { Id = 53, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Andartia's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 165, Value = 1 },
                        new GearItemStat { Id = 166, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} }
                },
                new GearItem
                {
                    Name = "Brigantia's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 221, Value = 20 },
                        new GearItemStat { Id = 222, Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Campestres's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 167, Value = 1 },
                        new GearItemStat { Id = 168, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Rosmerta's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 169, Value = 10 },
                        new GearItemStat { Id = 170, Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 16} }
                },
                new GearItem
                {
                    Name = "Camulus's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 171, Value = 30 },
                        new GearItemStat { Id = 189, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Visucius's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 173, Value = -10 },
                        new GearItemStat { Id = 174, Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Senuna's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 175, Value = 15 },
                        new GearItemStat { Id = 46, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 19} }
                },
                new GearItem
                {
                    Name = "Lugh's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 53, Value = 10 },
                        new GearItemStat { Id = 81, Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Nantosuelta's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 176, Value = 20 },
                        new GearItemStat { Id = 177, Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Ogma's cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 178, Value = 3 },
                        new GearItemStat { Id = 179, Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                }
            };

            return items;
        }
    }
}
