using Domain.Model;

namespace WebAPP.Services
{
    public interface IAuthenticationService
    {
        event Action? OnAuthStateChanged;

        Task<User?> AuthenticateAsync(string email, string contraseña);
        User? GetCurrentUser();
        void Logout();

        void NotifyAuthStateChanged();
    }
}
