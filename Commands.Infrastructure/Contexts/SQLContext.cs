using Commands.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Commands.Infrastructure.Contexts;

public class SQLContext : DbContext
{
    public SQLContext(DbContextOptions<SQLContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Price)
                .HasPrecision(18, 2);

            entity.Property(p => p.PriceWithDiscount)
                .HasPrecision(18, 2);
        });
        
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 1", 
                Price = 10.99m, 
                PriceWithDiscount = 8m, 
                Article = "1", 
                Description = "Product 1" , 
                Condition = 1
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 2", 
                Price = 10.99m, 
                PriceWithDiscount = 10m, 
                Article = "2", 
                Description = "Product 2" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 3", 
                Price = 20m, 
                PriceWithDiscount = 11m, 
                Article = "3", 
                Description = "Product 3" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 4", 
                Price = 22m, 
                PriceWithDiscount = 10m, 
                Article = "4", 
                Description = "Product 4" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 5", 
                Price = 60m, 
                PriceWithDiscount = 11m, 
                Article = "5", 
                Description = "Product 5" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 6", 
                Price = 55m, 
                PriceWithDiscount = 10m, 
                Article = "6", 
                Description = "Product 6" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 7", 
                Price = 44m, 
                PriceWithDiscount = 14m, 
                Article = "7", 
                Description = "Product 7" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 8", 
                Price = 10.99m, 
                PriceWithDiscount = 10m, 
                Article = "8", 
                Description = "Product 8" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 9", 
                Price = 13m, 
                PriceWithDiscount = 10m, 
                Article = "9", 
                Description = "Product 9" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 10", 
                Price = 17m, 
                PriceWithDiscount = 10m, 
                Article = "10", 
                Description = "Product 10" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 11", 
                Price = 19m, 
                PriceWithDiscount = 10m, 
                Article = "11", 
                Description = "Product 11" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 12", 
                Price = 14m, 
                PriceWithDiscount = 10m, 
                Article = "12", 
                Description = "Product 12" , 
                Condition = 1, 
            },
            new Product
            {
                Id = UUIDNext.Uuid.NewDatabaseFriendly(UUIDNext.Database.SqlServer), 
                Name = "Product 13", 
                Price = 25m, 
                PriceWithDiscount = 10m, 
                Article = "12", 
                Description = "Product 13" , 
                Condition = 1, 
            }
        );
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
}