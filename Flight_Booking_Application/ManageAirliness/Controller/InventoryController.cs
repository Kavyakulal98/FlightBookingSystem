using DinkToPdf;
using ManageAirliness.Model;
using ManageAirliness.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf.Contracts;

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
        [HttpGet("{id}/{value}")]
        // [Route("getAllInventory")]
        public IEnumerable<Inventory> Get(int id, bool value)
        {
            return inventory.GetAllInventory(id, value);
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
        public IActionResult Post([FromBody] Inventory inv)
        {
            return Ok(new { apiresponse = inventory.InsertInventory(inv) });
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


