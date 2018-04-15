using Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders;

namespace Sherweb.HackDon.Models.Extensions
{
    public static class DbContextSeederExtension
    {
        public static void SeedDevData(this DatabaseContext context)
        {
            context.SeedCategories();
            context.SeedSubCategories();
            context.SeedOSBLs();
            context.SeedCauses();
            context.SeedUsers();
            context.SeedVotedCauses();
        }
    }
}