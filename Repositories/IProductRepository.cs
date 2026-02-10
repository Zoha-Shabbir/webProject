using MyMvcAuthProject.Models;

namespace MyMvcAuthProject.Repositories
{
    public interface IProductRepository
    {
        // Create
        Task<Product> AddProductAsync(Product product);
        
        // Read
        Task<Product?> GetProductByIdAsync(int id);
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Product>> GetProductsByCategoryAsync(string category);
        
        // Update
        Task<Product> UpdateProductAsync(Product product);
        
        // Delete
        Task<bool> DeleteProductAsync(int id);
        
        // Additional operations
        Task<bool> ProductExistsAsync(int id);
        Task SaveChangesAsync();
    }
}
