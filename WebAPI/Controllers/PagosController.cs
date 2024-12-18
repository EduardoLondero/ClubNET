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
            return await _context.Pago.ToListAsync();
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
        public async Task<ActionResult<Pago>> PostPago(Pago pago)
        {
            _context.Pago.Add(pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPago), new { id = pago.id }, pago);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPago(int id, Pago pago)
        {
            if (id != pago.id)
            {
                return BadRequest();
            }

            _context.Entry(pago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePago(int id)
        {
            var pago = await _context.Pago.FindAsync(id);
            if (pago == null)
            {
                return NotFound();
            }

            _context.Pago.Remove(pago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PagoExists(int id)
        {
            return _context.Pago.Any(e => e.id == id);
        }
    }
}
