using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Model;
using UserManagement.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository user;

        public UserController(IUserRepository _user)
        {
             user = _user;
        }
        // GET: api/<UserController>
        [HttpGet]
        [Route("getAllUser")]
        public IEnumerable<User> Get()
        {
            return user.GetUser();
        }

        // GET api/<UserController>/5
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User presentUser = user.GetUserbyUserId(id);
            if(presentUser == null)
            {
                return NotFound("User does not exist");
            }
            else
            {
                return Ok(presentUser);
            }
        }

        //// GET api/<UserController>/5
        //[HttpGet("{username}/{password}")]
        //public IActionResult Get(string username, string password)
        //{
        //    User loggedUser = user.Login(username, password);
        //    if (loggedUser == null)
        //    {
        //        return NotFound("User does not exist.Please Register");
        //    }
        //    else
        //    {
        //        return Ok(loggedUser);
        //    }
      //  }

        // POST api/<UserController>
        [HttpPost]
        [Route("registerUser")]
        public void Post([FromBody] User userdetails)
        {
            user.RegisterUser(userdetails);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
