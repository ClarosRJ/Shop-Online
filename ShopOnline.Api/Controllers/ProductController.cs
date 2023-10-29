using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Extensions;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            try
            {
                var product = await productRepository.GetAllProduct();
                
                var categories = await productRepository.GetAllCategories();

                if (product==null || categories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = product.ConverToDto(categories); 
                    return Ok(productDtos); 
                }

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving data from database");
            }
        }

    }
}
