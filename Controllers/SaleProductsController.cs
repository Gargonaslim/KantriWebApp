using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/SaleProducts")]
    [ApiController]
    public class SaleProductsController : ControllerBase
    {
        ApplicationContext db;

        public SaleProductsController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleProduct>>> Get()
        {
            return await db.SaleProducts.ToListAsync();
        }
    }
}
