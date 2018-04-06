using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Sherweb.HackDon.Domain;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api.Controllers
{
    [ODataRoutePrefix("Partner")]
    public class PartnerController : Controller
    {
        public IPartnerService PartnerService { get; private set; }

        public DatabaseContext DatabaseContext { get; private set; }

        // GET: /Partners(3a9d67ca-e720-4c76-94cb-0ee64f1cb564)/News?$select=Description
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public IActionResult GetNews(Guid key)
        {
            return Ok(this.DatabaseContext.News.Where(w => w.PartnerId == key));
        }
    }
}
