using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextSubCategoriesSeeder
    {
        internal static readonly Guid FightCancer = Guid.Parse("C193ED09-CF07-454C-81C7-7145952D388C");
        internal static readonly Guid Deforestation = Guid.Parse("EDFA2B9E-DFF5-4FD3-AF4E-ABEDDCE77E2E");
        internal static readonly Guid Oceans = Guid.Parse("EF205A2E-FEE1-45E9-970E-9198CAC319FC");
        internal static readonly Guid ChildDiseases = Guid.Parse("1B8CF9DB-175C-4D94-84DC-4582AA2D1D30");
        internal static readonly Guid Amputees = Guid.Parse("3B45DC01-70E7-4455-9C4E-FF75BAA6DC33");
        internal static readonly Guid FoodAndWaterSupplies = Guid.Parse("5BB3B425-E1B3-4019-B0E2-847E5F1D38D4");
        internal static readonly Guid Hurricane = Guid.Parse("075C0D31-2710-4FFB-8237-496EDF33769D");
        internal static readonly Guid Earthquakes = Guid.Parse("480C7AF4-E2B4-40DC-B31C-088F05D5F354");

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
                Id = Oceans,
                Title = "Cleanup the oceans",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.Environnement
            },
            new SubCategory
            {
                Id = Deforestation,
                Title = "Help prevent deforestation",
                Description = "Raises funds and develops strong and sustaining philanthropic relationships to support the highest level of adult health care through the funding of vital medical equipment, research, education and the provision of items that impact patient comfort and care.",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.Environnement
            },
            new SubCategory
            {
                Id = FightCancer,
                Title = "Fight cancer",
                Description = "Raises funds and develops strong and sustaining philanthropic relationships to support the highest level of adult health care through the funding of vital medical equipment, research, education and the provision of items that impact patient comfort and care.",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.HealthCare
            },
            new SubCategory
            {
                Id = ChildDiseases,
                Title = "Fight child diseases",
                Description = "Raises funds and develops strong and sustaining philanthropic relationships to support the highest level of adult health care through the funding of vital medical equipment, research, education and the provision of items that impact patient comfort and care.",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.HealthCare
            },
            new SubCategory
            {
                Id = Amputees,
                Title = "Amputees",
                Description = "Help people with physical disabilities to feel empowered and inspired to redefine what's possible",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.DisabledPeople
            },
            new SubCategory
            {
                Id = FoodAndWaterSupplies,
                Title = "Food and water supplies",
                Description = "Help the victims of war conflicts",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.WarConflicts
            },
            new SubCategory
            {
                Id = Hurricane,
                Title = "Hurricane",
                Description = "Reduce suffering, disease, and death in countries affected by natural disasters and complex emergencies",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.NaturalDisaster
            },
            new SubCategory
            {
                Id = Earthquakes,
                Title = "Earthquakes",
                Description = "Reduce suffering, disease, and death in countries affected by natural disasters and complex emergencies",
                IconUrl = "http://via.placeholder.com/50x50",
                CategoryId = DatabaseContextCategoriesSeeder.NaturalDisaster
            }
        };
    }
}