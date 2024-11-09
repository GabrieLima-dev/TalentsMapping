using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using MinhaApi.Models;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespostaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RespostaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetRespostaComAlternativas(int id)
        {
            var resposta = _context.Respostas
                .Where(r => r.id_resposta == id)
                .Select(r => new
                {
                    r.id_resposta,
                    r.id_pergunta,
                    r.id_teste,
                    Alternativas = r.RespostaAlternativas.Select(ra => ra.Alternativa).ToList()
                })
                .FirstOrDefault();

            if (resposta == null)
            {
                return NotFound();
            }

            return Ok(resposta);
        }
    }
}
