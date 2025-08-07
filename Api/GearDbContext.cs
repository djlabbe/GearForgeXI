
using Microsoft.EntityFrameworkCore;
using FFXIComp.Api.Models;
using FFXIComp.Api.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FFXIComp.Api
{
    public class GearDbContext : IdentityDbContext<ApplicationUser>
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
        public DbSet<GearSet> GearSets { get; set; } = null!;
        public DbSet<GearSetItem> GearSetItems { get; set; } = null!;



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
                new Stat { Id = 1, Name = "STR", DisplayName = "Strength", Category = StatCategory.Base },
                new Stat { Id = 2, Name = "DEX", DisplayName = "Dexterity", Category = StatCategory.Base },
                new Stat { Id = 3, Name = "VIT", DisplayName = "Vitality", Category = StatCategory.Base },
                new Stat { Id = 4, Name = "AGI", DisplayName = "Agility", Category = StatCategory.Base },
                new Stat { Id = 5, Name = "INT", DisplayName = "Intelligence", Category = StatCategory.Base },
                new Stat { Id = 6, Name = "MND", DisplayName = "Mind", Category = StatCategory.Base },
                new Stat { Id = 7, Name = "CHR", DisplayName = "Charisma", Category = StatCategory.Base },

                // Skills
                new Stat { Id = 8, Name = "HandToHandSkill", DisplayName = "Hand-to-Hand Skill", Category = StatCategory.Skill },
                new Stat { Id = 9, Name = "DaggerSkill", DisplayName = "Dagger Skill", Category = StatCategory.Skill },
                new Stat { Id = 10, Name = "SwordSkill", DisplayName = "Sword Skill", Category = StatCategory.Skill },
                new Stat { Id = 11, Name = "GreatSwordSkill", DisplayName = "Great Sword Skill", Category = StatCategory.Skill },
                new Stat { Id = 12, Name = "AxeSkill", DisplayName = "Axe Skill", Category = StatCategory.Skill },
                new Stat { Id = 13, Name = "GreatAxeSkill", DisplayName = "Great Axe Skill", Category = StatCategory.Skill },
                new Stat { Id = 14, Name = "ScytheSkill", DisplayName = "Scythe Skill", Category = StatCategory.Skill },
                new Stat { Id = 15, Name = "PolearmSkill", DisplayName = "Polearm Skill", Category = StatCategory.Skill },
                new Stat { Id = 16, Name = "KatanaSkill", DisplayName = "Katana Skill", Category = StatCategory.Skill },
                new Stat { Id = 17, Name = "GreatKatanaSkill", DisplayName = "Great Katana Skill", Category = StatCategory.Skill },
                new Stat
                {
                    Id = 18,
                    Name = "ClubSkill",
                    DisplayName = "Club Skill",
                    Category = StatCategory.Skill
                },
                new Stat
                {
                    Id = 19,
                    Name = "StaffSkill",
                    DisplayName = "Staff Skill",
                    Category = StatCategory.Skill
                },
                new Stat { Id = 20, Name = "ArcherySkill", DisplayName = "Archery Skill", Category = StatCategory.Skill },
                new Stat { Id = 21, Name = "MarksmanshipSkill", DisplayName = "Marksmanship Skill", Category = StatCategory.Skill },
                new Stat { Id = 22, Name = "ThrowingSkill", DisplayName = "Throwing Skill", Category = StatCategory.Skill },
                new Stat { Id = 23, Name = "EvasionSkill", DisplayName = "Evasion Skill", Category = StatCategory.Skill },
                new Stat { Id = 24, Name = "GuardSkill", DisplayName = "Guard Skill", Category = StatCategory.Skill },
                new Stat { Id = 25, Name = "ParryingSkill", DisplayName = "Parrying Skill", Category = StatCategory.Skill },
                new Stat { Id = 26, Name = "ShieldSkill", DisplayName = "Shield Skill", Category = StatCategory.Skill },
                new Stat { Id = 27, Name = "DivineSkill", DisplayName = "Divine Skill", Category = StatCategory.Skill },
                new Stat { Id = 28, Name = "HealingSkill", DisplayName = "Healing Skill", Category = StatCategory.Skill },
                new Stat { Id = 29, Name = "EnhancingSkill", DisplayName = "Enhancing Skill", Category = StatCategory.Skill },
                new Stat { Id = 30, Name = "EnfeeblingSkill", DisplayName = "Enfeebling Skill", Category = StatCategory.Skill },
                new Stat { Id = 31, Name = "ElementalSkill", DisplayName = "Elemental Skill", Category = StatCategory.Skill },
                new Stat { Id = 32, Name = "DarkSkill", DisplayName = "Dark Skill", Category = StatCategory.Skill },
                new Stat { Id = 33, Name = "SingingSkill", DisplayName = "Singing Skill", Category = StatCategory.Skill },
                new Stat { Id = 34, Name = "StringedSkill", DisplayName = "Stringed Skill", Category = StatCategory.Skill },
                new Stat { Id = 35, Name = "WindSkill", DisplayName = "Wind Skill", Category = StatCategory.Skill },
                new Stat { Id = 36, Name = "NinjutsuSkill", DisplayName = "Ninjutsu Skill", Category = StatCategory.Skill },
                new Stat { Id = 37, Name = "SummoningSkill", DisplayName = "Summoning Skill", Category = StatCategory.Skill },
                new Stat { Id = 38, Name = "BlueSkill", DisplayName = "Blue Skill", Category = StatCategory.Skill },
                new Stat { Id = 39, Name = "GeomancySkill", DisplayName = "Geomancy Skill", Category = StatCategory.Skill },
                new Stat { Id = 40, Name = "HandbellSkill", DisplayName = "Handbell Skill", Category = StatCategory.Skill },

                // Weapon Stats
                new Stat { Id = 41, Name = "Delay", DisplayName = "Delay", Category = StatCategory.Weapon },
                new Stat { Id = 42, Name = "DMG", DisplayName = "Damage", Category = StatCategory.Weapon },
                new Stat { Id = 231, Name = "MagicAccuracySkill", DisplayName = "Magic Accuracy Skill", Category = StatCategory.Weapon },

                // Combat Stats
                new Stat { Id = 43, Name = "Accuracy", Category = StatCategory.Combat },
                new Stat { Id = 44, Name = "Attack", Category = StatCategory.Combat },
                new Stat { Id = 45, Name = "CritRate", DisplayName = "Critical Hit Rate", Category = StatCategory.Combat },
                new Stat { Id = 46, Name = "CritDamage", DisplayName = "Critical Hit Damage", Category = StatCategory.Combat },
                new Stat { Id = 47, Name = "DoubleAttack", DisplayName = "Double Attack", Category = StatCategory.Combat },
                new Stat { Id = 48, Name = "TripleAttack", DisplayName = "Triple Attack", Category = StatCategory.Combat },
                new Stat { Id = 49, Name = "QuadrupleAttack", DisplayName = "Quadruple Attack", Category = StatCategory.Combat },
                new Stat { Id = 50, Name = "StoreTP", DisplayName = "Store TP", Category = StatCategory.Combat },
                new Stat { Id = 51, Name = "SubtleBlow", DisplayName = "Subtle Blow", Category = StatCategory.Combat },
                new Stat { Id = 186, Name = "SubtleBlowII", DisplayName = "Subtle Blow II", Category = StatCategory.Combat },
                new Stat { Id = 52, Name = "Zanshin", Category = StatCategory.Combat },
                new Stat { Id = 53, Name = "SkillchainBonus", DisplayName = "Skillchain Bonus", Category = StatCategory.Combat },
                new Stat { Id = 54, Name = "WeaponSkillDamage", DisplayName = "Weapon Skill Damage", Category = StatCategory.Combat },
                new Stat { Id = 55, Name = "WeaponSkillAccuracy", DisplayName = "Weapon Skill Accuracy", Category = StatCategory.Combat },
                new Stat { Id = 56, Name = "PhysicalDamageLimit", DisplayName = "Physical Damage Limit+", Category = StatCategory.Combat },
                new Stat { Id = 57, Name = "TPBonus", DisplayName = "TP Bonus", Category = StatCategory.Combat },
                new Stat { Id = 58, Name = "WSDMG+", DisplayName = "Weapon Skill Damage +%", Category = StatCategory.Combat }, // Not used?
                new Stat { Id = 59, Name = "Haste", Category = StatCategory.Combat },
                new Stat { Id = 60, Name = "Zanshin2", DisplayName = "Zanshin", Category = StatCategory.Combat },
                new Stat { Id = 61, Name = "DoubleAttackDamage", DisplayName = "Double Attack Damage", Category = StatCategory.Combat },
                new Stat { Id = 197, Name = "TripleAttackDamage", DisplayName = "Triple Attack Damage", Category = StatCategory.Combat },
                new Stat { Id = 62, Name = "FTP", DisplayName = "fTP", Category = StatCategory.Combat },
                new Stat { Id = 63, Name = "TpNotDepleted", DisplayName = "TP not depleted when weapon skill used", Category = StatCategory.Combat },
                new Stat { Id = 64, Name = "WSC(Dex)", DisplayName = "Weapon skill DEX", Category = StatCategory.Combat },
                new Stat { Id = 239, Name = "WSC(CHR)", DisplayName = "Weapon skill CHR", Category = StatCategory.Combat },
                new Stat { Id = 65, Name = "Fencer", DisplayName = "Fencer", Category = StatCategory.Combat },
                new Stat { Id = 66, Name = "MartialArts", DisplayName = "Martial Arts", Category = StatCategory.Combat },
                new Stat { Id = 67, Name = "DualWield", DisplayName = "Dual Wield", Category = StatCategory.Combat },
                new Stat { Id = 201, Name = "ConserveTP", DisplayName = "Conserve TP", Category = StatCategory.Combat },
                new Stat { Id = 232, Name = "OA2-8", DisplayName = "Occasionally Attacks 2-8 Times", Category = StatCategory.Combat },
                new Stat { Id = 233, Name = "ElementalWeaponSkillDamage", DisplayName = "Elemental Weapon Skill Damage %", Category = StatCategory.Combat },
                new Stat { Id = 235, Name = "FollowUpAttackChance", DisplayName = "Follow Up Attack Chance", Category = StatCategory.Combat },

                // Magic Stats
                new Stat { Id = 68, Name = "MagicAccuracy", DisplayName = "Magic Accuracy", Category = StatCategory.Magic },
                new Stat { Id = 69, Name = "MagicAttackBonus", DisplayName = "Magic Attack Bonus", Category = StatCategory.Magic },
                new Stat { Id = 70, Name = "MagicDamage", DisplayName = "Magic Damage", Category = StatCategory.Magic },
                new Stat { Id = 71, Name = "MagicCriticalHitRate", DisplayName = "Magic Critical Hit Rate", Category = StatCategory.Magic },
                new Stat { Id = 72, Name = "MagicCriticalHitRateII", DisplayName = "Magic Critical Hit Rate II", Category = StatCategory.Magic },
                new Stat { Id = 73, Name = "MagicCriticalHitDamage", DisplayName = "Magic Critical Hit Damage", Category = StatCategory.Magic },
                new Stat { Id = 74, Name = "FastCast", DisplayName = "Fast Cast", Category = StatCategory.Magic },
                new Stat { Id = 75, Name = "ConserveMP", DisplayName = "Conserve MP", Category = StatCategory.Magic },
                new Stat { Id = 76, Name = "EnhancingMagicDuration", DisplayName = "Enhancing Magic Duration", Category = StatCategory.Magic },
                new Stat { Id = 77, Name = "MagicBurstBonus", DisplayName = "Magic Burst Bonus", Category = StatCategory.Magic },
                new Stat { Id = 78, Name = "MagicBurstBonusII", DisplayName = "Magic Burst Bonus II", Category = StatCategory.Magic },
                new Stat { Id = 79, Name = "EnfeeblingMagicEffect", DisplayName = "Enfeebling Magic Effect", Category = StatCategory.Magic },
                new Stat { Id = 80, Name = "PhysicalDamageToMP", DisplayName = "Physical Damage to MP", Category = StatCategory.Magic },
                new Stat { Id = 81, Name = "RegenDuration", DisplayName = "Regen Duration", Category = StatCategory.Magic },
                new Stat { Id = 82, Name = "CurePotency", DisplayName = "Cure Potency", Category = StatCategory.Magic },
                new Stat { Id = 83, Name = "CurePotencyII", DisplayName = "Cure Potency II", Category = StatCategory.Magic },
                new Stat { Id = 84, Name = "RefreshPotency", DisplayName = "Refresh Potency", Category = StatCategory.Magic },
                new Stat { Id = 85, Name = "DrainAspirPotency", DisplayName = "Drain and Aspir Potency", Category = StatCategory.Magic },
                new Stat { Id = 86, Name = "CureToMana", DisplayName = "Cure to Mana", Category = StatCategory.Magic },
                new Stat { Id = 87, Name = "HealingMagicCastingTime", DisplayName = "Healing Magic Casting Time", Category = StatCategory.Magic },
                new Stat { Id = 88, Name = "ElementalMagicCastingTime", DisplayName = "Elemental Magic Casting Time", Category = StatCategory.Magic },
                new Stat { Id = 89, Name = "EnfeeblingMagicCastingTime", DisplayName = "Enfeebling Magic Casting Time", Category = StatCategory.Magic },
                new Stat { Id = 90, Name = "ElementalMagicRecastDelay", DisplayName = "Elemental Magic Recast Delay", Category = StatCategory.Magic },
                new Stat { Id = 208, Name = "EnspellDamage", DisplayName = "Enspell Damage", Category = StatCategory.Magic },
                new Stat { Id = 234, Name = "EnspellDamage%", DisplayName = "Enspell Damage %", Category = StatCategory.Magic },
                new Stat { Id = 240, Name = "DayWeatherBonus", DisplayName = "Day Weather Bonus", Category = StatCategory.Magic },
                new Stat { Id = 212, Name = "FullDayWeatherBonus", DisplayName = "Full Day Weather Bonus", Category = StatCategory.Magic },
                new Stat { Id = 213, Name = "ElementalDistanceBonus", DisplayName = "Elemental Distance Bonus", Category = StatCategory.Magic },
                new Stat { Id = 215, Name = "DarkElementalBonus", DisplayName = "Dark Elemental Bonus", Category = StatCategory.Magic },
                new Stat { Id = 218, Name = "LightElementalBonus", DisplayName = "Light Elemental Bonus", Category = StatCategory.Magic },
                new Stat { Id = 219, Name = "MagicBurstAccuracy", DisplayName = "Magic Burst Accuracy", Category = StatCategory.Magic },
                new Stat { Id = 220, Name = "EarthElementalBonus", DisplayName = "Earth Elemental Bonus", Category = StatCategory.Magic },
                new Stat { Id = 237, Name = "FireElementalBonus", DisplayName = "Fire Elemental Bonus", Category = StatCategory.Magic },
                new Stat { Id = 238, Name = "WindElementalBonus", DisplayName = "Wind Elemental Bonus", Category = StatCategory.Magic },
                new Stat { Id = 241, Name = "ThunderElementalBonus", DisplayName = "Thunder Elemental Bonus", Category = StatCategory.Magic },

                // Defensive Stats
                new Stat { Id = 91, Name = "Evasion", Category = StatCategory.Defense },
                new Stat { Id = 92, Name = "Defense", Category = StatCategory.Defense },
                new Stat { Id = 93, Name = "MagicEvasion", DisplayName = "Magic Evasion", Category = StatCategory.Defense },
                new Stat { Id = 94, Name = "MagicDefenseBonus", DisplayName = "Magic Defense Bonus", Category = StatCategory.Defense },
                new Stat { Id = 95, Name = "Regen", Category = StatCategory.Defense },
                new Stat { Id = 96, Name = "ShieldBlock", DisplayName = "Shield Block Rate", Category = StatCategory.Defense },
                new Stat { Id = 97, Name = "BlockSuccessRate", DisplayName = "Shield Block Rate", Category = StatCategory.Defense },
                new Stat { Id = 98, Name = "DT", DisplayName = "Damage Taken -%", Category = StatCategory.Defense },
                new Stat { Id = 99, Name = "PDT", DisplayName = "Physical Damage Taken -%", Category = StatCategory.Defense },
                new Stat { Id = 236, Name = "PDTII", DisplayName = "Physical Damage Taken -% II", Category = StatCategory.Defense },
                new Stat { Id = 100, Name = "MDT", DisplayName = "Magic Damage Taken -%", Category = StatCategory.Defense },
                new Stat { Id = 214, Name = "MDTII", DisplayName = "Magic Damage Taken -% II", Category = StatCategory.Defense },
                new Stat { Id = 101, Name = "Enmity+", Category = StatCategory.Defense },
                new Stat { Id = 102, Name = "Enmity-", Category = StatCategory.Defense },
                new Stat { Id = 103, Name = "ResistSilence", DisplayName = "Resist Silence", Category = StatCategory.Defense },
                new Stat { Id = 104, Name = "MitigatesDamageTakenEnmity", Description = "Gives -% Damage Taken as Enmity increases.", DisplayName = "Mitigates Damage Taken Based on Enmity", Category = StatCategory.Defense },
                new Stat { Id = 105, Name = "ShieldDefBonus", Description = "Reduces blocked damage taken", DisplayName = "Shield Defense Bonus", Category = StatCategory.Defense },
                new Stat { Id = 106, Name = "BoostsEnmityRetentionWhenTakingDamage", DisplayName = "Boosts Enmity Retention When Taking Damage", Category = StatCategory.Defense },
                new Stat { Id = 107, Name = "DivineEmblem", DisplayName = "Divine Emblem", Category = StatCategory.Defense },
                new Stat { Id = 216, Name = "CureReceived", DisplayName = "Cure Received", Category = StatCategory.Defense },

                // Ranged Stats
                new Stat { Id = 108, Name = "Snapshot", Category = StatCategory.Ranged },
                new Stat { Id = 109, Name = "RapidShot", DisplayName = "Rapid Shot", Category = StatCategory.Ranged },
                new Stat { Id = 110, Name = "RangedAccuracy", DisplayName = "Ranged Accuracy", Category = StatCategory.Ranged },
                new Stat { Id = 111, Name = "RangedAttack", DisplayName = "Ranged Attack", Category = StatCategory.Ranged },
                new Stat { Id = 112, Name = "Barrage", DisplayName = "Barrage", Category = StatCategory.Ranged },
                new Stat { Id = 204, Name = "BarrageRangedAccuracy", DisplayName = "Barrage Ranged Accuracy", Category = StatCategory.Ranged },
                new Stat { Id = 187, Name = "TrueShot", DisplayName = "True Shot", Category = StatCategory.Ranged },
                new Stat { Id = 188, Name = "DoubleShot", DisplayName = "Double Shot", Category = StatCategory.Ranged },
                new Stat { Id = 189, Name = "TripleShot", DisplayName = "Triple Shot", Category = StatCategory.Ranged },
                new Stat { Id = 227, Name = "RangedCritDamage", DisplayName = "Ranged Crit Damage", Category = StatCategory.Ranged },
                new Stat { Id = 228, Name = "DoubleShotDamage", DisplayName = "Double Shot Damage", Category = StatCategory.Ranged },
                new Stat { Id = 229, Name = "TripleShotDamage", DisplayName = "Triple Shot Damage", Category = StatCategory.Ranged },

                // Pet Stats
                new Stat { Id = 113, Name = "PetMagicAccuracy", DisplayName = "Pet Magic Accuracy", Category = StatCategory.Pet },
                new Stat { Id = 114, Name = "PetMagicAttack", DisplayName = "Pet Magic Attack", Category = StatCategory.Pet },
                new Stat { Id = 115, Name = "PetDoubleAttack", DisplayName = "Pet Double Attack", Category = StatCategory.Pet },
                new Stat { Id = 116, Name = "PetHaste", DisplayName = "Pet Haste", Category = StatCategory.Pet },
                new Stat { Id = 117, Name = "PetAccuracy", DisplayName = "Pet Accuracy", Category = StatCategory.Pet },
                new Stat { Id = 118, Name = "PetAttack", DisplayName = "Pet Attack", Category = StatCategory.Pet },
                new Stat { Id = 119, Name = "PetRangedAccuracy", DisplayName = "Pet Ranged Accuracy", Category = StatCategory.Pet },
                new Stat { Id = 120, Name = "PetRangedAttack", DisplayName = "Pet Ranged Attack", Category = StatCategory.Pet },
                new Stat { Id = 121, Name = "PetStoreTP", DisplayName = "Pet Store TP", Category = StatCategory.Pet },
                new Stat { Id = 122, Name = "PetDT", DisplayName = "Pet Store TP", Category = StatCategory.Pet },
                new Stat { Id = 191, Name = "PetEvasion", DisplayName = "Pet Evasion", Category = StatCategory.Pet },
                new Stat { Id = 192, Name = "PetPDT", DisplayName = "Pet PDT", Category = StatCategory.Pet },
                new Stat { Id = 206, Name = "PetMDT", DisplayName = "Pet MDT", Category = StatCategory.Pet },
                new Stat { Id = 202, Name = "PetINT", DisplayName = "Pet INT", Category = StatCategory.Pet },
                new Stat { Id = 203, Name = "PetMND", DisplayName = "Pet MND", Category = StatCategory.Pet },
                new Stat { Id = 209, Name = "PetSTR", DisplayName = "Pet STR", Category = StatCategory.Pet },
                new Stat { Id = 210, Name = "PetDEX", DisplayName = "Pet DEX", Category = StatCategory.Pet },
                new Stat { Id = 211, Name = "PetAGI", DisplayName = "Pet AGI", Category = StatCategory.Pet },
                new Stat { Id = 205, Name = "PetSubtleBlow", DisplayName = "Pet Subtle Blow", Category = StatCategory.Pet },
                new Stat { Id = 225, Name = "PetTPBonus", DisplayName = "Pet TP Bonus", Category = StatCategory.Pet },

                // Utility Stats
                new Stat { Id = 123, Name = "Refresh", Category = StatCategory.Utility },
                new Stat { Id = 124, Name = "Regain", Category = StatCategory.Utility },
                new Stat { Id = 125, Name = "TreasureHunter", DisplayName = "Treasure Hunter", Category = StatCategory.Utility },
                new Stat { Id = 126, Name = "MovementSpeed", DisplayName = "Movement Speed", Category = StatCategory.Utility },
                new Stat { Id = 127, Name = "SIRD", DisplayName = "Spell Interruption Rate Down", Category = StatCategory.Utility },
                new Stat { Id = 128, Name = "Throwing", Category = StatCategory.Utility },
                new Stat { Id = 129, Name = "OccultAcumen", Category = StatCategory.Utility },
                new Stat { Id = 217, Name = "KnockbackDistance", Category = StatCategory.Utility },

                // Job Specific
                new Stat { Id = 130, Name = "JobAbilityDuration", DisplayName = "Job Ability Duration", Category = StatCategory.Job },

                // WAR
                new Stat { Id = 131, Name = "BerserkDuration", DisplayName = "Berserk Duration", Category = StatCategory.Job },
                new Stat { Id = 132, Name = "Retaliation", DisplayName = "Retaliation", Category = StatCategory.Job },
                new Stat { Id = 133, Name = "Restraint", DisplayName = "Restraint", Category = StatCategory.Job },
                new Stat { Id = 134, Name = "BloodRageDuration", DisplayName = "Blood Rage Duration", Category = StatCategory.Job },

                // MNK
                new Stat { Id = 135, Name = "KickAttacks", DisplayName = "Kick Attacks", Category = StatCategory.Job },
                new Stat { Id = 136, Name = "KickAttacksAttack", DisplayName = "Kick Attack Attack", Category = StatCategory.Job },
                new Stat { Id = 137, Name = "PerfectCounterAttack", DisplayName = "Perfect Counter Attack", Category = StatCategory.Job },
                new Stat { Id = 138, Name = "AugmentsImpetus", DisplayName = "Augments Impetus", Description = "Increases Critical Hit Damage by 1% and Accuracy by 2 for each consecutive successful attack while worn", Category = StatCategory.Job },
                new Stat { Id = 139, Name = "TacticalGuard", DisplayName = "Tactical Guard", Category = StatCategory.Job },
                new Stat { Id = 140, Name = "Footwork%", DisplayName = "Footwork %", Description = "Increases Footwork's Attack modifier by 16% if worn during Job Ability activation.", Category = StatCategory.Job },

                // WHM
                new Stat { Id = 141, Name = "AfflatusSolace", DisplayName = "Afflatus Solace", Category = StatCategory.Job },
                new Stat { Id = 142, Name = "Cursna", DisplayName = "Cursna", Category = StatCategory.Job },
                new Stat { Id = 143, Name = "DivineVeil", DisplayName = "Divine Veil", Category = StatCategory.Job },
                new Stat { Id = 144, Name = "DivineCaress", DisplayName = "Divine Caress", Category = StatCategory.Job },
                new Stat { Id = 145, Name = "DivineBenison", DisplayName = "Divine Benison", Category = StatCategory.Job },
                new Stat { Id = 146, Name = "Auspice", DisplayName = "Auspice", Category = StatCategory.Job },

                // BLM
                new Stat { Id = 147, Name = "ManaWall", DisplayName = "Mana Wall", Category = StatCategory.Job },
                new Stat { Id = 148, Name = "IncreasesMagicEffectDuration", DisplayName = "Increases Magic Effect Duration", Category = StatCategory.Job },

                // RDM
                new Stat { Id = 149, Name = "Saboteur", DisplayName = "Saboteur", Category = StatCategory.Job },

                // THF
                new Stat { Id = 150, Name = "SneakAttack", DisplayName = "Sneak Attack", Category = StatCategory.Job },
                new Stat { Id = 184, Name = "TrickAttack", Description = "Increases effective AGI during Trick Attack by x%", DisplayName = "Trick Attack +", Category = StatCategory.Job },
                new Stat { Id = 185, Name = "TrickAttackDamage", DisplayName = "Trick Attack damage +", Category = StatCategory.Job },
                new Stat { Id = 151, Name = "Accomplice", DisplayName = "Accomplice", Category = StatCategory.Job },
                new Stat { Id = 152, Name = "Collaborator", DisplayName = "Collaborator", Category = StatCategory.Job },
                new Stat { Id = 153, Name = "Despoil", Description = "Success rate when using Despoil", DisplayName = "Despoil", Category = StatCategory.Job },
                new Stat { Id = 154, Name = "DespoilEffect", Description = "Enhances Despoil enfeeble potency", DisplayName = "Despoil Effect", Category = StatCategory.Job },
                new Stat { Id = 155, Name = "AugmentsConspirator", Description = "Grants an attack bonus equal to the accuracy bonus. Grants a store TP bonus equal to store TP +2 for each party member with enmity on the target. (Wearer only, must remain equipped.)", DisplayName = "Augments Conspirator", Category = StatCategory.Job },


                // DRK
                new Stat { Id = 156, Name = "LastResortDuration", DisplayName = "Last Resort Duration", Category = StatCategory.Job },
                new Stat { Id = 157, Name = "AbsorbDuration", DisplayName = "Absorb Duration", Category = StatCategory.Job },

                // BST
                new Stat { Id = 158, Name = "Reward", DisplayName = "Reward", Category = StatCategory.Job },
                new Stat { Id = 159, Name = "Spur", DisplayName = "Spur", Category = StatCategory.Job },

                // BRD
                new Stat { Id = 160, Name = "Madrigal", DisplayName = "Madrigal", Category = StatCategory.Job },
                new Stat { Id = 161, Name = "Prelude", DisplayName = "Prelude", Category = StatCategory.Job },

                // RNG
                new Stat { Id = 162, Name = "VelocityShot", DisplayName = "Velocity Shot", Category = StatCategory.Job },
                // new Stat { Id = 163, Name = "DoubleShotDamage", DisplayName = "Double Shot Damage", Category = StatCategory.Job },
                new Stat { Id = 182, Name = "Recycle", DisplayName = "Recycle", Category = StatCategory.Job },

                // SAM
                new Stat { Id = 164, Name = "MeditateDuration", DisplayName = "Meditate Duration", Category = StatCategory.Job },
                new Stat { Id = 198, Name = "Hasso", Description = "Hasso + JA Haste", DisplayName = "Hasso", Category = StatCategory.Job },
                new Stat { Id = 199, Name = "ZanshinOA2", Description = "Zanshin Occasionally Attacks Twice", DisplayName = "Zanshin OA Twice", Category = StatCategory.Job },

                // NIN
                new Stat { Id = 165, Name = "Utsusemi", DisplayName = "Utsusemi", Category = StatCategory.Job },
                new Stat { Id = 166, Name = "Migawari", DisplayName = "Migawari", Category = StatCategory.Job },
                new Stat { Id = 183, Name = "Daken", DisplayName = "Daken", Category = StatCategory.Job },
                new Stat { Id = 195, Name = "NinjutsuDamagePercent", DisplayName = "Ninjutsu Damage Percent", Category = StatCategory.Job },
                new Stat { Id = 196, Name = "NinjutsuMagicAttack", DisplayName = "Ninjutsu Magic Attack", Category = StatCategory.Job },
                new Stat { Id = 207, Name = "Futae", DisplayName = "Futae", Category = StatCategory.Job },
                new Stat { Id = 223, Name = "InninDoubleAttack", DisplayName = "Innin Double Attack", Category = StatCategory.Job },

                // DRG
                new Stat { Id = 221, Name = "JumpDoubleAttack", DisplayName = "Jump Double Attack", Category = StatCategory.Job },
                new Stat { Id = 222, Name = "WyvernBreathAttacks", DisplayName = "Wyvern Breath Attacks", Category = StatCategory.Job },


                // SMN
                new Stat { Id = 167, Name = "AvatarLevel", DisplayName = "Avatar Level", Category = StatCategory.Job },
                new Stat { Id = 168, Name = "BloodPactDamage", DisplayName = "Blood Pact Damage", Category = StatCategory.Job },

                // BLU
                new Stat { Id = 169, Name = "MonsterCorrelationEffects", DisplayName = "Monster Correlation Effects", Category = StatCategory.Job },
                new Stat { Id = 170, Name = "EffluxTPBonus", DisplayName = "Efflux TP Bonus", Category = StatCategory.Job },

                // COR
                new Stat { Id = 171, Name = "PhantomRollDuration", DisplayName = "Phantom Roll Duration", Category = StatCategory.Job },
                // new Stat { Id = 172, Name = "TripleShot", DisplayName = "Triple Shot", Category = StatCategory.Job },
                new Stat { Id = 193, Name = "QuickDrawDamage", DisplayName = "Quick Draw Damage", Category = StatCategory.Job },
                new Stat { Id = 242, Name = "QuickDrawDamage%", DisplayName = "Quick Draw Damage %", Category = StatCategory.Job },
                new Stat { Id = 194, Name = "QuickDrawMagicAccuracy", DisplayName = "Quick Draw Magic Accuracy", Category = StatCategory.Job },

                // PUP
                new Stat { Id = 173, Name = "OverloadRate", DisplayName = "Overload Rate", Category = StatCategory.Job },
                new Stat { Id = 174, Name = "AutomatonLevel", DisplayName = "Automaton Level", Category = StatCategory.Job },
                new Stat { Id = 230, Name = "AutomatonCombatSkill", DisplayName = "Automaton Combat Skill", Category = StatCategory.Job },

                // DNC
                new Stat { Id = 175, Name = "SambaDuration", DisplayName = "Samba Duration", Category = StatCategory.Job },
                new Stat { Id = 190, Name = "StrikingCritRate", Description = "Increases the Critical Hit Rate of Striking Flourish for the main hit and Double Attack of the stacked attack round or Weapon Skill", DisplayName = "Striking Flourish: Critical Rate", Category = StatCategory.Job },
                new Stat { Id = 226, Name = "ClimacticCritDamage", Description = "Increases the Critical Damage of Climactic Flourish ", DisplayName = "Climactic Flourish: Critical Damage", Category = StatCategory.Job },

                // GEO
                new Stat { Id = 176, Name = "IndicolureDuration", DisplayName = "Indicolure Duration", Category = StatCategory.Job },
                new Stat { Id = 177, Name = "LifeCycle", DisplayName = "Life Cycle", Category = StatCategory.Job },

                // RUN
                new Stat { Id = 178, Name = "Inquartata", DisplayName = "Inquartata", Category = StatCategory.Job },
                new Stat { Id = 179, Name = "VallationValianceDuration", DisplayName = "Vallation Valiance Duration", Category = StatCategory.Job },

                // SCH
                new Stat { Id = 180, Name = "Rapture", DisplayName = "Rapture", Category = StatCategory.Job },
                new Stat { Id = 181, Name = "Ebullience", DisplayName = "Ebullience", Category = StatCategory.Job },
                new Stat { Id = 224, Name = "EbullienceBonus", DisplayName = "Ebullience", Category = StatCategory.Job },
                new Stat { Id = 200, Name = "KlimaformDamage", Description = "Klimaform Damage %", DisplayName = "Klimaform Damage", Category = StatCategory.Job }
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

            // Store Stat.Category as string
            modelBuilder.Entity<Stat>()
                .Property(s => s.Category)
                .HasConversion<string>();

            // GearSetItem: many-to-one with GearSet
            modelBuilder.Entity<GearSetItem>()
                .HasOne(gss => gss.GearSet)
                .WithMany(gs => gs.GearSetItems)
                .HasForeignKey(gss => gss.GearSetId);

            // GearSetItem: many-to-one with GearItem
            modelBuilder.Entity<GearSetItem>()
                .HasOne(gss => gss.GearItem)
                .WithMany()  // No backref needed
                .HasForeignKey(gss => gss.GearItemId);

            // Store GearSetItem.Position as string
            modelBuilder.Entity<GearSetItem>()
                .Property(gss => gss.Position)
                .HasConversion<string>();

            // Optional: Unique constraints for GearItemJob and GearItemSlot
            modelBuilder.Entity<GearItemSlot>()
                .HasIndex(gis => new { gis.GearItemId, gis.GearSlotId })
                .IsUnique();

            modelBuilder.Entity<GearItemJob>()
                .HasIndex(gij => new { gij.GearItemId, gij.JobId })
                .IsUnique();

            modelBuilder.Entity<GearSetItem>()
                .HasIndex(gss => new { gss.GearSetId, gss.Position })
                .IsUnique();

            // GearSet: many-to-one with User
            modelBuilder.Entity<GearSet>()
                .HasOne(gs => gs.User)
                .WithMany(u => u.GearSets)  // Now we have the navigation property
                .HasForeignKey(gs => gs.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Delete user's gear sets when user is deleted

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
