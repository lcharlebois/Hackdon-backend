using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextCategoriesSeeder
    {
        internal static readonly Guid Environnement = Guid.Parse("4CDF52EB-7604-43B7-B11F-96924F8294F1");
        internal static readonly Guid HealthCare = Guid.Parse("F21ED3D5-F43B-490B-A1AC-7B6881099FDA");
        internal static readonly Guid WarConflicts = Guid.Parse("C587EC5C-7F8E-4F55-B04C-116CE19EC65C");
        internal static readonly Guid DisabledPeople = Guid.Parse("2BFA99D8-58A2-4CB9-8F9D-33BD5EE81B05");
        internal static readonly Guid NaturalDisaster = Guid.Parse("EFC51C89-E68B-4829-9FDA-CC9F48E90BCA");

        internal static DatabaseContext SeedCategories(this DatabaseContext databaseContext)
        {
            if (!databaseContext.Categories.Any())
            {
                databaseContext.Categories.AddRange(Categories);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<Category> Categories = new List<Category> {
            new Category
            {
                Id = Environnement,
                Title = "Environnement",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new Category
            {
                Id = HealthCare,
                Title = "Health Care",
                Description = "Raises funds and develops strong and sustaining philanthropic relationships to support the highest level of adult health care through the funding of vital medical equipment, research, education and the provision of items that impact patient comfort and care.",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new Category
            {
                Id = WarConflicts,
                Title = "War conflicts",
                Description = "Help the victims of war conflicts",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new Category
            {
                Id = DisabledPeople,
                Title = "Disabled people",
                Description = "Help people with physical disabilities to feel empowered and inspired to redefine what's possible",
                IconUrl = "http://via.placeholder.com/50x50"
            },
            new Category
            {
                Id = NaturalDisaster,
                Title = "Natural disaster",
                Description = "Reduce suffering, disease, and death in countries affected by natural disasters and complex emergencies",
                IconUrl = "http://via.placeholder.com/50x50"
            }
        };
    }
}