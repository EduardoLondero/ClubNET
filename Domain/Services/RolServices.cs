using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class RolServices
    {

        public void add(Rol rol) {

            using var context = new userContext();

            context.Rol.Add(rol);
            context.SaveChanges();
        }


        public void Delete(int Id) {

            using var context = new userContext();

            Rol? rolToDelete = context.Rol.Find(Id);

            if (rolToDelete != null)
            {
                context.Rol.Remove(rolToDelete);
                context.SaveChanges() ;
            }
        }


        public Rol? Get(int idRol) 
        {
            using var context = new userContext();

            return context.Rol.Find(idRol); 
        
        }


        public IEnumerable<Rol> GetAll() 
        {
            using var context = new userContext();

            return context.Rol.ToList();
        
        }


        public void Update (Rol rol) 
        {
            using var context = new userContext();

            Rol? rolToUpdate = context.Rol.Find(rol.Id);

            if (rolToUpdate != null)
            {
                rolToUpdate.descripcionrol = rol.descripcionrol;

                context.SaveChanges() ;

            }
        
        }
    }
}
