
using Microsoft.EntityFrameworkCore;
using FFXIComp.Api.Models;
using FFXIComp.Api.SeedData;

namespace FFXIComp.Api
{
    public class GearDbContext : DbContext
    {
        public GearDbContext(DbContextOptions<GearDbContext> options) : base(options) { }
        public DbSet<GearItem> GearItems { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<GearSlot> GearSlots { get; set; }
        public DbSet<GearItemCategory> GearItemCategories { get; set; }
        public DbSet<GearItemJob> GearItemJobs { get; set; }
        public DbSet<GearItemSlot> GearItemSlots { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<GearItemStat> GearItemStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Jobs
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Abbreviation = "WAR", FullName = "Warrior" },
                new Job { Id = 2, Abbreviation = "MNK", FullName = "Monk" },
                new Job { Id = 3, Abbreviation = "WHM", FullName = "White Mage" },
                new Job { Id = 4, Abbreviation = "BLM", FullName = "Black Mage" },
                new Job { Id = 5, Abbreviation = "RDM", FullName = "Red Mage" },
                new Job { Id = 6, Abbreviation = "THF", FullName = "Thief" },
                new Job { Id = 7, Abbreviation = "PLD", FullName = "Paladin" },
                new Job { Id = 8, Abbreviation = "DRK", FullName = "Dark Knight" },
                new Job { Id = 9, Abbreviation = "BST", FullName = "Beastmaster" },
                new Job { Id = 10, Abbreviation = "BRD", FullName = "Bard" },
                new Job { Id = 11, Abbreviation = "RNG", FullName = "Ranger" },
                new Job { Id = 12, Abbreviation = "SAM", FullName = "Samurai" },
                new Job { Id = 13, Abbreviation = "NIN", FullName = "Ninja" },
                new Job { Id = 14, Abbreviation = "DRG", FullName = "Dragoon" },
                new Job { Id = 15, Abbreviation = "SMN", FullName = "Summoner" },
                new Job { Id = 16, Abbreviation = "BLU", FullName = "Blue Mage" },
                new Job { Id = 17, Abbreviation = "COR", FullName = "Corsair" },
                new Job { Id = 18, Abbreviation = "PUP", FullName = "Puppetmaster" },
                new Job { Id = 19, Abbreviation = "DNC", FullName = "Dancer" },
                new Job { Id = 20, Abbreviation = "SCH", FullName = "Scholar" },
                new Job { Id = 21, Abbreviation = "GEO", FullName = "Geomancer" },
                new Job { Id = 22, Abbreviation = "RUN", FullName = "Rune Fencer" }
            );

            // Seed GearSlots
            modelBuilder.Entity<GearSlot>().HasData(
                new GearSlot { Id = 1, Name = "Main" },
                new GearSlot { Id = 2, Name = "Sub" },
                new GearSlot { Id = 3, Name = "Range" },
                new GearSlot { Id = 4, Name = "Ammo" },
                new GearSlot { Id = 5, Name = "Head" },
                new GearSlot { Id = 6, Name = "Neck" },
                new GearSlot { Id = 7, Name = "Ear" },
                new GearSlot { Id = 8, Name = "Body" },
                new GearSlot { Id = 9, Name = "Hands" },
                new GearSlot { Id = 10, Name = "Ring" },
                new GearSlot { Id = 11, Name = "Back" },
                new GearSlot { Id = 12, Name = "Waist" },
                new GearSlot { Id = 13, Name = "Legs" },
                new GearSlot { Id = 14, Name = "Feet" }
            );

            // Seed GearCategories
            modelBuilder.Entity<GearItemCategory>().HasData(
                new GearItemCategory { Id = 1, Name = "1H" }, //Done
                new GearItemCategory { Id = 2, Name = "2H" }, //Done
                new GearItemCategory { Id = 3, Name = "H2H" },//Done
                new GearItemCategory { Id = 4, Name = "Shield" }, //Done
                new GearItemCategory { Id = 5, Name = "Grip" }, // Done
                new GearItemCategory { Id = 6, Name = "Instrument" },
                new GearItemCategory { Id = 7, Name = "Bow" },
                new GearItemCategory { Id = 8, Name = "Crossbow" },
                new GearItemCategory { Id = 9, Name = "Gun" },
                new GearItemCategory { Id = 10, Name = "Arrow" }, //Done
                new GearItemCategory { Id = 11, Name = "Bolt" }, //Done
                new GearItemCategory { Id = 12, Name = "Bullet" }, //Done
                new GearItemCategory { Id = 13, Name = "Ammo" }, //Done
                new GearItemCategory { Id = 14, Name = "Cloak" }, //Done
                new GearItemCategory { Id = 15, Name = "Thrown" } //Done
            );

            modelBuilder.Entity<Stat>().HasData(
                // Base Stats
                new Stat { Id = 1, Name = "STR", DisplayName = "Strength", Category = "Base" },
                new Stat { Id = 2, Name = "DEX", DisplayName = "Dexterity", Category = "Base" },
                new Stat { Id = 3, Name = "VIT", DisplayName = "Vitality", Category = "Base" },
                new Stat { Id = 4, Name = "AGI", DisplayName = "Agility", Category = "Base" },
                new Stat { Id = 5, Name = "INT", DisplayName = "Intelligence", Category = "Base" },
                new Stat { Id = 6, Name = "MND", DisplayName = "Mind", Category = "Base" },
                new Stat { Id = 7, Name = "CHR", DisplayName = "Charisma", Category = "Base" },

                // Skills
                new Stat { Id = 8, Name = "HandToHandSkill", DisplayName = "Hand-to-Hand Skill", Category = "Skill" },
                new Stat { Id = 9, Name = "DaggerSkill", DisplayName = "Dagger Skill", Category = "Skill" },
                new Stat { Id = 10, Name = "SwordSkill", DisplayName = "Sword Skill", Category = "Skill" },
                new Stat { Id = 11, Name = "GreatSwordSkill", DisplayName = "Great Sword Skill", Category = "Skill" },
                new Stat { Id = 12, Name = "AxeSkill", DisplayName = "Axe Skill", Category = "Skill" },
                new Stat { Id = 13, Name = "GreatAxeSkill", DisplayName = "Great Axe Skill", Category = "Skill" },
                new Stat { Id = 14, Name = "ScytheSkill", DisplayName = "Scythe Skill", Category = "Skill" },
                new Stat { Id = 15, Name = "PolearmSkill", DisplayName = "Polearm Skill", Category = "Skill" },
                new Stat { Id = 16, Name = "KatanaSkill", DisplayName = "Katana Skill", Category = "Skill" },
                new Stat { Id = 17, Name = "GreatKatanaSkill", DisplayName = "Great Katana Skill", Category = "Skill" },
                new Stat { Id = 18, Name = "ClubSkill", DisplayName = "Club Skill", Category = "Skill" },
                new Stat { Id = 19, Name = "StaffSkill", DisplayName = "Staff Skill", Category = "Skill" },
                new Stat { Id = 20, Name = "ArcherySkill", DisplayName = "Archery Skill", Category = "Skill" },
                new Stat { Id = 21, Name = "MarksmanshipSkill", DisplayName = "Marksmanship Skill", Category = "Skill" },
                new Stat { Id = 22, Name = "ThrowingSkill", DisplayName = "Throwing Skill", Category = "Skill" },
                new Stat { Id = 23, Name = "EvasionSkill", DisplayName = "Evasion Skill", Category = "Skill" },
                new Stat { Id = 24, Name = "GuardSkill", DisplayName = "Guard Skill", Category = "Skill" },
                new Stat { Id = 25, Name = "ParryingSkill", DisplayName = "Parrying Skill", Category = "Skill" },
                new Stat { Id = 26, Name = "ShieldSkill", DisplayName = "Shield Skill", Category = "Skill" },
                new Stat { Id = 27, Name = "DivineSkill", DisplayName = "Divine Skill", Category = "Skill" },
                new Stat { Id = 28, Name = "HealingSkill", DisplayName = "Healing Skill", Category = "Skill" },
                new Stat { Id = 29, Name = "EnhancingSkill", DisplayName = "Enhancing Skill", Category = "Skill" },
                new Stat { Id = 30, Name = "EnfeeblingSkill", DisplayName = "Enfeebling Skill", Category = "Skill" },
                new Stat { Id = 31, Name = "ElementalSkill", DisplayName = "Elemental Skill", Category = "Skill" },
                new Stat { Id = 32, Name = "DarkSkill", DisplayName = "Dark Skill", Category = "Skill" },
                new Stat { Id = 33, Name = "SingingSkill", DisplayName = "Singing Skill", Category = "Skill" },
                new Stat { Id = 34, Name = "StringedSkill", DisplayName = "Stringed Skill", Category = "Skill" },
                new Stat { Id = 35, Name = "WindSkill", DisplayName = "Wind Skill", Category = "Skill" },
                new Stat { Id = 36, Name = "NinjutsuSkill", DisplayName = "Ninjutsu Skill", Category = "Skill" },
                new Stat { Id = 37, Name = "SummoningSkill", DisplayName = "Summoning Skill", Category = "Skill" },
                new Stat { Id = 38, Name = "BlueSkill", DisplayName = "Blue Skill", Category = "Skill" },
                new Stat { Id = 39, Name = "GeomancySkill", DisplayName = "Geomancy Skill", Category = "Skill" },
                new Stat { Id = 40, Name = "HandbellSkill", DisplayName = "Handbell Skill", Category = "Skill" },

                // Weapon Stats
                new Stat { Id = 41, Name = "Delay", DisplayName = "Delay", Category = "Weapon" },
                new Stat { Id = 42, Name = "DMG", DisplayName = "Damage", Category = "Weapon" },
                new Stat { Id = 231, Name = "MagicAccuracySkill", DisplayName = "Magic Accuracy Skill", Category = "Weapon" },

                // Combat Stats
                new Stat { Id = 43, Name = "Accuracy", Category = "Combat" },
                new Stat { Id = 44, Name = "Attack", Category = "Combat" },
                new Stat { Id = 45, Name = "CritRate", DisplayName = "Critical Hit Rate", Category = "Combat" },
                new Stat { Id = 46, Name = "CritDamage", DisplayName = "Critical Hit Damage", Category = "Combat" },
                new Stat { Id = 47, Name = "DoubleAttack", DisplayName = "Double Attack", Category = "Combat" },
                new Stat { Id = 48, Name = "TripleAttack", DisplayName = "Triple Attack", Category = "Combat" },
                new Stat { Id = 49, Name = "QuadrupleAttack", DisplayName = "Quadruple Attack", Category = "Combat" },
                new Stat { Id = 50, Name = "StoreTP", DisplayName = "Store TP", Category = "Combat" },
                new Stat { Id = 51, Name = "SubtleBlow", DisplayName = "Subtle Blow", Category = "Combat" },
                new Stat { Id = 186, Name = "SubtleBlowII", DisplayName = "Subtle Blow II", Category = "Combat" },
                new Stat { Id = 52, Name = "Zanshin", Category = "Combat" },
                new Stat { Id = 53, Name = "SkillchainBonus", DisplayName = "Skillchain Bonus", Category = "Combat" },
                new Stat { Id = 54, Name = "WeaponSkillDamage", DisplayName = "Weapon Skill Damage", Category = "Combat" },
                new Stat { Id = 55, Name = "WeaponSkillAccuracy", DisplayName = "Weapon Skill Accuracy", Category = "Combat" },
                new Stat { Id = 56, Name = "PhysicalDamageLimit", DisplayName = "Physical Damage Limit+", Category = "Combat" },
                new Stat { Id = 57, Name = "TPBonus", DisplayName = "TP Bonus", Category = "Combat" },
                new Stat { Id = 58, Name = "WSDMG+", DisplayName = "Weapon Skill Damage +%", Category = "Combat" }, // Not used?
                new Stat { Id = 59, Name = "Haste", Category = "Combat" },
                new Stat { Id = 60, Name = "Zanshin2", DisplayName = "Zanshin", Category = "Combat" },
                new Stat { Id = 61, Name = "DoubleAttackDamage", DisplayName = "Double Attack Damage", Category = "Combat" },
                new Stat { Id = 197, Name = "TripleAttackDamage", DisplayName = "Triple Attack Damage", Category = "Combat" },
                new Stat { Id = 62, Name = "FTP", DisplayName = "fTP", Category = "Combat" },
                new Stat { Id = 63, Name = "TpNotDepleted", DisplayName = "TP not depleted when weapon skill used", Category = "Combat" },
                new Stat { Id = 64, Name = "WSC(Dex)", DisplayName = "Weapon skill DEX", Category = "Combat" },
                new Stat { Id = 239, Name = "WSC(CHR)", DisplayName = "Weapon skill CHR", Category = "Combat" },
                new Stat { Id = 65, Name = "Fencer", DisplayName = "Fencer", Category = "Combat" },
                new Stat { Id = 66, Name = "MartialArts", DisplayName = "Martial Arts", Category = "Combat" },
                new Stat { Id = 67, Name = "DualWield", DisplayName = "Dual Wield", Category = "Combat" },
                new Stat { Id = 201, Name = "ConserveTP", DisplayName = "Conserve TP", Category = "Combat" },
                new Stat { Id = 232, Name = "OA2-8", DisplayName = "Occasionally Attacks 2-8 Times", Category = "Combat" },
                new Stat { Id = 233, Name = "ElementalWeaponSkillDamage", DisplayName = "Elemental Weapon Skill Damage %", Category = "Combat" },
                new Stat { Id = 235, Name = "FollowUpAttackChance", DisplayName = "Follow Up Attack Chance", Category = "Combat" },

                // Magic Stats
                new Stat { Id = 68, Name = "MagicAccuracy", DisplayName = "Magic Accuracy", Category = "Magic" },
                new Stat { Id = 69, Name = "MagicAttackBonus", DisplayName = "Magic Attack Bonus", Category = "Magic" },
                new Stat { Id = 70, Name = "MagicDamage", DisplayName = "Magic Damage", Category = "Magic" },
                new Stat { Id = 71, Name = "MagicCriticalHitRate", DisplayName = "Magic Critical Hit Rate", Category = "Magic" },
                new Stat { Id = 72, Name = "MagicCriticalHitRateII", DisplayName = "Magic Critical Hit Rate II", Category = "Magic" },
                new Stat { Id = 73, Name = "MagicCriticalHitDamage", DisplayName = "Magic Critical Hit Damage", Category = "Magic" },
                new Stat { Id = 74, Name = "FastCast", DisplayName = "Fast Cast", Category = "Magic" },
                new Stat { Id = 75, Name = "ConserveMP", DisplayName = "Conserve MP", Category = "Magic" },
                new Stat { Id = 76, Name = "EnhancingMagicDuration", DisplayName = "Enhancing Magic Duration", Category = "Magic" },
                new Stat { Id = 77, Name = "MagicBurstBonus", DisplayName = "Magic Burst Bonus", Category = "Magic" },
                new Stat { Id = 78, Name = "MagicBurstBonusII", DisplayName = "Magic Burst Bonus II", Category = "Magic" },
                new Stat { Id = 79, Name = "EnfeeblingMagicEffect", DisplayName = "Enfeebling Magic Effect", Category = "Magic" },
                new Stat { Id = 80, Name = "PhysicalDamageToMP", DisplayName = "Physical Damage to MP", Category = "Magic" },
                new Stat { Id = 81, Name = "RegenDuration", DisplayName = "Regen Duration", Category = "Magic" },
                new Stat { Id = 82, Name = "CurePotency", DisplayName = "Cure Potency", Category = "Magic" },
                new Stat { Id = 83, Name = "CurePotencyII", DisplayName = "Cure Potency II", Category = "Magic" },
                new Stat { Id = 84, Name = "RefreshPotency", DisplayName = "Refresh Potency", Category = "Magic" },
                new Stat { Id = 85, Name = "DrainAspirPotency", DisplayName = "Drain and Aspir Potency", Category = "Magic" },
                new Stat { Id = 86, Name = "CureToMana", DisplayName = "Cure to Mana", Category = "Magic" },
                new Stat { Id = 87, Name = "HealingMagicCastingTime", DisplayName = "Healing Magic Casting Time", Category = "Magic" },
                new Stat { Id = 88, Name = "ElementalMagicCastingTime", DisplayName = "Elemental Magic Casting Time", Category = "Magic" },
                new Stat { Id = 89, Name = "EnfeeblingMagicCastingTime", DisplayName = "Enfeebling Magic Casting Time", Category = "Magic" },
                new Stat { Id = 90, Name = "ElementalMagicRecastDelay", DisplayName = "Elemental Magic Recast Delay", Category = "Magic" },
                new Stat { Id = 208, Name = "EnspellDamage", DisplayName = "Enspell Damage", Category = "Magic" },
                new Stat { Id = 234, Name = "EnspellDamage%", DisplayName = "Enspell Damage %", Category = "Magic" },
                new Stat { Id = 240, Name = "DayWeatherBonus", DisplayName = "Day Weather Bonus", Category = "Magic" },
                new Stat { Id = 212, Name = "FullDayWeatherBonus", DisplayName = "Full Day Weather Bonus", Category = "Magic" },
                new Stat { Id = 213, Name = "ElementalDistanceBonus", DisplayName = "Elemental Distance Bonus", Category = "Magic" },
                new Stat { Id = 215, Name = "DarkElementalBonus", DisplayName = "Dark Elemental Bonus", Category = "Magic" },
                new Stat { Id = 218, Name = "LightElementalBonus", DisplayName = "Light Elemental Bonus", Category = "Magic" },
                new Stat { Id = 219, Name = "MagicBurstAccuracy", DisplayName = "Magic Burst Accuracy", Category = "Magic" },
                new Stat { Id = 220, Name = "EarthElementalBonus", DisplayName = "Earth Elemental Bonus", Category = "Magic" },
                new Stat { Id = 237, Name = "FireElementalBonus", DisplayName = "Fire Elemental Bonus", Category = "Magic" },
                new Stat { Id = 238, Name = "WindElementalBonus", DisplayName = "Wind Elemental Bonus", Category = "Magic" },
                new Stat { Id = 241, Name = "ThunderElementalBonus", DisplayName = "Thunder Elemental Bonus", Category = "Magic" },

                // Defensive Stats
                new Stat { Id = 91, Name = "Evasion", Category = "Defense" },
                new Stat { Id = 92, Name = "Defense", Category = "Defense" },
                new Stat { Id = 93, Name = "MagicEvasion", DisplayName = "Magic Evasion", Category = "Defense" },
                new Stat { Id = 94, Name = "MagicDefenseBonus", DisplayName = "Magic Defense Bonus", Category = "Defense" },
                new Stat { Id = 95, Name = "Regen", Category = "Defense" },
                new Stat { Id = 96, Name = "ShieldBlock", DisplayName = "Shield Block Rate", Category = "Defense" },
                new Stat { Id = 97, Name = "BlockSuccessRate", DisplayName = "Shield Block Rate", Category = "Defense" },
                new Stat { Id = 98, Name = "DT", DisplayName = "Damage Taken -%", Category = "Defense" },
                new Stat { Id = 99, Name = "PDT", DisplayName = "Physical Damage Taken -%", Category = "Defense" },
                new Stat { Id = 236, Name = "PDTII", DisplayName = "Physical Damage Taken -% II", Category = "Defense" },
                new Stat { Id = 100, Name = "MDT", DisplayName = "Magic Damage Taken -%", Category = "Defense" },
                new Stat { Id = 214, Name = "MDTII", DisplayName = "Magic Damage Taken -% II", Category = "Defense" },
                new Stat { Id = 101, Name = "Enmity+", Category = "Defense" },
                new Stat { Id = 102, Name = "Enmity-", Category = "Defense" },
                new Stat { Id = 103, Name = "ResistSilence", DisplayName = "Resist Silence", Category = "Defense" },
                new Stat { Id = 104, Name = "MitigatesDamageTakenEnmity", Description = "Gives -% Damage Taken as Enmity increases.", DisplayName = "Mitigates Damage Taken Based on Enmity", Category = "Defense" },
                new Stat { Id = 105, Name = "ShieldDefBonus", Description = "Reduces blocked damage taken", DisplayName = "Shield Defense Bonus", Category = "Defense" },
                new Stat { Id = 106, Name = "BoostsEnmityRetentionWhenTakingDamage", DisplayName = "Boosts Enmity Retention When Taking Damage", Category = "Defense" },
                new Stat { Id = 107, Name = "DivineEmblem", DisplayName = "Divine Emblem", Category = "Defense" },
                new Stat { Id = 216, Name = "CureReceived", DisplayName = "Cure Received", Category = "Defense" },

                // Ranged Stats
                new Stat { Id = 108, Name = "Snapshot", Category = "Ranged" },
                new Stat { Id = 109, Name = "RapidShot", DisplayName = "Rapid Shot", Category = "Ranged" },
                new Stat { Id = 110, Name = "RangedAccuracy", DisplayName = "Ranged Accuracy", Category = "Ranged" },
                new Stat { Id = 111, Name = "RangedAttack", DisplayName = "Ranged Attack", Category = "Ranged" },
                new Stat { Id = 112, Name = "Barrage", DisplayName = "Barrage", Category = "Ranged" },
                new Stat { Id = 204, Name = "BarrageRangedAccuracy", DisplayName = "Barrage Ranged Accuracy", Category = "Ranged" },
                new Stat { Id = 187, Name = "TrueShot", DisplayName = "True Shot", Category = "Ranged" },
                new Stat { Id = 188, Name = "DoubleShot", DisplayName = "Double Shot", Category = "Ranged" },
                new Stat { Id = 189, Name = "TripleShot", DisplayName = "Triple Shot", Category = "Ranged" },
                new Stat { Id = 227, Name = "RangedCritDamage", DisplayName = "Ranged Crit Damage", Category = "Ranged" },
                new Stat { Id = 228, Name = "DoubleShotDamage", DisplayName = "Double Shot Damage", Category = "Ranged" },
                new Stat { Id = 229, Name = "TripleShotDamage", DisplayName = "Triple Shot Damage", Category = "Ranged" },

                // Pet Stats
                new Stat { Id = 113, Name = "PetMagicAccuracy", DisplayName = "Pet Magic Accuracy", Category = "Pet" },
                new Stat { Id = 114, Name = "PetMagicAttack", DisplayName = "Pet Magic Attack", Category = "Pet" },
                new Stat { Id = 115, Name = "PetDoubleAttack", DisplayName = "Pet Double Attack", Category = "Pet" },
                new Stat { Id = 116, Name = "PetHaste", DisplayName = "Pet Haste", Category = "Pet" },
                new Stat { Id = 117, Name = "PetAccuracy", DisplayName = "Pet Accuracy", Category = "Pet" },
                new Stat { Id = 118, Name = "PetAttack", DisplayName = "Pet Attack", Category = "Pet" },
                new Stat { Id = 119, Name = "PetRangedAccuracy", DisplayName = "Pet Ranged Accuracy", Category = "Pet" },
                new Stat { Id = 120, Name = "PetRangedAttack", DisplayName = "Pet Ranged Attack", Category = "Pet" },
                new Stat { Id = 121, Name = "PetStoreTP", DisplayName = "Pet Store TP", Category = "Pet" },
                new Stat { Id = 122, Name = "PetDT", DisplayName = "Pet Store TP", Category = "Pet" },
                new Stat { Id = 191, Name = "PetEvasion", DisplayName = "Pet Evasion", Category = "Pet" },
                new Stat { Id = 192, Name = "PetPDT", DisplayName = "Pet PDT", Category = "Pet" },
                new Stat { Id = 206, Name = "PetMDT", DisplayName = "Pet MDT", Category = "Pet" },
                new Stat { Id = 202, Name = "PetINT", DisplayName = "Pet INT", Category = "Pet" },
                new Stat { Id = 203, Name = "PetMND", DisplayName = "Pet MND", Category = "Pet" },
                new Stat { Id = 209, Name = "PetSTR", DisplayName = "Pet STR", Category = "Pet" },
                new Stat { Id = 210, Name = "PetDEX", DisplayName = "Pet DEX", Category = "Pet" },
                new Stat { Id = 211, Name = "PetAGI", DisplayName = "Pet AGI", Category = "Pet" },
                new Stat { Id = 205, Name = "PetSubtleBlow", DisplayName = "Pet Subtle Blow", Category = "Pet" },
                new Stat { Id = 225, Name = "PetTPBonus", DisplayName = "Pet TP Bonus", Category = "Pet" },

                // Utility Stats
                new Stat { Id = 123, Name = "Refresh", Category = "Utility" },
                new Stat { Id = 124, Name = "Regain", Category = "Utility" },
                new Stat { Id = 125, Name = "TreasureHunter", DisplayName = "Treasure Hunter", Category = "Utility" },
                new Stat { Id = 126, Name = "MovementSpeed", DisplayName = "Movement Speed", Category = "Utility" },
                new Stat { Id = 127, Name = "SIRD", DisplayName = "Spell Interruption Rate Down", Category = "Utility" },
                new Stat { Id = 128, Name = "Throwing", Category = "Utility" },
                new Stat { Id = 129, Name = "OccultAcumen", Category = "Utility" },
                new Stat { Id = 217, Name = "KnockbackDistance", Category = "Utility" },

                // Job Specific
                new Stat { Id = 130, Name = "JobAbilityDuration", DisplayName = "Job Ability Duration", Category = "Job" },

                // WAR
                new Stat { Id = 131, Name = "BerserkDuration", DisplayName = "Berserk Duration", Category = "Job" },
                new Stat { Id = 132, Name = "Retaliation", DisplayName = "Retaliation", Category = "Job" },
                new Stat { Id = 133, Name = "Restraint", DisplayName = "Restraint", Category = "Job" },
                new Stat { Id = 134, Name = "BloodRageDuration", DisplayName = "Blood Rage Duration", Category = "Job" },

                // MNK
                new Stat { Id = 135, Name = "KickAttacks", DisplayName = "Kick Attacks", Category = "Job" },
                new Stat { Id = 136, Name = "KickAttacksAttack", DisplayName = "Kick Attack Attack", Category = "Job" },
                new Stat { Id = 137, Name = "PerfectCounterAttack", DisplayName = "Perfect Counter Attack", Category = "Job" },
                new Stat { Id = 138, Name = "AugmentsImpetus", DisplayName = "Augments Impetus", Description = "Increases Critical Hit Damage by 1% and Accuracy by 2 for each consecutive successful attack while worn", Category = "Job" },
                new Stat { Id = 139, Name = "TacticalGuard", DisplayName = "Tactical Guard", Category = "Job" },
                new Stat { Id = 140, Name = "Footwork%", DisplayName = "Footwork %", Description = "Increases Footwork's Attack modifier by 16% if worn during Job Ability activation.", Category = "Job" },

                // WHM
                new Stat { Id = 141, Name = "AfflatusSolace", DisplayName = "Afflatus Solace", Category = "Job" },
                new Stat { Id = 142, Name = "Cursna", DisplayName = "Cursna", Category = "Job" },
                new Stat { Id = 143, Name = "DivineVeil", DisplayName = "Divine Veil", Category = "Job" },
                new Stat { Id = 144, Name = "DivineCaress", DisplayName = "Divine Caress", Category = "Job" },
                new Stat { Id = 145, Name = "DivineBenison", DisplayName = "Divine Benison", Category = "Job" },
                new Stat { Id = 146, Name = "Auspice", DisplayName = "Auspice", Category = "Job" },

                // BLM
                new Stat { Id = 147, Name = "ManaWall", DisplayName = "Mana Wall", Category = "Job" },
                new Stat { Id = 148, Name = "IncreasesMagicEffectDuration", DisplayName = "Increases Magic Effect Duration", Category = "Job" },

                // RDM
                new Stat { Id = 149, Name = "Saboteur", DisplayName = "Saboteur", Category = "Job" },

                // THF
                new Stat { Id = 150, Name = "SneakAttack", DisplayName = "Sneak Attack", Category = "Job" },
                new Stat { Id = 184, Name = "TrickAttack", Description = "Increases effective AGI during Trick Attack by x%", DisplayName = "Trick Attack +", Category = "Job" },
                new Stat { Id = 185, Name = "TrickAttackDamage", DisplayName = "Trick Attack damage +", Category = "Job" },
                new Stat { Id = 151, Name = "Accomplice", DisplayName = "Accomplice", Category = "Job" },
                new Stat { Id = 152, Name = "Collaborator", DisplayName = "Collaborator", Category = "Job" },
                new Stat { Id = 153, Name = "Despoil", Description = "Success rate when using Despoil", DisplayName = "Despoil", Category = "Job" },
                new Stat { Id = 154, Name = "DespoilEffect", Description = "Enhances Despoil enfeeble potency", DisplayName = "Despoil Effect", Category = "Job" },
                new Stat { Id = 155, Name = "AugmentsConspirator", Description = "Grants an attack bonus equal to the accuracy bonus. Grants a store TP bonus equal to store TP +2 for each party member with enmity on the target. (Wearer only, must remain equipped.)", DisplayName = "Augments Conspirator", Category = "Job" },


                // DRK
                new Stat { Id = 156, Name = "LastResortDuration", DisplayName = "Last Resort Duration", Category = "Job" },
                new Stat { Id = 157, Name = "AbsorbDuration", DisplayName = "Absorb Duration", Category = "Job" },

                // BST
                new Stat { Id = 158, Name = "Reward", DisplayName = "Reward", Category = "Job" },
                new Stat { Id = 159, Name = "Spur", DisplayName = "Spur", Category = "Job" },

                // BRD
                new Stat { Id = 160, Name = "Madrigal", DisplayName = "Madrigal", Category = "Job" },
                new Stat { Id = 161, Name = "Prelude", DisplayName = "Prelude", Category = "Job" },

                // RNG
                new Stat { Id = 162, Name = "VelocityShot", DisplayName = "Velocity Shot", Category = "Job" },
                // new Stat { Id = 163, Name = "DoubleShotDamage", DisplayName = "Double Shot Damage", Category = "Job" },
                new Stat { Id = 182, Name = "Recycle", DisplayName = "Recycle", Category = "Job" },

                // SAM
                new Stat { Id = 164, Name = "MeditateDuration", DisplayName = "Meditate Duration", Category = "Job" },
                new Stat { Id = 198, Name = "Hasso", Description = "Hasso + JA Haste", DisplayName = "Hasso", Category = "Job" },
                new Stat { Id = 199, Name = "ZanshinOA2", Description = "Zanshin Occasionally Attacks Twice", DisplayName = "Zanshin OA Twice", Category = "Job" },

                // NIN
                new Stat { Id = 165, Name = "Utsusemi", DisplayName = "Utsusemi", Category = "Job" },
                new Stat { Id = 166, Name = "Migawari", DisplayName = "Migawari", Category = "Job" },
                new Stat { Id = 183, Name = "Daken", DisplayName = "Daken", Category = "Job" },
                new Stat { Id = 195, Name = "NinjutsuDamagePercent", DisplayName = "Ninjutsu Damage Percent", Category = "Job" },
                new Stat { Id = 196, Name = "NinjutsuMagicAttack", DisplayName = "Ninjutsu Magic Attack", Category = "Job" },
                new Stat { Id = 207, Name = "Futae", DisplayName = "Futae", Category = "Job" },
                new Stat { Id = 223, Name = "InninDoubleAttack", DisplayName = "Innin Double Attack", Category = "Job" },

                // DRG
                new Stat { Id = 221, Name = "JumpDoubleAttack", DisplayName = "Jump Double Attack", Category = "Job" },
                new Stat { Id = 222, Name = "WyvernBreathAttacks", DisplayName = "Wyvern Breath Attacks", Category = "Job" },


                // SMN
                new Stat { Id = 167, Name = "AvatarLevel", DisplayName = "Avatar Level", Category = "Job" },
                new Stat { Id = 168, Name = "BloodPactDamage", DisplayName = "Blood Pact Damage", Category = "Job" },

                // BLU
                new Stat { Id = 169, Name = "MonsterCorrelationEffects", DisplayName = "Monster Correlation Effects", Category = "Job" },
                new Stat { Id = 170, Name = "EffluxTPBonus", DisplayName = "Efflux TP Bonus", Category = "Job" },

                // COR
                new Stat { Id = 171, Name = "PhantomRollDuration", DisplayName = "Phantom Roll Duration", Category = "Job" },
                // new Stat { Id = 172, Name = "TripleShot", DisplayName = "Triple Shot", Category = "Job" },
                new Stat { Id = 193, Name = "QuickDrawDamage", DisplayName = "Quick Draw Damage", Category = "Job" },
                new Stat { Id = 242, Name = "QuickDrawDamage%", DisplayName = "Quick Draw Damage %", Category = "Job" },
                new Stat { Id = 194, Name = "QuickDrawMagicAccuracy", DisplayName = "Quick Draw Magic Accuracy", Category = "Job" },

                // PUP
                new Stat { Id = 173, Name = "OverloadRate", DisplayName = "Overload Rate", Category = "Job" },
                new Stat { Id = 174, Name = "AutomatonLevel", DisplayName = "Automaton Level", Category = "Job" },
                new Stat { Id = 230, Name = "AutomatonCombatSkill", DisplayName = "Automaton Combat Skill", Category = "Job" },

                // DNC
                new Stat { Id = 175, Name = "SambaDuration", DisplayName = "Samba Duration", Category = "Job" },
                new Stat { Id = 190, Name = "StrikingCritRate", Description = "Increases the Critical Hit Rate of Striking Flourish for the main hit and Double Attack of the stacked attack round or Weapon Skill", DisplayName = "Striking Flourish: Critical Rate", Category = "Job" },
                new Stat { Id = 226, Name = "ClimacticCritDamage", Description = "Increases the Critical Damage of Climactic Flourish ", DisplayName = "Climactic Flourish: Critical Damage", Category = "Job" },

                // GEO
                new Stat { Id = 176, Name = "IndicolureDuration", DisplayName = "Indicolure Duration", Category = "Job" },
                new Stat { Id = 177, Name = "LifeCycle", DisplayName = "Life Cycle", Category = "Job" },

                // RUN
                new Stat { Id = 178, Name = "Inquartata", DisplayName = "Inquartata", Category = "Job" },
                new Stat { Id = 179, Name = "VallationValianceDuration", DisplayName = "Vallation Valiance Duration", Category = "Job" },

                // SCH
                new Stat { Id = 180, Name = "Rapture", DisplayName = "Rapture", Category = "Job" },
                new Stat { Id = 181, Name = "Ebullience", DisplayName = "Ebullience", Category = "Job" },
                new Stat { Id = 224, Name = "EbullienceBonus", DisplayName = "Ebullience", Category = "Job" },
                new Stat { Id = 200, Name = "KlimaformDamage", Description = "Klimaform Damage %", DisplayName = "Klimaform Damage", Category = "Job" }
            );

            // GearItem → GearCategory
            modelBuilder.Entity<GearItem>()
              .HasOne(g => g.Category)
              .WithMany(c => c.GearItems)
              .HasForeignKey(g => g.GearItemCategoryId)
              .IsRequired(false);

            // GearItem -> GearItemJob (1:M)
            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.GearItem)
                .WithMany(gi => gi.GearItemJobs)
                .HasForeignKey(gij => gij.GearItemId);

            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.Job)
                .WithMany(j => j.GearItemJobs)
                .HasForeignKey(gij => gij.JobId);

            // GearItem -> GearItemSlot (1:M)
            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearItem)
                .WithMany(gi => gi.GearItemSlots)
                .HasForeignKey(gis => gis.GearItemId);

            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearSlot)
                .WithMany(gs => gs.GearItemSlots)
                .HasForeignKey(gis => gis.GearSlotId);

            // GearItem -> GearItemStat (1:M)
            modelBuilder.Entity<GearItemStat>()
                .HasOne(gis => gis.GearItem)
                .WithMany(gi => gi.GearItemStats)
                .HasForeignKey(gis => gis.GearItemId);

            modelBuilder.Entity<GearItemStat>()
                .HasOne(gis => gis.Stat)
                .WithMany(s => s.GearItemStats)
                .HasForeignKey(gis => gis.StatId);

            // Optional: Unique constraint on Stat.Name
            modelBuilder.Entity<Stat>()
                .HasIndex(s => s.Name)
                .IsUnique();

            // Optional: Unique constraints for GearItemJob and GearItemSlot
            modelBuilder.Entity<GearItemSlot>()
                .HasIndex(gis => new { gis.GearItemId, gis.GearSlotId })
                .IsUnique();

            modelBuilder.Entity<GearItemJob>()
                .HasIndex(gij => new { gij.GearItemId, gij.JobId })
                .IsUnique();

        }

        public static void SeedInitialData(GearDbContext context)
        {
            if (!context.GearItems.Any())
            {
                var main1Items = Main1SeedData.GetItems();
                context.GearItems.AddRange(main1Items);

                context.GearItems.AddRange(Main2H.GetItems());
                context.GearItems.AddRange(MainH2HSeedData.GetItems());
                context.GearItems.AddRange(ShieldSeedData.GetItems());


                var head1Items = Head1SeedData.GetItems();
                context.GearItems.AddRange(head1Items);

                var neckItems = NeckSeedData.GetItems();
                context.GearItems.AddRange(neckItems);

                var ammoItems = AmmoSeedData.GetItems();
                context.GearItems.AddRange(ammoItems);

                var earItems = EarSeedData.GetItems();
                context.GearItems.AddRange(earItems);

                var ringItems = RingSeedData.GetItems();
                context.GearItems.AddRange(ringItems);

                var waistItems = WaistSeedData.GetItems();
                context.GearItems.AddRange(waistItems);

                var legsItems = LegsSeedData.GetItems();
                context.GearItems.AddRange(legsItems);

                var bodyItems = Body1SeedData.GetItems();
                context.GearItems.AddRange(bodyItems);

                var handsItems = Hands1SeedData.GetItems();
                context.GearItems.AddRange(handsItems);

                var feet2Items = Feet2SeedData.GetItems();
                context.GearItems.AddRange(feet2Items);

                var backItems = BackSeedData.GetItems();
                context.GearItems.AddRange(backItems);

                var subItems = GripSeedData.GetItems();
                context.GearItems.AddRange(subItems);

                var rangeItems = RangeSeedData.GetItems();
                context.GearItems.AddRange(rangeItems);

                context.SaveChanges();
            }
        }
    }
}
