using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class LocalidadService
    {

        public void Add(Localidad localidad)
        {
            using var context = new userContext();

            context.Localidad.Add(localidad);
            context.SaveChanges();
        }


        public void Delete(int id)
        {
            using var context = new userContext();

            Localidad? localidadToDelete = context.Localidad.Find(id);

            if( localidadToDelete != null)
            {

                context.Remove(localidadToDelete);
                context.SaveChanges();

            }
        }


        public Localidad? Get(int id)
        {
            using var context = new userContext();

            return context.Localidad.Find(id);

        }

        public IEnumerable<Localidad> GetAll()
        {
            using var context = new userContext();

            return context.Localidad.ToList();

        }

        public void Update(Localidad localidad)
        {
            using var context = new userContext();

            
            Localidad? localidadToUpdate = context.Localidad.Find(localidad.Id);

            if (localidadToUpdate != null)
            {
                
                if (context.Provincia.Find(localidad.oProvinciaId) == null)
                {

                    return;
                }

                localidadToUpdate.nombreLocalidad = localidad.nombreLocalidad;
                localidadToUpdate.codigoPostal = localidad.codigoPostal;
                localidadToUpdate.oProvinciaId = localidad.oProvinciaId;

                context.SaveChanges();
            }
        }

        public bool CanDeleteProvince(int idProvincia)
        {
            using var context = new userContext();

            bool isReferenced = context.Localidad.Any(u => u.oProvinciaId == idProvincia);

            return !isReferenced;
        }
    }
}
