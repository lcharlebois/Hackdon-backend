using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using RawRabbit;
using RawRabbit.Configuration;
using RawRabbit.Instantiation;
using System;
using System.IO;
using System.Threading.Tasks;
using Moment.Services.Daemon.Handler.Deal;

namespace Moment.Services.Daemon
{
    internal class Program
    {
        private static void Main()
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("Options/RawRabbit.json", false)
                    .AddJsonFile("Options/ConnectionStrings.json", false)
                    .AddJsonFile("Options/OneSignal.json", false)
                    .Build();

            Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(new[] {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(2),
                    TimeSpan.FromSeconds(4)
                });

            var client = RawRabbitFactory.CreateSingleton(new RawRabbitOptions
            {
                ClientConfiguration = configuration.Get<RawRabbitConfiguration>(),
 
                 Plugins = p => p
                    .UseAttributeRouting()
                 //   .UsePolly(c => c
                 //       .UsePolicy(policy, PolicyKeys.QueueBind)
                 //       .UsePolicy(policy, PolicyKeys.QueueDeclare)
                 //       .UsePolicy(policy, PolicyKeys.ExchangeDeclare)
                 //)
            });

            //IoCContainerFactory.BuildConfigurationBuilder();
            var services = IoCContainerFactory.BuildServiceProvider(configuration);

            client.SubscribeAsync<ProfileMessage>(async msg =>
            {
                await Task.Run(() =>
                {
                    //Console.WriteLine($"Received: {context.GlobalRequestId}");
                    Console.WriteLine($"Received: {msg.Id}");

                    var service = services.GetService<NewNotificationWhenNewDealHandler>();

                    service.Handle(msg);
                });
            });

            //var message = new ProfileMessage()
            //{
            //    Id = Guid.NewGuid(),
            //    BusinessId = new Guid("3a9d67ca-e720-4c76-94cb-0ee64f1cb564"),
            //    StartDate = DateTime.Now.AddDays(1)

            //};
            //client.PublishAsync(message);
        }
    }
}
