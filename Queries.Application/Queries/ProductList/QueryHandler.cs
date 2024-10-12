using System.Data;
using MediatR;
using Dapper;

namespace Queries.Application.Queries.ProductList;

public class QueryHandler(IDbConnection connection) : IRequestHandler<Query, ViewModel>
{
    public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
    {
        var viewModel = new ViewModel();

        var offset = (request.Page - 1) * request.CountProducts;

        var sql = @"
            SELECT
            p.Id AS Id,
            p.Name AS Name,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.ImagePath AS ImagePath
            FROM Products p
            ORDER BY p.Id
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;

            SELECT CEILING(CONVERT(DECIMAL(18, 1), COUNT(*)) / @PageSize) FROM Products
        ";

        await using var query = await connection.QueryMultipleAsync(sql, new
        {
            Offset = offset,
            PageSize = request.CountProducts,
        });

        viewModel.Products = query.Read<ViewModel.Product>().ToList();
        viewModel.PageCount = query.ReadFirstOrDefault<int>();

        return viewModel;
    }
}