using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class Profiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    CharacterName = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Server = table.Column<string>(type: "text", nullable: false),
                    Race = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CharacterProfileId = table.Column<int>(type: "integer", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false),
                    JobLevel = table.Column<int>(type: "integer", nullable: false),
                    MasterLevel = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterJobs_CharacterProfiles_CharacterProfileId",
                        column: x => x.CharacterProfileId,
                        principalTable: "CharacterProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterJobs_CharacterProfileId_JobId",
                table: "CharacterJobs",
                columns: new[] { "CharacterProfileId", "JobId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterJobs_JobId",
                table: "CharacterJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterProfiles_CharacterName_Server",
                table: "CharacterProfiles",
                columns: new[] { "CharacterName", "Server" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterProfiles_UserId",
                table: "CharacterProfiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterJobs");

            migrationBuilder.DropTable(
                name: "CharacterProfiles");
        }
    }
}
