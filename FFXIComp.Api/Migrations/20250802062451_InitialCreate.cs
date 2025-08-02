using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFXIComp.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    FullName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
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
                name: "GearStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    GearItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearStats_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
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
                columns: new[] { "Id", "Abbreviation", "FullName" },
                values: new object[,]
                {
                    { 1, "WAR", "Warrior" },
                    { 2, "MNK", "Monk" },
                    { 3, "WHM", "White Mage" },
                    { 4, "BLM", "Black Mage" },
                    { 5, "RDM", "Red Mage" },
                    { 6, "THF", "Thief" },
                    { 7, "PLD", "Paladin" },
                    { 8, "DRK", "Dark Knight" },
                    { 9, "BST", "Beastmaster" },
                    { 10, "BRD", "Bard" },
                    { 11, "RNG", "Ranger" },
                    { 12, "SAM", "Samurai" },
                    { 13, "NIN", "Ninja" },
                    { 14, "DRG", "Dragoon" },
                    { 15, "SMN", "Summoner" },
                    { 16, "BLU", "Blue Mage" },
                    { 17, "COR", "Corsair" },
                    { 18, "PUP", "Puppetmaster" },
                    { 19, "DNC", "Dancer" },
                    { 20, "SCH", "Scholar" },
                    { 21, "GEO", "Geomancer" },
                    { 22, "RUN", "Rune Fencer" }
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
                name: "IX_GearItems_GearItemCategoryId",
                table: "GearItems",
                column: "GearItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GearStats_GearItemId",
                table: "GearStats",
                column: "GearItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearItemJobs");

            migrationBuilder.DropTable(
                name: "GearItemSlots");

            migrationBuilder.DropTable(
                name: "GearStats");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "GearSlots");

            migrationBuilder.DropTable(
                name: "GearItems");

            migrationBuilder.DropTable(
                name: "GearItemCategories");
        }
    }
}
