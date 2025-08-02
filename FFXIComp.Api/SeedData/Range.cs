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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 71 },
                        new GearStat { Name = "Delay", Value = 252 },
                        new GearStat { Name = "RangedAttack", Value = 21 },
                        new GearStat { Name = "Throwing Skill", Value = 242 },
                        new GearStat { Name = "RangedAccuracy", Value = 21 },
                        new GearStat { Name = "DA", Value = 6 },
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 125 },
                        new GearStat { Name = "Delay", Value = 192 },
                        new GearStat { Name = "Evasion", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 5 },
                        new GearStat { Name = "Throwing Skill", Value = 242 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Agi", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 99 },
                        new GearStat { Name = "Delay", Value = 188 },
                        new GearStat { Name = "Accuracy", Value = 6 },
                        new GearStat { Name = "Attack", Value = 6 },
                        new GearStat { Name = "RangedAccuracy", Value = 11 },
                        new GearStat { Name = "Throwing Skill", Value = 228 },
                        new GearStat { Name = "CritRate", Value = 2 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 101 },
                        new GearStat { Name = "Delay", Value = 192 },
                        new GearStat { Name = "Attack", Value = 13 },
                        new GearStat { Name = "StoreTP", Value = 2 },
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 103 },
                        new GearStat { Name = "Delay", Value = 548 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 228 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Agi", Value = 5 },
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "ArcherySkill", Value = 250 },
                        new GearStat { Name = "DMG", Value = 178 },
                        new GearStat { Name = "Delay", Value = 360 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 310 },
                        new GearStat { Name = "Delay", Value = 524 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "ArcherySkill", Value = 269 },
                        new GearStat { Name = "CritRate", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 303 },
                        new GearStat { Name = "Delay", Value = 524 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "ArcherySkill", Value = 269 },
                        new GearStat { Name = "CritRate", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Agi", Value = 70 },
                        new GearStat { Name = "DMG", Value = 151 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 50 },
                        new GearStat { Name = "DMG", Value = 143 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 176 },
                        new GearStat { Name = "Delay", Value = 600 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 167 },
                        new GearStat { Name = "Delay", Value = 600 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "DMG", Value = 107 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "QuickDrawDamage%", Value = 60 },
                        new GearStat { Name = "QuickDrawMagicAccuracy", Value = 60 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 101 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "QuickDrawDamage%", Value = 60 },
                        new GearStat { Name = "QuickDrawMagicAccuracy", Value = 60 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 53 },
                        new GearStat { Name = "Delay", Value = 600 },
                        new GearStat { Name = "TPBonus", Value = 1000 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 25 },
                        new GearStat { Name = "DMG", Value = 103 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 242 },
                        new GearStat { Name = "CritDamage", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 70 },
                        new GearStat { Name = "DMG", Value = 293 },
                        new GearStat { Name = "Delay", Value = 490 },
                        new GearStat { Name = "ArcherySkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "DMG", Value = 286 },
                        new GearStat { Name = "Delay", Value = 490 },
                        new GearStat { Name = "ArcherySkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 337 },
                        new GearStat { Name = "Delay", Value = 600 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "ArcherySkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 330 },
                        new GearStat { Name = "Delay", Value = 600 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "ArcherySkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 94 },
                        new GearStat { Name = "Delay", Value = 524 },
                        new GearStat { Name = "TPBonus", Value = 1000 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 155 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 143 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 181 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "BarrageRangedAccuracy", Value = 70 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 176 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "BarrageRangedAccuracy", Value = 70 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 111 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 37 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 242 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "DMG", Value = 271 },
                        new GearStat { Name = "Delay", Value = 540 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "ArcherySkill", Value = 255 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "DMG", Value = 286 },
                        new GearStat { Name = "Delay", Value = 540 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "ArcherySkill", Value = 255 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "DMG", Value = 288 },
                        new GearStat { Name = "Delay", Value = 540 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "ArcherySkill", Value = 255 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "DMG", Value = 290 },
                        new GearStat { Name = "Delay", Value = 540 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 70 },
                        new GearStat { Name = "ArcherySkill", Value = 255 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "DMG", Value = 292 },
                        new GearStat { Name = "Delay", Value = 540 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 75 },
                        new GearStat { Name = "ArcherySkill", Value = 255 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 115 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 120 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 121 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 123 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 70 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 124 },
                        new GearStat { Name = "Delay", Value = 432 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 75 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MarksmanshipSkill", Value = 277 },
                        new GearStat { Name = "DMG", Value = 162 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 277 },
                        new GearStat { Name = "CritRate", Value = 15 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MarksmanshipSkill", Value = 269 },
                        new GearStat { Name = "DMG", Value = 151 },
                        new GearStat { Name = "Delay", Value = 582 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 269 },
                        new GearStat { Name = "CritRate", Value = 12 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "ArcherySkill", Value = 277 },
                        new GearStat { Name = "DMG", Value = 324 },
                        new GearStat { Name = "Delay", Value = 524 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "ArcherySkill", Value = 269 },
                        new GearStat { Name = "DMG", Value = 309 },
                        new GearStat { Name = "Delay", Value = 524 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "MagicAccuracy Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 }
                    }
                }
            };
        }
    }
}
