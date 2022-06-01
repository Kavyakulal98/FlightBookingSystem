﻿// <auto-generated />
using System;
using ManageAirliness.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageAirliness.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220525162834_initialmigration6")]
    partial class initialmigration6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManageAirliness.Model.Airlines", b =>
                {
                    b.Property<int>("AirlinesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirlineAddress");

                    b.Property<int>("AirlineContactNumber");

                    b.Property<string>("AirlineName");

                    b.HasKey("AirlinesId");

                    b.ToTable("AirlinesDetails");
                });

            modelBuilder.Entity("ManageAirliness.Model.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AirlineEndDate");

                    b.Property<double>("AirlinePrice");

                    b.Property<DateTime?>("AirlineStartDate");

                    b.Property<double>("AirlineTotalCost");

                    b.Property<int>("AirlinesId");

                    b.Property<int>("FlightNumber");

                    b.Property<string>("FromPlace");

                    b.Property<string>("InstrumentUsed");

                    b.Property<string>("Meal");

                    b.Property<int>("NoOfRows");

                    b.Property<string>("ToPlace");

                    b.Property<int>("TotalBusinessClassSeats");

                    b.Property<int>("TotalNonBusinessClassSeats");

                    b.HasKey("InventoryId");

                    b.HasIndex("AirlinesId");

                    b.ToTable("InventoryofAirlines");
                });

            modelBuilder.Entity("ManageAirliness.Model.Inventory", b =>
                {
                    b.HasOne("ManageAirliness.Model.Airlines", "AirlineList")
                        .WithMany()
                        .HasForeignKey("AirlinesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
