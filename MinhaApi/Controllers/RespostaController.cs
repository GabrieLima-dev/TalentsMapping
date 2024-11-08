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
    public class RespostaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RespostaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Resposta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resposta>>> GetRespostas()
        {
            // Inclui as entidades relacionadas Pergunta e Alternativa
            return await _context.Respostas
                                 .Include(r => r.Pergunta)
                                 .Include(r => r.Alternativa)
                                 .ToListAsync();
        }

        // GET: api/Resposta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resposta>> GetResposta(int id)
        {
            // Inclui as entidades relacionadas Pergunta e Alternativa
            var resposta = await _context.Respostas
                                         .Include(r => r.Pergunta)
                                         .Include(r => r.Alternativa)
                                         .FirstOrDefaultAsync(r => r.id_resposta == id);

            if (resposta == null)
            {
                return NotFound();
            }

            return resposta;
        }

        // POST: api/Resposta
        [HttpPost]
        public async Task<ActionResult<Resposta>> PostResposta(Resposta resposta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Respostas.Add(resposta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetResposta), new { id = resposta.id_resposta }, resposta);
        }

        // PUT: api/Resposta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResposta(int id, Resposta resposta)
        {
            if (id != resposta.id_resposta)
            {
                return BadRequest("O ID da URL não corresponde ao ID do objeto Resposta.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(resposta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespostaExists(id))
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

        // DELETE: api/Resposta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResposta(int id)
        {
            var resposta = await _context.Respostas
                                         .Include(r => r.Pergunta)
                                         .Include(r => r.Alternativa)
                                         .FirstOrDefaultAsync(r => r.id_resposta == id);

            if (resposta == null)
            {
                return NotFound();
            }

            _context.Respostas.Remove(resposta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar se uma resposta existe
        private bool RespostaExists(int id)
        {
            return _context.Respostas.Any(e => e.id_resposta == id);
        }
    }
}
