using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class BaseStatRank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "JobBaseStats");

            migrationBuilder.AddColumn<string>(
                name: "BaseStatRank",
                table: "JobBaseStats",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BaseStatRankMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaseStatRank = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    BaseStatValue = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseStatRankMappings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseStatRankMappings");

            migrationBuilder.DropColumn(
                name: "BaseStatRank",
                table: "JobBaseStats");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "JobBaseStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
