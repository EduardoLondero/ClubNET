using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Pago
    {
        public int id { get; set; }
        public string estado { get; set; }
        public DateTime? fechaPago { get; set; }
        public int oMembresiaId { get; set; }
        public int precioTotal { get; set; }
        public Membresia oMembresia { get; set; }

    }

    public class PagoDto
    {
        public string estado { get; set; }
        public DateTime? fechaPago { get; set; }
        public int oMembresiaId { get; set; }
        public int precioTotal { get; set; }
    }

}
