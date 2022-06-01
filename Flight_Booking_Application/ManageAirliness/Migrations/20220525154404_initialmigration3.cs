using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlightNumber",
                table: "AirlinesDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "AirlinePrice",
                table: "AirlinesDetails",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AirlinesDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "AirlineEndDate",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineEndDate",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineStartDate",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineTotalCost",
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

            migrationBuilder.AlterColumn<int>(
                name: "FlightNumber",
                table: "AirlinesDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AirlinePrice",
                table: "AirlinesDetails",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
