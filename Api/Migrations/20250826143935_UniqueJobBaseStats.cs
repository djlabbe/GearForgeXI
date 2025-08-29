using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class UniqueJobBaseStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobBaseStats_JobConfigurationId",
                table: "JobBaseStats");

            migrationBuilder.CreateIndex(
                name: "IX_JobBaseStats_JobConfigurationId_StatId",
                table: "JobBaseStats",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobBaseStats_JobConfigurationId_StatId",
                table: "JobBaseStats");

            migrationBuilder.CreateIndex(
                name: "IX_JobBaseStats_JobConfigurationId",
                table: "JobBaseStats",
                column: "JobConfigurationId");
        }
    }
}
