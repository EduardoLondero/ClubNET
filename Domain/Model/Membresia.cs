using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Model
{
    public class Membresia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public DateTime? fechaVencimiento { get; set; }
        public Usuario oUsuario { get; set; }
        public int OUsuarioId { get; set; }
        public Tipo_Membresia oTipo_Membresia { get; set; }
        public int oTipo_MembresiaId { get; set; }
        public virtual ICollection<Membresia_deporte> Membresias { get; set; } = new List<Membresia_deporte>();
    }
}
