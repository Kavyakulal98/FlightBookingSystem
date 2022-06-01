using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryofAirlines_AirlinesDetails_AirlineListAirlinesId",
                table: "InventoryofAirlines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryofAirlines_AirlineListAirlinesId",
                table: "InventoryofAirlines");

            migrationBuilder.DropColumn(
                name: "AirlineListAirlinesId",
                table: "InventoryofAirlines");

            migrationBuilder.RenameColumn(
                name: "AirlineId",
                table: "InventoryofAirlines",
                newName: "AirlinesId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryofAirlines_AirlinesId",
                table: "InventoryofAirlines",
                column: "AirlinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryofAirlines_AirlinesDetails_AirlinesId",
                table: "InventoryofAirlines",
                column: "AirlinesId",
                principalTable: "AirlinesDetails",
                principalColumn: "AirlinesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryofAirlines_AirlinesDetails_AirlinesId",
                table: "InventoryofAirlines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryofAirlines_AirlinesId",
                table: "InventoryofAirlines");

            migrationBuilder.RenameColumn(
                name: "AirlinesId",
                table: "InventoryofAirlines",
                newName: "AirlineId");

            migrationBuilder.AddColumn<int>(
                name: "AirlineListAirlinesId",
                table: "InventoryofAirlines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryofAirlines_AirlineListAirlinesId",
                table: "InventoryofAirlines",
                column: "AirlineListAirlinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryofAirlines_AirlinesDetails_AirlineListAirlinesId",
                table: "InventoryofAirlines",
                column: "AirlineListAirlinesId",
                principalTable: "AirlinesDetails",
                principalColumn: "AirlinesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
