using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;
using Sherweb.HackDon.Models.Extensions;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("Posts")]
    public class PostsController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }
        

        public PostsController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
            this.DatabaseContext.SeedDevData();
        }

        // GET: /Posts
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get()
        {
            return Ok(this.DatabaseContext.Posts);
        }

        // GET: /Posts(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)?$select=Description
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get([FromODataUri] Guid key)
        {
            return Ok(this.DatabaseContext.Posts.Where(w => w.Id == key));
        }
    }
}
