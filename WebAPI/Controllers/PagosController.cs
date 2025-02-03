using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly userContext _context;

        public PagosController(userContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPagos()
        {
            var pagos = await _context.Pago.ToListAsync();
            if (pagos == null || !pagos.Any())
            {
                return NotFound(new { message = "No se encontraron pagos." });
            }

            return Ok(pagos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pago>> GetPago(int id)
        {
            var pago = await _context.Pago.FindAsync(id);

            if (pago == null)
            {
                return NotFound();
            }

            return pago;
        }

        [HttpPost]
        public async Task<ActionResult<Pago>> PostPago([FromBody] PagoDto pagoDto)
        {
            var membresia = await _context.Membresia.FindAsync(pagoDto.oMembresiaId);
            if (membresia == null)
            {
                return BadRequest(new { message = "Membresía no encontrada." });
            }

            var pago = new Pago
            {
                estado = pagoDto.estado,
                fechaPago = pagoDto.fechaPago,
                oMembresiaId = pagoDto.oMembresiaId,
                precioTotal = pagoDto.precioTotal,
                oMembresia = membresia
            };

            _context.Pago.Add(pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPago), new { id = pago.id }, pago);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutPago(int id, [FromBody] PagoDto pagoDto)
        {
            var pagoExistente = await _context.Pago.FindAsync(id);
            if (pagoExistente == null)
            {
                return NotFound(new { message = "Pago no encontrado." });
            }

            var membresia = await _context.Membresia.FindAsync(pagoDto.oMembresiaId);
            if (membresia == null)
            {
                return BadRequest(new { message = "Membresía no encontrada." });
            }

            pagoExistente.estado = pagoDto.estado;
            pagoExistente.fechaPago = pagoDto.fechaPago;
            pagoExistente.oMembresiaId = pagoDto.oMembresiaId;
            pagoExistente.precioTotal = pagoDto.precioTotal;
            pagoExistente.oMembresia = membresia;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(new { message = "Pago actualizado con éxito." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor.", details = ex.Message });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePago(int id)
        {
            var pago = await _context.Pago.FindAsync(id);
            if (pago == null)
            {
                return NotFound(new { message = "Pago no encontrado." });
            }

            _context.Pago.Remove(pago);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Pago eliminado con éxito." });
        }

        private bool PagoExists(int id)
        {
            return _context.Pago.Any(e => e.id == id);
        }
    }
}
