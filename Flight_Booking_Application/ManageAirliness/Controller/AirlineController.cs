using ManageAirliness.Model;
using ManageAirliness.Repository;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class AirlineController : ControllerBase
    {
        private IManageAirlineRepository airline;
        public AirlineController(IManageAirlineRepository _airline)
        {
            airline = _airline;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        [Route("getAllAirline")]
        public IEnumerable<Airlines> Get()
        {
            return airline.GetAllAirlines().ToList();

        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Airlines Get(int id)
        {
            return airline.GetAirlinebyFlightId(id);
        }
        

        // POST api/<ValuesController>
        [HttpPost]
       [Route("insertAirline")]
        public IActionResult Post([FromBody] Airlines airlines)
        {
            bool apiresponse=airline.InsertAirline(airlines);
            return Ok(new{ apiresponse= apiresponse });
        }
       
        // PUT api/<ValuesController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Airlines airlines)
        {
            return Ok(new {apiresponse= airline.BlockAirlines(airlines) });
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new { apiresponse = airline.DeleteAirlines(id) }) ;
        }
    }
}
