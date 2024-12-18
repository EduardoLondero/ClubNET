using Domain.Model;

namespace WebAPP.Services
{
    public interface IAuthenticationService
    {
        Task<User?> AuthenticateAsync(string email, string contraseña);
    }
}
