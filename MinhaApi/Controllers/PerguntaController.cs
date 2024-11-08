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
            // Inclui as alternativas relacionadas ao retornar as perguntas
            return await _context.Perguntas.Include(p => p.Alternativa).ToListAsync();
        }

        // GET: api/Pergunta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pergunta>> GetPergunta(int id)
        {
            // Inclui as alternativas relacionadas ao buscar uma pergunta específica
            var pergunta = await _context.Perguntas.Include(p => p.Alternativa)
                                                   .FirstOrDefaultAsync(p => p.id_pergunta == id);

            if (pergunta == null)
            {
                return NotFound();
            }

            return pergunta;
        }

        // POST: api/Pergunta
        [HttpPost]
        public async Task<ActionResult<Pergunta>> PostPergunta(Pergunta pergunta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Perguntas.Add(pergunta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPergunta), new { id = pergunta.id_pergunta }, pergunta);
        }

        // PUT: api/Pergunta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPergunta(int id, Pergunta pergunta)
        {
            if (id != pergunta.id_pergunta)
            {
                return BadRequest("O ID da URL não corresponde ao ID do objeto Pergunta.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(pergunta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerguntaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Pergunta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePergunta(int id)
        {
            var pergunta = await _context.Perguntas.Include(p => p.Alternativa).FirstOrDefaultAsync(p => p.id_pergunta == id);
            if (pergunta == null)
            {
                return NotFound();
            }

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
