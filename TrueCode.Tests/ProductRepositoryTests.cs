using Commands.Infrastructure.Contexts;
using Commands.Infrastructure.Entities;
using Commands.Infrastructure.Mappers;
using Commands.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TrueCode.Tests
{
    public class ProductRepositoryTests
    {
        private readonly SQLContext _context;
        private readonly ProductRepository _repository;
        private readonly ProductMapper _mapper;

        public ProductRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<SQLContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new SQLContext(options);
            _repository = new ProductRepository(_context);
            _mapper = new ProductMapper();
        }

        [Fact]
        public async Task GetByIdsAsync_ReturnsNull_WhenProductNotFound()
        {
            // Act
            var result = await _repository.GetByIdAsync(Guid.NewGuid());

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetByIdsAsync_ReturnsProduct_WhenProductFound()
        {
            // Arrange
            var product = new Product { Id = Guid.NewGuid(), Name = "TestProduct", Article = "Article", Description = "Description", Price = 100m, PriceWithDiscount = 90m };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            // Act
            var result = await _repository.GetByIdAsync(product.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(product.Id, result.Id);
        }

        [Fact]
        public async Task SaveAsync_AddsNewProduct_WhenProductDoesNotExist()
        {
            // Arrange
            var product = new Commands.Domain.Models.Product(Guid.NewGuid(), "NewProduct", "Article", "Description", 100m, 90m, 1);

            // Act
            await _repository.SaveAsync(product);

            // Assert
            var savedProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            Assert.NotNull(savedProduct);
            Assert.Equal(product.Id, savedProduct.Id);
        }

        [Fact]
        public async Task SaveAsync_UpdatesExistingProduct_WhenProductExists()
        {
            // Arrange
            var product = new Product { Id = Guid.NewGuid(), Name = "ExistingProduct", Description = "Description", Price = 100m, PriceWithDiscount = 90m };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var updatedProduct = new Commands.Domain.Models.Product(product.Id, "UpdatedProduct", "Article", "UpdatedDescription", 120m, 110m, 1);

            // Act
            await _repository.SaveAsync(updatedProduct);

            // Assert
            var savedProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            Assert.NotNull(savedProduct);
            Assert.Equal("UpdatedProduct", savedProduct.Name);
            Assert.Equal(120m, savedProduct.Price);
        }

        [Fact]
        public async Task GetByIdsAsync_MultipleIds_ReturnsProducts()
        {
            // Arrange
            var product1 = new Product { Id = Guid.NewGuid(), Name = "Product1", Description = "Description1", Price = 100m, PriceWithDiscount = 90m };
            var product2 = new Product { Id = Guid.NewGuid(), Name = "Product2", Description = "Description2", Price = 200m, PriceWithDiscount = 180m };
            _context.Products.AddRange(product1, product2);
            await _context.SaveChangesAsync();

            var ids = new List<Guid> { product1.Id, product2.Id };

            // Act
            var result = await _repository.GetByIdsAsync(ids);

            // Assert
            Assert.Equal(2, result.Count);
        }
    }
}
