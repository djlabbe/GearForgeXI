using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class BackSeedData
    {
        public static List<GearItem> GetItems()
        {
            var items = new List<GearItem>
            {
                new GearItem
                {
                    Name = "Takaha Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 15 },
                        new GearItemStat { Id = 44, Value = 15 },
                        new GearItemStat { Id = 1, Value = 5 },
                        new GearItemStat { Id = 50, Value = 13 },
                        new GearItemStat { Id = 52, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Null Shawl",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 43, Value = 50 },
                        new GearItemStat { Id = 110, Value = 50 },
                        new GearItemStat { Id = 68, Value = 50 },
                        new GearItemStat { Id = 91, Value = 50 },
                        new GearItemStat { Id = 93, Value = 50 },
                        new GearItemStat { Id = 47, Value = 7 },
                        new GearItemStat { Id = 50, Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Cichol's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearItemStat { Id = 61, Value = 20 },
                        new GearItemStat { Id = 131, Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 1 } }
                },
                new GearItem
                {
                    Name = "Segomo's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearItemStat { Id = 135, Value = 10 },
                        new GearStat { Name = "KickAttackDamage", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 2 } }
                },
                new GearItem
                {
                    Name = "Alaunus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearStat { Name = "AfflatusSolace", Value = 10 },
                        new GearStat { Name = "Cursna", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 3 } }
                },
                new GearItem
                {
                    Name = "Taranus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 77, Value = 5 },
                        new GearStat { Name = "ManaWall", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 4 } }
                },
                new GearItem
                {
                    Name = "Sucellos's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearStat { Name = "EnfeeblingMagicEffect", Value = 10 },
                        new GearStat { Name = "EnhancingMagicDuration", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 5 } }
                },
                new GearItem
                {
                    Name = "Toutatis's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "SneakAttack", Value = 10 },
                        new GearStat { Name = "TripleAttack", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 6 } }
                },
                new GearItem
                {
                    Name = "Rudianos's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 20 },
                        new GearStat { Name = "PhysicalDamageToMP", Value = 5 },
                        new GearStat { Name = "BlockSuccessRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 7 } }
                },
                new GearItem
                {
                    Name = "Ankou's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearStat { Name = "LastResortDuration", Value = 15 },
                        new GearStat { Name = "AbsorbDuration", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 8 } }
                },
                new GearItem
                {
                    Name = "Artio's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearStat { Name = "Reward", Value = 30 },
                        new GearStat { Name = "Spur", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 9 } }
                },
                new GearItem
                {
                    Name = "Intarabus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearStat { Name = "Madrigal", Value = 1 },
                        new GearStat { Name = "Prelude", Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 10 } }
                },
                new GearItem
                {
                    Name = "Belenus's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "VelocityShot", Value = 2 },
                        new GearItemStat { Id = 163, Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 11} }
                },
                new GearItem
                {
                    Name = "Smertrios's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearStat { Name = "MeditateDuration", Value = 8 },
                        new GearItemStat { Id = 53, Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 12} }
                },
                new GearItem
                {
                    Name = "Andartia's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "Utsusemi", Value = 1 },
                        new GearStat { Name = "Migawari", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 13} }
                },
                new GearItem
                {
                    Name = "Brigantia's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearStat { Name = "JumpDoubleAttack", Value = 20 },
                        new GearStat { Name = "WyvernBreathAttacks", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 14} }
                },
                new GearItem
                {
                    Name = "Campestres's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearStat { Name = "AvatarLevel", Value = 1 },
                        new GearStat { Name = "BloodPactDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 15} }
                },
                new GearItem
                {
                    Name = "Rosmerta's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "MonsterCorrelationEffects", Value = 10 },
                        new GearStat { Name = "EffluxTPBonus", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 16} }
                },
                new GearItem
                {
                    Name = "Camulus's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "PhantomRollDuration", Value = 30 },
                        new GearItemStat { Id = 189, Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 17} }
                },
                new GearItem
                {
                    Name = "Visucius's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "OverloadRate", Value = -10 },
                        new GearStat { Name = "AutomatonLevel", Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 18} }
                },
                new GearItem
                {
                    Name = "Senuna's Mantle",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 16 },
                        new GearStat { Name = "SambaDuration", Value = 15 },
                        new GearStat { Name = "CriticalHitDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 19} }
                },
                new GearItem
                {
                    Name = "Lugh's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearItemStat { Id = 53, Value = 10 },
                        new GearStat { Name = "RegenDuration", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 20} }
                },
                new GearItem
                {
                    Name = "Nantosuelta's Cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 15 },
                        new GearStat { Name = "IndicolureDuration", Value = 20 },
                        new GearStat { Name = "LifeCycle", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 21} }
                },
                new GearItem
                {
                    Name = "Ogma's cape",
                    GearItemSlots = new List<GearItemSlot>
    {
        new GearItemSlot { GearSlotId = 11 }
    },
                    GearItemStats = new List<GearItemStat>
                    {
                        new GearItemStat { Id = 92, Value = 18 },
                        new GearStat { Name = "Inquartata", Value = 3 },
                        new GearStat { Name = "VallationValianceDuration", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobId= 22} }
                }
            };

            return items;
        }
    }
}
