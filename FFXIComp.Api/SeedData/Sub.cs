using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class SubSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Alber Strap",
                    Slot = "Sub",
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
                    Slot = "Sub",
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
                    Slot = "Sub",
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
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "WSC(Dex)", Value = 10, }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Niobid Strap",
                    Slot = "Sub",
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
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Khonsu",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Refined Grip +1",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                 new GearItem
                {
                    Name = "Refined Grip +1 R15",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Ammurapi Shield",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 13 },
                        new GearStat { Name = "Mnd", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 38 },
                        new GearStat { Name = "MagicAttack", Value = 38 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Genmei Shield",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "PDT", Value = -10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Blurred Shield +1",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "Fencer", Value = 1 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Nusku Shield",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Culminus",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 75 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Sacro Bulwark",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Aegis",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MDT2", Value = -50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Srivatsa",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "DT", Value = -8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Duban",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "MDT2", Value = -20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Duban V",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Evasion", Value = 35 },
                        new GearStat { Name = "MagicEvasion", Value = 35 },
                        new GearStat { Name = "MDT2", Value = -25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Ochain",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Diamond Aspis",
                    Slot = "Sub",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BST" } }
                }
            };
        }
    }
}
