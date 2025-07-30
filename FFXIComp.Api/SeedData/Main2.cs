using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Main2SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Shining One",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Tauret",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 125 },
                        new GearStat { Name = "Delay", Value = 180 },
                        new GearStat { Name = "DaggerSkill", Value = 250 },
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Ternion Dagger +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 27 },
                        new GearStat { Name = "DMG", Value = 117 },
                        new GearStat { Name = "Delay", Value = 175 },
                        new GearStat { Name = "Accuracy", Value = 67 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "DaggerSkill", Value = 228 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "Agi", Value = 14 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Tsuru R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "KatanaSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "Daken", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Tsuru R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "KatanaSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "Daken", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Tsuru R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "KatanaSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "Daken", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Tsuru R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "KatanaSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 35 },
                        new GearStat { Name = "Daken", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Tsuru R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 190 },
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "KatanaSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 40 },
                        new GearStat { Name = "Daken", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "MalevolenceA",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 94 },
                        new GearStat { Name = "Delay", Value = 201 },
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 },
                        new GearStat { Name = "MagicAttack", Value = 44 },
                        new GearStat { Name = "MagicDamage", Value = 118 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 201 },
                        new GearStat { Name = "DaggerSkill", Value = 242 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "MalevolenceB",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 94 },
                        new GearStat { Name = "Delay", Value = 201 },
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 35 },
                        new GearStat { Name = "MagicAttack", Value = 44 },
                        new GearStat { Name = "MagicDamage", Value = 118 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 201 },
                        new GearStat { Name = "DaggerSkill", Value = 242 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Marin Staff +1 R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Maxentius",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 15 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 21 },
                        new GearStat { Name = "MagicDamage", Value = 232 },
                        new GearStat { Name = "ClubSkill", Value = 250 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 250 },
                        new GearStat { Name = "DMG", Value = 200 },
                        new GearStat { Name = "Delay", Value = 288 },
                        new GearStat { Name = "MagicBurstDamage", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Rod R0",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 152 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Rod R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 152 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 40 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Rod R20",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 153 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 45 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Rod R25",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 154 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Rod R30",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "DMG", Value = 155 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 248 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 55 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Almace R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Dex", Value = 70 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Almace R15 (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 163 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Almace",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 158 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Almace (sub)",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 158 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Excalibur R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 173 },
                        new GearStat { Name = "Delay", Value = 233 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Excalibur",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 164 },
                        new GearStat { Name = "Delay", Value = 233 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sequence R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 176 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sequence",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 168 },
                        new GearStat { Name = "Delay", Value = 240 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 0 },
                        new GearStat { Name = "TPBonus", Value = 500 },
                        new GearStat { Name = "MagicDamage", Value = 186 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Murgleis R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 157 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "SwordSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Murgleis",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 140 },
                        new GearStat { Name = "Delay", Value = 224 },
                        new GearStat { Name = "Accuracy", Value = 0 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "SwordSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Thibron",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 55 },
                        new GearStat { Name = "Delay", Value = 238 },
                        new GearStat { Name = "TPBonus", Value = 1000 },
                        new GearStat { Name = "SwordSkill", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Gungnir R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 367 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Gungnir",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 347 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Trishula R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Trishula",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Ryunohige R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Ryunohige",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Rhongomiant R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Rhongomiant",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 347 },
                        new GearStat { Name = "Delay", Value = 492 },
                        new GearStat { Name = "Vit", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 155 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 },
                        new GearStat { Name = "PolearmSkill", Value = 269 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Loxotic Mace +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 223 },
                        new GearStat { Name = "Delay", Value = 334 },
                        new GearStat { Name = "ClubSkill", Value = 242 },
                        new GearStat { Name = "Accuracy", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 21 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "Dex", Value = 9 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Mandau R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 131 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "TA Damage%", Value = 10 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "DaggerSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Mandau",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 124 },
                        new GearStat { Name = "Delay", Value = 176 },
                        new GearStat { Name = "TA Damage%", Value = 10 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "DaggerSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 228 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Nandaka",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Montante +1 R15",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Akademos R15C",
                    Slot = "Main",
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
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Crocea Mors R25C",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 187 },
                        new GearStat { Name = "Delay", Value = 260 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "SwordSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "Elemental WS Damage%", Value = 100 },
                        new GearStat { Name = "EnSpell Damage%", Value = 500 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Pukulatmuj +1 R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 152 },
                        new GearStat { Name = "Delay", Value = 225 },
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "SwordSkill", Value = 242 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 188 },
                        new GearStat { Name = "EnSpell Damage%", Value = 150 },
                        new GearStat { Name = "EnSpell Damage", Value = 11 },
                        new GearStat { Name = "Int", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Daybreak",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "DMG", Value = 150 },
                        new GearStat { Name = "Delay", Value = 216 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 242 },
                        new GearStat { Name = "MagicDamage", Value = 241 },
                        new GearStat { Name = "ClubSkill", Value = 228 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Light Elemental Bonus", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Mjollnir R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 229 },
                        new GearStat { Name = "Delay", Value = 308 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Mjollnir",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 217 },
                        new GearStat { Name = "Delay", Value = 308 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Yagrush R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 184 },
                        new GearStat { Name = "Delay", Value = 267 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "Accuracy", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Yagrush",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 167 },
                        new GearStat { Name = "Delay", Value = 267 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 },
                        new GearStat { Name = "Accuracy", Value = 0 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Gambanteinn R15",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 219 },
                        new GearStat { Name = "Delay", Value = 300 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Gambanteinn",
                    Slot = "Main",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DMG", Value = 212 },
                        new GearStat { Name = "Delay", Value = 300 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "MagicDamage", Value = 217 },
                        new GearStat { Name = "ClubSkill", Value = 269 },
                        new GearStat { Name = "MagicAccuracySkill", Value = 255 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                }
            };
        }
    }
}
