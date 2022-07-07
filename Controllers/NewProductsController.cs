using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/NewProducts")]
    [ApiController]
    public class NewProductsController : ControllerBase
    {
        ApplicationContext db;

        public NewProductsController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewProduct>>> Get()
        {
            return await db.NewProducts.ToListAsync();
        }
    }
}
