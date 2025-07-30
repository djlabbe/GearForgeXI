using FFXIComp.Api.Models;
using System.Collections.Generic;

namespace FFXIComp.Api.SeedData
{
    public static class Main6SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Fernagu",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 63 },
                        new GearStat { Name = "Delay", Value = 268 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "Axe Skill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Ukaldi",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 65 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "Club Skill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Sangarius +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 193 },
                        new GearStat { Name = "Delay", Value = 281 },
                        new GearStat { Name = "Attack", Value = 26 },
                        new GearStat { Name = "SwordSkill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "QA", Value = 3 },
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Onion Sword III",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 165 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> {}
                },
                new GearItem
                {
                    Name = "Hepatizon Baghnakhs",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 159 },
                        new GearStat { Name = "Delay", Value = 81 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Hepatizon Sapara",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 155 },
                        new GearStat { Name = "Delay", Value = 230 },
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Hepatizon Rapier",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 147 },
                        new GearStat { Name = "Delay", Value = 218 },
                        new GearStat { Name = "Str", Value = 8 },
                        new GearStat { Name = "Mnd", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 22 },
                        new GearStat { Name = "MagicAttack", Value = 14 },
                        new GearStat { Name = "MagicDamage", Value = 108 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 201 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Exalted Spear",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 259 },
                        new GearStat { Name = "Delay", Value = 385 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "PolearmSkill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Maliya Sickle",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Beryllium Kris",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 126 },
                        new GearStat { Name = "Delay", Value = 187 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Agi", Value = 12 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Dagger Skill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Beryllium Pick",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 204 },
                        new GearStat { Name = "Delay", Value = 303 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 32 },
                        new GearStat { Name = "Axe Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Beryllium Tachi",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Beryllium Sword",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 290 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Great SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Weapon Skill Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Lycurgos",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Zantetsuken",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 167 },
                        new GearStat { Name = "Delay", Value = 236 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 27 },
                        new GearStat { Name = "Attack", Value = 33 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "QA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Tanmogayi +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 188 },
                        new GearStat { Name = "Delay", Value = 280 },
                        new GearStat { Name = "Accuracy", Value = 76 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "Attack", Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Aizkora +1 R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Sandung R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 102 },
                        new GearStat { Name = "Delay", Value = 200 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 22 },
                        new GearStat { Name = "Dagger Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "TA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Polyhymnia R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 95 },
                        new GearStat { Name = "Delay", Value = 194 },
                        new GearStat { Name = "Regain", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 22 },
                        new GearStat { Name = "Dagger Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "Attack", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Aettir R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 263 },
                        new GearStat { Name = "Delay", Value = 480 },
                        new GearStat { Name = "Great SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "PDT2", Value = -5 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "MagicEvasion", Value = 50 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Comeuppances +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 79 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 81 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Subtle Blow", Value = 12 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Demersal Degen +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 110 },
                        new GearStat { Name = "Delay", Value = 218 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "OA2", Value = 45 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "EnSpell Damage%", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Jugo Kukri +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 95 },
                        new GearStat { Name = "Delay", Value = 142 },
                        new GearStat { Name = "Evasion", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 61 },
                        new GearStat { Name = "Dagger Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "Agi", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Reikiko",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 164 },
                        new GearStat { Name = "Delay", Value = 268 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Regain", Value = 30 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Perfervid Sword",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 110 },
                        new GearStat { Name = "Delay", Value = 236 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Fire Elemental Bonus", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Levante Dagger",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 95 },
                        new GearStat { Name = "Delay", Value = 183 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Dagger Skill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Accuracy", Value = 27 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Evasion", Value = 27 },
                        new GearStat { Name = "Wind Elemental Bonus", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Pixquizpan",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Barbarity",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 189 },
                        new GearStat { Name = "Delay", Value = 280 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "Axe Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Izcalli",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 209 },
                        new GearStat { Name = "Delay", Value = 324 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 41 },
                        new GearStat { Name = "MagicAttack", Value = 12 },
                        new GearStat { Name = "MagicDamage", Value = 93 },
                        new GearStat { Name = "Club Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 201 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Magesmasher +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 220 },
                        new GearStat { Name = "Delay", Value = 315 },
                        new GearStat { Name = "Int", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Attack", Value = 24 },
                        new GearStat { Name = "MagicDamage", Value = 110 },
                        new GearStat { Name = "Club Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Air Knife",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 103 },
                        new GearStat { Name = "Delay", Value = 150 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Evasion", Value = 40 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "GearHaste", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Dragon Fangs",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 188 },
                        new GearStat { Name = "Delay", Value = 126 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Flametongue",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 187 },
                        new GearStat { Name = "Delay", Value = 264 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Yagyu Darkblade",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 156 },
                        new GearStat { Name = "Delay", Value = 227 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Wizard Rod",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 149 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "Club Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Ice Brand",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 187 },
                        new GearStat { Name = "Delay", Value = 264 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Varga Purnikawa V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 213 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "CritRate", Value = 15 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Varga Purnikawa IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 202 },
                        new GearStat { Name = "Delay", Value = 116 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "CritRate", Value = 12 },
                        new GearStat { Name = "Hand-to-Hand Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpu Gandring V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 137 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "TA", Value = 6 },
                        new GearStat { Name = "Dagger Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Mpu Gandring IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 130 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "Dagger Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Caliburnus V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 181 },
                        new GearStat { Name = "Delay", Value = 233 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "SwordSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Caliburnus IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 172 },
                        new GearStat { Name = "Delay", Value = 233 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Helheim V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 336 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "Great SwordSkill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Helheim IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 318 },
                        new GearStat { Name = "Delay", Value = 431 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "Great SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Spalirisos V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 218 },
                        new GearStat { Name = "Delay", Value = 280 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "CritRate", Value = 15 },
                        new GearStat { Name = "Axe Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Spalirisos IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 207 },
                        new GearStat { Name = "Delay", Value = 280 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "CritRate", Value = 12 },
                        new GearStat { Name = "Axe Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Laphria V",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Laphria IV",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Foenaria V",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Foenaria IV",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Gae Buide V",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Gae Buide IV",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Dokoku V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "Katana Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Dokoku IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 155 },
                        new GearStat { Name = "Delay", Value = 210 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "Katana Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Kusanagi-no-Tsurugi V",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Kusanagi-no-Tsurugi IV",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Long Mor V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 240 },
                        new GearStat { Name = "Delay", Value = 308 },
                        new GearStat { Name = "Str", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 263 },
                        new GearStat { Name = "Club Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Long Mor IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 227 },
                        new GearStat { Name = "Delay", Value = 308 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "Club Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Opashoro V",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 304 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "MagicAttack", Value = 80 },
                        new GearStat { Name = "MagicDamage", Value = 325 },
                        new GearStat { Name = "Staff Skill", Value = 277 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 277 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Opashoro IV",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 288 },
                        new GearStat { Name = "Delay", Value = 390 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "MagicAttack", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 310 },
                        new GearStat { Name = "Staff Skill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 269 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Odium",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 113 },
                        new GearStat { Name = "Delay", Value = 208 },
                        new GearStat { Name = "Str", Value = 13 },
                        new GearStat { Name = "Dex", Value = 13 },
                        new GearStat { Name = "Vit", Value = 13 },
                        new GearStat { Name = "Agi", Value = 13 },
                        new GearStat { Name = "Int", Value = 13 },
                        new GearStat { Name = "Mnd", Value = 13 },
                        new GearStat { Name = "Chr", Value = 13 },
                        new GearStat { Name = "Accuracy", Value = 13 },
                        new GearStat { Name = "Attack", Value = 13 },
                        new GearStat { Name = "Evasion", Value = 13 },
                        new GearStat { Name = "Dagger Skill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "MagicEvasion", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" } }
                }
            };
        }
    }
}
