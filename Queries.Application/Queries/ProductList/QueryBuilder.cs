namespace Queries.Application.Queries.ProductList;

public static class QueryBuilder
{
    public static string GetProducts(Query query) => @$"
            SELECT
            p.Id AS Id,
            p.Name AS Name,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
            p.ImagePath AS ImagePath
            FROM Products p
            
            {(!string.IsNullOrEmpty(query.Name) && string.IsNullOrEmpty(query.Article) ? " WHERE p.Name LIKE @Name" : "")}
            {(string.IsNullOrEmpty(query.Name) && !string.IsNullOrEmpty(query.Article) ? " WHERE p.Article = @Article" : "")}
            {(!string.IsNullOrEmpty(query.Name) && !string.IsNullOrEmpty(query.Article) ? " WHERE p.Name LIKE @Name AND p.Article = @Article" : "")}
            
            ORDER BY p.Id
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;
    ";

    public static string GetPageCount(Query query) => $@"
        SELECT 
        CEILING(CONVERT(DECIMAL(18, 1), COUNT(*)) / @PageSize) 
        FROM Products p
        
        {(!string.IsNullOrEmpty(query.Name) && string.IsNullOrEmpty(query.Article) ? " WHERE p.Name LIKE @Name" : "")}
        {(string.IsNullOrEmpty(query.Name) && !string.IsNullOrEmpty(query.Article) ? " WHERE p.Article = @Article" : "")}
        {(!string.IsNullOrEmpty(query.Name) && !string.IsNullOrEmpty(query.Article) ? " WHERE p.Name LIKE @Name AND p.Article = @Article" : "")}
    ";
}