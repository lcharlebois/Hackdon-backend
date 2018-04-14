using System.Management.Automation;
using Microsoft.EntityFrameworkCore;
using Sherweb.HackDon.Models.Extensions;

namespace Moment.Services.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "Migrations")]
    public class InvokeMigrations : BaseCmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public SwitchParameter SeedData { get; set; }

        protected override void ExecuteProcess()
        {
            this.DbContext.Database.Migrate();

            if (this.SeedData.IsPresent)
            {
                this.DbContext.SeedDevData();
            }
        }
    }
}
