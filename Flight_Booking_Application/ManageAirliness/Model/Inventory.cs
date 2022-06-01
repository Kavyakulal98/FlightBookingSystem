using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Model
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int AirlinesId { get; set; }
        public Airlines AirlineList { get; set; }
        public int FlightNumber { get; set; }
        public double AirlinePrice { get; set; }
        public double AirlineTotalCost { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime? AirlineStartDate { get; set; }
        public DateTime? AirlineEndDate { get; set; }
        public string InstrumentUsed { get; set; }
        public int TotalBusinessClassSeats { get; set; }
        public int TotalNonBusinessClassSeats { get; set; }
        public int NoOfRows { get; set; }
        public string Meal { get; set; }
        //public string Oneway { get; set; }
        //public string Roundway { get; set; }
    }
}
