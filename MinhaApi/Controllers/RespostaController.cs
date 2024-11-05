﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resposta>>> GetRespostas()
        {
            return await _context.Respostas
                .Include(r => r.Pergunta)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Resposta>> GetResposta(int id)
        {
            var resposta = await _context.Respostas
                .Include(r => r.Pergunta)
                .FirstOrDefaultAsync(r => r.id_resposta == id);
            if (resposta == null) return NotFound();
            return resposta;
        }

        [HttpPost]
        public async Task<ActionResult<Resposta>> PostResposta(Resposta resposta)
        {
            _context.Respostas.Add(resposta);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetResposta", new { id = resposta.id_resposta }, resposta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutResposta(int id, Resposta resposta)
        {
            if (id != resposta.id_resposta) return BadRequest();
            _context.Entry(resposta).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespostaExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResposta(int id)
        {
            var resposta = await _context.Respostas.FindAsync(id);
            if (resposta == null) return NotFound();
            _context.Respostas.Remove(resposta);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool RespostaExists(int id)
        {
            return _context.Respostas.Any(e => e.id_resposta == id);
        }
    }
}