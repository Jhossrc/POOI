using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_01
{
    public class Empleado
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public double basico { get; set; }

        public double bonificacion()
        {
            double bon = 0;
            switch(categoria)
            {
                case "A": bon = 50;break;
                case "B": bon = 85; break;
                case "C": bon = 135; break;
                default: bon = 0;break;
            }

            return bon;
        }
        public double pago()
        {
            return basico + bonificacion();
        }
        public Empleado()
        {
            dni = "";
            nombre = "";
            categoria = "A";
            basico = 950;
        }
    }
}
