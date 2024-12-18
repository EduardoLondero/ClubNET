using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class UserServices
    {
        public void Add(Usuario usuario)
        {
            using var context = new userContext();

            context.Usuario.Add(usuario);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new userContext();

            Usuario? clienteToDelete = context.Usuario.Find(id);

            if (clienteToDelete != null)
            {
                context.Usuario.Remove(clienteToDelete);
                context.SaveChanges();
            }
        }

        public Usuario? Get(int idUsuario)
        {
            using var context = new userContext();

            return context.Usuario
                                  .Include(e => e.oLocalidad)
                                  .Include(r => r.oRol)
                                  .Include(u => u.Membresias)
                                  .ThenInclude(a => a.oTipo_Membresia)
                                  .FirstOrDefault(u => u.Id == idUsuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = new userContext();

            var usuarios = context.Usuario
                .ToList();

            return usuarios;

        }

        public void Update(Usuario usuario)
        {
            using var context = new userContext();

            Usuario? clienteToUpdate = context.Usuario.Find(usuario.Id);

            if (clienteToUpdate != null)
            {
                clienteToUpdate.email = usuario.email;
                clienteToUpdate.contraseña = usuario.contraseña;
                clienteToUpdate.telefono = usuario.telefono;
                clienteToUpdate.oLocalidadId = usuario.oLocalidadId;
                clienteToUpdate.oRolId = usuario.oRolId;
                context.SaveChanges();
            }
        }

        public bool CanDelete(int idLocalidad)
        {
            using var context = new userContext();

            bool isReferenced = context.Usuario.Any(u => u.oLocalidadId == idLocalidad);

            return !isReferenced;
        }

        public bool CanDeleteRol(int idRol)
        {
            using var context = new userContext();

            bool isReferenced = context.Usuario.Any(u => u.oRolId == idRol);

            return !isReferenced;
        }

    }
}