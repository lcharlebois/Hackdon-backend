using System;
using System.IO;
using System.Management.Automation;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sherweb.HackDon.Models;

namespace Moment.Services.Cmdlets
{
    public abstract class BaseCmdlet : PSCmdlet
    {
        protected ILogger Log { get; private set; }

        protected DatabaseContext DbContext { get; private set; }

        protected abstract void ExecuteProcess();

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            try
            {
                var executingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(executingDirectory)
                    .AddJsonFile("appsettings.json", false)
                    .Build();

                var services = new ServiceCollection();

                services.AddLogging();
                services.AddOptions();

                services.AddDbContext<DatabaseContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("HackDonDatabase"))
                );


                var serviceProvider = services.BuildServiceProvider();

                var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

                loggerFactory.AddConsole();

                this.Log = loggerFactory.CreateLogger(nameof(BaseCmdlet));

                this.DbContext = serviceProvider.GetRequiredService<DatabaseContext>();
            }
            catch (Exception e)
            {
                this.Log?.LogCritical("Error while configuring the cmdlet", e);

                this.ThrowTerminatingError(new ErrorRecord(e, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                this.ExecuteProcess();
            }
            catch (Exception e)
            {
                this.Log?.LogError($"Error in Cmdlet: '{this.GetType().FullName}'", e);
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            this.DbContext?.Dispose();
        }
    }
}