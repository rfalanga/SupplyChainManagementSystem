using SupplyChainManagementSystem.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;
using SupplyChainManagementSystem.Server.Models;


/* 
 * This is from Listing 4 on the CODE Magazine article of March/April 2025
 * 
 * The ProductController class is responsible for handling HTTP requests related to products.
 * It uses the IProductRepository interface to interact with the data layer.
 * 
 * The controller has a single action method, GetAllProducts, which returns a list of all products.
 */
namespace SupplyChainManagementSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository   )
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetAllProducts")] // In the CODE magazine article this was named GetProducts
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProductsAsync();
        }
    }
}
