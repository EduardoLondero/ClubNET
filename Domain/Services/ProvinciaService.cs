using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public class ProvinciaService
    {

        public void Add(Provincia provincia)
        {
            using var context = new userContext();

            context.Provincia.Add(provincia);
            context.SaveChanges();

        }


        public void Delete(int Id)
        {

            using var context = new userContext();

            Provincia? provinciaToDelete = context.Provincia.Find(Id);

            if (provinciaToDelete != null)
            {
                context.Provincia.Remove(provinciaToDelete);
                context.SaveChanges();
            }
        }

        public Provincia? Get(int id)
        {
            using var context = new userContext();

            return context.Provincia.Find(id);

        }

        public IEnumerable<Provincia> GetAll()
        {
            using var context = new userContext();

            return context.Provincia.ToList();


        }

        public void Update(Provincia provincia)
        {
            using var context = new userContext();

            Provincia? provinciaToUpdate = context.Provincia.Find(provincia.Id);

            if (provinciaToUpdate != null)
            {
               provinciaToUpdate.nombreProvincia = provincia.nombreProvincia;

                context.SaveChanges();


            }
        }
    }
}
