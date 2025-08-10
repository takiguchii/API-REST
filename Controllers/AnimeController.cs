using ConectDatabase.Data;
using Microsoft.AspNetCore.Mvc;

namespace ConnectDatabase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AnimesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var animes = _context.Animes.ToList();
            return Ok(animes);
        }
    }
}

