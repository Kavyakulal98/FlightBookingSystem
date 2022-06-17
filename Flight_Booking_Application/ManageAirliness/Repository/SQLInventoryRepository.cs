using ManageAirliness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Repository
{
    public class SQLInventoryRepository : IInventoryAirlineRepository
    {
        private readonly AppDBContext context;

        public SQLInventoryRepository(AppDBContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<Inventory> GetAllInventory(int id, bool value)
        {
            
            try
            {
                return context.InventoryofAirlines.Where(m=>m.AirlinesId == id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public Inventory GetInventorybyId(int id)
        {
            
            try
            {
                return context.InventoryofAirlines.Find(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public bool InsertInventory(Inventory inv)
        {
            try
            {
                context.InventoryofAirlines.Add(inv);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
           
        }


    }
}
