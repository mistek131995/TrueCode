using MediatR;

namespace Commands.Application.Commands.DeleteProduct;

public class Command : IRequest<Unit>
{
    public Guid Id { get; set; }
}