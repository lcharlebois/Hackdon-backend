using Microsoft.EntityFrameworkCore;
using Sherweb.HackDon.Models.Entities;
using System.Linq;

namespace Sherweb.HackDon.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cause> Causes { get; set; }

        public DbSet<OSBL> OSBLs { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<VotedCause> VotedCauses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}