using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentVishalNew.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly AppDbContext _appDbContext;
        public LoginController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }




        [HttpGet("login")]
        public IActionResult DoLogin(string Username, string Password)
        {
            try
            {

                var user= _appDbContext.UserLogins.FirstOrDefault(l => l.UserName == Username && l.Password == Password);
                if (user != null)
                {
                    return Ok("User Exists");
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return Ok("User Exists");
        }
    }
}