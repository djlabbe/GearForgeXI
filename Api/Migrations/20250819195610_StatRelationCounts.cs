using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class StatRelationCounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStats_Stats_StatId",
                table: "JobBaseStats");

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStats_Stats_StatId",
                table: "JobBaseStats",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStats_Stats_StatId",
                table: "JobBaseStats");

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStats_Stats_StatId",
                table: "JobBaseStats",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
