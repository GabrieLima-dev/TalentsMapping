using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TalentsMapping.Models;

namespace TalentsMapping.Services
{
    public class UsuarioService
    {
        private readonly LocalStorageService _localStorageService;
        private const string UsuariosKey = "usuarios";
        private const string UsuarioLogadoKey = "usuarioLogado"; // Chave para o usuário logado

        public UsuarioService(LocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        // Método para obter a lista de usuários
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            var usuariosJson = await _localStorageService.GetItemAsync(UsuariosKey);
            if (string.IsNullOrEmpty(usuariosJson))
            {
                return new List<Usuario>();
            }

            return JsonSerializer.Deserialize<List<Usuario>>(usuariosJson) ?? new List<Usuario>();
        }

        // Método para verificar se um usuário existe
        public async Task<bool> VerificarUsuarioExistenteAsync(string nome)
        {
            var usuarios = await GetUsuariosAsync();
            return usuarios.Any(u => u.Nome == nome);
        }

        // Método para login
        public async Task<bool> FazerLoginAsync(string nome, string senha)
        {
            var usuarios = await GetUsuariosAsync();
            var usuario = usuarios.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);

            if (usuario != null)
            {
                // Armazena o usuário logado no LocalStorage
                var usuarioJson = JsonSerializer.Serialize(usuario);
                await _localStorageService.SetItemAsync(UsuarioLogadoKey, usuarioJson);
                return true;
            }

            return false;
        }

        // Método para obter o usuário logado
        public async Task<Usuario> ObterUsuarioLogadoAsync()
        {
            var usuarioJson = await _localStorageService.GetItemAsync(UsuarioLogadoKey);
            if (string.IsNullOrEmpty(usuarioJson))
            {
                return null;
            }

            return JsonSerializer.Deserialize<Usuario>(usuarioJson);
        }

        // Método para logout
        public async Task FazerLogoutAsync()
        {
            await _localStorageService.RemoveItemAsync(UsuarioLogadoKey);
        }

        // Método para cadastrar um novo usuário
        public async Task<bool> FazerCadastroAsync(string nome, string senha)
        {
            var usuarios = await GetUsuariosAsync();

            // Verifica se o usuário já existe
            if (usuarios.Any(u => u.Nome == nome))
            {
                return false;
            }

            // Adiciona o novo usuário
            usuarios.Add(new Usuario { Nome = nome, Senha = senha });
            var usuariosJson = JsonSerializer.Serialize(usuarios);
            await _localStorageService.SetItemAsync(UsuariosKey, usuariosJson);

            return true;
        }
    }
}
