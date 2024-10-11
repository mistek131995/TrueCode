﻿using System.Data;
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
            p.Description AS Description,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.ImagePath AS ImagePath,
            p.Condition AS Condition,
            p.Article AS Article
            FROM Products p
            ORDER BY p.Id
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;
        ";

        viewModel.Products = (await connection.QueryAsync<ViewModel.Product>(sql, new
        {
            Offset = offset,
            PageSize = request.CountProducts,
        })).ToList();

        return viewModel;
    }
}