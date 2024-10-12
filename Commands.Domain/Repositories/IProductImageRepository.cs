using Commands.Domain.Models;

namespace Commands.Domain.Repositories;

public interface IProductImageRepository : IBaseRepository
{
    Task<ProductImage?> GetByProductIdAsync(Guid productId);
    Task<ProductImage> SaveAsync(ProductImage productImage);
}