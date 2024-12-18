using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Localidad
    {
        public int Id { get; set; }
        public string nombreLocalidad { get; set; }
        public int codigoPostal { get; set; }
        public int oProvinciaId { get; set; }
        public  Provincia oProvincia { get; set; }


    }
}
