using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextUsersSeeder
    {

        internal static readonly Guid JeanDonnePas = Guid.Parse("4CDF52EB-7604-43B7-B11F-96924F8294F1");


        internal static DatabaseContext SeedUsers(this DatabaseContext databaseContext)
        {
            if (!databaseContext.VotedCauses.Any())
            {
                databaseContext.Users.AddRange(users);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<User> users = new List<User> {
            new User
            {
                Id = JeanDonnePas,
                Age = 25,
                FirstName = "Jean-Donne",
                LastName = "Pas"
                
            }
        };
    }
}