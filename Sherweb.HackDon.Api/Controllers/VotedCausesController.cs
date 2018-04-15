using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [Route("api/[controller]")]
    public class VotedCausesController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }


        public VotedCausesController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this.DatabaseContext.VotedCauses);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(this.DatabaseContext.VotedCauses.Where(w => w.Id == id));
        }
    }
}
