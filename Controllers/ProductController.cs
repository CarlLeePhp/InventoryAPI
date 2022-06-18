using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Inventory.Entities;
using Inventory.Data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> NewProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<Product>> UpdateProduct(Product product)
        {
            var oldProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            if(oldProduct != null)
            {
                oldProduct.WarnLevel = product.WarnLevel;
                oldProduct.Stock = product.Stock;
                
                _context.Entry<Product>(oldProduct).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok(oldProduct);
            }

            return NotFound();
        }
    }
}
