using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        /// <summary>
        /// Retorna todos os cursos.
        /// </summary>
        /// <returns>Uma lista de cursos.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
            return await _context.Cursos.ToListAsync();
        }

        /// <summary>
        /// Retorna um curso específico.
        /// </summary>
        /// <param name="id">ID do curso.</param>
        /// <returns>Um curso com o ID especificado.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Curso>> GetCurso(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            return curso;
        }

        /// <summary>
        /// Cria um novo curso.
        /// </summary>
        /// <param name="curso">Dados do curso a ser criado.</param>
        /// <returns>O curso recém-criado.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurso", new { id = curso.id_curso }, curso);
        }

        /// <summary>
        /// Atualiza um curso existente.
        /// </summary>
        /// <param name="id">ID do curso a ser atualizado.</param>
        /// <param name="curso">Dados atualizados do curso.</param>
        /// <returns>Resposta HTTP indicando o sucesso ou falha da operação.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutCurso(int id, Curso curso)
        {
            if (id != curso.id_curso)
            {
                return BadRequest();
            }

            _context.Entry(curso).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Exclui um curso existente.
        /// </summary>
        /// <param name="id">ID do curso a ser excluído.</param>
        /// <returns>Resposta HTTP indicando o sucesso ou falha da operação.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCurso(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
