using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextCausesSeeder
    {
        internal static DatabaseContext SeedCauses(this DatabaseContext databaseContext)
        {
            if (!databaseContext.Causes.Any())
            {
                databaseContext.Causes.AddRange(Causes);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<Cause> Causes = new List<Cause> {
            new Cause
            {
                Id = Guid.NewGuid(),
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                Title = "Stop climate change"
            }
        };
    }
}