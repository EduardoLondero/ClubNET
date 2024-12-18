using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Permiso
    {
        public int Id {  get; set; }
        public int oRolId { get; set; }
        public string nombrepermiso { get; set; }
        public string fechaCreacionPermiso { get; set; }

    }
}
