using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class AddIsBaseStatToStat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBaseStat",
                table: "Stats",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            // Update the base stats to set IsBaseStat = true
            migrationBuilder.Sql(@"
                UPDATE ""Stats"" 
                SET ""IsBaseStat"" = true 
                WHERE ""Name"" IN ('STR', 'DEX', 'VIT', 'AGI', 'INT', 'MND', 'CHR')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBaseStat",
                table: "Stats");
        }
    }
}
