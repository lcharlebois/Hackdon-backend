using Sherweb.HackDon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sherweb.HackDon.Models.Extensions
{
    public static class DbContextSeederExtension
    {
        public static void SeedDevData(this DatabaseContext context)
        {
            if (context.OSBLs.Any())
            {
                return; // DB has been seeded
            }

            // Seed ClientUsers
            
            context.OSBLs.AddRange(GenerateOSBLs());

            context.SaveChanges();
        }

        private static List<OSBL> GenerateOSBLs()
        {
            return new List<OSBL> {
                new OSBL
                {
                    Id = Guid.NewGuid(),
                }
            };
        }
    }
}