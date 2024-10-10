using MediatR;
using Queries.Application.Queries.ProductList;

namespace Queries.Application.Queries.ProductList;

public class Query : IRequest<ViewModel>
{
    public int Page { get; set; }
    public int CountProducts { get; set; } = 10;
}