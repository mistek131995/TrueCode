using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commands.Infrastructure.Entities;

public class Product
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Article { get; set; }
    [MaxLength(250)]
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithDiscount { get; set; }
    public string ImagePath { get; set; }
    
    /// <summary>
    /// 0 - Удалено, 1 - Активно (Конечно можно было бы использовать Enum)
    /// </summary>
    public int Condition { get; set; }
}