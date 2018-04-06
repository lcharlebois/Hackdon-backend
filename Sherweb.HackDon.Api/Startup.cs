using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sherweb.HackDon.Models;

namespace Sherweb.HackDon.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

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

            builder.EntitySet<Models.Entities.News>("News").EntityType.Filter(Microsoft.AspNet.OData.Query.QueryOptionSetting.Allowed);
            
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
                routeBuilder.MapODataServiceRoute("ODataBusinessesRoute", "", builder.GetEdmModel());
                routeBuilder.EnableDependencyInjection();
            });
        }
    }
}
