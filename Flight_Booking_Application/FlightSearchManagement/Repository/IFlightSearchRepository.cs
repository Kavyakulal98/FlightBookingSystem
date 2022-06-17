using ManageAirliness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearchManagement.Repository
{
   public interface IFlightSearchRepository
    {
        IEnumerable<Inventory> SearchAirline(int airlineId, DateTime travellDate, string pickupLocation, string dropLocation);
        int GetAirlineIdbyName(string name);
    }
}
