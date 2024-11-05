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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recomendacao>>> GetRecomendacoes()
        {
            return await _context.Recomendacoes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recomendacao>> GetRecomendacao(int id)
        {
            var recomendacao = await _context.Recomendacoes.FindAsync(id);
            if (recomendacao == null) return NotFound();
            return recomendacao;
        }

        [HttpPost]
        public async Task<ActionResult<Recomendacao>> PostRecomendacao(Recomendacao recomendacao)
        {
            _context.Recomendacoes.Add(recomendacao);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetRecomendacao", new { id = recomendacao.id_recomendacao }, recomendacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecomendacao(int id, Recomendacao recomendacao)
        {
            if (id != recomendacao.id_recomendacao) return BadRequest();
            _context.Entry(recomendacao).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecomendacaoExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecomendacao(int id)
        {
            var recomendacao = await _context.Recomendacoes.FindAsync(id);
            if (recomendacao == null) return NotFound();
            _context.Recomendacoes.Remove(recomendacao);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool RecomendacaoExists(int id)
        {
            return _context.Recomendacoes.Any(e => e.id_recomendacao == id);
        }
    }
}