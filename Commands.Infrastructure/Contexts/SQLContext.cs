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
    }

    public DbSet<Product> Products { get; set; }
}