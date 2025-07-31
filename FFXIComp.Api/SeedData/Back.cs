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
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 15 },
                        new GearStat { Name = "Attack", Value = 15 },
                        new GearStat { Name = "Str", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 13 },
                        new GearStat { Name = "Zanshin", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Null Shawl",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Accuracy", Value = 50 },
                        new GearStat { Name = "RangedAccuracy", Value = 50 },
                        new GearStat { Name = "MagicAccuracy", Value = 50 },
                        new GearStat { Name = "Evasion", Value = 50 },
                        new GearStat { Name = "MagicEvasion", Value = 50 },
                        new GearStat { Name = "DA", Value = 7 },
                        new GearStat { Name = "StoreTP", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob>()
                },
                new GearItem
                {
                    Name = "Cichol's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "DoubleAttackDamage", Value = 20 },
                        new GearStat { Name = "BerserkDuration", Value = 15 },
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Segomo's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "KickAttacks", Value = 10 },
                        new GearStat { Name = "KickAttackDamage", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Alaunus's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "AfflatusSolace", Value = 10 },
                        new GearStat { Name = "Cursna", Value = 25 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" } }
                },
                new GearItem
                {
                    Name = "Taranus's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "MagicBurstDamage", Value = 5 },
                        new GearStat { Name = "ManaWall", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" } }
                },
                new GearItem
                {
                    Name = "Sucellos's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "EnfeeblingMagicEffect", Value = 10 },
                        new GearStat { Name = "EnhancingMagicDuration", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" } }
                },
                new GearItem
                {
                    Name = "Toutatis's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "SneakAttack", Value = 10 },
                        new GearStat { Name = "TripleAttack", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Rudianos's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 20 },
                        new GearStat { Name = "PhysicalDamageToMP", Value = 5 },
                        new GearStat { Name = "BlockSuccessRate", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Ankou's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "LastResortDuration", Value = 15 },
                        new GearStat { Name = "AbsorbDuration", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRK" } }
                },
                new GearItem
                {
                    Name = "Artio's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "Reward", Value = 30 },
                        new GearStat { Name = "Spur", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Intarabus's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "Madrigal", Value = 1 },
                        new GearStat { Name = "Prelude", Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Belenus's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "VelocityShot", Value = 2 },
                        new GearStat { Name = "DoubleShotDamage", Value = 20 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Smertrios's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "MeditateDuration", Value = 8 },
                        new GearStat { Name = "SkillchainBonus", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Andartia's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "Utsusemi", Value = 1 },
                        new GearStat { Name = "Migawari", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "NIN" } }
                },
                new GearItem
                {
                    Name = "Brigantia's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "JumpDoubleAttack", Value = 20 },
                        new GearStat { Name = "WyvernBreathAttacks", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Campestres's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "AvatarLevel", Value = 1 },
                        new GearStat { Name = "BloodPactDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SMN" } }
                },
                new GearItem
                {
                    Name = "Rosmerta's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "MonsterCorrelationEffects", Value = 10 },
                        new GearStat { Name = "EffluxTPBonus", Value = 250 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Camulus's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "PhantomRollDuration", Value = 30 },
                        new GearStat { Name = "TripleShot", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Visucius's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "OverloadRate", Value = -10 },
                        new GearStat { Name = "AutomatonLevel", Value = 1 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Senuna's Mantle",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 16 },
                        new GearStat { Name = "SambaDuration", Value = 15 },
                        new GearStat { Name = "CriticalHitDamage", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Lugh's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "SkillchainBonus", Value = 10 },
                        new GearStat { Name = "RegenDuration", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Nantosuelta's Cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 15 },
                        new GearStat { Name = "IndicolureDuration", Value = 20 },
                        new GearStat { Name = "LifeCycle", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Ogma's cape",
                    Slot = "Back",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Defense", Value = 18 },
                        new GearStat { Name = "Inquartata", Value = 3 },
                        new GearStat { Name = "VallationValianceDuration", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                }
            };

            return items;
        }
    }
}
