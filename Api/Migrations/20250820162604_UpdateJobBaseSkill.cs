using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateJobBaseSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseSkills_Stats_StatId",
                table: "JobBaseSkills");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "JobBaseSkills");

            migrationBuilder.AddColumn<string>(
                name: "SkillRank",
                table: "JobBaseSkills",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseSkills_Stats_StatId",
                table: "JobBaseSkills",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseSkills_Stats_StatId",
                table: "JobBaseSkills");

            migrationBuilder.DropColumn(
                name: "SkillRank",
                table: "JobBaseSkills");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "JobBaseSkills",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseSkills_Stats_StatId",
                table: "JobBaseSkills",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
