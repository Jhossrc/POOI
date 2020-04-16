using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_02
{
    /* Alcance public */
    public class Recibo
    {
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string descripcion { get; set; }
        public double monto { get; set; }

    }
}
