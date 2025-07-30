using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class EarSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Balder Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 3 },
                        new GearStat { Name = "QA", Value = 1 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Brutal Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 1 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Cessance Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 6 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Crematio Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 6 },
                        new GearStat { Name = "MagicDamage", Value = 6 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Crepuscular Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Dedition Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = -10 },
                        new GearStat { Name = "RangedAccuracy", Value = -10 },
                        new GearStat { Name = "Attack", Value = -10 },
                        new GearStat { Name = "RangedAttack", Value = -10 },
                        new GearStat { Name = "StoreTP", Value = 8 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Dignitary's Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 3 },
                        new GearStat { Name = "SubtleBlow", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Eabani Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 15 },
                        new GearStat { Name = "MagicEvasion", Value = 8 },
                        new GearStat { Name = "DualWield", Value = 4 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Friomisi Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ishvara Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Lugra Earring +1 R15 (day)",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 8 },
                        new GearStat { Name = "Dex", Value = 8 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Int", Value = 8 },
                        new GearStat { Name = "DA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "PLD" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "BST" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "NIN" }
                    }
                },
                new GearItem
                {
                    Name = "Lugra Earring +1 R15 (night)",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 16 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "DA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "PLD" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "BST" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "NIN" }
                    }
                },
                new GearItem
                {
                    Name = "Mache Earring +1A",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "DA", Value = 2 },
                        new GearStat { Name = "MartialArts", Value = 13 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Moonshade Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 4 },
                        new GearStat { Name = "TPBonus", Value = 250 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Odr Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "THF" },
                        new GearItemJob { JobName = "RNG" },
                        new GearItemJob { JobName = "NIN" },
                        new GearItemJob { JobName = "BLU" },
                        new GearItemJob { JobName = "COR" },
                        new GearItemJob { JobName = "DNC" },
                        new GearItemJob { JobName = "RUN" }
                    }
                },
                new GearItem
                {
                    Name = "Schere Earring R0",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "SubtleBlow", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Schere Earring R15",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "SubtleBlow", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Schere Earring R20",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Schere Earring R25",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 3 },
                        new GearStat { Name = "SubtleBlow", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Schere Earring R30",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Static Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 2 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Suppanomimi",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "DualWield", Value = 5 },
                        new GearStat { Name = "SwordSkill", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Telos Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "DA", Value = 1 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Thrud Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" },
                        new GearItemJob { JobName = "PLD" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "BST" },
                        new GearItemJob { JobName = "SAM" },
                        new GearItemJob { JobName = "DRG" }
                    }
                },
                new GearItem
                {
                    Name = "Hattori Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "ThrowingSkill", Value = 12 },
                        new GearStat { Name = "KatanaSkill", Value = 12 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Agi", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "NIN" }
                    }
                },
                new GearItem
                {
                    Name = "Hattori Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "ThrowingSkill", Value = 11 },
                        new GearStat { Name = "KatanaSkill", Value = 11 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "NIN" }
                    }
                },
                new GearItem
                {
                    Name = "Heathen's Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 6 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Int", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DRK" }
                    }
                },
                new GearItem
                {
                    Name = "Heathen's Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 17 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DRK" }
                    }
                },
                new GearItem
                {
                    Name = "Regal Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "Chr", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLM" },
                        new GearItemJob { JobName = "RDM" },
                        new GearItemJob { JobName = "SCH" },
                        new GearItemJob { JobName = "GEO" },
                        new GearItemJob { JobName = "WHM" },
                        new GearItemJob { JobName = "BRD" },
                        new GearItemJob { JobName = "BLU" }
                    }
                },
                new GearItem
                {
                    Name = "Malignance Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 8 },
                        new GearStat { Name = "Mnd", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLM" },
                        new GearItemJob { JobName = "RDM" },
                        new GearItemJob { JobName = "SCH" },
                        new GearItemJob { JobName = "GEO" },
                        new GearItemJob { JobName = "DRK" },
                        new GearItemJob { JobName = "WHM" }
                    }
                },
                new GearItem
                {
                    Name = "Barkarole Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 8 },
                        new GearStat { Name = "MagicAttack", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLM" },
                        new GearItemJob { JobName = "SCH" },
                        new GearItemJob { JobName = "GEO" }
                    }
                },
                new GearItem
                {
                    Name = "Wicce Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 9 },
                        new GearStat { Name = "MagicDamage", Value = 9 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLM" }
                    }
                },
                new GearItem
                {
                    Name = "Wicce Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 8 },
                        new GearStat { Name = "MagicDamage", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLM" }
                    }
                },
                new GearItem
                {
                    Name = "Sherida Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "MNK" },
                        new GearItemJob { JobName = "RDM" },
                        new GearItemJob { JobName = "THF" },
                        new GearItemJob { JobName = "BST" },
                        new GearItemJob { JobName = "RNG" },
                        new GearItemJob { JobName = "DRG" },
                        new GearItemJob { JobName = "DNC" },
                        new GearItemJob { JobName = "RUN" }
                    }
                },
                new GearItem
                {
                    Name = "Lethargy Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RDM" }
                    }
                },
                new GearItem
                {
                    Name = "Lethargy Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "DA", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RDM" }
                    }
                },
                new GearItem
                {
                    Name = "Peltast's Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "SubtleBlow", Value = 7 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Vit", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DRG" }
                    }
                },
                new GearItem
                {
                    Name = "Peltast's Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "SubtleBlow", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DRG" }
                    }
                },
                new GearItem
                {
                    Name = "Ebers Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WHM" }
                    }
                },
                new GearItem
                {
                    Name = "Ebers Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WHM" }
                    }
                },
                new GearItem
                {
                    Name = "Kasuga Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "StoreTP", Value = 9 },
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "SAM" }
                    }
                },
                new GearItem
                {
                    Name = "Kasuga Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "SAM" }
                    }
                },
                new GearItem
                {
                    Name = "Arbatel Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 9 },
                        new GearStat { Name = "MagicDamage", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "SCH" }
                    }
                },
                new GearItem
                {
                    Name = "Arbatel Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 8 },
                        new GearStat { Name = "MagicDamage", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "SCH" }
                    }
                },
                new GearItem
                {
                    Name = "Enervating Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 7 },
                        new GearStat { Name = "RangedAttack", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Boii Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Vit", Value = 11 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" }
                    }
                },
                new GearItem
                {
                    Name = "Boii Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "WAR" }
                    }
                },
                new GearItem
                {
                    Name = "Chasseurs Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Agi", Value = 11 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "COR" }
                    }
                },
                new GearItem
                {
                    Name = "Chasseurs Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "COR" }
                    }
                },
                new GearItem
                {
                    Name = "Fili Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BRD" }
                    }
                },
                new GearItem
                {
                    Name = "Fili Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BRD" }
                    }
                },
                new GearItem
                {
                    Name = "Skulkers Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "TA", Value = 5 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Agi", Value = 11 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "THF" }
                    }
                },
                new GearItem
                {
                    Name = "Skulkers Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "THF" }
                    }
                },
                new GearItem
                {
                    Name = "Bhikku Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Hand-to-HandSkill", Value = 12 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "MNK" }
                    }
                },
                new GearItem
                {
                    Name = "Bhikku Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Hand-to-HandSkill", Value = 11 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "MNK" }
                    }
                },
                new GearItem
                {
                    Name = "Maculele Earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 7 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Agi", Value = 11 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DNC" }
                    }
                },
                new GearItem
                {
                    Name = "Maculele Earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 6 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "DNC" }
                    }
                },
                new GearItem
                {
                    Name = "Nukumi earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Chr", Value = 11 },
                        new GearStat { Name = "AxeSkill", Value = 12 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BST" }
                    }
                },
                new GearItem
                {
                    Name = "Nukumi earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "AxeSkill", Value = 11 },
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BST" }
                    }
                },
                new GearItem
                {
                    Name = "Azimuth earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "MagicAttack", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "GEO" }
                    }
                },
                new GearItem
                {
                    Name = "Azimuth earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAttack", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "GEO" }
                    }
                },
                new GearItem
                {
                    Name = "Sroda Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BST" },
                        new GearItemJob { JobName = "DRG" },
                        new GearItemJob { JobName = "SMN" },
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Chevalier's earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Vit", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "DT", Value = -7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "PLD" }
                    }
                },
                new GearItem
                {
                    Name = "Chevalier's earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "DT", Value = -4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "PLD" }
                    }
                },
                new GearItem
                {
                    Name = "Amini earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Agi", Value = 11 },
                        new GearStat { Name = "PDL", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "CritRate", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RNG" }
                    }
                },
                new GearItem
                {
                    Name = "Amini earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDL", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RNG" }
                    }
                },
                new GearItem
                {
                    Name = "Karagoz earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 11 },
                        new GearStat { Name = "Hand-to-HandSkill", Value = 12 },
                        new GearStat { Name = "SubtleBlow", Value = 7 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Karagoz earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Hand-to-HandSkill", Value = 11 },
                        new GearStat { Name = "SubtleBlow", Value = 6 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "PUP" }
                    }
                },
                new GearItem
                {
                    Name = "Hashishin earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "SwordSkill", Value = 12 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLU" }
                    }
                },
                new GearItem
                {
                    Name = "Hashishin earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SwordSkill", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "DA", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "BLU" }
                    }
                },
                new GearItem
                {
                    Name = "Erilaz earring +2",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 11 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 18 },
                        new GearStat { Name = "Accuracy", Value = 18 },
                        new GearStat { Name = "DT", Value = -7 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RUN" }
                    }
                },
                new GearItem
                {
                    Name = "Erilaz earring +1",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "DT", Value = -4 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RUN" }
                    }
                },
                new GearItem
                {
                    Name = "Odnowa Earring +1 R15",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Accuracy", Value = 9 },
                        new GearStat { Name = "MDT", Value = -2 },
                        new GearStat
                        {
                            Name = "DT",
                            Value = -3
                        }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Dominance Earring +1 R15",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 14 },
                        new GearStat { Name = "Dex", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Beyla Earring",
                    Slot = "Ear",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "SubtleBlow", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>
                    {
                        new GearItemJob { JobName = "RNG" },
                        new GearItemJob { JobName = "COR" }
                    }
                }
            };
        }
    }
}
