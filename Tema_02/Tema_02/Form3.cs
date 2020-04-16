using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_02
{
    public partial class Form3 : Form
    {
        List<Recibo> recibos = new List<Recibo>();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Autogenera
            int i = recibos.Count() + 1;

            // Instancia, agregar y listar
            Recibo reg = new Recibo();
            reg.numero = (i).ToString().PadLeft(4,'0'); // Relleno a la iz de ceros
            reg.fecha = dtFecha.Value;
            reg.cliente = txtCliente.Text;
            reg.descripcion = txtDescripcion.Text;
            reg.monto = double.Parse(txtMonto.Text);

            recibos.Add(reg);
            dgRecibo.DataSource = recibos.ToArray();
        }
    }
}
