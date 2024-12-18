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
    public class DeportesController : ControllerBase
    {
        private readonly userContext _context;

        public DeportesController(userContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDeportes()
        {
            var deportes = await _context.Deporte.ToListAsync();
            if (deportes == null || !deportes.Any())
            {
                return NotFound(new { message = "No se encontraron deportes." });
            }

            return Ok(deportes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeportes(int id)
        {
            var deporte = await _context.Deporte.FindAsync(id);
            if (deporte == null)
            {
                return NotFound(new { message = "Deporte no encontrado." });
            }

            return Ok(deporte);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeporte([FromBody] Deporte deporte)
        {
            try
            {
                if (deporte == null)
                {
                    return BadRequest(new { message = "Los datos del deporte no son válidos." });
                }

                _context.Deporte.Add(deporte);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Deporte creado con éxito." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor.", details = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeporte(int id, [FromBody] Deporte deporte)
        {
            var deporteExistente = await _context.Deporte.FindAsync(id);
            if (deporteExistente == null)
            {
                return NotFound(new { message = "Deporte no encontrado." });
            }

            deporteExistente.nombreDeporte = deporte.nombreDeporte;
            deporteExistente.horaInicio = deporte.horaInicio;
            deporteExistente.horaFin = deporte.horaFin;
            deporteExistente.precio = deporte.precio;

            await _context.SaveChangesAsync();
            return Ok(new { message = "Deporte actualizado con éxito." });
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeporte(int id)
        {
            var deporte = await _context.Deporte.FindAsync(id);
            if (deporte == null)
            {
                return NotFound(new { message = "Deporte no encontrado." });
            }

            _context.Deporte.Remove(deporte);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Deporte eliminado con éxito." });
        }
    }
}
