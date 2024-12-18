using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DeporteService
    {

        public void add(Deporte deporte)
        {
            using var context = new userContext();

            context.Deporte.Add(deporte);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new userContext();

            Deporte? deporteToDelete = context.Deporte.Find(Id);

            if (deporteToDelete != null)
            {
                context.Deporte.Remove(deporteToDelete);
                context.SaveChanges();
            }
        }

        public Deporte? Get(int Id)
        {
            using var context = new userContext();

            return context.Deporte.Find(Id);

        }


        public IEnumerable<Deporte> GetAll()
        {
            using var context = new userContext();

            return context.Deporte.ToList();

        }

        public void Update (Deporte deporte)
        {

            using var context = new userContext();

            Deporte? deporteToUpdate = context.Deporte.Find(deporte.Id);

            if (deporteToUpdate != null)
            {
                deporteToUpdate.precio = deporte.precio;
                deporteToUpdate.horaInicio = deporte.horaInicio;
                deporteToUpdate.horaFin = deporte.horaFin;
                deporteToUpdate.nombreDeporte = deporte.nombreDeporte;

                context.SaveChanges();
            }
        }
    }
}
