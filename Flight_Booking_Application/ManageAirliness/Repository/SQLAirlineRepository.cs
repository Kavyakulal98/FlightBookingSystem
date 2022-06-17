using ManageAirliness.Model;
using Microsoft.AspNetCore.Mvc;
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

        public bool InsertAirline(Airlines airline)
        {
            try { 
            Airlines existingairline = new Airlines();
            existingairline = context.AirlinesDetails.Where(m => m.AirlineName == airline.AirlineName).SingleOrDefault();
            if (existingairline != null)
            {
                return false;
            }
            else
            {
                context.AirlinesDetails.Add(airline);
                context.SaveChanges();
                return true;
            }

        }
            catch(Exception ex)
            {
                throw(ex);
            }
        }

        public Airlines GetAirlinebyFlightId(int airlineId)
        {
            try { 
            return context.AirlinesDetails.Find(airlineId);
            }
            catch(Exception ex)
            {
                throw(ex);
            }
        }

        public IEnumerable<Airlines> GetAllAirlines()
        {
            try { 
                return context.AirlinesDetails; 
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            
        }
        public bool DeleteAirlines(int id)
        {
            try {
                Airlines flight = new Airlines();
                flight = context.AirlinesDetails.Find(id);
                IEnumerable<Inventory> allInventories = context.InventoryofAirlines.Where(a => a.AirlinesId == id);
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
            catch
            {
                return false;
            }
            
        }

        public bool BlockAirlines(Airlines blockedAirline)
        {
            blockedAirline.IsBlocked = blockedAirline.IsBlocked == true ? false : true;
            try {
                var employee = context.AirlinesDetails.Attach(blockedAirline);
                context.Entry(blockedAirline).Property(a => a.IsBlocked).IsModified = true;
                // employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
