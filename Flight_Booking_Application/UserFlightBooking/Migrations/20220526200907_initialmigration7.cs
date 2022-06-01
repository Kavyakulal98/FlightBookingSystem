using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserFlightBooking.Migrations
{
    public partial class initialmigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    AirlinesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirlineName = table.Column<string>(nullable: true),
                    AirlineContactNumber = table.Column<int>(nullable: false),
                    AirlineAddress = table.Column<string>(nullable: true)
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
                    UserName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "FlightBookingDetailssql",
                columns: table => new
                {
                    FlightBookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserdetailsUserId = table.Column<int>(nullable: true),
                    AirlineDetailsAirlinesId = table.Column<int>(nullable: true),
                    MealOpted = table.Column<string>(nullable: true),
                    NoofSelctedSeats = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBookingDetailssql", x => x.FlightBookingId);
                    table.ForeignKey(
                        name: "FK_FlightBookingDetailssql_Airlines_AirlineDetailsAirlinesId",
                        column: x => x.AirlineDetailsAirlinesId,
                        principalTable: "Airlines",
                        principalColumn: "AirlinesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlightBookingDetailssql_User_UserdetailsUserId",
                        column: x => x.UserdetailsUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PassengerDetailssql",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    FlightBookingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerDetailssql", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerDetailssql_FlightBookingDetailssql_FlightBookingId",
                        column: x => x.FlightBookingId,
                        principalTable: "FlightBookingDetailssql",
                        principalColumn: "FlightBookingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingDetailssql_AirlineDetailsAirlinesId",
                table: "FlightBookingDetailssql",
                column: "AirlineDetailsAirlinesId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingDetailssql_UserdetailsUserId",
                table: "FlightBookingDetailssql",
                column: "UserdetailsUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerDetailssql_FlightBookingId",
                table: "PassengerDetailssql",
                column: "FlightBookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassengerDetailssql");

            migrationBuilder.DropTable(
                name: "FlightBookingDetailssql");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
