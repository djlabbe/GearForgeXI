using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIsBaseStat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBaseStat",
                table: "Stats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBaseStat",
                table: "Stats",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
