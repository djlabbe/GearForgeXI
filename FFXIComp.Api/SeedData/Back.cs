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
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "Zanshin", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Null Shawl",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Evasion", Value = 50 },
                        new GearStat { Name = "MagicEvasion", Value = 50 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                }
            };

            return items;
        }
    }
}
