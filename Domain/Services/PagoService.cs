using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class PagoService
    {

        public void Add(Pago pago)
        {
            using var context = new userContext();

            context.Pago.Add(pago);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new userContext();

            Pago? pagoToDelete = context.Pago.Find(id);

            if (pagoToDelete != null)
            {
                context.Pago.Remove(pagoToDelete);
                context.SaveChanges();
            }
        }


        public Pago? Get(int id)
        {
            using var context = new userContext();
            return context.Pago.Find(id);

        }


        public IEnumerable<Pago> GetAll()
        {
            using var context = new userContext();

            return context.Pago
                .Include(p => p.oMembresia) 
                .ThenInclude(m => m.oUsuario) 
                .ToList();
        }



        public void Update(Pago pago)
        {
            using var context = new userContext();

            Pago? pagoToUpdate = context.Pago.Find(pago.id);

            if (pagoToUpdate != null)
            {
                pagoToUpdate.precioTotal = pago.precioTotal;
                pagoToUpdate.fechaPago = pago.fechaPago;

            }
        }


        public Pago? ObtenerPagosPorMembresia(int membresiaId)
        {
            using var context = new userContext();

            return context.Pago
                .Include(n => n.oMembresia)
                .ThenInclude(t => t.oTipo_Membresia)
                .FirstOrDefault(p => p.oMembresiaId == membresiaId);

        }

        public bool CanDeleteMembresia(int idMembresia)
        {
            using var context = new userContext();

            bool isReferenced = context.Pago.Any(u => u.oMembresiaId == idMembresia);

            return !isReferenced;
        }

        public List<Pago> ObtenerPagosPorUsuario(int usuarioId)
        {
            MembresiaService membresiaService = new MembresiaService();
            PagoService pagoService = new PagoService();

            List<Membresia> membresias = membresiaService.ObtenerUsuarioMembresias(usuarioId);

            var pagosView = new List<Pago>();

            foreach (var membresia in membresias)
            {
                Pago pago = pagoService.ObtenerPagosPorMembresia(membresia.id);

                if (pago != null)
                {
                    pagosView.Add(pago);  
                }
            }

            return pagosView;
        }


    }
}
