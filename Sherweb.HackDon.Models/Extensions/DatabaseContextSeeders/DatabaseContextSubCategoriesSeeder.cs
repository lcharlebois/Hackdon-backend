using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextSubCategoriesSeeder
    {

        internal static DatabaseContext SeedSubCategories(this DatabaseContext databaseContext)
        {
            if (!databaseContext.SubCategories.Any())
            {
                databaseContext.SubCategories.AddRange(SubCategories);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<SubCategory> SubCategories = new List<SubCategory> {
            new SubCategory
            {
                Id = Guid.NewGuid(),
                Title = "Cleanup the oceans",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.Environnement
            },
            new SubCategory
            {
                Id = HealthCare,
                Title = "Health Care",
                Description = "Raises funds and develops strong and sustaining philanthropic relationships to support the highest level of adult health care through the funding of vital medical equipment, research, education and the provision of items that impact patient comfort and care.",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new SubCategory
            {
                Id = WarConflicts,
                Title = "War conflicts",
                Description = "Help the victims of war conflicts",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new SubCategory
            {
                Id = DisabledPeople,
                Title = "Disabled people",
                Description = "Help people with physical disabilities to feel empowered and inspired to redefine what's possible",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new SubCategory
            {
                Id = NaturalDisaster,
                Title = "Natural disaster",
                Description = "Reduce suffering, disease, and death in countries affected by natural disasters and complex emergencies",
                IconUrl = "http://via.placeholder.com/50x50"
            }
        };
    }
}