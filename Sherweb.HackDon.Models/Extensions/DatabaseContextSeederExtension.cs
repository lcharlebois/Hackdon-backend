using Sherweb.HackDon.Models.Extensions.DatabaseContextSeeders;

namespace Sherweb.HackDon.Models.Extensions
{
    public static class DbContextSeederExtension
    {
        public static void SeedDevData(this DatabaseContext context)
        {
            context.SeedCauses();
            context.SeedCategories();
            context.SeedSubCategories();
        }
    }
}