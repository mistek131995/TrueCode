using Commands.Infrastructure.Interfaces;
using MediatR;

namespace Commands.Application.Commands.DeleteProduct;

public class CommandHandler(IRepositoryProvider repositoryProvider) : IRequestHandler<Command, Unit>
{
    public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
    {
        var product = await repositoryProvider.ProductRepository.GetByIdAsync(request.Id) 
                      ?? throw new NullReferenceException("Товар не найден");
        product.Condition = 0;
        await repositoryProvider.ProductRepository.SaveAsync(product);
        
        return Unit.Value;
    }
}