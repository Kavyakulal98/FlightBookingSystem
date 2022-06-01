using ManageAirliness.Model;
using ManageAirliness.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManageAirliness.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IInventoryAirlineRepository inventory;

      //  public IManageAirlineRepository airline;
        public InventoryController(IInventoryAirlineRepository _inventory)
        {
            inventory = _inventory;
        }
        //public InventoryController(IManageAirlineRepository _airline)
        //{
        //    airline = _airline;
        //}
        // GET: api/<InventoryController>
        [HttpGet]
        [Route("getAllInventory")]
        public IEnumerable<Inventory> Get()
        {
            return inventory.GetAllInventory();
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
      //  [Route("getAirlinebyId")]
        public Inventory Get(int id)
        {
            return inventory.GetInventorybyId(id);
        }

        // POST api/<InventoryController>
        [HttpPost]
        [Route("insertInventory")] 
        public void Post([FromBody] Inventory inv)
        {
            inventory.InsertInventory(inv);
        }
       


        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
