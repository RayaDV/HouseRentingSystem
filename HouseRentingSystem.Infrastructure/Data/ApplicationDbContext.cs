using HouseRentingSystem.Infrastructure.Data.Models;
using HouseRentingSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<House>()        // moved to HouseConfiguration.cs
            //    .HasOne(h => h.Category)
            //    .WithMany(c => c.Houses)
            //    .HasForeignKey(h => h.CategoryId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<House>()
            //    .HasOne(h => h.Agent)
            //    .WithMany()
            //    .HasForeignKey(h => h.AgentId)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());

            base.OnModelCreating(builder);
        }

    }
}
