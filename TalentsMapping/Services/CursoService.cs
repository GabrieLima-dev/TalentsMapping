using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using TalentsMapping.Models;

namespace TalentsMapping.Services
{
    public class CursoService
    {
        private readonly HttpClient _httpClient;

        public CursoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Curso>> GetCursosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Curso>>("data/cursos.json");
        }
    }
}
