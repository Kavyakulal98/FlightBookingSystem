using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Model;
using UserManagement.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IUserRepository user;
        private IConfiguration _configuration;
        public LoginController(IConfiguration configuration, IUserRepository _user)
        {
            _configuration = configuration; user = _user;
        }
        //jwt start
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User _userData)
        {
            //Dictionary<string, string> response = new Dictionary<string, string>();
            if (_userData != null && _userData.UserName != null && _userData.Password != null)
            {
                User loggedUser = await user.Login(_userData.UserName, _userData.Password);
                if (loggedUser != null)
                {
                    return Ok(new { response=generateToken(loggedUser),success=1 });
                   
                }
                else
                {
                    return BadRequest(new {  success = 0});
                }
            }
            else
            {
                return BadRequest(new { success = 0 });
            }
        
        }
        public  string generateToken(User loggedUser)
        {
            //if (_userData != null && _userData.UserName != null && _userData.Password != null)
            //{
            //    User loggedUser = await user.Login(_userData.UserName, _userData.Password);

                //if (loggedUser != null)
                //{
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", loggedUser.UserId.ToString()),
                       // new Claim("DisplayName", loggedUser.DisplayName),
                        new Claim("UserName", loggedUser.UserName),
                        new Claim("Email", loggedUser.EmailAddress)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
            //return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            //}
            //else
            //{
            //    return BadRequest("Invalid credentials");
            //}
            //}
            //else
            //{
            //    return BadRequest();
            //}
            //}
            //jwt end

            //[HttpGet("{username}/{password}")]
            //public IActionResult Get(string username, string password)
            //{
            //    UserDetails loggedUser = user.Login(username, password);
            //    if (loggedUser == null)
            //    {
            //        return NotFound("UserDetails does not exist.Please Register");
            //    }
            //    else
            //    {
            //        return Ok(loggedUser);
            //    }
        }
    }
}
