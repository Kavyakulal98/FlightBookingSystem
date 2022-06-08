//using ManageAirliness.Model;
//using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using UserManagement;
//using UserManagement.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserFlightBooking.Model
{
    public class FlightBooking
    {
        public int FlightBookingId { get; set; }
        public int UserId { get; set; }
        // [ForeignKey("AirlinesId")]
        public int AirlinesId { get; set; }
        //public virtual Airlines Airlines { get; set; }
        //////[ForeignKey("InventoryId")]
        public int InventoryId { get; set; }
        //public virtual Inventory Inventory { get; set; }
        ////[ForeignKey("UserId")]
        //public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User Usewr { get; set; }
        public virtual IEnumerable<PassengerDetails> Passengers { get; set; }
        public string MealOpted { get; set; }
        public int NoofSelctedBusinessclassSeats { get; set; }
        public int NoofSelctedNonBusinessclassSeats { get; set; }
        public DateTime BookedDate { get; set; }

    }
}
