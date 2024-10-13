using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commands.Infrastructure.Entities;

public class ProductImage
{
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    [MaxLength(250)]
    public string FileName { get; set; }
    [MaxLength(500)]
    public string Path { get; set; }
    [MaxLength(250)]
    public string ContentType { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}