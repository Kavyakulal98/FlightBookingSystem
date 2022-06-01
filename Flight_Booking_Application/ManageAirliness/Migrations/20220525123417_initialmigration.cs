using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageAirliness.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlinesDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlightNumber = table.Column<int>(nullable: false),
                    AirlineName = table.Column<string>(nullable: true),
                    AirlinePrice = table.Column<double>(nullable: false),
                    AirlineContactNumber = table.Column<int>(nullable: false),
                    AirlineAddress = table.Column<string>(nullable: true),
                    AirlineStartDate = table.Column<DateTime>(nullable: true),
                    AirlineEndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlinesDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlinesDetails");
        }
    }
}
