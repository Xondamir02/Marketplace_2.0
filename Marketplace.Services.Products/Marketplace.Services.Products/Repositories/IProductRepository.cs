using Marketplace.Services.Products.Entities;

namespace Marketplace.Services.Products.Repositories
{
    public interface IProductRepository
    {
        Task AddProduct(Category category, Product product);
        Task UpdateProduct(Category category, Product product);
        Task DeleteProduct(Category category, Product product);
        Task<Product> GetProductById(Category category, Guid productId);
        Task<List<Product>> GetProducts(Category category);
    }
}
