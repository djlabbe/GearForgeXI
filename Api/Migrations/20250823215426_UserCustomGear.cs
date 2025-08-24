using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class UserCustomGear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GearItems",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GearItems_CreatedByUserId",
                table: "GearItems",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GearItems_AspNetUsers_CreatedByUserId",
                table: "GearItems",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearItems_AspNetUsers_CreatedByUserId",
                table: "GearItems");

            migrationBuilder.DropIndex(
                name: "IX_GearItems_CreatedByUserId",
                table: "GearItems");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GearItems");
        }
    }
}
