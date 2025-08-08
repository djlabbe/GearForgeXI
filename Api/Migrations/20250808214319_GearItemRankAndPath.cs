using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GearForgeXI.Migrations
{
    /// <inheritdoc />
    public partial class GearItemRankAndPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "GearItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "GearItems",
                type: "integer",
                nullable: true);

            // Data migration: Extract rank from item names and clean up names

            // Update items ending with " R30" - set Rank to 30 and remove " R30" from name
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Rank"" = 30, ""Name"" = LEFT(""Name"", LENGTH(""Name"") - 4)
                WHERE ""Name"" LIKE '% R30'
            ");

            // Update items ending with " R25" - set Rank to 25 and remove " R25" from name
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Rank"" = 25, ""Name"" = LEFT(""Name"", LENGTH(""Name"") - 4)
                WHERE ""Name"" LIKE '% R25'
            ");

            // Update items ending with " R20" - set Rank to 20 and remove " R20" from name
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Rank"" = 20, ""Name"" = LEFT(""Name"", LENGTH(""Name"") - 4)
                WHERE ""Name"" LIKE '% R20'
            ");

            // Update items ending with " R15" - set Rank to 15 and remove " R15" from name
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Rank"" = 15, ""Name"" = LEFT(""Name"", LENGTH(""Name"") - 4)
                WHERE ""Name"" LIKE '% R15'
            ");

            // Update items ending with " R0" - set Rank to 0 and remove " R0" from name
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Rank"" = 0, ""Name"" = LEFT(""Name"", LENGTH(""Name"") - 3)
                WHERE ""Name"" LIKE '% R0'
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse data migration: Restore rank suffixes to names before dropping columns

            // Restore " R30" suffix for items with Rank = 30
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Name"" = ""Name"" || ' R30'
                WHERE ""Rank"" = 30
            ");

            // Restore " R25" suffix for items with Rank = 25
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Name"" = ""Name"" || ' R25'
                WHERE ""Rank"" = 25
            ");

            // Restore " R20" suffix for items with Rank = 20
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Name"" = ""Name"" || ' R20'
                WHERE ""Rank"" = 20
            ");

            // Restore " R15" suffix for items with Rank = 15
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Name"" = ""Name"" || ' R15'
                WHERE ""Rank"" = 15
            ");

            // Restore " R0" suffix for items with Rank = 0
            migrationBuilder.Sql(@"
                UPDATE ""GearItems"" 
                SET ""Name"" = ""Name"" || ' R0'
                WHERE ""Rank"" = 0
            ");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "GearItems");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "GearItems");
        }
    }
}
