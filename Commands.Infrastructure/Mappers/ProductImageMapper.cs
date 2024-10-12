using Riok.Mapperly.Abstractions;
using DProductImage = Commands.Domain.Models.ProductImage;
using IProductImage = Commands.Infrastructure.Entities.ProductImage;

namespace Commands.Infrastructure.Mappers;

[Mapper]
public partial class ProductImageMapper
{
    public partial DProductImage MappingToDomainModel(IProductImage entity);
    public partial IProductImage MappingToInfrastructureModel(DProductImage entity);
}