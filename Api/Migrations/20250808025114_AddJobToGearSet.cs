using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFXIComp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddJobToGearSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "GearSets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GearSets_JobId",
                table: "GearSets",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_GearSets_Jobs_JobId",
                table: "GearSets",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearSets_Jobs_JobId",
                table: "GearSets");

            migrationBuilder.DropIndex(
                name: "IX_GearSets_JobId",
                table: "GearSets");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "GearSets");
        }
    }
}
