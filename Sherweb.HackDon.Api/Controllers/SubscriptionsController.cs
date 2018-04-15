using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [Route("api/[controller]")]
    public class SubscriptionsController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }


        public SubscriptionsController(DatabaseContext databaseContext)
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
            return Ok(this.DatabaseContext.Subscriptions);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(this.DatabaseContext.Subscriptions.Where(w => w.Id == id));
        }
    }
}
