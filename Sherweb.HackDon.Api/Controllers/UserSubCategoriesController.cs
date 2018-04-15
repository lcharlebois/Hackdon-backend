using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserSubCategoriesController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }


        public UserSubCategoriesController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this.DatabaseContext.UserSubCategories);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(this.DatabaseContext.UserSubCategories.Where(w => w.Id == id));
        }
    }
}
