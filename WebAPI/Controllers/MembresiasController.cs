using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembresiasController : ControllerBase
    {
        private readonly userContext _context;

        public MembresiasController(userContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembresias()
        {
            var membresias = await _context.Membresia.ToListAsync();
            if (membresias == null || !membresias.Any())
            {
                return NotFound(new { message = "No se encontraron membresías." });
            }

            return Ok(membresias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMembresia(int id)
        {
            var membresia = await _context.Membresia.FindAsync(id);
            if (membresia == null)
            {
                return NotFound(new { message = "Membresía no encontrada." });
            }

            return Ok(membresia);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MembresiaDto membresiaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _context.Usuario.FindAsync(membresiaDto.OUsuarioId);
            var tipoMembresia = await _context.Tipo_Membresia.FindAsync(membresiaDto.oTipo_MembresiaId);

            if (usuario == null || tipoMembresia == null)
            {
                return BadRequest("Usuario o Tipo de Membresía no encontrados.");
            }

            var membresia = new Membresia
            {
                fechaInicio = membresiaDto.fechaInicio,
                fechaFin = membresiaDto.fechaFin,
                fechaVencimiento = membresiaDto.fechaVencimiento,
                oUsuario = usuario,
                oTipo_Membresia = tipoMembresia
            };

            _context.Membresia.Add(membresia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMembresia", new { id = membresia.id }, membresia);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMembresia(int id, [FromBody] MembresiaDto membresiaDto)
        {
            var membresiaExistente = await _context.Membresia
                .Include(m => m.Membresias)
                .FirstOrDefaultAsync(m => m.id == id);

            if (membresiaExistente == null)
            {
                return NotFound(new { message = "Membresía no encontrada." });
            }

            var usuario = await _context.Usuario.FindAsync(membresiaDto.OUsuarioId);
            var tipoMembresia = await _context.Tipo_Membresia.FindAsync(membresiaDto.oTipo_MembresiaId);

            if (usuario == null || tipoMembresia == null)
            {
                return BadRequest(new { message = "Usuario o Tipo de Membresía no encontrados." });
            }

            membresiaExistente.fechaInicio = membresiaDto.fechaInicio;
            membresiaExistente.fechaFin = membresiaDto.fechaFin;
            membresiaExistente.fechaVencimiento = membresiaDto.fechaVencimiento;
            membresiaExistente.oUsuario = usuario;
            membresiaExistente.oTipo_Membresia = tipoMembresia;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(new { message = "Membresía actualizada con éxito." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor.", details = ex.Message });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembresia(int id)
        {
            var membresia = await _context.Membresia.FindAsync(id);
            if (membresia == null)
            {
                return NotFound(new { message = "Membresía no encontrada." });
            }

            _context.Membresia.Remove(membresia);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Membresía eliminada con éxito." });
        }
    }
}
