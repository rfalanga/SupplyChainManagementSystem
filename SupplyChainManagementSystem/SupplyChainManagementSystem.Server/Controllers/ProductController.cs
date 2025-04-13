using SupplyChainManagementSystem.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;


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
    }
}
