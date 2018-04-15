using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }


        public UsersController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this.DatabaseContext.Users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(this.DatabaseContext.Users.Where(w => w.Id == id));
        }
    }
}
