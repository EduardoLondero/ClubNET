using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Domain;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly userContext _context; 

    public UsuariosController(userContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetUsuarios()
    {

        var usuarios = await _context.Usuario.ToListAsync();
        if (usuarios == null || !usuarios.Any())
        {
            return NotFound(new { message = "No se encontraron usuarios." });
        }

        return Ok(usuarios);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetUsuario(int id)
    {
        var usuario = await _context.Usuario.FindAsync(id);
        if (usuario == null)
        {
            return NotFound(new { message = "Usuario no encontrado." });
        }

        return Ok(usuario);
    }

    [HttpGet("byEmail/{email}")]
    public async Task<IActionResult> GetUsuarioByEmail(string email)
    {
        var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.email == email);
        if (usuario == null)
        {
            return NotFound(new { message = "Usuario no encontrado." });
        }

        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUsuario([FromBody] Usuario usuario)
    {
        try
        {
            if (usuario == null)
            {
                return BadRequest(new { message = "Los datos del usuario no son v�lidos." });
            }

            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Usuario creado con �xito." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Error interno del servidor.", details = ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUsuario(int id, [FromBody] Usuario usuario)
    {
        var usuarioExistente = await _context.Usuario.FindAsync(id);
        if (usuarioExistente == null)
        {
            return NotFound(new { message = "Usuario no encontrado." });
        }

        usuarioExistente.email = usuario.email;
        usuarioExistente.contrase�a = usuario.contrase�a;
        usuarioExistente.telefono = usuario.telefono;
        usuarioExistente.direccion = usuario.direccion;
        usuarioExistente.oRolId = usuario.oRolId;
        usuarioExistente.oLocalidadId = usuario.oLocalidadId;


        await _context.SaveChangesAsync(); 
        return Ok(new { message = "Usuario actualizado con �xito." });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUsuario(int id)
    {
        var usuario = await _context.Usuario.FindAsync(id);
        if (usuario == null)
        {
            return NotFound(new { message = "Usuario no encontrado." });
        }

        _context.Usuario.Remove(usuario);
        await _context.SaveChangesAsync(); 

        return Ok(new { message = "Usuario eliminado con �xito." });
    }

    [HttpGet("test-db-connection")]
    public async Task<IActionResult> TestDatabaseConnection()
    {
        try
        {
            var count = await _context.Usuario.CountAsync();
            return Ok(new { message = "Conexi�n a la base de datos exitosa.", totalUsuarios = count });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Error al conectar con la base de datos.", details = ex.Message });
        }
    }
}
