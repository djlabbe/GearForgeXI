using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 180 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "HandToHandSkill", Value = 250 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 221 },
                        new GearStat { Name = "Delay", Value = 138 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 197 },
                        new GearStat { Name = "Delay", Value = 138 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 199 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 170 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 70 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 178 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "DMG", Value = 158 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 206 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 182 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 165 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "HandToHandSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 180 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "HandToHandSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 182 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "HandToHandSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 183 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "HandToHandSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 5 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 185 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "HandToHandSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 168 },
                        new GearStat { Name = "Delay", Value = 79 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "MartialArts", Value = 55 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 144 },
                        new GearStat { Name = "Delay", Value = 79 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "MartialArts", Value = 55 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 204 },
                        new GearStat { Name = "Delay", Value = 121 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 204 },
                        new GearStat { Name = "Delay", Value = 121 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 159 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "HandToHandSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 79 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 81 },
                        new GearStat { Name = "HandToHandSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "SubtleBlow", Value = 12 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 188 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 213 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "CritRate", Value = 15 },
                        new GearStat { Name = "HandToHandSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
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
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 202 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "CritRate", Value = 12 },
                        new GearStat { Name = "HandToHandSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
            };
        }
    }
}