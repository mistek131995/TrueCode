using System.Data;
using MediatR;
using Dapper;

namespace Queries.Application.Queries.ProductList;

public class QueryHandler(IDbConnection connection) : IRequestHandler<Query, ViewModel>
{
    public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
    {
        var viewModel = new ViewModel();

        var sql = @"
            SELECT
            p.Id AS Id,
            p.Description AS Description,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.ImagePath AS ImagePath,
            p.Condition AS Condition,
            p.Article AS Article
            FROM Products p
        ";

        viewModel.Products = (await connection.QueryAsync<ViewModel.Product>(sql, cancellationToken)).ToList();

        return viewModel;
    }
}