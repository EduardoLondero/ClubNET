using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly userContext _context;

    public AuthController(userContext context)
    {
        _context = context;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var user = await _context.Usuario
            .FirstOrDefaultAsync(u => u.email == request.email && u.contraseña == request.contraseña);

        if (user == null)
        {
            return Unauthorized(new { Message = "Credenciales incorrectas" });
        }

        return Ok(new
        {
            user.Id,
            user.email,
            user.oRolId
        });
    }
}

public class LoginRequest
{
    public string email { get; set; }
    public string contraseña { get; set; }
}
