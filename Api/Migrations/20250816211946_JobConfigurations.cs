using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class JobConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobConfigurations_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobPointBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobConfigurationId = table.Column<int>(type: "integer", nullable: false),
                    StatId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPointBonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPointBonuses_JobConfigurations_JobConfigurationId",
                        column: x => x.JobConfigurationId,
                        principalTable: "JobConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPointBonuses_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobTraits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobConfigurationId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTraits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTraits_JobConfigurations_JobConfigurationId",
                        column: x => x.JobConfigurationId,
                        principalTable: "JobConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterLevelBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobConfigurationId = table.Column<int>(type: "integer", nullable: false),
                    StatId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLevelBonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterLevelBonuses_JobConfigurations_JobConfigurationId",
                        column: x => x.JobConfigurationId,
                        principalTable: "JobConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterLevelBonuses_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_JobConfigurations_JobId",
                table: "JobConfigurations",
                column: "JobId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPointBonuses_JobConfigurationId_StatId",
                table: "JobPointBonuses",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPointBonuses_StatId",
                table: "JobPointBonuses",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTraitStats_JobTraitId_StatId",
                table: "JobTraitStats",
                columns: new[] { "JobTraitId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTraitStats_StatId",
                table: "JobTraitStats",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTraits_JobConfigurationId_Level",
                table: "JobTraits",
                columns: new[] { "JobConfigurationId", "Level" });

            migrationBuilder.CreateIndex(
                name: "IX_MasterLevelBonuses_JobConfigurationId_StatId",
                table: "MasterLevelBonuses",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterLevelBonuses_StatId",
                table: "MasterLevelBonuses",
                column: "StatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPointBonuses");

            migrationBuilder.DropTable(
                name: "JobTraitStats");

            migrationBuilder.DropTable(
                name: "MasterLevelBonuses");

            migrationBuilder.DropTable(
                name: "JobTraits");

            migrationBuilder.DropTable(
                name: "JobConfigurations");
        }
    }
}
