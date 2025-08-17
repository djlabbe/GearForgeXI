using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class CleanUpTraits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTraitStats");

            migrationBuilder.AddColumn<int>(
                name: "StatId",
                table: "JobTraits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "JobTraits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobTraits_JobConfigurationId_StatId",
                table: "JobTraits",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTraits_StatId",
                table: "JobTraits",
                column: "StatId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTraits_Stats_StatId",
                table: "JobTraits",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTraits_Stats_StatId",
                table: "JobTraits");

            migrationBuilder.DropIndex(
                name: "IX_JobTraits_JobConfigurationId_StatId",
                table: "JobTraits");

            migrationBuilder.DropIndex(
                name: "IX_JobTraits_StatId",
                table: "JobTraits");

            migrationBuilder.DropColumn(
                name: "StatId",
                table: "JobTraits");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "JobTraits");

            migrationBuilder.CreateTable(
                name: "JobTraitStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTraitId = table.Column<int>(type: "integer", nullable: false),
                    StatId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTraitStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTraitStats_JobTraits_JobTraitId",
                        column: x => x.JobTraitId,
                        principalTable: "JobTraits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTraitStats_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTraitStats_JobTraitId_StatId",
                table: "JobTraitStats",
                columns: new[] { "JobTraitId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTraitStats_StatId",
                table: "JobTraitStats",
                column: "StatId");
        }
    }
}
