using SupplyChainManagementSystem.Server.DataAccess;
using System.Web.Mvc;

namespace SupplyChainManagementSystem.Server.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository   )
        {
            _productRepository = productRepository;
        }
    }
}
