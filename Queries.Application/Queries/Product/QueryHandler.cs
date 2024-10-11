using System.Data;
using MediatR;
using Dapper;

namespace Queries.Application.Queries.Product;

public class QueryHandler(IDbConnection connection) : IRequestHandler<Query, ViewModel>
{
    public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
    {
        var result = new ViewModel();

        var sql = @"
            SELECT TOP 1
            p.Id AS Id,
            p.Name AS Name,
            p.Description AS Description,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.ImagePath AS ImagePath,
            p.Condition AS Condition,
            p.Article AS Article
            FROM Products p
			WHERE p.Id = @Id
        ";

        result = await connection.QueryFirstAsync<ViewModel>(sql, request);

        return result;
    }
}