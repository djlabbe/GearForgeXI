using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class JobBaseStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseAgi",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseChr",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseDex",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseInt",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseMnd",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseStr",
                table: "JobConfigurations");

            migrationBuilder.DropColumn(
                name: "BaseVit",
                table: "JobConfigurations");

            migrationBuilder.CreateTable(
                name: "JobBaseStats",
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
                    table.PrimaryKey("PK_JobBaseStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobBaseStats_JobConfigurations_JobConfigurationId",
                        column: x => x.JobConfigurationId,
                        principalTable: "JobConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobBaseStats_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobBaseStats_JobConfigurationId",
                table: "JobBaseStats",
                column: "JobConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobBaseStats_StatId",
                table: "JobBaseStats",
                column: "StatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobBaseStats");

            migrationBuilder.AddColumn<int>(
                name: "BaseAgi",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseChr",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseDex",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInt",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseMnd",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseStr",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseVit",
                table: "JobConfigurations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
