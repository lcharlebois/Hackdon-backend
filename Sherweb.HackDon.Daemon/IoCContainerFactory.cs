using Gorilla.Startup.OneSignal;
using Gorilla.Startup.OneSignal.Recipient.Factory;
using Gorilla.Startup.OneSignal.Recipient.Resolver;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moment.Services.Daemon.Handler.Deal;
using Moment.Services.Models;

namespace Moment.Services.Daemon
{
    public static class IoCContainerFactory
    {
        private static readonly IServiceCollection Services = new ServiceCollection();
        
        //public static void BuildConfigurationBuilder()
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", false);

        //    Configuration = builder.Build();

        //    var stuff = Configuration.GetSection("OneSignalSettings");
        //}

        public static ServiceProvider BuildServiceProvider(IConfigurationRoot configuration)
        {
            Services.AddOptions();
            Services.AddTransient<IRecipientFactory, RecipientFactory>();
            Services
                .AddTransient<IOneSignalNotificationService, OneSignalNotificationService>(
                    s => new OneSignalNotificationService(
                        s.GetService<IOptions<OneSignalOptions>>().Value,
                        s.GetService<IRecipientFactory>()));
            Services.AddTransient<NewNotificationWhenNewDealHandler, NewNotificationWhenNewDealHandler>();

            Services.AddSingleton<IRecipientFactory, RecipientFactory>();
            Services.AddSingleton<INotificationRecipientsResolver, DeveloperRecipientsResolver>();
            
            Services.Configure<OneSignalOptions>(configuration);
            Services.AddDbContext<MomentContext>(options => {
                var conn = configuration.GetConnectionString("MomentDatabase");
                options.UseSqlServer(conn);
                }
            );
            return Services.BuildServiceProvider();
        }
    }

    public class Tester
    {
        public OneSignalOptions Options1 { get; }

        public Tester(IOptions<OneSignalOptions> options)
        {
            Options1 = options.Value;
        }
    }

    public class ConnectionStrings
    {
        public string MomentDatabase { get; set; }
    }
}
