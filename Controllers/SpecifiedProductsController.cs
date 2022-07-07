using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/SpecifiedProducts")]
    [ApiController]
    public class SpecifiedProductsController : ControllerBase
    {
        ApplicationContext db;

        public SpecifiedProductsController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecifiedProduct>>> Get()
        {
            return await db.SpecifiedProducts.ToListAsync();
        }
    }
}
