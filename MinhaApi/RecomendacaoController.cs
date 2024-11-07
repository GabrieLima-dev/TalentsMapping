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
    public class RecomendacaoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RecomendacaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Recomendacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recomendacao>>> GetRecomendacoes()
        {
            // Inclui as entidades relacionadas Curso e Teste
            return await _context.Recomendacoes
                                 .Include(r => r.Curso)
                                 .Include(r => r.Teste)
                                 .ToListAsync();
        }

        // GET: api/Recomendacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recomendacao>> GetRecomendacao(int id)
        {
            // Inclui as entidades relacionadas Curso e Teste
            var recomendacao = await _context.Recomendacoes
                                             .Include(r => r.Curso)
                                             .Include(r => r.Teste)
                                             .FirstOrDefaultAsync(r => r.id_recomendacao == id);

            if (recomendacao == null)
            {
                return NotFound();
            }

            return recomendacao;
        }

        // POST: api/Recomendacao
        [HttpPost]
        public async Task<ActionResult<Recomendacao>> PostRecomendacao(Recomendacao recomendacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Recomendacoes.Add(recomendacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecomendacao), new { id = recomendacao.id_recomendacao }, recomendacao);
        }

        // PUT: api/Recomendacao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecomendacao(int id, Recomendacao recomendacao)
        {
            if (id != recomendacao.id_recomendacao)
            {
                return BadRequest("O ID da URL não corresponde ao ID do objeto Recomendacao.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(recomendacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecomendacaoExists(id))
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

        // DELETE: api/Recomendacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecomendacao(int id)
        {
            var recomendacao = await _context.Recomendacoes
                                             .Include(r => r.Curso)
                                             .Include(r => r.Teste)
                                             .FirstOrDefaultAsync(r => r.id_recomendacao == id);

            if (recomendacao == null)
            {
                return NotFound();
            }

            _context.Recomendacoes.Remove(recomendacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar se uma recomendação existe
        private bool RecomendacaoExists(int id)
        {
            return _context.Recomendacoes.Any(e => e.id_recomendacao == id);
        }
    }
}