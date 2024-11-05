using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using MinhaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PerguntaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Pergunta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pergunta>>> GetPerguntas()
        {
            return await _context.Perguntas.Include(p => p.Alternativas).ToListAsync();
        }

        // GET: api/Pergunta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pergunta>> GetPergunta(int id)
        {
            var pergunta = await _context.Perguntas.Include(p => p.Alternativas).FirstOrDefaultAsync(p => p.id_pergunta == id);
            if (pergunta == null) return NotFound();
            return pergunta;
        }

        // POST: api/Pergunta
        [HttpPost]
        public async Task<ActionResult<Pergunta>> PostPergunta(Pergunta pergunta)
        {
            _context.Perguntas.Add(pergunta);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetPergunta", new { id = pergunta.id_pergunta }, pergunta);
        }

        // PUT: api/Pergunta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPergunta(int id, Pergunta pergunta)
        {
            if (id != pergunta.id_pergunta) return BadRequest();

            _context.Entry(pergunta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerguntaExists(id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/Pergunta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePergunta(int id)
        {
            var pergunta = await _context.Perguntas.FindAsync(id);
            if (pergunta == null) return NotFound();

            _context.Perguntas.Remove(pergunta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar se uma pergunta existe
        private bool PerguntaExists(int id)
        {
            return _context.Perguntas.Any(e => e.id_pergunta == id);
        }
    }
}
