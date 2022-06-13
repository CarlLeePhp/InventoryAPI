using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Inventory.Entities;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Product> GetAllProducts()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Stock = 5;
            product.Unit = "Pack";

            return product;
        }
    }
}
