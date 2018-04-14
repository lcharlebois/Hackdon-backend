using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextOSBLsSeeder
    {
        internal static readonly Guid GreenPeace = Guid.Parse("C193ED09-CF07-454C-81C7-1111952D388C");
        internal static readonly Guid FondationCHUS = Guid.Parse("EDFA2B9E-DFF5-4FD3-1111-ABEDDCE77E2E");

        internal static DatabaseContext SeedOSBLs(this DatabaseContext databaseContext)
        {
            if (!databaseContext.OSBLs.Any())
            {
                databaseContext.OSBLs.AddRange(OSBLs);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<OSBL> OSBLs = new List<OSBL> {
            new OSBL
            {
                Id = GreenPeace,
                Description = "Greenpeace was founded in Vancouver in 1971, when a small boat of volunteers and journalists sailed into Amchitka, an area north of Alaska where the US Government was conducting underground nuclear tests. This tradition of 'bearing witness' in a non-violent manner continues, and our ships are an important part of all our campaign work.",
                Title = "La Fondation injecte des sommes très importantes en recherche médicale et en achat d'équipements médicaux.",
                ExternalOSBLUrl = "www.greenpeace.org",
                OSBLLogoUrl = "http://via.placeholder.com/350x150",
                OSBLName = "Green Peace"
            },
            new OSBL
            {
                Id = FondationCHUS,
                Description = "Notre mission est de contribuer à l’excellence des soins et des services prodigués à l’Hôpital Fleurimont et à l’Hôtel-Dieu de Sherbrooke, principalement par l’acquisition d’équipements médicaux  et en soutenant la recherche médicale.",
                Title = "La Fondation injecte des sommes très importantes en recherche médicale et en achat d'équipements médicaux.",
                ExternalOSBLUrl = "www.fondationchus.org",
                OSBLLogoUrl = "http://via.placeholder.com/350x150",
                OSBLName = "Fondation CHUS"
            }
        };
    }
}