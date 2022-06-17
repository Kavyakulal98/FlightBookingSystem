using ManageAirliness.Model;
using ManageAirliness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearchManagement.Repository
{
    public class SQLFlightSearchRepository : IFlightSearchRepository
    {
        private readonly AppDBContext context;

        public SQLFlightSearchRepository(AppDBContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<Inventory> SearchAirline(int airlineId, DateTime travellDate, string pickupLocation,string dropLocation)
        {          
                //var query = context.InventoryofAirlines.Where(a => a.AirlinesId == airlineId && a.AirlineStartDate == travellDate && a.ToPlace == dropLocation && a.FromPlace == pickupLocation && a.AirlineList.IsBlocked == false);
                //return query;
            try
            {
                return context.InventoryofAirlines.Where(a => a.AirlinesId == airlineId && a.AirlineStartDate.Date.Equals(travellDate.Date) && a.ToPlace == dropLocation && a.FromPlace == pickupLocation && a.AirlineList.IsBlocked == false);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public int GetAirlineIdbyName(string name)
        {
            int query = context.AirlinesDetails.Where(a => a.AirlineName == name).SingleOrDefault().AirlinesId;
            return query;
        }
    }
}
