using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFlightBooking.Model;
using UserFlightBooking.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserFlightBooking.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookFlightController : ControllerBase
    {
        private IFlightBookingRepository flights;
        public UserBookFlightController(IFlightBookingRepository _flights)
        {
            flights = _flights;
        }
        // GET: api/<UserBookFlightController>
        //[HttpGet]
        //public IEnumerable<string> Get(id)
        //{
        //    return flights.GetBookingInfoByPnr(id)
        //}

        // GET api/<UserBookFlightController>/5
        [HttpGet("{id}")]
        public FlightBooking Get(int id)
        {
            return flights.GetBookingInfoByPnr(id);
        }

        // POST api/<UserBookFlightController>
        [HttpPost]
        [Route("bookFlight")]
        public void Post([FromBody] FlightBooking flightDetails)
        {
            flights.BookFlightbyUser(flightDetails);
        }

        // PUT api/<UserBookFlightController>/5
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserBookFlightController>/5
        [HttpDelete("{id}")]
        //[Route("cancelBooking")]
        public void Delete(int id)
        {
            flights.CancelBookingbyPnr(id);
        }
    }
}
