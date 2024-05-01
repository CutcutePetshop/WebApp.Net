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

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) 
        {

        }
    }
}
