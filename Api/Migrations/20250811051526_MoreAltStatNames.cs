using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class MoreAltStatNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateName1",
                table: "Stats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateName2",
                table: "Stats",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateName1",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "AlternateName2",
                table: "Stats");
        }
    }
}
