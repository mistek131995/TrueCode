using MediatR;

namespace Queries.Application.Queries.Product;

public class Query : IRequest<ViewModel>
{
    public Guid Id { get; set; }
}