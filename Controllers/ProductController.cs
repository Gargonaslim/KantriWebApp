using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/AllProducts")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ApplicationContext db;
          
         public ProductController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllProduct>>> Get()
        {
            return await db.AllProducts.ToListAsync();
        }
   
        

        // GET api/Friends/5
        /*0[HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            Product product = await db.AllProducts.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                return NotFound();
            return new ObjectResult(product);
        }

        // POST api/Friends
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product Product)
        {
            if (Product == null)
            {
                return BadRequest();
            }

            db.AllProducts.Add(Product);
            await db.SaveChangesAsync();
            return Ok(Product);
        }

        // PUT api/Friends/
        [HttpPut]
        public async Task<ActionResult<Product>> Put(Product Product)
        {
            if (Product == null)
            {
                return BadRequest();
            }
            if (!db.AllProducts.Any(x => x.Id == Product.Id))
            {
                return NotFound();
            }

            db.Update(Product);
            await db.SaveChangesAsync();
            return Ok(Product);
        }

        // DELETE api/Friends/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            Product Product = db.AllProducts.FirstOrDefault(x => x.Id == id);
            if (Product == null)
            {
                return NotFound();
            }
            db.AllProducts.Remove(Product);
            await db.SaveChangesAsync();
            return Ok(Product);
        }*/
    }
}
