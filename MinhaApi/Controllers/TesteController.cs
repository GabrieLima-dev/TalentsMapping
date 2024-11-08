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

        // GET: api/Teste
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teste>>> GetTestes()
        {
            return await _context.Testes.ToListAsync();
        }

        // GET: api/Teste/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teste>> GetTeste(int id)
        {
            var teste = await _context.Testes.FindAsync(id);

            if (teste == null)
            {
                return NotFound();
            }

            return teste;
        }

        // POST: api/Teste
        [HttpPost]
        public async Task<ActionResult<Teste>> PostTeste(Teste teste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Testes.Add(teste);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeste", new { id = teste.id_teste }, teste);
        }

        // PUT: api/Teste/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeste(int id, Teste teste)
        {
            if (id != teste.id_teste)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(teste).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TesteExists(id))
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

        // DELETE: api/Teste/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeste(int id)
        {
            var teste = await _context.Testes.FindAsync(id);
            if (teste == null)
            {
                return NotFound();
            }

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
