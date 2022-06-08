using ManageAirliness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Repository
{
    public class SQLAirlineRepository : IManageAirlineRepository
    {
        private readonly AppDBContext context;

        public SQLAirlineRepository(AppDBContext _context)
        {
            this.context = _context;
        }

        public Airlines InsertAirline(Airlines airline)
        {
            context.AirlinesDetails.Add(airline);
            context.SaveChanges();
            return airline;
        }

        public Airlines GetAirlinebyFlightId(int airlineId)
        {
            return context.AirlinesDetails.Find(airlineId);
        }

        public IEnumerable<Airlines> GetAllAirlines()
        {
            return context.AirlinesDetails;
        }
        public bool DeleteAirlines(int id)
        {
            Airlines flight = context.AirlinesDetails.Find(id);
            var allInventories = context.InventoryofAirlines.Where(a => a.AirlinesId == id);
            if (flight != null)
            {
                context.AirlinesDetails.Remove(flight);
                context.SaveChanges();
                if (allInventories != null)
                {
                    foreach (var inventory in allInventories)
                    {
                        context.InventoryofAirlines.Remove(inventory);
                    }
                    
                }
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public bool BlockAirlines(Airlines blockedAirline)
        {
            var employee = context.AirlinesDetails.Attach(blockedAirline);
            context.Entry(blockedAirline).Property(a => a.IsBlocked).IsModified = true;
            // employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
