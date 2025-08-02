using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class WaistSeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Eschan Stone",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "MagicAccuracy", Value = 7 },
                        new GearStat { Name = "MagicAttack", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Fotia Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 10 },
                        new GearStat { Name = "ConserveTP", Value = 7 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Grunfeld Rope",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "Attack", Value = 20 },
                        new GearStat { Name = "DA", Value = 2 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Hachirin-no-Obi",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "DayWeatherBonus", Value = 1 },
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ioskeha Belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 17 },
                        new GearStat { Name = "DA", Value = 9 },
                        new GearStat { Name = "GearHaste", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Kentarch Belt +1 R15",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 10 },
                        new GearStat { Name = "Accuracy", Value = 14 },
                        new GearStat { Name = "DA", Value = 3 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13}, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Orpheus's Sash",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "ElementalBonus", Value = 15 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Reiki Yotai",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 4 },
                        new GearStat { Name = "DualWield", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13}, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Sailfi Belt +1 R15",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 9 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "Attack", Value = 14 },
                        new GearStat { Name = "Str", Value = 15 },
                        new GearStat { Name = "DA", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13}, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Windbuffet Belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 2 },
                        new GearStat { Name = "TA", Value = 2 },
                        new GearStat { Name = "QA", Value = 2 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Skrymir Cord +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "MagicAccuracy", Value = 7 },
                        new GearStat { Name = "MagicAttack", Value = 7 },
                        new GearStat { Name = "MagicDamage", Value = 35 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Sacro Cord",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 8 },
                        new GearStat { Name = "Mnd", Value = 8 },
                        new GearStat { Name = "MagicAccuracy", Value = 8 },
                        new GearStat { Name = "MagicAttack", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Acuity Belt +1 R15",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "MagicAccuracy", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Luminary Sash",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Mnd", Value = 10 },
                        new GearStat { Name = "MagicAccuracy", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 4 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 15}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 18}, new GearItemJob { JobId= 20}, new GearItemJob { JobId= 21}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Yemaya Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 7 },
                        new GearStat { Name = "RangedAccuracy", Value = 10 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "StoreTP", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 3 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Prosilio Belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Attack", Value = 28 },
                        new GearStat { Name = "DA", Value = -5 },
                        new GearStat { Name = "WeaponSkillAccuracy", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Kwahu kachina belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 8 },
                        new GearStat { Name = "RangedAccuracy", Value = 20 },
                        new GearStat { Name = "MagicAccuracy", Value = 20 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Tellen Belt R0",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Tellen Belt R15",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Tellen Belt R20",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 5 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Tellen Belt R25",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 10 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Tellen Belt R30",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "RangedAttack", Value = 15 },
                        new GearStat { Name = "RangedAccuracy", Value = 15 },
                        new GearStat { Name = "TrueShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Moonbow Belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 20 },
                        new GearStat { Name = "TA", Value = 8 },
                        new GearStat { Name = "DT", Value = -6 },
                        new GearStat { Name = "SubtleBlowII", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Gerdr Belt +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 7 },
                        new GearStat { Name = "Agi", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "DualWield", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Gerdr Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Dex", Value = 5 },
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 },
                        new GearStat { Name = "DualWield", Value = 3 },
                        new GearStat { Name = "CritRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 2 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Cornelia's Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 10 },
                        new GearStat { Name = "Str", Value = 10 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Goading Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 5 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Tempus Fugit +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Ninurta's Sash",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "GearHaste", Value = 7 },
                        new GearStat { Name = "SubtleBlow", Value = 6 },
                        new GearStat { Name = "Attack", Value = 6 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Sweordfaetels +1",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Attack", Value = 18 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 }, new GearItemJob { JobId= 5 }, new GearItemJob { JobId= 6 }, new GearItemJob { JobId= 7 }, new GearItemJob { JobId= 8 }, new GearItemJob { JobId= 9 }, new GearItemJob { JobId= 10 }, new GearItemJob { JobId= 11}, new GearItemJob { JobId= 12}, new GearItemJob { JobId= 13}, new GearItemJob { JobId= 14}, new GearItemJob { JobId= 16}, new GearItemJob { JobId= 17}, new GearItemJob { JobId= 19}, new GearItemJob { JobId= 22} }
                },
                new GearItem
                {
                    Name = "Oneiros Rope",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "StoreTP", Value = 2 },
                        new GearStat { Name = "OccultAcumen", Value = 20 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Olseni Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 20 },
                        new GearStat { Name = "Attack", Value = -5 },
                        new GearStat { Name = "StoreTP", Value = 3 }
                    },
                    GearItemJobs = []
                },
                new GearItem
                {
                    Name = "Ponente Sash",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 4 },
                        new GearStat { Name = "Agi", Value = 9 },
                        new GearStat { Name = "RangedAttack", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11}, new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Null Belt",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 12 }
    },
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 30 },
                        new GearStat { Name = "MagicAccuracy", Value = 30 },
                        new GearStat { Name = "Evasion", Value = 30 },
                        new GearStat { Name = "RangedAccuracy", Value = 30 },
                        new GearStat { Name = "MagicEvasion", Value = 30 },
                        new GearStat { Name = "MagicDefense", Value = 3 }
                    },
                    GearItemJobs = []
                }
            };
        }
    }
}
