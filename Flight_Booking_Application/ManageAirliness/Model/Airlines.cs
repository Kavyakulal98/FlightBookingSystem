using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Model
{
    public class Airlines
    {
        public int AirlinesId { get; set; }
        public string AirlineName { get; set; }  
        public int AirlineContactNumber { get; set; }
        public string AirlineAddress { get; set; }
        public bool IsBlocked { get; set; }

    }
}
