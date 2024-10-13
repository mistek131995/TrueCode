using MediatR;

namespace Commands.Application.Commands.DeleteImage;

public class Command : IRequest<Unit>
{
    public Guid ProductId { get; set; }
}