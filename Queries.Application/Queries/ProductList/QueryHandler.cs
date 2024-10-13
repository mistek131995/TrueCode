using System.Data;
using System.Text;
using MediatR;
using Dapper;
using Microsoft.Extensions.Caching.Memory;

namespace Queries.Application.Queries.ProductList;

public class QueryHandler(IDbConnection connection, IMemoryCache memoryCache) : IRequestHandler<Query, ViewModel>
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

        // Параллельная загрузка изображений с кэшированием
        var loadImagesTasks = viewModel.Products
            .Where(x => !string.IsNullOrEmpty(x.Path) && File.Exists(x.Path))
            .Select(async product =>
            {
                if (!memoryCache.TryGetValue(product.Path, out byte[] imageData))
                {
                    imageData = await File.ReadAllBytesAsync(product.Path, cancellationToken);
                    memoryCache.Set(product.Path, imageData);
                }
                product.Image = imageData;
            }).ToArray();

        await Task.WhenAll(loadImagesTasks);

        return viewModel;
    }
}