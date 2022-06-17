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
        [HttpPost("{airlinename}")]
        public IEnumerable<Inventory> Post(string airlinename, [FromBody] Inventory inv)
        {
            //string airlinename = data["airlineName"].ToString();JObject data
            int airlineId = sFlight.GetAirlineIdbyName(airlinename);
            //Inventory inv = data["inventory"].ToObject<Inventory>();
            //IEnumerable<Inventory> flights = new Inventory();
            //DateTime myDateTime = (DateTime)inv.AirlineStartDate;
            //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return sFlight.SearchAirline(airlineId, inv.AirlineStartDate, inv.FromPlace, inv.ToPlace);           
            //if (flights != null)
            //{
                //return flights;
            //}
            //else
            //{
            //    return NotFound("No Records Found");
            //}
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
