using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class RingSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Apate Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Dex", Value = 6 },
                        new GearStat { Name = "Agi", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Archon Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DarkElementalBonus", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Begrudging Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 7 },
                        new GearStat { Name = "Attack", Value = 7 },
                        new GearStat { Name = "CritRate", Value = 5 },
                        new GearStat { Name = "DT", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Beithir Ring R0",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Beithir Ring R15",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 15 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Beithir Ring R20",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 5 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Beithir Ring R25",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 },
                        new GearStat { Name = "SkillchainBonus", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Beithir Ring R30",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 2 },
                        new GearStat { Name = "SkillchainBonus", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Chirich Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Crepuscular Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 6 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Defending Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Vocane Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DT", Value = -8 },
                        new GearStat { Name = "CureReceived", Value = 5 },
                        new GearStat { Name = "KnockBackDistance", Value = -2 },
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Dingir Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 25 },
                        new GearStat { Name = "MagicAttack", Value = 10 },
                        new GearStat { Name = "Recycle", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Epaminondas's Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillDamage", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = -10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Epona's Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "TA", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Flamma Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 6 },
                        new GearStat { Name = "MagicAccuracy", Value = 6 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drg" } }
                },
                new GearItem
                {
                    Name = "Gere Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Attack", Value = 16 },
                        new GearStat { Name = "TA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" } }
                },
                new GearItem
                {
                    Name = "Hetairoi Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "CritRate", Value = 1 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "TADamage", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ilabrat Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Attack", Value = 25 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Karieyh Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 4 },
                        new GearStat { Name = "Regain", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Locus Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "MagicCritRate", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Metamorph Ring +1 R15",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 16 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "MagicAccuracy", Value = 14 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Mujin Band",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "SkillchainBonus", Value = 5 },
                        new GearStat { Name = "MagicBurstDamageII", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Mummu Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 6 },
                        new GearStat { Name = "RangedAccuracy", Value = 6 },
                        new GearStat { Name = "MagicAccuracy", Value = 6 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "cor" } }
                },
                new GearItem
                {
                    Name = "Niqmaddu Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "QA", Value = 3 },
                        new GearStat { Name = "SubtleBlowII", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Petrov Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 3 },
                        new GearStat { Name = "Vit", Value = 3 },
                        new GearStat { Name = "Agi", Value = 3 },
                        new GearStat { Name = "DA", Value = 1 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Regal Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Rufescent Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 6 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Shiva Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 9 },
                        new GearStat { Name = "MagicAttack", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Fenrir Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 3 },
                        new GearStat { Name = "MagicAttack", Value = 3 },
                        new GearStat { Name = "MagicDamage", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Shukuyu Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 7 },
                        new GearStat { Name = "Attack", Value = 15 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Sroda Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "Dex", Value = -20 },
                        new GearStat { Name = "PDL", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "mnk" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "rng" }, new GearItemJob { JobName = "sam" }, new GearItemJob { JobName = "nin" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "cor" }, new GearItemJob { JobName = "pup" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Weatherspoon Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "LightElementalBonus", Value = 11 },
                        new GearStat { Name = "MagicAccuracy", Value = 13 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Freke Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "MagicAttack", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Stikini Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 8 },
                        new GearStat { Name = "DivineMagicSkill", Value = 8 },
                        new GearStat { Name = "HealingMagicSkill", Value = 8 },
                        new GearStat { Name = "EnhancingMagicSkill", Value = 8 },
                        new GearStat { Name = "EnfeeblingMagicSkill", Value = 8 },
                        new GearStat { Name = "ElementalMagicSkill", Value = 8 },
                        new GearStat { Name = "DarkMagicSkill", Value = 8 },
                        new GearStat { Name = "SingingMagicSkill", Value = 8 },
                        new GearStat { Name = "StringMagicSkill", Value = 8 },
                        new GearStat { Name = "WindMagicSkill", Value = 8 },
                        new GearStat { Name = "BlueMagicSkill", Value = 8 },
                        new GearStat { Name = "GeomancyMagicSkill", Value = 8 },
                        new GearStat { Name = "HandbellMagicSkill", Value = 8 },
                        new GearStat { Name = "NinjutsuSkill", Value = 8 },
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ayanmo Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 6 },
                        new GearStat { Name = "MagicAccuracy", Value = 6 },
                        new GearStat { Name = "DT", Value = -3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "whm" }, new GearItemJob { JobName = "rdm" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "blu" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Cacoethic Ring +1 R15",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 11 },
                        new GearStat { Name = "RangedAccuracy", Value = 16 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Agi", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ramuh Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 9 },
                        new GearStat { Name = "Accuracy", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ifrit Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 9 },
                        new GearStat { Name = "Attack", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Leviathan Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Titan Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 9 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Carbuncle Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Chr", Value = 9 },
                        new GearStat { Name = "MagicAccuracy", Value = 4 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Garuda Ring +1",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 9 },
                        new GearStat { Name = "RangedAccuracy", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Gelatinous Ring +1 R15",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "PDT", Value = -7 },
                        new GearStat { Name = "MDT", Value = 1 },
                        new GearStat { Name = "Vit", Value = 15 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Moonlight Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 8 },
                        new GearStat { Name = "Attack", Value = 8 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "DT", Value = -5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "war" }, new GearItemJob { JobName = "thf" }, new GearItemJob { JobName = "pld" }, new GearItemJob { JobName = "drk" }, new GearItemJob { JobName = "bst" }, new GearItemJob { JobName = "brd" }, new GearItemJob { JobName = "drg" }, new GearItemJob { JobName = "dnc" }, new GearItemJob { JobName = "run" } }
                },
                new GearItem
                {
                    Name = "Mallquis Ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 6 },
                        new GearStat { Name = "MagicDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "blm" }, new GearItemJob { JobName = "sch" }, new GearItemJob { JobName = "geo" } }
                },
                new GearItem
                {
                    Name = "Cornelia's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 10 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ephramad's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "RangedAttack", Value = 20 },
                        new GearStat { Name = "PDL", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Fickblix's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DA", Value = 10 },
                        new GearStat { Name = "SubtleBlow", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Gurebu-Ogurebu's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "MagicEvasion", Value = 20 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Lehko Habhoka's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "GearHaste", Value = 10 },
                        new GearStat { Name = "CritRate", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Medada's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAttack", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ragelise's ring",
                    Slot = "Ring",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Vit", Value = 10 },
                        new GearStat { Name = "DT", Value = -10 }
                    },
                    GearItemJobs = []
                }
            };
        }
    }
}
