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
        public IEnumerable<Inventory> GetAllInventory()
        {
            return context.InventoryofAirlines;
        }

        public Inventory GetInventorybyId(int id)
        {
            return context.InventoryofAirlines.Find(id);
        }

        public Inventory InsertInventory(Inventory inv)
        {
            context.InventoryofAirlines.Add(inv);
            context.SaveChanges();
            return inv;
        }

       
    }
}
