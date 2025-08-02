using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData;

public static class Main2H
{
    public static List<GearItem> GetItems()
    {
        return new List<GearItem>
        {
            new GearItem
            {
            Name = "Amanomurakumo R15",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 326 },
                new GearStat { Name = "Delay", Value = 437 },
                new GearStat { Name = "Accuracy", Value = 60 },
                new GearStat { Name = "Great Katana Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                new GearStat { Name = "SkillchainBonus", Value = 5 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 12 } }
            },
            new GearItem
            {
            Name = "Amanomurakumo",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 308 },
                new GearStat { Name = "Delay", Value = 437 },
                new GearStat { Name = "Accuracy", Value = 60 },
                new GearStat { Name = "Great Katana Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                new GearStat { Name = "SkillchainBonus", Value = 0 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 12 } }
            },
            new GearItem
            {
            Name = "Anguta R15",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 387 },
                new GearStat { Name = "Delay", Value = 528 },
                new GearStat { Name = "MagicDamage", Value = 186 },
                new GearStat { Name = "Scythe Skill", Value = 269 },
                new GearStat { Name = "TPBonus", Value = 500 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Accuracy", Value = 30 },
                new GearStat { Name = "MagicAccuracy", Value = 30 },
                new GearStat { Name = "StoreTP", Value = 10 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 } }
            },
            new GearItem
            {
            Name = "Anguta",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 370 },
                new GearStat { Name = "Delay", Value = 528 },
                new GearStat { Name = "MagicDamage", Value = 186 },
                new GearStat { Name = "Scythe Skill", Value = 269 },
                new GearStat { Name = "TPBonus", Value = 500 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Accuracy", Value = 0 },
                new GearStat { Name = "MagicAccuracy", Value = 0 },
                new GearStat { Name = "StoreTP", Value = 10 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 } }
            },
            new GearItem
            {
            Name = "Apocalypse R15",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 383 },
                new GearStat { Name = "Delay", Value = 513 },
                new GearStat { Name = "MagicDamage", Value = 217 },
                new GearStat { Name = "Scythe Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Accuracy", Value = 60 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 } }
            },
            new GearItem
            {
            Name = "Apocalypse",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 362 },
                new GearStat { Name = "Delay", Value = 513 },
                new GearStat { Name = "MagicDamage", Value = 217 },
                new GearStat { Name = "Scythe Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Accuracy", Value = 60 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 } }
            },
            new GearItem
            {
            Name = "Caladbolg R15",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 314 },
                new GearStat { Name = "Delay", Value = 430 },
                new GearStat { Name = "MagicDamage", Value = 155 },
                new GearStat { Name = "GreatSwordSkill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Vit", Value = 70 },
                new GearStat { Name = "Str", Value = 20 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 }, new GearItemJob { JobId = 7 } }
            },
            new GearItem
            {
            Name = "Caladbolg",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 303 },
                new GearStat { Name = "Delay", Value = 430 },
                new GearStat { Name = "MagicDamage", Value = 155 },
                new GearStat { Name = "GreatSwordSkill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                new GearStat { Name = "Vit", Value = 50 },
                new GearStat { Name = "Str", Value = 0 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 8 }, new GearItemJob { JobId = 7 } }
            },
            new GearItem
            {
            Name = "Crepuscular Knife",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 133 },
                new GearStat { Name = "Delay", Value = 190 },
                new GearStat { Name = "Dex", Value = 15 },
                new GearStat { Name = "Agi", Value = 15 },
                new GearStat { Name = "Chr", Value = 15 },
                new GearStat { Name = "Accuracy", Value = 40 },
                new GearStat { Name = "MagicAccuracy", Value = 40 },
                new GearStat { Name = "DaggerSkill", Value = 248 },
                new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                new GearStat { Name = "QA", Value = 5 },
                new GearStat { Name = "WSC_CHR", Value = 3 }
            },
            GearItemJobs = new List<GearItemJob>
            {
                new GearItemJob { JobId = 13 },
                new GearItemJob { JobId = 5 },
                new GearItemJob { JobId = 1 },
                new GearItemJob { JobId = 6 },
                new GearItemJob { JobId = 19 },
                new GearItemJob { JobId = 17 },
                new GearItemJob { JobId = 10 },
                new GearItemJob { JobId = 9 },
                new GearItemJob { JobId = 11 }
            }
            },
            new GearItem
            {
            Name = "Dojikiri Yasutsuna R15",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 330 },
                new GearStat { Name = "Delay", Value = 450 },
                new GearStat { Name = "StoreTP", Value = 10 },
                new GearStat { Name = "Accuracy", Value = 30 },
                new GearStat { Name = "MagicAccuracy", Value = 30 },
                new GearStat { Name = "TPBonus", Value = 500 },
                new GearStat { Name = "Great Katana Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                new GearStat { Name = "MagicDamage", Value = 155 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 12 } }
            },
            new GearItem
            {
            Name = "Dojikiri Yasutsuna",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 315 },
                new GearStat { Name = "Delay", Value = 450 },
                new GearStat { Name = "StoreTP", Value = 10 },
                new GearStat { Name = "Accuracy", Value = 0 },
                new GearStat { Name = "MagicAccuracy", Value = 0 },
                new GearStat { Name = "TPBonus", Value = 500 },
                new GearStat { Name = "Great Katana Skill", Value = 269 },
                new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                new GearStat { Name = "MagicDamage", Value = 155 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 12 } }
            },
            new GearItem
            {
            Name = "Hachimonji",
            GearItemCategoryId = 2, // 2H category
            GearItemSlots = new List<GearItemSlot>
            {
                new GearItemSlot { GearSlotId = 1 }
            },
            GearStats = new List<GearStat>
            {
                new GearStat { Name = "DMG", Value = 318 },
                new GearStat { Name = "Delay", Value = 450 },
                new GearStat { Name = "Str", Value = 20 },
                new GearStat { Name = "Dex", Value = 20 },
                new GearStat { Name = "Vit", Value = 20 },
                new GearStat { Name = "Accuracy", Value = 40 },
                new GearStat { Name = "Attack", Value = 30 },
                new GearStat { Name = "MagicAccuracy", Value = 40 },
                new GearStat { Name = "Great Katana Skill", Value = 250 },
                new GearStat { Name = "MagicAccuracySkill", Value = 250 }
            },
            GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId = 13 }, new GearItemJob { JobId = 12 } }
            },
            new GearItem
                {
                    Name = "Kogarasumaru R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 310 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Kogarasumaru",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 281 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Liberator R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 364 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "MagicAccuracy", Value = 80 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Liberator",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 330 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Masamune R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 319 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Str", Value = 70 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Masamune",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 308 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Str", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Ragnarok R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 321 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Crit Damage", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Ragnarok",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 304 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Crit Damage", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Redemption R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 367 },
                        new GearStat { Name = "Delay", Value = 502 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Mnd", Value = 50 },
                        new GearStat { Name = "Int", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Redemption",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 354 },
                        new GearStat { Name = "Delay", Value = 502 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                 new GearItem
                {
                    Name = "Shining One",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 333 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 21 },
                        new GearStat { Name = "MagicDamage", Value = 226 },
                        new GearStat { Name = "PolearmSkill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Marin Staff +1 R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 68 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Wind Elemental Bonus", Value = 11 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "DMG", Value = 199 },
                        new GearStat { Name = "Delay", Value = 356 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Trishula R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 360 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Trishula",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 345 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ryunohige R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 339 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ryunohige",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 307 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Rhongomiant R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 359 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Vit", Value = 70 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Rhongomiant",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 347 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Vit", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Nandaka",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 333 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 21 },
                        new GearStat { Name = "MagicDamage", Value = 226 },
                        new GearStat { Name = "GreatSwordSkill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Montante +1 R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 319 },
                        new GearStat { Name = "Delay", Value = 475 },
                        new GearStat { Name = "GreatSwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 34 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Akademos R15C",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 198 },
                        new GearStat { Name = "Delay", Value = 366 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "MagicAccuracy", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 53 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Elemental Bonus", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Chango R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Chango",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 336 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Ukonvasara R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 70 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 482 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Ukonvasara",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 340 },
                        new GearStat { Name = "Delay", Value = 482 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Conqueror R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 347 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Conqueror",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 315 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bravura R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 364 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "DADamage%", Value = 20 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bravura",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 344 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "DADamage%", Value = 20 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Laevateinn R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Laevateinn",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Khatvanga R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 276 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Occult Acumen", Value = 30 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Khatvanga",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 268 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Occult Acumen", Value = 30 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Hvergelmir R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 285 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Hvergelmir",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 275 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Claustrum R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 291 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Claustrum",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 275 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Nirvana R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Nirvana",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Tupsimati R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Tupsimati",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "StaffSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Malignance Pole",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -20 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "DMG", Value = 286 },
                        new GearStat { Name = "Delay", Value = 412 },
                        new GearStat { Name = "StaffSkill", Value = 255 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 215 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Gozuki Mezuki",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 266 },
                        new GearStat { Name = "Delay", Value = 412 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Drepanum",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "DMG", Value = 366 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 21 },
                        new GearStat { Name = "MagicDamage", Value = 226 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "Scythe Skill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Xoanon",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "DMG", Value = 254 },
                        new GearStat { Name = "Delay", Value = 366 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 26 },
                        new GearStat { Name = "MagicDamage", Value = 241 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "StaffSkill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 20 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 320 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GreatSwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 20 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 335 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GreatSwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 20 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 340 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GreatSwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 20 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 343 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GreatSwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 20 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 346 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GreatSwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = 0 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Scythe Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = 0 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 367 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Scythe Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = 0 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 372 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Scythe Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 377 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Scythe Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "DMG", Value = 380 },
                        new GearStat { Name = "Delay", Value = 528 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Scythe Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "DMG", Value = 336 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GreatAxeSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "DMG", Value = 351 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GreatAxeSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "DMG", Value = 356 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GreatAxeSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "DMG", Value = 360 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GreatAxeSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "DMG", Value = 363 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GreatAxeSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Gekkei R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 300 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Great Katana Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Gekkei R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 315 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Great Katana Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Gekkei R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 319 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Great Katana Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Gekkei R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 321 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Great Katana Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Gekkei R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 324 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Great Katana Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                 new GearItem
                {
                    Name = "Ikenga's Lance R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DMG", Value = 328 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "PolearmSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DMG", Value = 343 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "PolearmSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DMG", Value = 348 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "PolearmSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DMG", Value = 351 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "PolearmSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DMG", Value = 354 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "PolearmSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R0",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 268 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 283 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R20",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 285 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 18 },
                        new GearStat { Name = "Mnd", Value = 18 },
                        new GearStat { Name = "DMG", Value = 287 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R30",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "DMG", Value = 289 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "StaffSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Lionheart R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Lionheart",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 336 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Epeolatry R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 344 },
                        new GearStat { Name = "Delay", Value = 489 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "PDT2", Value = -25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Epeolatry",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 305 },
                        new GearStat { Name = "Delay", Value = 489 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "PDT2", Value = -25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Morgelai R25",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 346 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "GreatSwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Labraunda R25C",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 489 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "CritRate", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Maliya Sickle",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 328 },
                        new GearStat { Name = "Delay", Value = 490 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "Scythe Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Beryllium Tachi",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 275 },
                        new GearStat { Name = "Delay", Value = 407 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Great Katana Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13} }
                },
                new GearItem
                {
                    Name = "Lycurgos",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 359 },
                        new GearStat { Name = "Delay", Value = 508 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GreatAxeSkill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "TPBonus", Value = 400 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Aizkora +1 R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 489 },
                        new GearStat { Name = "Attack", Value = 21 },
                        new GearStat { Name = "GreatAxeSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "MDT", Value = -4 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "QA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Aettir R15",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 263 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "GreatSwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "PDT2", Value = -5 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "MagicEvasion", Value = 50 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Pixquizpan",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 327 },
                        new GearStat { Name = "Delay", Value = 490 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Scythe Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 215 },
                        new GearStat { Name = "Accuracy", Value = 66 },
                        new GearStat { Name = "MagicAccuracy", Value = 66 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "MagicAttack", Value = 72 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Laphria V",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 380 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "DA", Value = 10 },
                        new GearStat { Name = "GreatAxeSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Laphria IV",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 361 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Foenaria V",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 400 },
                        new GearStat { Name = "Delay", Value = 513 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "Scythe Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Foenaria IV",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 379 },
                        new GearStat { Name = "Delay", Value = 513 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "Scythe Skill", Value = 260 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Gae Buide V",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 383 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "DA", Value = 10 },
                        new GearStat { Name = "PolearmSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Gae Buide IV",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 364 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "PolearmSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                 new GearItem
                {
                    Name = "Kusanagi-no-Tsurugi V",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 340 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "DA", Value = 10 },
                        new GearStat { Name = "Great Katana Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Kusanagi-no-Tsurugi IV",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 323 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Opashoro V",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 304 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "MagicAttack", Value = 80 },
                        new GearStat { Name = "MagicDamage", Value = 325 },
                        new GearStat { Name = "StaffSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Opashoro IV",
                    GearItemCategoryId = 2, // 2H category
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 1 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 288 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 310 },
                        new GearStat { Name = "StaffSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 20} }
                },
        };
    }
}