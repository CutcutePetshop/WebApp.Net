using Microsoft.EntityFrameworkCore;
using PetshopWebApp.Models;

namespace PetshopWebApp.Persistence
{
    public class OracleDbContext : DbContext
    {

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Petshop> PetShops { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Petshop)
                .WithMany(ps => ps.Reviews)
                .HasForeignKey(r => r.PetshopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.Petshop)
                .WithMany(ps => ps.Pets)
                .HasForeignKey(p => p.PetshopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Petshop)
                .WithMany(ps => ps.Products)
                .HasForeignKey(p => p.PetshopId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) 
        {

        }
    }
}
