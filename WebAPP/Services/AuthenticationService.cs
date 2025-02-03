using System.Net.Http.Json;
using WebAPP.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;
    private User? _currentUser;

    public event Action? OnAuthStateChanged;

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
            var user = await response.Content.ReadFromJsonAsync<User>();
            _currentUser = user;

            NotifyAuthStateChanged();
            return user;

        }

        return null;
    }

    public User? GetCurrentUser()
    {
        return _currentUser;
    }

    public void Logout()
    {
        _currentUser = null;
        NotifyAuthStateChanged();
    }

    public void NotifyAuthStateChanged()
    {
        OnAuthStateChanged?.Invoke();
    }

}

public class User
{
    public int Id { get; set; }
    public string email { get; set; }
    public int oRolId { get; set; }
}
