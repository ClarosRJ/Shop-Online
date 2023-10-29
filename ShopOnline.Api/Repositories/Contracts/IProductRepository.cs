using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<IEnumerable<ProductCategory>> GetAllCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
