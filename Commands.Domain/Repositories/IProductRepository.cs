using DModels = Commands.Domain.Models;

namespace Commands.Domain.Repositories;

public interface IProductRepository : IBaseRepository
{
    Task<DModels.Product?> GetByIdAsync(Guid id);
    Task<List<DModels.Product>> GetByIdsAsync(List<Guid> ids);
    Task<DModels.Product> SaveAsync(DModels.Product product);
}