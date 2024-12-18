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
        public async Task<IActionResult> CreateMembresia([FromBody] Membresia membresia)
        {
            try
            {
                if (membresia == null)
                {
                    return BadRequest(new { message = "Los datos de la membresía no son válidos." });
                }

                _context.Membresia.Add(membresia);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Membresía creada con éxito." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor.", details = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMembresia(int id, [FromBody] Membresia membresia)
        {
            var membresiaExistente = await _context.Membresia.FindAsync(id);
            if (membresiaExistente == null)
            {
                return NotFound(new { message = "Membresía no encontrada." });
            }

            membresiaExistente.fechaInicio = membresia.fechaInicio;
            membresiaExistente.fechaFin = membresia.fechaFin;
            membresiaExistente.fechaVencimiento = membresia.fechaVencimiento;
            membresiaExistente.OUsuarioId = membresia.OUsuarioId;
            membresiaExistente.oTipo_MembresiaId = membresia.oTipo_MembresiaId;

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
