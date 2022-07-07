using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/HuntFishProducts")]
    [ApiController]
    public class HuntFishProductsController : ControllerBase
    {
        ApplicationContext db;

        public HuntFishProductsController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HuntFishProduct>>> Get()
        {
            return await db.HuntFishProducts.ToListAsync();
        }
    }
}
