using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Main3SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Tishtrya R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 193 },
                        new GearStat { Name = "Delay", Value = 264 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "Club Skill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Tishtrya",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 185 },
                        new GearStat { Name = "Delay", Value = 264 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "Club Skill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Sindri R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 175 },
                        new GearStat { Name = "Delay", Value = 324 },
                        new GearStat { Name = "Accuracy", Value = 77 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "Int", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 6 },
                        new GearStat { Name = "MagicDamage", Value = 90 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Club Skill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" } }
                },
                new GearItem
                {
                    Name = "Chango R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Chango",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Ukonvasara R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 70 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 352 },
                        new GearStat { Name = "Delay", Value = 482 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Ukonvasara",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 50 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "DMG", Value = 340 },
                        new GearStat { Name = "Delay", Value = 482 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Conqueror R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 347 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Conqueror",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 315 },
                        new GearStat { Name = "Delay", Value = 504 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bravura R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 364 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "DADamage%", Value = 20 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Bravura",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 344 },
                        new GearStat { Name = "Delay", Value = 488 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "DADamage%", Value = 20 },
                        new GearStat { Name = "GreatAxeSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Dolichenus",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 200 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 16 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Axe Skill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Laevateinn R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Laevateinn",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" } }
                },
                new GearItem
                {
                    Name = "Khatvanga R15",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Khatvanga",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Hvergelmir R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 285 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Hvergelmir",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 275 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Claustrum R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 291 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" } }
                },
                new GearItem
                {
                    Name = "Claustrum",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 275 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "smn" } }
                },
                new GearItem
                {
                    Name = "Nirvana R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "smn" } }
                },
                new GearItem
                {
                    Name = "Nirvana",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "smn" } }
                },
                new GearItem
                {
                    Name = "Tizona R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 165 },
                        new GearStat { Name = "Delay", Value = 236 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "SwordSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
                },
                new GearItem
                {
                    Name = "Tizona",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 147 },
                        new GearStat { Name = "Delay", Value = 236 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "SwordSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blu" } }
                },
                new GearItem
                {
                    Name = "Terpsichore R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 144 },
                        new GearStat { Name = "Delay", Value = 205 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Terpsichore",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 128 },
                        new GearStat { Name = "Delay", Value = 205 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Tupsimati R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 277 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Tupsimati",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 251 },
                        new GearStat { Name = "Delay", Value = 402 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 279 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Staff Skill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sch" } }
                },
                new GearItem
                {
                    Name = "Carnwenhan R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 130 },
                        new GearStat { Name = "Delay", Value = 186 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Carnwenhan",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 116 },
                        new GearStat { Name = "Delay", Value = 186 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "brd" } }
                },
                new GearItem
                {
                    Name = "Aeneas R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 146 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Aeneas",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 140 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Kustawi +1 R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 22 },
                        new GearStat { Name = "DMG", Value = 114 },
                        new GearStat { Name = "Delay", Value = 189 },
                        new GearStat { Name = "RangedAccuracy", Value = 65 },
                        new GearStat { Name = "RangedAttack", Value = 36 },
                        new GearStat { Name = "Dagger Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Twashtar R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 70 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "DMG", Value = 128 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Twashtar",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "DMG", Value = 124 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Twashtar R15 (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "DMG", Value = 128 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Twashtar (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "DMG", Value = 124 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Centovente",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 42 },
                        new GearStat { Name = "Delay", Value = 186 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "Dagger Skill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Malignance Pole",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -20 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "DMG", Value = 286 },
                        new GearStat { Name = "Delay", Value = 412 },
                        new GearStat { Name = "Staff Skill", Value = 255 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 215 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Gozuki Mezuki",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 266 },
                        new GearStat { Name = "Delay", Value = 412 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Staff Skill", Value = 242 },
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
                    Name = "Mafic Cudgel",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDT", Value = -10 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Int", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 6 },
                        new GearStat { Name = "DMG", Value = 142 },
                        new GearStat { Name = "Delay", Value = 278 },
                        new GearStat { Name = "Accuracy", Value = 27 },
                        new GearStat { Name = "Club Skill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 }
                    },
                    GearItemJobs = new List<GearItemJob> { }
                },
                new GearItem
                {
                    Name = "Drepanum",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" } }
                },
                new GearItem
                {
                    Name = "Xoanon",
                    Slot = "Main",
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
                        new GearStat { Name = "Staff Skill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "smn" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Vajra R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 140 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                },
                new GearItem
                {
                    Name = "Vajra",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 125 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "thf" } }
                },
                new GearItem
                {
                    Name = "Karambit",
                    Slot = "Main",
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
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Godhands R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 221 },
                        new GearStat { Name = "Delay", Value = 138 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Godhands",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 197 },
                        new GearStat { Name = "Delay", Value = 138 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "pup" } }
                },
                new GearItem
                {
                    Name = "Glanzfaust R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 199 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                },
                new GearItem
                {
                    Name = "Glanzfaust",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 170 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "mnk" } }
                }
            };
        }
    }
}
