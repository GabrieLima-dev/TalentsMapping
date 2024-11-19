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
            //Console.WriteLine($"BaseAddress: {_httpClient.BaseAddress}");
        }

        public async Task<List<Curso>> GetCursosAsync()
        {
            try
            {
                var url = "data/cursos.json";  // Caminho relativo ao BaseAddress
                //Console.WriteLine($"Buscando cursos de: {url}");

                var cursos = await _httpClient.GetFromJsonAsync<List<Curso>>(url);

                //if (cursos == null || cursos.Count == 0)
                //{
                //    Console.WriteLine("Nenhum curso encontrado.");
                //}
                //else
                //{
                //    Console.WriteLine($"Encontrados {cursos.Count} cursos.");
                //}

                return cursos ?? new List<Curso>();  // Retorna uma lista vazia se null
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar cursos: {ex.Message}");
                return new List<Curso>(); // Retorna uma lista vazia em caso de erro
            }
        }
    }
}
