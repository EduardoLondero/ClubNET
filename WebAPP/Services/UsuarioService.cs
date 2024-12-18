using Domain.Model;
using System.Net.Http.Json;

namespace WebAPP.Services
{
    public class UsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7105"); 
        }

        public async Task<List<Usuario>> GetUsuariosFromExternalApiAsync()
        {
            var response = await _httpClient.GetAsync("api/Usuarios");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Usuario>>();
            }
            else
            {
                throw new Exception($"Error obteniendo usuarios: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        public async Task<Usuario> GetUsuarioByIdFromExternalApiAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Usuarios/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Usuario>();
            }
            else
            {
                throw new Exception($"Error obteniendo el usuario con ID {id}: {response.ReasonPhrase}");
            }
        }

        public async Task<bool> CreateUsuarioAsync(Usuario usuario)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Usuarios", usuario);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception($"Error creando el usuario: {response.ReasonPhrase}");
            }
        }

        public async Task<bool> UpdateUsuarioAsync(int id, Usuario usuario)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Usuarios/{id}", usuario);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception($"Error actualizando el usuario con ID {id}: {response.ReasonPhrase}");
            }
        }

        public async Task<bool> DeleteUsuarioAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Usuarios/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception($"Error eliminando el usuario con ID {id}: {response.ReasonPhrase}");
            }
        }
    }
}
