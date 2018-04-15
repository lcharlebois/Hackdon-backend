using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("Users")]
    public class UsersController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }
        

        public UsersController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        // GET: /Users
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get()
        {
            return Ok(this.DatabaseContext.Users);
        }

        // GET: /Users(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)?$select=Description
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get([FromODataUri] Guid key)
        {
            return Ok(this.DatabaseContext.Users.Where(w => w.Id == key));
        }
    }
}
