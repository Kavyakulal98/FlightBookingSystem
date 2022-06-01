using ManageAirliness.Model;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement;
using UserManagement.Model;

namespace UserFlightBooking.Model
{
    public class FlightBooking
    {
        public int FlightBookingId { get; set; }
        public int UserId { get; set; }
        public int AirlineId { get; set; }

        public IEnumerable<PassengerDetails> Passengers { get; set; }

        public string MealOpted { get; set; }
        public string NoofSelctedSeats { get; set; }

    }
}
