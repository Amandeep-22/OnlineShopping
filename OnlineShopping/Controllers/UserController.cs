using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext _context { get; }
        
        [HttpGet]
     [Route("getusers")]
        public ActionResult<IEnumerable<User>> Get()
        {
  
            return Ok(_context.Users.ToList());
        }

        [HttpPost]
        [Route("post/NewUser")]
        public ActionResult Post(User newUser)
        {  
            _context.Users.Add(newUser);
            _context.SaveChanges();

            return CreatedAtAction("Get", new { id = newUser.UID }, newUser);
        }

    }
}
