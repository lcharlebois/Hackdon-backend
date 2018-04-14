using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextCausesSeeder
    {
        internal static readonly Guid Climate = Guid.Parse("D3967784-9830-4079-9CE2-F82A21D751B9");
        internal static readonly Guid Mri = Guid.Parse("642A3B6D-FDE4-414D-97C5-060105555ADF");
        internal static readonly Guid LungCancer = Guid.Parse("66CDD454-DB0D-48D5-AD6D-01B28FE02B4F");
        internal static readonly Guid BreastCancer = Guid.Parse("0E8184C2-3E44-4B27-9595-539B13C446F4");
        internal static readonly Guid Leukemia = Guid.Parse("7ECA103F-47DC-485F-9EB5-1A861043DE6F");
        internal static readonly Guid Deforestation = Guid.Parse("E5336F93-B284-4B0E-BF3A-BC6B15DBB2BB");
        internal static readonly Guid Irma = Guid.Parse("B6919BE6-62D1-4D29-BFEC-313E85B2C972");
        internal static readonly Guid Prosthesis = Guid.Parse("A3345064-7590-4D15-99EA-363B56AF4694");

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
                Id = Climate,
                Title = "Stop climate change",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "https://www.greenpeace.org/archive-international/en/campaigns/climate-change/",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.GreenPeace,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.Oceans
            },
            new Cause
            {
                Id = Mri,
                Title = "Help us buy another MRI machine",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "https://www.greenpeace.org/archive-international/en/campaigns/climate-change/",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.FondationCHUS,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.FightCancer
            },
            new Cause
            {
                Id = LungCancer,
                Title = "Lung cancer research",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "https://www.greenpeace.org/archive-international/en/campaigns/climate-change/",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.FondationCHUS,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.FightCancer
            },
            new Cause
            {
                Id = BreastCancer,
                Title = "Breast cancer research",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.FondationCHUS,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.FightCancer
            },
            new Cause
            {
                Id = Leukemia,
                Title = "Fight child Leukemia",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.FondationCHUS,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.ChildDiseases
            },
            new Cause
            {
                Id = Guid.Parse("F06971B9-4B68-4D28-ACC9-75B9692EC83B"),
                Title = "Help feed war victims",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.GreenPeace,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.FoodAndWaterSupplies
            },
            new Cause
            {
                Id = Prosthesis,
                Title = "Buy new prosthesis",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.GreenPeace,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.Amputees
            },
            new Cause
            {
                Id = Irma,
                Title = "Help people that were hurt by Irma hurricane",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.GreenPeace,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.Hurricane
            },
            new Cause
            {
                Id = Deforestation,
                Title = "Stop bad people from cutting trees",
                Description = "Deeply complex, the climate system drives wind, water, and warmth around our beautiful blue planet, nurturing all life. But now our climate is changing fast. The cause is an old, broken energy system that pollutes our air and water, drives inequality and destroys priceless landscapes. We really have to change; we have only a limited time to act. Join us as we fight to end polluting coal, oil, gas and nuclear projects. Help us accelerate the urgent leap to a future powered by 100 percent clean renewable energy — the key to security and wellbeing for all.",
                ExternalProjectUrl = "http://www.cbcf.org/Pages/default.aspx",
                ProjectImageUrl = "http://via.placeholder.com/50x50",
                OSBLId =  DatabaseContextOSBLsSeeder.GreenPeace,
                SubCategoryId = DatabaseContextSubCategoriesSeeder.Deforestation
            }
        };
    }
}