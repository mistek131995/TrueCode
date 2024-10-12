using System.Data;
using System.Text;
using MediatR;
using Dapper;

namespace Queries.Application.Queries.ProductList;

public class QueryHandler(IDbConnection connection) : IRequestHandler<Query, ViewModel>
{
    public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
    {
        var viewModel = new ViewModel();

        var offset = (request.Page - 1) * request.CountProducts;

        var sqlBuilder = new StringBuilder();
        sqlBuilder.Append(QueryBuilder.GetProducts(request));
        sqlBuilder.Append(QueryBuilder.GetPageCount(request));

        await using var query = await connection.QueryMultipleAsync(sqlBuilder.ToString(), new
        {
            Offset = offset,
            PageSize = request.CountProducts,
            Name = request.Name != null ? $"%{request.Name}%" : null,
            request.Article
        });

        viewModel.Products = query.Read<ViewModel.Product>().ToList();
        viewModel.PageCount = query.ReadFirstOrDefault<int>();

        foreach (var product in viewModel.Products.Where(x => !string.IsNullOrEmpty(x.Path)))
        {
            product.Image = await File.ReadAllBytesAsync(product.Path, cancellationToken);
        }

        return viewModel;
    }
}