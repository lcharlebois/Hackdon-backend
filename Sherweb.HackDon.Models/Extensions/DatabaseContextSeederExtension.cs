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
            if (context.News.Any())
            {
                return; // DB has been seeded
            }

            // Seed ClientUsers
            
            context.News.AddRange(GenerateNews());

            context.SaveChanges();
        }

        private static List<News> GenerateNews()
        {
            return new List<News> {
                new News
                {
                    Id = Guid.NewGuid(),
                }
            };
        }
    }
}