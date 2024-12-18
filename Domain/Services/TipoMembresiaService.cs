using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class TipoMembresiaService
    {


        public void Add(Tipo_Membresia tipoMembresia)
        {
            using var context = new userContext();

            context.Tipo_Membresia.Add(tipoMembresia);
            context.SaveChanges();
        }

        public void Delete (int Id)
        {
            using var context = new userContext();

            Tipo_Membresia? tipoMembresiaToDelete = context.Tipo_Membresia.Find(Id);
            
            if(tipoMembresiaToDelete != null)
            {
                context.Tipo_Membresia.Remove(tipoMembresiaToDelete);
                context.SaveChanges() ;

            }

        }

        public Tipo_Membresia? Get (int Id)
        {
            using var context = new userContext();

            return context.Tipo_Membresia.Find(Id);
        }



        public IEnumerable<Tipo_Membresia> GetAll()
        {
            using var context = new userContext(); 

            return context.Tipo_Membresia.ToList();
        }


        public void Update (Tipo_Membresia tipoMembresia)
        {
            using var context = new userContext();

            Tipo_Membresia? tipoMembresiaToUpdate = context.Tipo_Membresia.Find(tipoMembresia.Id);
               
            if(tipoMembresiaToUpdate != null)
            {
                tipoMembresiaToUpdate.precioMembresia = tipoMembresia.precioMembresia;
                tipoMembresiaToUpdate.descripcion = tipoMembresia.descripcion;

                context.SaveChanges();

            }

        }
    }
}
