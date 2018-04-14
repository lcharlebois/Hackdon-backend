using System.Management.Automation;
using Microsoft.EntityFrameworkCore;
using Sherweb.HackDon.Models.Extensions;

namespace Sherweb.HackDon.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "SeedDatabase")]
    public class SeedDatabase : BaseCmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public SwitchParameter SeedData { get; set; }

        protected override void ExecuteProcess()
        {
            //this.DbContext.Database.Migrate();

            if (this.SeedData.IsPresent)
            {
                this.DbContext.SeedDevData();
            }
        }
    }
}
