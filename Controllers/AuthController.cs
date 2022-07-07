using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KantriWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantriWebApp.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        ApplicationContext db;

        public AuthController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthModel>>> Get()
        {
            return await db.Auth.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<AuthModel>> Post(AuthModel Auth)
        {
            if (Auth == null)
            {
                return BadRequest();
            }

            db.Auth.Add(Auth);
            await db.SaveChangesAsync();
            return Ok(Auth);
        }
    }
}
