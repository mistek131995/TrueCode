using Commands.Domain.Repositories;
using Commands.Infrastructure.Interfaces;
using Commands.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Commands.Infrastructure.Providers;

public class RepositoryProvider(IServiceProvider serviceProvider) : IRepositoryProvider
{
    private readonly Dictionary<Type, IBaseRepository> _repositories = new();
    private T Get<T>() where T : IBaseRepository
    {
        var type = typeof(T);
            
        if (_repositories.TryGetValue(type, out IBaseRepository repositories))
        {
            return (T)repositories;
        }

        repositories = ActivatorUtilities.CreateInstance<T>(serviceProvider) ?? 
                       throw new Exception($"Не удалось создать репозиторий {type.Name}");

        _repositories[type] = repositories;

        return (T)repositories;
    }
    
    public IProductRepository ProductRepository => Get<ProductRepository>();
    public IProductImageRepository ProductImageRepository => Get<ProductImageRepository>();
}