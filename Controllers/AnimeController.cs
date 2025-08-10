using ConectDatabase.Data;
using ConectDatabase;
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
        
        [HttpPost]
        public IActionResult PostAnime(Anime novoAnime)
        {
            _context.Animes.Add(novoAnime);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = novoAnime.Id }, novoAnime);
        }
    }
}

