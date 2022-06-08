
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFlightBooking.Model;


namespace UserFlightBooking.Repository
{
    public class FlightBookAppDBContext : DbContext
    {
        public FlightBookAppDBContext(DbContextOptions<FlightBookAppDBContext> options) : base(options)
        {

        }
        public DbSet<FlightBooking> FlightBookingDetailssql { get; set; }
        public DbSet<PassengerDetails> PassengerDetailssql { get; set; }
    }
}
