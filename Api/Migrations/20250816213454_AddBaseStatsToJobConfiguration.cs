using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseStatsToJobConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
