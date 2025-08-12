using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class AddPermanceIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Abbreviation",
                table: "Jobs",
                column: "Abbreviation");

            migrationBuilder.CreateIndex(
                name: "IX_GearSlots_Name",
                table: "GearSlots",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_GearItems_Name",
                table: "GearItems",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_GearItems_Verified",
                table: "GearItems",
                column: "Verified");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Jobs_Abbreviation",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_GearSlots_Name",
                table: "GearSlots");

            migrationBuilder.DropIndex(
                name: "IX_GearItems_Name",
                table: "GearItems");

            migrationBuilder.DropIndex(
                name: "IX_GearItems_Verified",
                table: "GearItems");
        }
    }
}
