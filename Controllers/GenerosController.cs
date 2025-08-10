using ConectDatabase.Data;
using ConectDatabase;
using Microsoft.AspNetCore.Mvc;

namespace ConectDatabase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GenerosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostGenero(Genero novoGenero)
        {
            _context.Generos.Add(novoGenero);
            _context.SaveChanges();
            return Ok(novoGenero);
        }
    }
}

