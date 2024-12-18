using System.Net.Http.Json;
using WebAPP.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;

    public AuthenticationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<User?> AuthenticateAsync(string email, string contraseña)
    {
        var loginRequest = new { Email = email, Contraseña = contraseña };

        var response = await _httpClient.PostAsJsonAsync("api/Auth/Login", loginRequest);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<User>();
        }

        return null;
    }
}

public class User
{
    public int Id { get; set; }
    public string email { get; set; }
    public int oRolId { get; set; }
}
