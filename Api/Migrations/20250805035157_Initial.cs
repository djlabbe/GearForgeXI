using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GearItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearSlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    CanDualWield = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GearItemCategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearItems_GearItemCategories_GearItemCategoryId",
                        column: x => x.GearItemCategoryId,
                        principalTable: "GearItemCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GearItemJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobId = table.Column<int>(type: "integer", nullable: false),
                    GearItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItemJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearItemJobs_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearItemJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GearItemSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GearItemId = table.Column<int>(type: "integer", nullable: false),
                    GearSlotId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItemSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearItemSlots_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearItemSlots_GearSlots_GearSlotId",
                        column: x => x.GearSlotId,
                        principalTable: "GearSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GearItemStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GearItemId = table.Column<int>(type: "integer", nullable: false),
                    StatId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItemStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearItemStats_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearItemStats_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GearSetSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GearSetId = table.Column<int>(type: "integer", nullable: false),
                    GearSlotId = table.Column<int>(type: "integer", nullable: false),
                    GearItemId = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearSetSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearSetSlots_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearSetSlots_GearSets_GearSetId",
                        column: x => x.GearSetId,
                        principalTable: "GearSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearSetSlots_GearSlots_GearSlotId",
                        column: x => x.GearSlotId,
                        principalTable: "GearSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GearItemCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1H" },
                    { 2, "2H" },
                    { 3, "H2H" },
                    { 4, "Shield" },
                    { 5, "Grip" },
                    { 6, "Instrument" },
                    { 7, "Bow" },
                    { 8, "Crossbow" },
                    { 9, "Gun" },
                    { 10, "Arrow" },
                    { 11, "Bolt" },
                    { 12, "Bullet" },
                    { 13, "Ammo" },
                    { 14, "Cloak" },
                    { 15, "Thrown" }
                });

            migrationBuilder.InsertData(
                table: "GearSlots",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Main" },
                    { 2, "Sub" },
                    { 3, "Range" },
                    { 4, "Ammo" },
                    { 5, "Head" },
                    { 6, "Neck" },
                    { 7, "Ear" },
                    { 8, "Body" },
                    { 9, "Hands" },
                    { 10, "Ring" },
                    { 11, "Back" },
                    { 12, "Waist" },
                    { 13, "Legs" },
                    { 14, "Feet" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Abbreviation", "CanDualWield", "FullName" },
                values: new object[,]
                {
                    { 1, "WAR", false, "Warrior" },
                    { 2, "MNK", false, "Monk" },
                    { 3, "WHM", false, "White Mage" },
                    { 4, "BLM", false, "Black Mage" },
                    { 5, "RDM", false, "Red Mage" },
                    { 6, "THF", false, "Thief" },
                    { 7, "PLD", false, "Paladin" },
                    { 8, "DRK", false, "Dark Knight" },
                    { 9, "BST", false, "Beastmaster" },
                    { 10, "BRD", false, "Bard" },
                    { 11, "RNG", false, "Ranger" },
                    { 12, "SAM", false, "Samurai" },
                    { 13, "NIN", false, "Ninja" },
                    { 14, "DRG", false, "Dragoon" },
                    { 15, "SMN", false, "Summoner" },
                    { 16, "BLU", false, "Blue Mage" },
                    { 17, "COR", false, "Corsair" },
                    { 18, "PUP", false, "Puppetmaster" },
                    { 19, "DNC", false, "Dancer" },
                    { 20, "SCH", false, "Scholar" },
                    { 21, "GEO", false, "Geomancer" },
                    { 22, "RUN", false, "Rune Fencer" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Category", "Description", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, "Base", null, "Strength", "STR" },
                    { 2, "Base", null, "Dexterity", "DEX" },
                    { 3, "Base", null, "Vitality", "VIT" },
                    { 4, "Base", null, "Agility", "AGI" },
                    { 5, "Base", null, "Intelligence", "INT" },
                    { 6, "Base", null, "Mind", "MND" },
                    { 7, "Base", null, "Charisma", "CHR" },
                    { 8, "Skill", null, "Hand-to-Hand Skill", "HandToHandSkill" },
                    { 9, "Skill", null, "Dagger Skill", "DaggerSkill" },
                    { 10, "Skill", null, "Sword Skill", "SwordSkill" },
                    { 11, "Skill", null, "Great Sword Skill", "GreatSwordSkill" },
                    { 12, "Skill", null, "Axe Skill", "AxeSkill" },
                    { 13, "Skill", null, "Great Axe Skill", "GreatAxeSkill" },
                    { 14, "Skill", null, "Scythe Skill", "ScytheSkill" },
                    { 15, "Skill", null, "Polearm Skill", "PolearmSkill" },
                    { 16, "Skill", null, "Katana Skill", "KatanaSkill" },
                    { 17, "Skill", null, "Great Katana Skill", "GreatKatanaSkill" },
                    { 18, "Skill", null, "Club Skill", "ClubSkill" },
                    { 19, "Skill", null, "Staff Skill", "StaffSkill" },
                    { 20, "Skill", null, "Archery Skill", "ArcherySkill" },
                    { 21, "Skill", null, "Marksmanship Skill", "MarksmanshipSkill" },
                    { 22, "Skill", null, "Throwing Skill", "ThrowingSkill" },
                    { 23, "Skill", null, "Evasion Skill", "EvasionSkill" },
                    { 24, "Skill", null, "Guard Skill", "GuardSkill" },
                    { 25, "Skill", null, "Parrying Skill", "ParryingSkill" },
                    { 26, "Skill", null, "Shield Skill", "ShieldSkill" },
                    { 27, "Skill", null, "Divine Skill", "DivineSkill" },
                    { 28, "Skill", null, "Healing Skill", "HealingSkill" },
                    { 29, "Skill", null, "Enhancing Skill", "EnhancingSkill" },
                    { 30, "Skill", null, "Enfeebling Skill", "EnfeeblingSkill" },
                    { 31, "Skill", null, "Elemental Skill", "ElementalSkill" },
                    { 32, "Skill", null, "Dark Skill", "DarkSkill" },
                    { 33, "Skill", null, "Singing Skill", "SingingSkill" },
                    { 34, "Skill", null, "Stringed Skill", "StringedSkill" },
                    { 35, "Skill", null, "Wind Skill", "WindSkill" },
                    { 36, "Skill", null, "Ninjutsu Skill", "NinjutsuSkill" },
                    { 37, "Skill", null, "Summoning Skill", "SummoningSkill" },
                    { 38, "Skill", null, "Blue Skill", "BlueSkill" },
                    { 39, "Skill", null, "Geomancy Skill", "GeomancySkill" },
                    { 40, "Skill", null, "Handbell Skill", "HandbellSkill" },
                    { 41, "Weapon", null, "Delay", "Delay" },
                    { 42, "Weapon", null, "Damage", "DMG" },
                    { 43, "Combat", null, null, "Accuracy" },
                    { 44, "Combat", null, null, "Attack" },
                    { 45, "Combat", null, "Critical Hit Rate", "CritRate" },
                    { 46, "Combat", null, "Critical Hit Damage", "CritDamage" },
                    { 47, "Combat", null, "Double Attack", "DoubleAttack" },
                    { 48, "Combat", null, "Triple Attack", "TripleAttack" },
                    { 49, "Combat", null, "Quadruple Attack", "QuadrupleAttack" },
                    { 50, "Combat", null, "Store TP", "StoreTP" },
                    { 51, "Combat", null, "Subtle Blow", "SubtleBlow" },
                    { 52, "Combat", null, null, "Zanshin" },
                    { 53, "Combat", null, "Skillchain Bonus", "SkillchainBonus" },
                    { 54, "Combat", null, "Weapon Skill Damage", "WeaponSkillDamage" },
                    { 55, "Combat", null, "Weapon Skill Accuracy", "WeaponSkillAccuracy" },
                    { 56, "Combat", null, "Physical Damage Limit+", "PhysicalDamageLimit" },
                    { 57, "Combat", null, "TP Bonus", "TPBonus" },
                    { 58, "Combat", null, "Weapon Skill Damage +%", "WSDMG+" },
                    { 59, "Combat", null, null, "Haste" },
                    { 60, "Combat", null, "Zanshin", "Zanshin2" },
                    { 61, "Combat", null, "Double Attack Damage", "DoubleAttackDamage" },
                    { 62, "Combat", null, "fTP", "FTP" },
                    { 63, "Combat", null, "TP not depleted when weapon skill used", "TpNotDepleted" },
                    { 64, "Combat", null, "Weapon skill DEX", "WSC(Dex)" },
                    { 65, "Combat", null, "Fencer", "Fencer" },
                    { 66, "Combat", null, "Martial Arts", "MartialArts" },
                    { 67, "Combat", null, "Dual Wield", "DualWield" },
                    { 68, "Magic", null, "Magic Accuracy", "MagicAccuracy" },
                    { 69, "Magic", null, "Magic Attack Bonus", "MagicAttackBonus" },
                    { 70, "Magic", null, "Magic Damage", "MagicDamage" },
                    { 71, "Magic", null, "Magic Critical Hit Rate", "MagicCriticalHitRate" },
                    { 72, "Magic", null, "Magic Critical Hit Rate II", "MagicCriticalHitRateII" },
                    { 73, "Magic", null, "Magic Critical Hit Damage", "MagicCriticalHitDamage" },
                    { 74, "Magic", null, "Fast Cast", "FastCast" },
                    { 75, "Magic", null, "Conserve MP", "ConserveMP" },
                    { 76, "Magic", null, "Enhancing Magic Duration", "EnhancingMagicDuration" },
                    { 77, "Magic", null, "Magic Burst Bonus", "MagicBurstBonus" },
                    { 78, "Magic", null, "Magic Burst Bonus II", "MagicBurstBonusII" },
                    { 79, "Magic", null, "Enfeebling Magic Effect", "EnfeeblingMagicEffect" },
                    { 80, "Magic", null, "Physical Damage to MP", "PhysicalDamageToMP" },
                    { 81, "Magic", null, "Regen Duration", "RegenDuration" },
                    { 82, "Magic", null, "Cure Potency", "CurePotency" },
                    { 83, "Magic", null, "Cure Potency II", "CurePotencyII" },
                    { 84, "Magic", null, "Refresh Potency", "RefreshPotency" },
                    { 85, "Magic", null, "Drain and Aspir Potency", "DrainAspirPotency" },
                    { 86, "Magic", null, "Cure to Mana", "CureToMana" },
                    { 87, "Magic", null, "Healing Magic Casting Time", "HealingMagicCastingTime" },
                    { 88, "Magic", null, "Elemental Magic Casting Time", "ElementalMagicCastingTime" },
                    { 89, "Magic", null, "Enfeebling Magic Casting Time", "EnfeeblingMagicCastingTime" },
                    { 90, "Magic", null, "Elemental Magic Recast Delay", "ElementalMagicRecastDelay" },
                    { 91, "Defense", null, null, "Evasion" },
                    { 92, "Defense", null, null, "Defense" },
                    { 93, "Defense", null, "Magic Evasion", "MagicEvasion" },
                    { 94, "Defense", null, "Magic Defense Bonus", "MagicDefenseBonus" },
                    { 95, "Defense", null, null, "Regen" },
                    { 96, "Defense", null, "Shield Block Rate", "ShieldBlock" },
                    { 97, "Defense", null, "Shield Block Rate", "BlockSuccessRate" },
                    { 98, "Defense", null, "Damage Taken -%", "DT" },
                    { 99, "Defense", null, "Physical Damage Taken -%", "PDT" },
                    { 100, "Defense", null, "Magic Damage Taken -%", "MDT" },
                    { 101, "Defense", null, null, "Enmity+" },
                    { 102, "Defense", null, null, "Enmity-" },
                    { 103, "Defense", null, "Resist Silence", "ResistSilence" },
                    { 104, "Defense", "Gives -% Damage Taken as Enmity increases.", "Mitigates Damage Taken Based on Enmity", "MitigatesDamageTakenEnmity" },
                    { 105, "Defense", "Reduces blocked damage taken", "Shield Defense Bonus", "ShieldDefBonus" },
                    { 106, "Defense", null, "Boosts Enmity Retention When Taking Damage", "BoostsEnmityRetentionWhenTakingDamage" },
                    { 107, "Defense", null, "Divine Emblem", "DivineEmblem" },
                    { 108, "Ranged", null, null, "Snapshot" },
                    { 109, "Ranged", null, "Rapid Shot", "RapidShot" },
                    { 110, "Ranged", null, "Ranged Accuracy", "RangedAccuracy" },
                    { 111, "Ranged", null, "Ranged Attack", "RangedAttack" },
                    { 112, "Ranged", null, "Barrage", "Barrage" },
                    { 113, "Pet", null, "Pet Magic Accuracy", "PetMagicAccuracy" },
                    { 114, "Pet", null, "Pet Magic Attack", "PetMagicAttack" },
                    { 115, "Pet", null, "Pet Double Attack", "PetDoubleAttack" },
                    { 116, "Pet", null, "Pet Haste", "PetHaste" },
                    { 117, "Pet", null, "Pet Accuracy", "PetAccuracy" },
                    { 118, "Pet", null, "Pet Attack", "PetAttack" },
                    { 119, "Pet", null, "Pet Ranged Accuracy", "PetRangedAccuracy" },
                    { 120, "Pet", null, "Pet Ranged Attack", "PetRangedAttack" },
                    { 121, "Pet", null, "Pet Store TP", "PetStoreTP" },
                    { 122, "Pet", null, "Pet Store TP", "PetDT" },
                    { 123, "Utility", null, null, "Refresh" },
                    { 124, "Utility", null, null, "Regain" },
                    { 125, "Utility", null, "Treasure Hunter", "TreasureHunter" },
                    { 126, "Utility", null, "Movement Speed", "MovementSpeed" },
                    { 127, "Utility", null, "Spell Interruption Rate Down", "SIRD" },
                    { 128, "Utility", null, null, "Throwing" },
                    { 129, "Utility", null, null, "OccultAcumen" },
                    { 130, "Job", null, "Job Ability Duration", "JobAbilityDuration" },
                    { 131, "Job", null, "Berserk Duration", "BerserkDuration" },
                    { 132, "Job", null, "Retaliation", "Retaliation" },
                    { 133, "Job", null, "Restraint", "Restraint" },
                    { 134, "Job", null, "Blood Rage Duration", "BloodRageDuration" },
                    { 135, "Job", null, "Kick Attacks", "KickAttacks" },
                    { 136, "Job", null, "Kick Attack Attack", "KickAttacksAttack" },
                    { 137, "Job", null, "Perfect Counter Attack", "PerfectCounterAttack" },
                    { 138, "Job", "Increases Critical Hit Damage by 1% and Accuracy by 2 for each consecutive successful attack while worn", "Augments Impetus", "AugmentsImpetus" },
                    { 139, "Job", null, "Tactical Guard", "TacticalGuard" },
                    { 140, "Job", "Increases Footwork's Attack modifier by 16% if worn during Job Ability activation.", "Footwork %", "Footwork%" },
                    { 141, "Job", null, "Afflatus Solace", "AfflatusSolace" },
                    { 142, "Job", null, "Cursna", "Cursna" },
                    { 143, "Job", null, "Divine Veil", "DivineVeil" },
                    { 144, "Job", null, "Divine Caress", "DivineCaress" },
                    { 145, "Job", null, "Divine Benison", "DivineBenison" },
                    { 146, "Job", null, "Auspice", "Auspice" },
                    { 147, "Job", null, "Mana Wall", "ManaWall" },
                    { 148, "Job", null, "Increases Magic Effect Duration", "IncreasesMagicEffectDuration" },
                    { 149, "Job", null, "Saboteur", "Saboteur" },
                    { 150, "Job", null, "Sneak Attack", "SneakAttack" },
                    { 151, "Job", null, "Accomplice", "Accomplice" },
                    { 152, "Job", null, "Collaborator", "Collaborator" },
                    { 153, "Job", "Success rate when using Despoil", "Despoil", "Despoil" },
                    { 154, "Job", "Enhances Despoil enfeeble potency", "Despoil Effect", "DespoilEffect" },
                    { 155, "Job", "Grants an attack bonus equal to the accuracy bonus. Grants a store TP bonus equal to store TP +2 for each party member with enmity on the target. (Wearer only, must remain equipped.)", "Augments Conspirator", "AugmentsConspirator" },
                    { 156, "Job", null, "Last Resort Duration", "LastResortDuration" },
                    { 157, "Job", null, "Absorb Duration", "AbsorbDuration" },
                    { 158, "Job", null, "Reward", "Reward" },
                    { 159, "Job", null, "Spur", "Spur" },
                    { 160, "Job", null, "Madrigal", "Madrigal" },
                    { 161, "Job", null, "Prelude", "Prelude" },
                    { 162, "Job", null, "Velocity Shot", "VelocityShot" },
                    { 164, "Job", null, "Meditate Duration", "MeditateDuration" },
                    { 165, "Job", null, "Utsusemi", "Utsusemi" },
                    { 166, "Job", null, "Migawari", "Migawari" },
                    { 167, "Job", null, "Avatar Level", "AvatarLevel" },
                    { 168, "Job", null, "Blood Pact Damage", "BloodPactDamage" },
                    { 169, "Job", null, "Monster Correlation Effects", "MonsterCorrelationEffects" },
                    { 170, "Job", null, "Efflux TP Bonus", "EffluxTPBonus" },
                    { 171, "Job", null, "Phantom Roll Duration", "PhantomRollDuration" },
                    { 173, "Job", null, "Overload Rate", "OverloadRate" },
                    { 174, "Job", null, "Automaton Level", "AutomatonLevel" },
                    { 175, "Job", null, "Samba Duration", "SambaDuration" },
                    { 176, "Job", null, "Indicolure Duration", "IndicolureDuration" },
                    { 177, "Job", null, "Life Cycle", "LifeCycle" },
                    { 178, "Job", null, "Inquartata", "Inquartata" },
                    { 179, "Job", null, "Vallation Valiance Duration", "VallationValianceDuration" },
                    { 180, "Job", null, "Rapture", "Rapture" },
                    { 181, "Job", null, "Ebullience", "Ebullience" },
                    { 182, "Job", null, "Recycle", "Recycle" },
                    { 183, "Job", null, "Daken", "Daken" },
                    { 184, "Job", "Increases effective AGI during Trick Attack by x%", "Trick Attack +", "TrickAttack" },
                    { 185, "Job", null, "Trick Attack damage +", "TrickAttackDamage" },
                    { 186, "Combat", null, "Subtle Blow II", "SubtleBlowII" },
                    { 187, "Ranged", null, "True Shot", "TrueShot" },
                    { 188, "Ranged", null, "Double Shot", "DoubleShot" },
                    { 189, "Ranged", null, "Triple Shot", "TripleShot" },
                    { 190, "Job", "Increases the Critical Hit Rate of Striking Flourish for the main hit and Double Attack of the stacked attack round or Weapon Skill", "Striking Flourish: Critical Rate", "StrikingCritRate" },
                    { 191, "Pet", null, "Pet Evasion", "PetEvasion" },
                    { 192, "Pet", null, "Pet PDT", "PetPDT" },
                    { 193, "Job", null, "Quick Draw Damage", "QuickDrawDamage" },
                    { 194, "Job", null, "Quick Draw Magic Accuracy", "QuickDrawMagicAccuracy" },
                    { 195, "Job", null, "Ninjutsu Damage Percent", "NinjutsuDamagePercent" },
                    { 196, "Job", null, "Ninjutsu Magic Attack", "NinjutsuMagicAttack" },
                    { 197, "Combat", null, "Triple Attack Damage", "TripleAttackDamage" },
                    { 198, "Job", "Hasso + JA Haste", "Hasso", "Hasso" },
                    { 199, "Job", "Zanshin Occasionally Attacks Twice", "Zanshin OA Twice", "ZanshinOA2" },
                    { 200, "Job", "Klimaform Damage %", "Klimaform Damage", "KlimaformDamage" },
                    { 201, "Combat", null, "Conserve TP", "ConserveTP" },
                    { 202, "Pet", null, "Pet INT", "PetINT" },
                    { 203, "Pet", null, "Pet MND", "PetMND" },
                    { 204, "Ranged", null, "Barrage Ranged Accuracy", "BarrageRangedAccuracy" },
                    { 205, "Pet", null, "Pet Subtle Blow", "PetSubtleBlow" },
                    { 206, "Pet", null, "Pet MDT", "PetMDT" },
                    { 207, "Job", null, "Futae", "Futae" },
                    { 208, "Magic", null, "Enspell Damage", "EnspellDamage" },
                    { 209, "Pet", null, "Pet STR", "PetSTR" },
                    { 210, "Pet", null, "Pet DEX", "PetDEX" },
                    { 211, "Pet", null, "Pet AGI", "PetAGI" },
                    { 212, "Magic", null, "Full Day Weather Bonus", "FullDayWeatherBonus" },
                    { 213, "Magic", null, "Elemental Distance Bonus", "ElementalDistanceBonus" },
                    { 214, "Defense", null, "Magic Damage Taken -% II", "MDTII" },
                    { 215, "Magic", null, "Dark Elemental Bonus", "DarkElementalBonus" },
                    { 216, "Defense", null, "Cure Received", "CureReceived" },
                    { 217, "Utility", null, null, "KnockbackDistance" },
                    { 218, "Magic", null, "Light Elemental Bonus", "LightElementalBonus" },
                    { 219, "Magic", null, "Magic Burst Accuracy", "MagicBurstAccuracy" },
                    { 220, "Magic", null, "Earth Elemental Bonus", "EarthElementalBonus" },
                    { 221, "Job", null, "Jump Double Attack", "JumpDoubleAttack" },
                    { 222, "Job", null, "Wyvern Breath Attacks", "WyvernBreathAttacks" },
                    { 223, "Job", null, "Innin Double Attack", "InninDoubleAttack" },
                    { 224, "Job", null, "Ebullience", "EbullienceBonus" },
                    { 225, "Pet", null, "Pet TP Bonus", "PetTPBonus" },
                    { 226, "Job", "Increases the Critical Damage of Climactic Flourish ", "Climactic Flourish: Critical Damage", "ClimacticCritDamage" },
                    { 227, "Ranged", null, "Ranged Crit Damage", "RangedCritDamage" },
                    { 228, "Ranged", null, "Double Shot Damage", "DoubleShotDamage" },
                    { 229, "Ranged", null, "Triple Shot Damage", "TripleShotDamage" },
                    { 230, "Job", null, "Automaton Combat Skill", "AutomatonCombatSkill" },
                    { 231, "Weapon", null, "Magic Accuracy Skill", "MagicAccuracySkill" },
                    { 232, "Combat", null, "Occasionally Attacks 2-8 Times", "OA2-8" },
                    { 233, "Combat", null, "Elemental Weapon Skill Damage %", "ElementalWeaponSkillDamage" },
                    { 234, "Magic", null, "Enspell Damage %", "EnspellDamage%" },
                    { 235, "Combat", null, "Follow Up Attack Chance", "FollowUpAttackChance" },
                    { 236, "Defense", null, "Physical Damage Taken -% II", "PDTII" },
                    { 237, "Magic", null, "Fire Elemental Bonus", "FireElementalBonus" },
                    { 238, "Magic", null, "Wind Elemental Bonus", "WindElementalBonus" },
                    { 239, "Combat", null, "Weapon skill CHR", "WSC(CHR)" },
                    { 240, "Magic", null, "Day Weather Bonus", "DayWeatherBonus" },
                    { 241, "Magic", null, "Thunder Elemental Bonus", "ThunderElementalBonus" },
                    { 242, "Job", null, "Quick Draw Damage %", "QuickDrawDamage%" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GearItemJobs_GearItemId_JobId",
                table: "GearItemJobs",
                columns: new[] { "GearItemId", "JobId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GearItemJobs_JobId",
                table: "GearItemJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_GearItemSlots_GearItemId_GearSlotId",
                table: "GearItemSlots",
                columns: new[] { "GearItemId", "GearSlotId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GearItemSlots_GearSlotId",
                table: "GearItemSlots",
                column: "GearSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_GearItemStats_GearItemId",
                table: "GearItemStats",
                column: "GearItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GearItemStats_StatId",
                table: "GearItemStats",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_GearItems_GearItemCategoryId",
                table: "GearItems",
                column: "GearItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GearSetSlots_GearItemId",
                table: "GearSetSlots",
                column: "GearItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GearSetSlots_GearSetId_Position",
                table: "GearSetSlots",
                columns: new[] { "GearSetId", "Position" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GearSetSlots_GearSlotId",
                table: "GearSetSlots",
                column: "GearSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_Name",
                table: "Stats",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearItemJobs");

            migrationBuilder.DropTable(
                name: "GearItemSlots");

            migrationBuilder.DropTable(
                name: "GearItemStats");

            migrationBuilder.DropTable(
                name: "GearSetSlots");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "GearItems");

            migrationBuilder.DropTable(
                name: "GearSets");

            migrationBuilder.DropTable(
                name: "GearSlots");

            migrationBuilder.DropTable(
                name: "GearItemCategories");
        }
    }
}
