using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MembresiaService
    {

        public void add(Membresia membresia)
        {
            using var context = new userContext();


            context.Membresia.Add(membresia);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new userContext();

          
            Membresia? membresiaToDelete = context.Membresia.Find(id);

            if (membresiaToDelete != null)
            {

                context.Membresia.Remove(membresiaToDelete);
                context.SaveChanges();
            }
        }

        public Membresia? Get(int idMembresia)
        {
            using var context = new userContext();

            return context.Membresia
                .Include(e => e.oTipo_Membresia)
                .FirstOrDefault(u => u.id == idMembresia);

        }

        public bool CanDeleteTipoRol(int idTipoRol)
        {
            using var context = new userContext();

            bool isReferenced = context.Membresia.Any(u => u.oTipo_MembresiaId == idTipoRol);

            return !isReferenced;
        }

        public IEnumerable<Membresia> GetAll()
        {
            using var context = new userContext();

            var usuarios = context.Membresia.ToList();

            return usuarios;

        }


        public void Update (Membresia membresia)
        {
            using var context = new userContext();

            Membresia? membresiaToUpdate = context.Membresia.Find(membresia.id);

            if (membresiaToUpdate != null)
            {
                membresiaToUpdate.fechaVencimiento = membresia.fechaVencimiento;
                membresiaToUpdate.fechaFin = membresia.fechaFin;

                context.SaveChanges();

            }

        }

        public List <Membresia> ObtenerUsuarioMembresias(int userId)
        {
            using var context = new userContext();

            List<Membresia> membresiasUsuario = context.Membresia.
                                          Where(m => m.OUsuarioId == userId)
                                          .ToList();

            return membresiasUsuario;



        }
        public bool CanDeleteUsuario(int idUsuario)
        {
            using var context = new userContext();

            bool isReferenced = context.Membresia.Any(u => u.oTipo_MembresiaId == idUsuario);

            return !isReferenced;
        }
    }
}
