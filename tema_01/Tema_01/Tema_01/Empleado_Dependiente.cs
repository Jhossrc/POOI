using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_01
{
    /* Empleado_Dependiente hereda de Empleado */
    class Empleado_Dependiente : Empleado
    {
        // Por ser dependiente se le calcula su AFP 13% del pago.
        public double AFP()
        {
            return base.pago() * 0.13;
        }

        public double Neto()
        {
            return base.pago() - AFP();
        }
        
    }
}
