using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniques : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MasterLevelBonuses_JobConfigurationId_StatId",
                table: "MasterLevelBonuses");

            migrationBuilder.DropIndex(
                name: "IX_JobTraits_JobConfigurationId_StatId",
                table: "JobTraits");

            migrationBuilder.DropIndex(
                name: "IX_JobPointBonuses_JobConfigurationId_StatId",
                table: "JobPointBonuses");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLevelBonuses_JobConfigurationId",
                table: "MasterLevelBonuses",
                column: "JobConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPointBonuses_JobConfigurationId",
                table: "JobPointBonuses",
                column: "JobConfigurationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MasterLevelBonuses_JobConfigurationId",
                table: "MasterLevelBonuses");

            migrationBuilder.DropIndex(
                name: "IX_JobPointBonuses_JobConfigurationId",
                table: "JobPointBonuses");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLevelBonuses_JobConfigurationId_StatId",
                table: "MasterLevelBonuses",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTraits_JobConfigurationId_StatId",
                table: "JobTraits",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPointBonuses_JobConfigurationId_StatId",
                table: "JobPointBonuses",
                columns: new[] { "JobConfigurationId", "StatId" },
                unique: true);
        }
    }
}
