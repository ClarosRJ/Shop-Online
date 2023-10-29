using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            try
            {
                var product = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("Api/Product");
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
