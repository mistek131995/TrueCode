using MediatR;
using Queries.Application.Queries.ProductList;

namespace Queries.Application.Queries.ProductList;

public class Query : IRequest<ViewModel>
{
    public string? Name { get; set; } = string.Empty;
    public string? Article { get; set; } = String.Empty;
    public int Page { get; set; }
    public int CountProducts { get; set; } = 10;
}