using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api
{
    public class Startup
    {
        private ILogger<Startup> _logger;

        public IConfiguration Configuration { get; }

        public Startup(ILogger<Startup> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }     

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
            services.AddDbContext<DatabaseContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("HackDonDatabase"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var builder = new ODataConventionModelBuilder(app.ApplicationServices);

            _logger.LogWarning($"Connection String Used: {Configuration.GetConnectionString("HackDonDatabase")}");

            builder.EntitySet<Models.Entities.OSBL>("OSBLs").EntityType.Filter(Microsoft.AspNet.OData.Query.QueryOptionSetting.Allowed);
            builder.EntitySet<Models.Entities.Category>("Categories").EntityType.Filter(Microsoft.AspNet.OData.Query.QueryOptionSetting.Allowed);
            
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
                routeBuilder.MapODataServiceRoute("ODataRoutes", null, builder.GetEdmModel());
                routeBuilder.EnableDependencyInjection();
            });
        }
    }
}
