using Riok.Mapperly.Abstractions;
using DModel = Commands.Domain.Models;
using IModel = Commands.Infrastructure.Entities;

namespace Commands.Infrastructure.Mappers;

[Mapper]
public partial class ProductMapper
{
    public partial DModel.Product MappingToDomainModel(IModel.Product entity);
    public partial List<DModel.Product> MappingToDomainModels(List<IModel.Product> entity);
    public partial IModel.Product MappingToInfrastructureModel(DModel.Product entity);
    public partial List<IModel.Product> MappingToInfrastructureModels(List<DModel.Product> entity);
}