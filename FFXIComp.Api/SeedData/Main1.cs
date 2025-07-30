using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Main1SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Amanomurakumo R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 326 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "SkillchainBonus", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Amanomurakumo",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 308 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "SkillchainBonus", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Anguta R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Anguta",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Apocalypse R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 383 },
                        new GearStat { Name = "Delay", Value = 513 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 60 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Apocalypse",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 362 },
                        new GearStat { Name = "Delay", Value = 513 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Scythe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 60 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Caladbolg R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 314 },
                        new GearStat { Name = "Delay", Value = 430 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Great SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Vit", Value = 70 },
                        new GearStat { Name = "Str", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "pld" } }
                },
                new GearItem
                {
                    Name = "Caladbolg",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 303 },
                        new GearStat { Name = "Delay", Value = 430 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Great SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Vit", Value = 50 },
                        new GearStat { Name = "Str", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "pld" } }
                },
                new GearItem
                {
                    Name = "Crepuscular Knife",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 133 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Dagger Skill", Value = 248 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "QA", Value = 5 },
                        new GearStat { Name = "WSC_CHR", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Dojikiri Yasutsuna R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Dojikiri Yasutsuna",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Gleti's Knife R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 2 },

                        new GearStat { Name = "DMG", Value = 133 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 20 },
                        new GearStat { Name = "Dagger Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "SubtleBlowII", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Gleti's Knife R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 2 },

                        new GearStat { Name = "DMG", Value = 141 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 20 },
                        new GearStat { Name = "Dagger Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "SubtleBlowII", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Gleti's Knife R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 2 },

                        new GearStat { Name = "DMG", Value = 142 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "Evasion", Value = 20 },
                        new GearStat { Name = "Dagger Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "SubtleBlowII", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Gleti's Knife R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 2 },

                        new GearStat { Name = "DMG", Value = 143 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Evasion", Value = 20 },
                        new GearStat { Name = "Dagger Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Gleti's Knife R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 2 },

                        new GearStat { Name = "DMG", Value = 144 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "Evasion", Value = 20 },
                        new GearStat { Name = "Dagger Skill", Value = 255 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "SubtleBlowII", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "rng" } }
                },
                new GearItem
                {
                    Name = "Gokotai",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 157 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Katana Skill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 16 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hachimonji",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Heishi Shorinken R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 166 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Heishi Shorinken",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 159 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hitaki",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 49 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "Katana Skill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Hitaki2",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 49 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "Katana Skill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kannagi R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 153 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Agi", Value = 70 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kannagi",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 148 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Agi", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kannagi R15 (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 153 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Agi", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kannagi (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 148 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "Dex", Value = 0 },
                        new GearStat { Name = "Agi", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kikoku R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 156 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kikoku",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 148 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kogarasumaru R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 310 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Kogarasumaru",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 281 },
                        new GearStat { Name = "Delay", Value = 450 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Kraken Club",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 11 },
                        new GearStat { Name = "Delay", Value = 264 },
                        new GearStat { Name = "OA2", Value = 15 },
                        new GearStat { Name = "OA3", Value = 25 },
                        new GearStat { Name = "OA4", Value = 25 },
                        new GearStat { Name = "OA5", Value = 15 },
                        new GearStat { Name = "OA6", Value = 10 },
                        new GearStat { Name = "OA7", Value = 3 },
                        new GearStat { Name = "OA8", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "smn" } }
                },
                new GearItem
                {
                    Name = "Kunimitsu R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 151 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 248 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Daken", Value = 0 },
                        new GearStat { Name = "Evasion", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kunimitsu R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 159 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 248 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Daken", Value = 0 },
                        new GearStat { Name = "Evasion", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kunimitsu R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 160 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 248 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Daken", Value = 0 },
                        new GearStat { Name = "Evasion", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kunimitsu R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 162 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 248 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Daken", Value = 3 },
                        new GearStat { Name = "Evasion", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Kunimitsu R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 75 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 248 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Daken", Value = 5 },
                        new GearStat { Name = "Evasion", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Liberator R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Liberator",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Masamune R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 319 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Str", Value = 70 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Masamune",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 308 },
                        new GearStat { Name = "Delay", Value = 437 },
                        new GearStat { Name = "Great Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Str", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "sam" } }
                },
                new GearItem
                {
                    Name = "Naegling",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 166 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "SwordSkill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "Dex", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 16 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Nagi R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 156 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Nagi",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 142 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 186 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" } }
                },
                new GearItem
                {
                    Name = "Ragnarok R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 321 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Great SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Crit Damage", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Ragnarok",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {

                        new GearStat { Name = "DMG", Value = 304 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "Great SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Crit Damage", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "war" } }
                },
                new GearItem
                {
                    Name = "Redemption R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                },
                new GearItem
                {
                    Name = "Redemption",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" } }
                }
            };
        }
    }
}
