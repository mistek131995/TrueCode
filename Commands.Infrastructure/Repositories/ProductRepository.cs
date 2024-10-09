using Commands.Domain.Models;
using Commands.Domain.Repositories;
using Commands.Infrastructure.Contexts;
using Commands.Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Commands.Infrastructure.Repositories;

public class ProductRepository(SQLContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Guid id)
    {
        var mapper = new ProductMapper();
        var product = await context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
        
        return product == null ? null : mapper.MappingToDomainModel(product);
    }

    public async Task<List<Product>> GetByIdsAsync(List<Guid> ids)
    {
        var mapper = new ProductMapper();
        var products = await context.Products
            .AsNoTracking()
            .Where(p => ids.Contains(p.Id))
            .ToListAsync();

        return mapper.MappingToDomainModels(products);
    }

    public async Task<Product> SaveAsync(Product product)
    {
        var mapper = new ProductMapper();
        var dbProduct = mapper.MappingToInfrastructureModel(product);
        
        var existProduct = await context.Products.FindAsync(product.Id);

        if (existProduct == null)
            context.Products.Add(dbProduct);
        else
            context.Entry(existProduct).CurrentValues.SetValues(dbProduct);
        
        await context.SaveChangesAsync();

        return product;
    }
}