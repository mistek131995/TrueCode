using Commands.Domain.Repositories;

namespace Commands.Infrastructure.Interfaces;

public interface IRepositoryProvider
{
    IProductRepository ProductRepository { get; }
}