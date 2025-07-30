using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Main4SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Verethragna R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 70 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 178 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Verethragna",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "DMG", Value = 158 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Spharai R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 206 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Spharai",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 182 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Agwu's Axe R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "DMG", Value = 192 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Agwu's Axe R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "DMG", Value = 202 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Agwu's Axe R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "DMG", Value = 204 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Agwu's Axe R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "DMG", Value = 205 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Agwu's Axe R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "DMG", Value = 212 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R0",
                    Slot = "Main",
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
                        new GearStat { Name = "Great SwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R15",
                    Slot = "Main",
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
                        new GearStat { Name = "Great SwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R20",
                    Slot = "Main",
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
                        new GearStat { Name = "Great SwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R25",
                    Slot = "Main",
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
                        new GearStat { Name = "Great SwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Agwu's Claymore R30",
                    Slot = "Main",
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
                        new GearStat { Name = "Great SwordSkill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R0",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R20",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R25",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Agwu's Scythe R30",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R0",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R20",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R25",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Chopper R30",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Gekkei R0",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Gekkei R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Gekkei R20",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Gekkei R25",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Gekkei R30",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Axe R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 192 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "TPBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Axe R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 202 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "TPBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Axe R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 204 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "TPBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Axe R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 205 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "TPBonus", Value = 300 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Axe R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 207 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Axe Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "TPBonus", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R0",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R20",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R25",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Lance R30",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R0",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R15",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R20",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R25",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Staff R30",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 165 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 180 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 182 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 183 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Fists R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "DMG", Value = 185 },
                        new GearStat { Name = "Delay", Value = 96 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Sword R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 160 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "SwordSkill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "blu" } }
                }
            };
        }
    }
}
