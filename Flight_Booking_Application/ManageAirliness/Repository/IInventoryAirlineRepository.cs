using ManageAirliness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Repository
{
    public interface IInventoryAirlineRepository
    {
        Inventory GetInventorybyId(int id);
        IEnumerable<Inventory> GetAllInventory();
        Inventory InsertInventory(Inventory inv);
        
    }
}
