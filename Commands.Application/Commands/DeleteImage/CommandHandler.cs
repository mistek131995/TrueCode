using Commands.Infrastructure.Interfaces;
using MediatR;

namespace Commands.Application.Commands.DeleteImage;

public class CommandHandler(IRepositoryProvider repositoryProvider) : IRequestHandler<Command, Unit>
{
    public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
    {
        var productImage = await repositoryProvider.ProductImageRepository.GetByProductIdAsync(request.ProductId) ?? 
                           throw new NullReferenceException("Изображение не найдено.");
        
        await repositoryProvider.ProductImageRepository.DeleteByProductIdAsync(request.ProductId);
        File.Delete(productImage.Path);
        
        return Unit.Value;
    }
}