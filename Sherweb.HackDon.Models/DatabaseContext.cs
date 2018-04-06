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

        public DbSet<News> News { get; set; }

        public DbSet<Partner> Partners { get; set; }

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