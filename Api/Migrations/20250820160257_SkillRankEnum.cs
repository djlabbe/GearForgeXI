using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class SkillRankEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillRankMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillRank = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    SkillValue = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillRankMappings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillRankMappings_SkillRank",
                table: "SkillRankMappings",
                column: "SkillRank");

            migrationBuilder.CreateIndex(
                name: "IX_SkillRankMappings_SkillRank_Level",
                table: "SkillRankMappings",
                columns: new[] { "SkillRank", "Level" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillRankMappings");
        }
    }
}
