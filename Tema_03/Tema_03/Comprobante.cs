using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_03
{
    public class Comprobante
    {
        public int numero { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string descripcion { get; set; }
        public double monto { get; set; }
        // definir al atributo descuento que retorna el valor de descuento
        public double descuento { get { return Descuento(); } }
        public double neto { get { return Neto(); } }

        // Programar el descuento que representa el 20 + 30% de descuento del monto
        public double Descuento()
        {
            return (monto*0.20) + (monto*0.80)*0.30;
        }

        public double Neto()
        {
            return monto - Descuento();
        }
    }
}
