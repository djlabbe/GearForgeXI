using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Feet2SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Agoge Calligae +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 28 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Agoge Calligae +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 32 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 140 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "KickAttacksDMG", Value = 120 },
                        new GearStat { Name = "KickAttacks", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Anchorite's Gaiters +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 134 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "KickAttacksDMG", Value = 120 },
                        new GearStat { Name = "KickAttacks", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Ankusa Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Ankusa Gaiters +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "PetEvasion", Value = 38 },
                        new GearStat { Name = "PetPDT", Value = -5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Arcadian Socks +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 36 },
                        new GearStat { Name = "RangedAttack", Value = 81 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Arcadian Socks +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 51 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 41 },
                        new GearStat { Name = "RangedAttack", Value = 91 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Archmage's Sabots +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 75 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "MagicAttack", Value = 54 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 17 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Archmage's Sabots +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "MagicAccuracy", Value = 47 },
                        new GearStat { Name = "MagicAttack", Value = 57 },
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 167 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 18 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Bihu Slippers +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 48 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Bihu Slippers +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 50 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 103 },
                        new GearStat { Name = "MagicEvasion", Value = 167 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDT", Value = -5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Brioso Slippers +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 48 },
                        new GearStat { Name = "MagicAccuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Brioso Slippers +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 50 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 118 },
                        new GearStat { Name = "MagicEvasion", Value = 152 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Futhark Boots +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Futhark Boots +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Hachiya Kyahan +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hachiya Kyahan +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 25 },
                        new GearStat { Name = "Evasion", Value = 139 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Hesychast's Gaiters +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Horos Toe Shoes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Horos Toe Shoes +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 130 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Bottes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 33 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "QuickDrawDamage", Value = 20 },
                        new GearStat { Name = "QuickDrawMagicAccuracy", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Laksamana's Bottes +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 54 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "RangedAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "Evasion", Value = 132 },
                        new GearStat { Name = "MagicEvasion", Value = 114 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "QuickDrawDamage", Value = 20 },
                        new GearStat { Name = "QuickDrawMagicAccuracy", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Lanun Bottes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 19 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "RangedAttack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Lanun Bottes +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "RangedAttack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "PDT", Value = -6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Charuqs +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Luhlaza Charuqs +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 96 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Maxixi Toe Shoes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Maxixi Toe Shoes +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 142 },
                        new GearStat { Name = "MagicEvasion", Value = 114 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Kyahan +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "Attack", Value = 76 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "NinjutsuSkill", Value = 23 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "NinjutsuDamagePercent", Value = 25 },
                        new GearStat { Name = "NinjutsuMagicAttack", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Mochizuki Kyahan +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 86 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "NinjutsuSkill", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "NinjutsuDamagePercent", Value = 25 },
                        new GearStat { Name = "NinjutsuMagicAttack", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Piety Duckbills +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 75 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 27 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Piety Duckbills +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 167 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Pillager's Poulaines +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 99 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pillager's Poulaines +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "RangedAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "Evasion", Value = 142 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pitre Babouches +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 19 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "Evasion", Value = 89 },
                        new GearStat { Name = "MagicEvasion", Value = 84 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 43 },
                        new GearStat { Name = "Pet:MagicAttack", Value = 57 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Pitre Babouches +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 124 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:Accuracy", Value = 48 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 48 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 48 },
                        new GearStat { Name = "Pet:MagicAttack", Value = 60 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Poulaines +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 61 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 5 },
                        new GearStat { Name = "TADamagePercent", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Plunderer's Poulaines +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 27 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 71 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 117 },
                        new GearStat { Name = "MagicEvasion", Value = 129 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 5 },
                        new GearStat { Name = "TADamagePercent", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Greaves +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 95 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "Attack", Value = 73 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Pteroslaver Greaves +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 83 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 135 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Pummeler's Calligae +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 100 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Pummeler's Calligae +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Mnd", Value = 24 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Sakonji Sune-Ate +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 95 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "Attack", Value = 84 },
                        new GearStat { Name = "MagicAccuracy", Value = 36 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Sakonji Sune-Ate +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 36 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "Attack", Value = 94 },
                        new GearStat { Name = "MagicAccuracy", Value = 41 },
                        new GearStat { Name = "Evasion", Value = 97 },
                        new GearStat { Name = "MagicEvasion", Value = 135 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Sabots +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 75 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "MagicAccuracy", Value = 54 },
                        new GearStat { Name = "MagicDamage", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 26 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Spaekona's Sabots +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 64 },
                        new GearStat { Name = "MagicAccuracy", Value = 64 },
                        new GearStat { Name = "MagicAttack", Value = 28 },
                        new GearStat { Name = "MagicDamage", Value = 42 },
                        new GearStat { Name = "Evasion", Value = 115 },
                        new GearStat { Name = "MagicEvasion", Value = 152 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Totemic Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 89 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Totemic Gaiters +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 132 },
                        new GearStat { Name = "MagicEvasion", Value = 114 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "Pet:Accuracy", Value = 56 },
                        new GearStat { Name = "PetAttack", Value = 35 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 56 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Vishap Greaves +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 82 },
                        new GearStat { Name = "MagicEvasion", Value = 95 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Vishap Greaves +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 56 },
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Vitiation Boots +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 75 },
                        new GearStat { Name = "MagicEvasion", Value = 127 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Vitiation Boots +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 41 },
                        new GearStat { Name = "Int", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "MagicAccuracy", Value = 48 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 167 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Wakido Sune-Ate +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 95 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 27 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 36 },
                        new GearStat { Name = "Accuracy", Value = 56 },
                        new GearStat { Name = "Attack", Value = 38 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Zanshin", Value = 5 },
                        new GearStat { Name = "HassoPlusJAHaste", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Wakido Sune-Ate +4",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 47 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 37 },
                        new GearStat { Name = "Accuracy", Value = 66 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 66 },
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Zanshin", Value = 5 },
                        new GearStat { Name = "HassoPlusJAHaste", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Adhemar Gamashes +1 A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 54 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 34 },
                        new GearStat { Name = "RangedAttack", Value = 34 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Adhemar Gamashes +1 B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Attack", Value = 54 },
                        new GearStat { Name = "RangedAttack", Value = 34 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Adhemar Gamashes +1 C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = 23 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 54 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Attack", Value = 34 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 54 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Flamma Gambieras +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 6 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "DA", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Herculean Boots",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "PDT", Value = -2 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 10 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Herculean Boots QA",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "PDT", Value = -2 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 28 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 },
                        new GearStat { Name = "MagicAttack", Value = 13 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "QA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Hizamaru Sune-ate +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 3 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "Attack", Value = 24 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "DualWield", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Kendatsuba Sune-ate +1",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 8 },
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 14 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "RangedAccuracy", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Malignance Boots",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -4 },
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 9 },
                        new GearStat { Name = "PDL", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Mummu Gamashes +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 88 },
                        new GearStat { Name = "MagicEvasion", Value = 107 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "Agi", Value = 57 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "RangedAccuracy", Value = 42 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Rao Sune-ate +1 D",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SubtleBlow", Value = 8 },
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 64 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 41 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Ratri Sollerets +1",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 139 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "DT", Value = 6 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "ScytheSkill", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Ryuo Sune-ate +1 C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 11 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 5 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Attack", Value = 32 },
                        new GearStat { Name = "RangedAttack", Value = 32 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "SubtleBlow", Value = 8 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Zanshin", Value = 5 },
                        new GearStat { Name = "ZanshinOA2", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Ryuo Sune-ate +1 D",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 55 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 39 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 11 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 5 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Attack", Value = 57 },
                        new GearStat { Name = "RangedAttack", Value = 32 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Zanshin", Value = 5 },
                        new GearStat { Name = "ZanshinOA2", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Sulevia's Leggings +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 44 },
                        new GearStat { Name = "MagicEvasion", Value = 75 },
                        new GearStat { Name = "MagicDefense", Value = 1 },
                        new GearStat { Name = "DT", Value = -4 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 19 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 18 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "Attack", Value = 46 },
                        new GearStat { Name = "GearHaste", Value = 1 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Tatenashi Sune-ate +1 R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "Zanshin", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Hattori Kyahan +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 120 },
                        new GearStat { Name = "MagicEvasion", Value = 135 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 54 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Hattori Kyahan +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Heathen's Sollerets +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 102 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 42 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "OccultAcumen", Value = 36 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Heathen's Sollerets +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 92 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 37 },
                        new GearStat { Name = "Int", Value = 17 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 },
                        new GearStat { Name = "OccultAcumen", Value = 33 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Amalric Nails +1A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 118 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 6 },
                        new GearStat { Name = "Vit", Value = 6 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Ea Pigaches +1",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 66 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 14 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 5 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "MagicAccuracy", Value = 48 },
                        new GearStat { Name = "MagicAttack", Value = 32 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Wicce Sabots +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 168 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 47 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Wicce Sabots +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 158 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 13 },
                        new GearStat { Name = "Dex", Value = 16 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Thereoid Greaves",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 13 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 13 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 1 },
                        new GearStat { Name = "Mnd", Value = 13 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Attack", Value = 25 },
                        new GearStat { Name = "RangedAttack", Value = 25 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "CritDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Jhakri Pigaches +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 41 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "Attack", Value = 42 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "MagicAttack", Value = 39 },
                        new GearStat { Name = "GearHaste", Value = 0 },
                        new GearStat { Name = "MagicBurstDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Lethargy Houseaux +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Lethargy Houseaux +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 28 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Peltast's Schynbalds +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Peltast's Schynbalds +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Ayanmo Gambieras +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -3 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 37 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 42 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Arbatel Loafers +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 168 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 47 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 },
                        new GearStat { Name = "KlimaformDamagePercent", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Arbatel Loafers +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 158 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 13 },
                        new GearStat { Name = "Dex", Value = 16 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 28 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 4 },
                        new GearStat { Name = "KlimaformDamagePercent", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Boii Calligae +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "CritDamage", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Boii Calligae +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 6 },
                        new GearStat { Name = "CritDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Kasuga Sune-Ate +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 10 },
                        new GearStat { Name = "ConserveTP", Value = 14 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Kasuga Sune-Ate +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 7 },
                        new GearStat { Name = "ConserveTP", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Bottes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 124 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 56 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Bottes +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 51 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Fili Cothurnes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 113 },
                        new GearStat { Name = "MagicEvasion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 53 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Fili Cothurnes +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 103 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 48 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Meghanada Jambeaux +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "PDT", Value = -3 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 54 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 46 },
                        new GearStat { Name = "Attack", Value = 42 },
                        new GearStat { Name = "RangedAccuracy", Value = 46 },
                        new GearStat { Name = "RangedAttack", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Oshosi Leggings +1",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 73 },
                        new GearStat { Name = "MagicEvasion", Value = 131 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 56 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "RangedAccuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 48 },
                        new GearStat { Name = "DoubleShot", Value = 4 },
                        new GearStat { Name = "TripleShot", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Lustratio Leggings +1 R15A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 40 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "DA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Lustratio Leggings +1 R15B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 32 },
                        new GearStat { Name = "Dex", Value = 41 },
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Lustratio Leggings +1 R15D",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 47 },
                        new GearStat { Name = "Dex", Value = 48 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Skulker's Poulaines +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 130 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 57 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 40 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Skulker's Poulaines +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 120 },
                        new GearStat { Name = "MagicEvasion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Bhikku Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "KickAttacksDMG", Value = 65 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Bhikku Gaiters +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "KickAttacksDMG", Value = 60 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Maculele Toe Shoes +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 140 },
                        new GearStat { Name = "MagicEvasion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 57 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Maculele Toe Shoes +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 130 },
                        new GearStat { Name = "MagicEvasion", Value = 105 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 34 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Nukumi Ocreae +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 130 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 40 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 20 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "DA", Value = 6 },
                        new GearStat { Name = "PDL", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Nukumi Ocreae +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 95 },
                        new GearStat { Name = "MagicEvasion", Value = 120 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 15 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "PDL", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Azimuth Gaiters +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 168 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 18 },
                        new GearStat { Name = "Dex", Value = 21 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 47 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Azimuth Gaiters +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 158 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 13 },
                        new GearStat { Name = "Dex", Value = 16 },
                        new GearStat { Name = "Vit", Value = 18 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Sabatons +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 94 },
                        new GearStat { Name = "MagicEvasion", Value = 136 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 34 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 22 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Sabatons +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 84 },
                        new GearStat { Name = "MagicEvasion", Value = 126 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 23 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Amini Bottillons +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 124 },
                        new GearStat { Name = "MagicEvasion", Value = 125 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 56 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Amini Bottillons +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 114 },
                        new GearStat { Name = "MagicEvasion", Value = 115 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 51 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 21 },
                        new GearStat { Name = "Chr", Value = 33 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MarksmanshipSkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Erilaz Greaves +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 36 },
                        new GearStat { Name = "Vit", Value = 21 },
                        new GearStat { Name = "Agi", Value = 48 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 42 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Erilaz Greaves +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 8 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 31 },
                        new GearStat { Name = "Vit", Value = 16 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 37 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Karagoz Scarpe +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 30 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 49 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "Evasion", Value = 122 },
                        new GearStat { Name = "MagicEvasion", Value = 119 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 },
                        new GearStat { Name = "Pet:Int", Value = 30 },
                        new GearStat { Name = "Pet:Mnd", Value = 30 },
                        new GearStat { Name = "Pet:Accuracy", Value = 60 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 60 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 60 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Karagoz Scarpe +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 25 },
                        new GearStat { Name = "Agi", Value = 44 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 25 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Evasion", Value = 112 },
                        new GearStat { Name = "MagicEvasion", Value = 109 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 },
                        new GearStat { Name = "Pet:Int", Value = 25 },
                        new GearStat { Name = "Pet:Mnd", Value = 25 },
                        new GearStat { Name = "Pet:Accuracy", Value = 50 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 50 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 50 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Hashishin Basmak +3",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 157 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 30 },
                        new GearStat { Name = "Vit", Value = 22 },
                        new GearStat { Name = "Agi", Value = 43 },
                        new GearStat { Name = "Int", Value = 39 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 43 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Hashishin Basmak +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 100 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "Str", Value = 17 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 17 },
                        new GearStat { Name = "Agi", Value = 38 },
                        new GearStat { Name = "Int", Value = 34 },
                        new GearStat { Name = "Mnd", Value = 27 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Volte Spats",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 2 },
                        new GearStat { Name = "Agi", Value = 58 },
                        new GearStat { Name = "Mnd", Value = 3 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 35 },
                        new GearStat { Name = "RangedAccuracy", Value = 35 },
                        new GearStat { Name = "Evasion", Value = 109 },
                        new GearStat { Name = "MagicEvasion", Value = 107 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "SubtleBlow", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Mallquis Clogs +2",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 6 },
                        new GearStat { Name = "Vit", Value = 19 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "MagicAccuracy", Value = 42 },
                        new GearStat { Name = "MagicDamage", Value = 46 },
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 86 },
                        new GearStat { Name = "MagicAttack", Value = 15 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Merlinic Crackows (Occult Acumen)",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 6 },
                        new GearStat { Name = "Vit", Value = 6 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 23 },
                        new GearStat { Name = "Chr", Value = 35 },
                        new GearStat { Name = "Evasion", Value = 60 },
                        new GearStat { Name = "MagicEvasion", Value = 116 },
                        new GearStat { Name = "MagicAttack", Value = 15 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "OccultAcumen", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Carmine Greaves +1 R15B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 14 },
                        new GearStat { Name = "Dex", Value = 28 },
                        new GearStat { Name = "Vit", Value = 15 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Evasion", Value = 52 },
                        new GearStat { Name = "MagicEvasion", Value = 80 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "Accuracy", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Battlecast Gaiters",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 24 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 37 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Evasion", Value = 72 },
                        new GearStat { Name = "MagicEvasion", Value = 69 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "PDT", Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Turms Leggings +1",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 14 },
                        new GearStat { Name = "Dex", Value = 39 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 53 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 147 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R15A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 8 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R15B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 50 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R15C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R20A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 60 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 60 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 60 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 9 },
                        new GearStat { Name = "PDL", Value = 2 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R20B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 },
                        new GearStat { Name = "DA", Value = 2 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R20C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 2 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R25A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 56 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 65 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 65 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 65 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R25B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 48 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 48 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R25C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 48 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 25 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 4 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R30A",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 61 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 70 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 70 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 70 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R30B",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 38 },
                        new GearStat { Name = "Accuracy", Value = 53 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 53 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 11 },
                        new GearStat { Name = "DA", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Nyame Sollerets R30C",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 26 },
                        new GearStat { Name = "Vit", Value = 24 },
                        new GearStat { Name = "Agi", Value = 46 },
                        new GearStat { Name = "Int", Value = 25 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 53 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 65 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 6 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 30 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "DT", Value = -7 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Ikenga's Clogs R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Clogs R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 40 },
                        new GearStat { Name = "RangedAttack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "TrueShot", Value = 5 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Clogs R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 52 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 45 },
                        new GearStat { Name = "RangedAttack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "TrueShot", Value = 7 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Clogs R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 55 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "RangedAttack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "TrueShot", Value = 9 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Ikenga's Clogs R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 14 },
                        new GearStat { Name = "Agi", Value = 57 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "RangedAccuracy", Value = 55 },
                        new GearStat { Name = "RangedAttack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "StoreTP", Value = 7 },
                        new GearStat { Name = "PDL", Value = 3 },
                        new GearStat { Name = "TrueShot", Value = 10 },
                        new GearStat { Name = "Evasion", Value = 105 },
                        new GearStat { Name = "MagicEvasion", Value = 123 },
                        new GearStat { Name = "MagicDefense", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Gleti's Boots R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 2 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Boots R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 2 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Boots R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 2 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Boots R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 2 },
                        new GearStat { Name = "Str", Value = 31 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Gleti's Boots R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Regain", Value = 2 },
                        new GearStat { Name = "Str", Value = 33 },
                        new GearStat { Name = "Dex", Value = 29 },
                        new GearStat { Name = "Vit", Value = 26 },
                        new GearStat { Name = "Agi", Value = 33 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 12 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "PDL", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 4 },
                        new GearStat { Name = "PDT", Value = -5 },
                        new GearStat { Name = "Evasion", Value = 110 },
                        new GearStat { Name = "MagicEvasion", Value = 112 },
                        new GearStat { Name = "MagicDefense", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Leggings R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Leggings R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Leggings R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Leggings R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Sakpata's Leggings R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 35 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 19 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 2 },
                        new GearStat { Name = "DA", Value = 4 },
                        new GearStat { Name = "PDL", Value = 4 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Boots R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Boots R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Boots R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 34 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Boots R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 37 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "MagicAttack", Value = 40 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Mpaca's Boots R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 32 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 39 },
                        new GearStat { Name = "Int", Value = 0 },
                        new GearStat { Name = "Mnd", Value = 11 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 },
                        new GearStat { Name = "MagicAttack", Value = 45 },
                        new GearStat { Name = "PDT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 119 },
                        new GearStat { Name = "MagicEvasion", Value = 96 },
                        new GearStat { Name = "MagicDefense", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Agwu's Pigaches R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 35 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Pigaches R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 50 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Pigaches R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 55 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Pigaches R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 58 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Agwu's Pigaches R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 25 },
                        new GearStat { Name = "Vit", Value = 8 },
                        new GearStat { Name = "Agi", Value = 30 },
                        new GearStat { Name = "Int", Value = 30 },
                        new GearStat { Name = "Mnd", Value = 26 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 60 },
                        new GearStat { Name = "MagicDamage", Value = 20 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "Evasion", Value = 99 },
                        new GearStat { Name = "MagicEvasion", Value = 134 },
                        new GearStat { Name = "MagicDefense", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Sabots R0",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 40 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 30 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Sabots R15",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 40 },
                        new GearStat { Name = "Attack", Value = 55 },
                        new GearStat { Name = "MagicAccuracy", Value = 40 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 45 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Sabots R20",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 45 },
                        new GearStat { Name = "Attack", Value = 60 },
                        new GearStat { Name = "MagicAccuracy", Value = 45 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 50 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Sabots R25",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "Attack", Value = 65 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 55 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Bunzi's Sabots R30",
                    Slot = "Feet",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 12 },
                        new GearStat { Name = "Vit", Value = 12 },
                        new GearStat { Name = "Agi", Value = 32 },
                        new GearStat { Name = "Int", Value = 32 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 44 },
                        new GearStat { Name = "Accuracy", Value = 55 },
                        new GearStat { Name = "Attack", Value = 70 },
                        new GearStat { Name = "MagicAccuracy", Value = 55 },
                        new GearStat { Name = "MagicAttack", Value = 30 },
                        new GearStat { Name = "MagicDamage", Value = 60 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 6 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "Evasion", Value = 91 },
                        new GearStat { Name = "MagicEvasion", Value = 150 },
                        new GearStat { Name = "MagicDefense", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "SMN" } }
                }
            };
        }
    }
}
