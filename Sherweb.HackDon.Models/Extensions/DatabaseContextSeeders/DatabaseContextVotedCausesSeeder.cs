using System;
using System.Collections.Generic;
using System.Linq;
using Sherweb.HackDon.Models.Entities;

namespace Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders
{
    internal static class DatabaseContextVotedCausesSeeder
    {
        internal static DatabaseContext SeedVotedCauses(this DatabaseContext databaseContext)
        {
            if (!databaseContext.VotedCauses.Any())
            {
                databaseContext.VotedCauses.AddRange(votedCauses);
                databaseContext.SaveChanges();
            }

            return databaseContext;
        }

        private static readonly List<VotedCause> votedCauses = new List<VotedCause> {
            new VotedCause
            {
                Id = Guid.NewGuid(),
                CauseId = DatabaseContextCausesSeeder.BreastCancer,
                LikedIt = true,
                Ratio = 0.15,
                UserId = DatabaseContextUsersSeeder.JeanDonnePas
            },
            new VotedCause
            {
                Id = Guid.NewGuid(),
                CauseId = DatabaseContextCausesSeeder.Deforestation,
                LikedIt = true,
                Ratio = 0.15,
                UserId = DatabaseContextUsersSeeder.JeanDonnePas
            },
            new VotedCause
            {
                Id = Guid.NewGuid(),
                CauseId = DatabaseContextCausesSeeder.Leukemia,
                LikedIt = true,
                Ratio = 0.20,
                UserId = DatabaseContextUsersSeeder.JeanDonnePas
            },
            new VotedCause
            {
                Id = Guid.NewGuid(),
                CauseId = DatabaseContextCausesSeeder.Prosthesis,
                LikedIt = true,
                Ratio = 0.50,
                UserId = DatabaseContextUsersSeeder.JeanDonnePas
            }
        };
    }
}