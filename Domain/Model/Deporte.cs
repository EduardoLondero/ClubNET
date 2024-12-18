using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Deporte
    {

        public int Id { get; set; }
        public string? nombreDeporte { get; set; }
        public string? horaInicio { get; set; }
        public string? horaFin { get; set; }
        public int? precio { get; set; }

        public virtual ICollection<Membresia_deporte> Membresias { get; set; } = new List<Membresia_deporte>();

    }
}