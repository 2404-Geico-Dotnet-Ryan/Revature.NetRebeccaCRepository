using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Data
{

    // We use AppDbContext in our code to interact with our database
    // Previously, with ADO, we created a Data Access Object related to the entity in SQL
    // Now we just need the AppDbContext object
    public class AppDbContext : DbContext
    {
        // This constructor is used by EF to create the needed DB Context based on our provided models
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        // We provide the models through DbSet<ModelName> fields
        public DbSet<User> Users {get;set;}
        public DbSet<Profile> Profiles {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products {get;set;}

        // We have to override the default behavior to ensure the foreign key constraint is established
        // If we don't do this, then the columns will still be created but the constrain is not
        // enforced
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-One relationship
            modelBuilder.Entity<User>()
                    .HasOne(u => u.Profile)
                    .WithOne(p => p.User)
                    .HasForeignKey<Profile>(p => p.UserId);

            // One-to-Many relationship
            modelBuilder.Entity<Category>()
                    .HasMany(c => c.Products)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId);
        }
    }
}