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
    public class TesteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TesteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teste>>> GetTestes()
        {
            return await _context.Testes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teste>> GetTeste(int id)
        {
            var teste = await _context.Testes.FindAsync(id);
            if (teste == null) return NotFound();
            return teste;
        }

        [HttpPost]
        public async Task<ActionResult<Teste>> PostTeste(Teste teste)
        {
            _context.Testes.Add(teste);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTeste", new { id = teste.id_teste }, teste);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeste(int id, Teste teste)
        {
            if (id != teste.id_teste) return BadRequest();
            _context.Entry(teste).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TesteExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeste(int id)
        {
            var teste = await _context.Testes.FindAsync(id);
            if (teste == null) return NotFound();
            _context.Testes.Remove(teste);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool TesteExists(int id)
        {
            return _context.Testes.Any(e => e.id_teste == id);
        }
    }
}
