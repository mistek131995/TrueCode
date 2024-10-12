using UUIDNext;

namespace Commands.Domain.Models;

public class Product(Guid id, string name, string article, string description, decimal price, decimal priceWithDiscount, string imagePath, int condition = 1)
{
    public Guid Id { get; } = id;
    public string Name { get; set; } = name;
    public string Article { get; set; } = article;
    public string Description { get; set; } = description;
    public decimal Price { get; set; } = price;
    public decimal PriceWithDiscount { get; set; } = priceWithDiscount;
    public string ImagePath { get; set; } = imagePath;
    
    /// <summary>
    /// 0 - Удалено, 1 - Активно (Конечно можно было бы использовать Enum)
    /// </summary>
    public int Condition { get; set; } = condition;
    
    public Product(string name, string article, string description, decimal price, decimal priceWithDiscount, string imagePath) : 
        this(Uuid.NewDatabaseFriendly(Database.SqlServer), name, article, description, price, priceWithDiscount, imagePath) {}
}