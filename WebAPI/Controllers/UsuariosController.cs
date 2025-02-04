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
    public async Task<IActionResult> Post([FromBody] Usuario usuario)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var rol = await _context.Rol.FindAsync(usuario.oRolId);
        var localidad = await _context.Localidad.FindAsync(usuario.oLocalidadId);

        if (rol == null || localidad == null)
        {
            return BadRequest("Rol o Localidad no encontrados.");
        }

        _context.Usuario.Add(usuario);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
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
        usuarioExistente.contraseña = usuario.contraseña;
        usuarioExistente.telefono = usuario.telefono;
        usuarioExistente.direccion = usuario.direccion;
        usuarioExistente.oRolId = usuario.oRolId;
        usuarioExistente.oLocalidadId = usuario.oLocalidadId;


        await _context.SaveChangesAsync(); 
        return Ok(new { message = "Usuario actualizado con éxito." });
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

        return Ok(new { message = "Usuario eliminado con éxito." });
    }

    [HttpGet("test-db-connection")]
    public async Task<IActionResult> TestDatabaseConnection()
    {
        try
        {
            var count = await _context.Usuario.CountAsync();
            return Ok(new { message = "Conexión a la base de datos exitosa.", totalUsuarios = count });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Error al conectar con la base de datos.", details = ex.Message });
        }
    }
}
