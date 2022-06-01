using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserFlightBooking.Migrations
{
    public partial class initialmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightBookingDetailssql_Airlines_AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightBookingDetailssql_User_UserdetailsUserId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_FlightBookingDetailssql_AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropIndex(
                name: "IX_FlightBookingDetailssql_UserdetailsUserId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropColumn(
                name: "AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropColumn(
                name: "UserdetailsUserId",
                table: "FlightBookingDetailssql");

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "FlightBookingDetailssql",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FlightBookingDetailssql",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "FlightBookingDetailssql");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlightBookingDetailssql");

            migrationBuilder.AddColumn<int>(
                name: "AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserdetailsUserId",
                table: "FlightBookingDetailssql",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    AirlinesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirlineAddress = table.Column<string>(nullable: true),
                    AirlineContactNumber = table.Column<int>(nullable: false),
                    AirlineName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.AirlinesId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingDetailssql_AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql",
                column: "AirlineDetailsAirlinesId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingDetailssql_UserdetailsUserId",
                table: "FlightBookingDetailssql",
                column: "UserdetailsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightBookingDetailssql_Airlines_AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql",
                column: "AirlineDetailsAirlinesId",
                principalTable: "Airlines",
                principalColumn: "AirlinesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightBookingDetailssql_User_UserdetailsUserId",
                table: "FlightBookingDetailssql",
                column: "UserdetailsUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
