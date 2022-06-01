using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Oneway",
                table: "InventoryofAirlines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roundway",
                table: "InventoryofAirlines",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "AirlinesDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oneway",
                table: "InventoryofAirlines");

            migrationBuilder.DropColumn(
                name: "Roundway",
                table: "InventoryofAirlines");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "AirlinesDetails");
        }
    }
}
