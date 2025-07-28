using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFXIComp.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GearItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Slot = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearItemJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobName = table.Column<string>(type: "TEXT", nullable: false),
                    GearItemId = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "GearStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false),
                    GearItemId = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_GearItemJobs_GearItemId",
                table: "GearItemJobs",
                column: "GearItemId");

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
                name: "GearStats");

            migrationBuilder.DropTable(
                name: "GearItems");
        }
    }
}
