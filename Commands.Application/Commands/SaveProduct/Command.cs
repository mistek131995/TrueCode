using MediatR;

namespace Commands.Application.Commands.SaveProduct;

public class Command : IRequest<Guid>
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Article { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithDiscount { get; set; }
    public string ImageName { get; set; } = string.Empty;
    public string ContentType { get; set; } = String.Empty;
    public byte[]? Image { get; set; }
}