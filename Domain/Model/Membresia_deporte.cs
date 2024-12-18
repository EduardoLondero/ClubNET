using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Membresia_deporte
    {
        public Membresia oMembresia {  get; set; }
        public int oMembresiaId { get; set; }
        public Deporte oDeporte { get; set; }
        public int oDeporteId { get;set; }

    }
}
