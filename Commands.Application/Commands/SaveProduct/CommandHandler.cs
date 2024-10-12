﻿using System.ComponentModel.DataAnnotations;
using Commands.Domain.Models;
using Commands.Infrastructure.Interfaces;
using MediatR;

namespace Commands.Application.Commands.SaveProduct;

public class CommandHandler(IRepositoryProvider repositoryProvider, IFileStorageService fileStorageService) : IRequestHandler<Command, Guid>
{
    public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
    {
        var validator = new CommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if(!validationResult.IsValid)
            throw new ValidationException("Форма заполнена неправильно");
        
        var imagePath = string.Empty;
            
        if(request.Image != null && request.Image.Length > 0)
            imagePath = await fileStorageService.SaveFileAsync(request.Image, request.ImageName, "image");
        
        var product = new Product(request.Id, request.Name, request.Article, request.Description, request.Price, request.PriceWithDiscount);
        await repositoryProvider.ProductRepository.SaveAsync(product);

        return product.Id;
    }
}