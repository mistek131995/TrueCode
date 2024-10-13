using Commands.Domain.Models;
using Commands.Domain.Repositories;
using Commands.Infrastructure.Contexts;
using Commands.Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Commands.Infrastructure.Repositories;

public class ProductImageRepository(SQLContext context) : IProductImageRepository
{
    public async Task<ProductImage?> GetByProductIdAsync(Guid productId)
    {
        var mapper = new ProductImageMapper();
        var productImage = await context.ProductImages
            .AsTracking()
            .FirstOrDefaultAsync(x => x.ProductId == productId);

        return productImage == null ? null : mapper.MappingToDomainModel(productImage);
    }

    public async Task<ProductImage> SaveAsync(ProductImage productImage)
    {
        var mapper = new ProductImageMapper();
        var dbProductImage = mapper.MappingToInfrastructureModel(productImage);
        
        var existingProductImage = context.ProductImages.FirstOrDefault(x => x.ProductId == productImage.ProductId);
        
        if(existingProductImage == null)
            context.ProductImages.Add(dbProductImage);
        else
            context.Entry(existingProductImage).CurrentValues.SetValues(dbProductImage);
        
        await context.SaveChangesAsync();

        return productImage;
    }

    public async Task DeleteByProductIdAsync(Guid productId)
    {
        var productImage = context.ProductImages.FirstOrDefault(x => x.ProductId == productId);
        context.ProductImages.Remove(productImage);
        await context.SaveChangesAsync();
    }
}