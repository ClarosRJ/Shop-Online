using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ContextDB _context;
        public ProductRepository(ContextDB context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductCategory>> GetAllCategories()
        {
            var categories = await _context.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            var product = await _context.Products.ToListAsync();

            return product;
        }
    }
}
