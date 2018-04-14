using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("SubCategories")]
    public class SubCategoriesController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }
        

        public SubCategoriesController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        // GET: /Categories
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult GetSubCategories()
        {
            return Ok(this.DatabaseContext.SubCategories);
        }

        // GET: /Categories(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)?$select=Description
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult GetSubCategories([FromODataUri] Guid key)
        {
            return Ok(this.DatabaseContext.SubCategories.Where(w => w.Id == key));
        }
    }
}
