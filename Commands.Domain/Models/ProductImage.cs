namespace Commands.Domain.Models;

public class ProductImage(Guid id, Guid productId, string fileName, string path, string contentType)
{

    public Guid Id { get; set; } = id;
    public Guid ProductId { get; set; } = productId;
    public string FileName { get; set; } = fileName;
    public string Path { get; set; } = path;
    public string ContentType { get; set; } = contentType;
    
    public ProductImage(Guid productId, string fileName, string path, string contentType) : 
        this(productId, productId, fileName, path, contentType){}
}