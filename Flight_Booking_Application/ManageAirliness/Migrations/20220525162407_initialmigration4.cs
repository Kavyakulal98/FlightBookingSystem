using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineEndDate",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlinePrice",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineStartDate",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineTotalCost",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "FromPlace",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "InstrumentUsed",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "Meal",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "NoOfRows",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "ToPlace",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "TotalBusinessClassSeats",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "TotalNonBusinessClassSeats",
                table: "AirlinesDetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AirlinesDetails",
                newName: "AirlinesId");

            migrationBuilder.CreateTable(
                name: "InventoryofAirlines",
                columns: table => new
                {
                    InventoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirlineId = table.Column<int>(nullable: false),
                    AirlineListAirlinesId = table.Column<int>(nullable: true),
                    FlightNumber = table.Column<int>(nullable: false),
                    AirlinePrice = table.Column<double>(nullable: false),
                    AirlineTotalCost = table.Column<double>(nullable: false),
                    FromPlace = table.Column<string>(nullable: true),
                    ToPlace = table.Column<string>(nullable: true),
                    AirlineStartDate = table.Column<DateTime>(nullable: true),
                    AirlineEndDate = table.Column<DateTime>(nullable: true),
                    InstrumentUsed = table.Column<string>(nullable: true),
                    TotalBusinessClassSeats = table.Column<int>(nullable: false),
                    TotalNonBusinessClassSeats = table.Column<int>(nullable: false),
                    NoOfRows = table.Column<int>(nullable: false),
                    Meal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryofAirlines", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_InventoryofAirlines_AirlinesDetails_AirlineListAirlinesId",
                        column: x => x.AirlineListAirlinesId,
                        principalTable: "AirlinesDetails",
                        principalColumn: "AirlinesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryofAirlines_AirlineListAirlinesId",
                table: "InventoryofAirlines",
                column: "AirlineListAirlinesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryofAirlines");

            migrationBuilder.RenameColumn(
                name: "AirlinesId",
                table: "AirlinesDetails",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AirlinesDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "AirlineEndDate",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AirlinePrice",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AirlineStartDate",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AirlineTotalCost",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightNumber",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromPlace",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstrumentUsed",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Meal",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfRows",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToPlace",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalBusinessClassSeats",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalNonBusinessClassSeats",
                table: "AirlinesDetails",
                nullable: true);
        }
    }
}
