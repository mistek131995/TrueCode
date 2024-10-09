using MediatR;

namespace Commands.Application.Commands.SaveProduct;

public class Command : IRequest<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithDiscount { get; set; }
    public string ImageName { get; set; }
    public byte[] Image { get; set; }
}