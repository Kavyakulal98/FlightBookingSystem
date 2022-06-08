using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Model;
using ManageAirliness.Model;
//using UserFlightBooking.Model;

namespace UserManagement.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public string Password { get; set; }
        public  int Age { get; set; }
        public string Role { get; set; }
       // public IEnumerable<FlightBooking> FlightBookings { get; set; }

    }
}
