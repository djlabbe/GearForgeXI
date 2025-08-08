using GearForgeXI.Models;

namespace GearForgeXI.SeedData
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
                        new GearItemStat { StatId = 43, Value = 15 },
                        new GearItemStat { StatId = 44, Value = 15 },
                        new GearItemStat { StatId = 1, Value = 5 },
                        new GearItemStat { StatId = 50, Value = 13 },
                        new GearItemStat { StatId = 52, Value = 5 }
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
                        new GearItemStat { StatId = 43, Value = 50 },
                        new GearItemStat { StatId = 110, Value = 50 },
                        new GearItemStat { StatId = 68, Value = 50 },
                        new GearItemStat { StatId = 91, Value = 50 },
                        new GearItemStat { StatId = 93, Value = 50 },
                        new GearItemStat { StatId = 47, Value = 7 },
                        new GearItemStat { StatId = 50, Value = 7 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 61, Value = 20 },
                        new GearItemStat { StatId = 131, Value = 15 },
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 135, Value = 10 },
                        new GearItemStat { StatId = 136, Value = 25 }
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 141, Value = 10 },
                        new GearItemStat { StatId = 142, Value = 25 }
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 77, Value = 5 },
                        new GearItemStat { StatId = 147, Value = 10 }
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 179, Value = 10 },
                        new GearItemStat { StatId = 76, Value = 20 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 150, Value = 10 },
                        new GearItemStat { StatId = 185, Value = 20 }
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
                        new GearItemStat { StatId = 92, Value = 20 },
                        new GearItemStat { StatId = 80, Value = 5 },
                        new GearItemStat { StatId = 97, Value = 3 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 156, Value = 15 },
                        new GearItemStat { StatId = 157, Value = 10 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 158, Value = 30 },
                        new GearItemStat { StatId = 159, Value = 10 }
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 160, Value = 1 },
                        new GearItemStat { StatId = 161, Value = 1 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 162, Value = 2 },
                        new GearItemStat { StatId = 228, Value = 20 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 164, Value = 8 },
                        new GearItemStat { StatId = 53, Value = 3 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 165, Value = 1 },
                        new GearItemStat { StatId = 166, Value = 5 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 221, Value = 20 },
                        new GearItemStat { StatId = 222, Value = 15 },
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 167, Value = 1 },
                        new GearItemStat { StatId = 168, Value = 5 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 169, Value = 10 },
                        new GearItemStat { StatId = 170, Value = 250 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 171, Value = 30 },
                        new GearItemStat { StatId = 189, Value = 5 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 173, Value = -10 },
                        new GearItemStat { StatId = 174, Value = 1 }
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
                        new GearItemStat { StatId = 92, Value = 16 },
                        new GearItemStat { StatId = 175, Value = 15 },
                        new GearItemStat { StatId = 46, Value = 5 }
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 53, Value = 10 },
                        new GearItemStat { StatId = 81, Value = 15 },
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
                        new GearItemStat { StatId = 92, Value = 15 },
                        new GearItemStat { StatId = 176, Value = 20 },
                        new GearItemStat { StatId = 177, Value = 10 }
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
                        new GearItemStat { StatId = 92, Value = 18 },
                        new GearItemStat { StatId = 178, Value = 3 },
                        new GearItemStat { StatId = 179, Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                }
            };

            return items;
        }
    }
}
