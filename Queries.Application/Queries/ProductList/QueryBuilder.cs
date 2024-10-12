namespace Queries.Application.Queries.ProductList;

public static class QueryBuilder
{
    public static string GetProducts(Query query) => @$"
            SELECT
            p.Id AS Id,
            p.Name AS Name,
            p.Price AS Price,
            P.PriceWithDiscount AS PriceWithDiscount,
			[pi].FileName AS FileName,
			[pi].ContentType AS ContentType,
			[pi].Path AS Path
            FROM Products p
			LEFT JOIN ProductImages [pi] ON p.Id = [pi].ProductId
            WHERE p.Condition = 1
            {(!string.IsNullOrEmpty(query.Name) ? " AND p.Name LIKE @Name" : "")}
            {(!string.IsNullOrEmpty(query.Article) ? " AND p.Article = @Article" : "")}
            
            {(query.Sorting == Query.SortingType.None ? " ORDER BY p.Id" : "")}
            {(query.Sorting == Query.SortingType.NameAZ ? " ORDER BY p.Name" : "")}
            {(query.Sorting == Query.SortingType.NameZA ? " ORDER BY p.Name DESC" : "")}
            {(query.Sorting == Query.SortingType.PriceMoreLess ? @" 
                ORDER BY 
                    CASE 
                        WHEN p.PriceWithDiscount < p.Price THEN p.PriceWithDiscount
                        ELSE p.Price
                    END" : "")}
            {(query.Sorting == Query.SortingType.PriceLessMore ? @" 
                ORDER BY 
                    CASE 
                        WHEN p.PriceWithDiscount < p.Price THEN p.PriceWithDiscount
                        ELSE p.Price
                    END DESC" : "")}
            
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