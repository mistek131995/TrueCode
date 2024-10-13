using System.Data;
using MediatR;
using Dapper;

namespace Queries.Application.Queries.Product;

public class QueryHandler(IDbConnection connection) : IRequestHandler<Query, ViewModel>
{
    public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
    {
        var viewModel = new ViewModel();

        var sql = @"
            SELECT TOP 1
            p.Id AS Id,
            p.Name AS Name,
            p.Description AS Description,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.Condition AS Condition,
            p.Article AS Article,
			[pi].FileName AS FileName,
			[pi].ContentType AS ContentType,
			[pi].Path AS Path
            FROM Products p
			LEFT JOIN ProductImages [pi] ON p.Id = [pi].ProductId
			WHERE p.Id = @Id
        ";

        viewModel = await connection.QueryFirstAsync<ViewModel>(sql, request);
        
        if(!string.IsNullOrEmpty(viewModel.Path) && File.Exists(viewModel.Path))
	        viewModel.Image = await File.ReadAllBytesAsync(viewModel.Path, cancellationToken);

        return viewModel;
    }
}