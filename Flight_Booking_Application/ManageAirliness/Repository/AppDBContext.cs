using ManageAirliness.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Repository
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Airlines> AirlinesDetails { get; set; }
        public DbSet<Inventory> InventoryofAirlines { get; set; }
    }
}
