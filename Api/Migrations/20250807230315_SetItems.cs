using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FFXIComp.Api.Migrations
{
    /// <inheritdoc />
    public partial class SetItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearSetSlots");

            migrationBuilder.CreateTable(
                name: "GearSetItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GearSetId = table.Column<int>(type: "integer", nullable: false),
                    GearItemId = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearSetItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearSetItems_GearItems_GearItemId",
                        column: x => x.GearItemId,
                        principalTable: "GearItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearSetItems_GearSets_GearSetId",
                        column: x => x.GearSetId,
                        principalTable: "GearSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GearSetItems_GearItemId",
                table: "GearSetItems",
                column: "GearItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GearSetItems_GearSetId_Position",
                table: "GearSetItems",
                columns: new[] { "GearSetId", "Position" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearSetItems");

            migrationBuilder.CreateTable(
                name: "GearSetSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GearItemId = table.Column<int>(type: "integer", nullable: false),
                    GearSetId = table.Column<int>(type: "integer", nullable: false),
                    GearSlotId = table.Column<int>(type: "integer", nullable: false),
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
        }
    }
}
