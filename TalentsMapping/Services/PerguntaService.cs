using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using TalentsMapping.Models;

namespace TalentsMapping.Services
{
    public class PerguntaService
    {
        private readonly HttpClient _httpClient;

        public PerguntaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pergunta>> GetPerguntasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Pergunta>>("data/perguntas.json");
        }
    }
}
