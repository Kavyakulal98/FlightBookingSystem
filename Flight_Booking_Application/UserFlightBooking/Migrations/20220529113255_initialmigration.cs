using Microsoft.EntityFrameworkCore.Migrations;

namespace UserFlightBooking.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerDetailssql_FlightBookingDetailssql_FlightBookingId",
                table: "PassengerDetailssql");

            migrationBuilder.AlterColumn<int>(
                name: "FlightBookingId",
                table: "PassengerDetailssql",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerDetailssql_FlightBookingDetailssql_FlightBookingId",
                table: "PassengerDetailssql",
                column: "FlightBookingId",
                principalTable: "FlightBookingDetailssql",
                principalColumn: "FlightBookingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerDetailssql_FlightBookingDetailssql_FlightBookingId",
                table: "PassengerDetailssql");

            migrationBuilder.AlterColumn<int>(
                name: "FlightBookingId",
                table: "PassengerDetailssql",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerDetailssql_FlightBookingDetailssql_FlightBookingId",
                table: "PassengerDetailssql",
                column: "FlightBookingId",
                principalTable: "FlightBookingDetailssql",
                principalColumn: "FlightBookingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
