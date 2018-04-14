using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("OSBLs")]
    public class OSBLsController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }
        

        public OSBLsController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        // GET: /OSBLs
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult GetOSBLs()
        {
            return Ok(this.DatabaseContext.OSBLs);
        }

        // GET: /OSBLs(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)/News?$select=Description
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult GetOSBLs([FromODataUri] Guid key)
        {
            return Ok(this.DatabaseContext.OSBLs.Where(w => w.Id == key));
        }
    }
}
