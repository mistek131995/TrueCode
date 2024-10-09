using Commands.Domain.Models;
using Commands.Infrastructure.Interfaces;
using MediatR;

namespace Commands.Application.Commands.SaveProduct;

public class CommandHandler(IRepositoryProvider repositoryProvider, IFileStorageService fileStorageService) : IRequestHandler<Command, Guid>
{
    public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
    {
        var filePath = await fileStorageService.SaveFileAsync(request.Image, request.ImageName, "image");
        
        var product = new Product(request.Name, request.Description, request.Price, request.PriceWithDiscount, filePath);
        await repositoryProvider.ProductRepository.SaveAsync(product);

        return product.Id;
    }
}