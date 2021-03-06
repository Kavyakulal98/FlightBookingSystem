using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserFlightBooking.Model
{
    public class PassengerDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string SeatNumber { get; set; }
        //public string MealOpted { get; set; }
        //public int NoofSelctedBusinessclassSeats { get; set; }
        //public int NoofSelctedNonBusinessclassSeats { get; set; }
        public string Seat { get; set; }
        public int SeatCount { get; set; }
        public int FlightBookingId { get; set; }
        //[ForeignKey("FlightBookingId")]
        //public FlightBooking FlightBooking { get; set; }
    }
}
