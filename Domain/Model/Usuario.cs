namespace Domain.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string contraseña { get; set; }
        public Rol oRol { get; set; }
        public int oRolId { get; set; }  
        public Localidad oLocalidad { get; set; }
        public int oLocalidadId { get; set; }  
        public virtual ICollection<Membresia> Membresias { get; set; } = new List<Membresia>();


    }
}