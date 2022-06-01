using FlightSearchManagement.Repository;
using ManageAirliness.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightSearchManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchFlightController : ControllerBase
    {
        private IFlightSearchRepository sFlight;

        //  public IManageAirlineRepository airline;
        public SearchFlightController(IFlightSearchRepository _inventory)
        {
            sFlight = _inventory;
        }
        // GET: api/<SearchFlightController>
        [HttpGet]
        public IActionResult Get([FromBody]JObject data)
        {
            string airlinename = data["airlineName"].ToString();
            int airlineId = sFlight.GetAirlineIdbyName(airlinename);
            Inventory inv = data["inventory"].ToObject<Inventory>();
            IEnumerable<Inventory> flights = sFlight.SearchAirline(airlineId, inv.AirlineStartDate, inv.FromPlace, inv.ToPlace);           
            if (flights != null)
            {
                return Ok(flights); 
            }
            else
            {
                return NotFound("No Records Found");
            }
        }

        // POST api/<SearchFlightController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SearchFlightController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchFlightController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
