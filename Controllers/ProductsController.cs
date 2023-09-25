using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext _context; //common to use _ when creating private field name

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet] //get a list of products
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync(); //when using async method, don't have to use OK

            //return Ok(products); //ok is 200 response type
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) //api/products/3 - 3 is the id
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }
    }
}