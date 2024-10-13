namespace Queries.Application.Queries.ProductList;

public class ViewModel
{
    public List<Product> Products { get; set; }
    public int PageCount { get; set; }
    
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public string Price { get; set; }
        public string PriceWithDiscount { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Image { get; set; }
        
        internal string Path { get; set; }
    }
}