using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commands.Infrastructure.Entities;

public class ProductImage
{
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string FileName { get; set; }
    public string Path { get; set; }
    public string ContentType { get; set; }
}