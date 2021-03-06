// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserFlightBooking.Repository;

namespace UserFlightBooking.Migrations
{
    [DbContext(typeof(FlightBookAppDBContext))]
    [Migration("20220529114218_initialmigration12")]
    partial class initialmigration12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserFlightBooking.Model.FlightBooking", b =>
                {
                    b.Property<int>("FlightBookingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineId");

                    b.Property<string>("MealOpted");

                    b.Property<string>("NoofSelctedSeats");

                    b.Property<int>("UserId");

                    b.HasKey("FlightBookingId");

                    b.ToTable("FlightBookingDetailssql");
                });

            modelBuilder.Entity("UserFlightBooking.Model.PassengerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("FlightBookingId");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FlightBookingId");

                    b.ToTable("PassengerDetailssql");
                });

            modelBuilder.Entity("UserFlightBooking.Model.PassengerDetails", b =>
                {
                    b.HasOne("UserFlightBooking.Model.FlightBooking")
                        .WithMany("Passengers")
                        .HasForeignKey("FlightBookingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
