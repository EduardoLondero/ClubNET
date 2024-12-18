using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MembresiaDeporteService
    {

        public void Add(Membresia_deporte membresiaDeporte)
        {
            using var context = new userContext();

            context.Membresia_Deporte.Add(membresiaDeporte);
            context.SaveChanges();
        }

        public void Remove(Membresia_deporte membresiaDeporte)
        {
            using var context = new userContext();

            Membresia_deporte? membresiaDeporteToDelete = context.Membresia_Deporte.Find(membresiaDeporte.oMembresiaId);

            if (membresiaDeporteToDelete != null)
            {
                context.Membresia_Deporte.Remove(membresiaDeporteToDelete);
                context.SaveChanges();
            }
        }

        public Membresia_deporte? Get(int membresiaId)
        {
            using var context = new userContext();

            return context.Membresia_Deporte.Find(membresiaId);

        }

        public IEnumerable<Membresia_deporte> GetAll()
        {
            using var context = new userContext();

            return context.Membresia_Deporte.ToList();

        }

        public bool CanDeleteDeporte(int idDeporte)
        {
            using var context = new userContext();


            bool isReferenced = context.Membresia_Deporte.Any(u => u.oDeporteId == idDeporte);

            return !isReferenced;
        }

        public bool ExisteInscripcion(int idDeporte, int idMembresia)
        {
            using var context = new userContext();

            return context.Membresia_Deporte
                .Any(md => md.oDeporteId == idDeporte && md.oMembresiaId == idMembresia);
        }
    }
}
