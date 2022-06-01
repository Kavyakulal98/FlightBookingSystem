using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirlineEndDate",
                table: "AirlinesDetails");

            migrationBuilder.DropColumn(
                name: "AirlineStartDate",
                table: "AirlinesDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AirlineEndDate",
                table: "AirlinesDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AirlineStartDate",
                table: "AirlinesDetails",
                nullable: true);
        }
    }
}
