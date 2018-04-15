using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("Categories")]
    [EnableCors("AllowAll")]
    public class CategoriesController : Controller
    {
        private DatabaseContext DatabaseContext { get; set; }
        

        public CategoriesController(DatabaseContext databaseContext)
        {
            this.DatabaseContext = databaseContext;
        }

        // GET: /Categories
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get()
        {
            return Ok(this.DatabaseContext.Categories);
        }

        // GET: /Categories(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)?$select=Description

        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult Get([FromODataUri] Guid key)
        {
            return Ok(this.DatabaseContext.Categories.Where(w => w.Id == key));
        }

        [AcceptVerbs("OPTIONS")]

        public HttpResponseMessage Options()

        {

            HttpResponseMessage response = new HttpResponseMessage();

            response.Headers.Add("Allow", "GET, PUT, POST, DELETE, HEAD");

            return response;

        }
    }
}
