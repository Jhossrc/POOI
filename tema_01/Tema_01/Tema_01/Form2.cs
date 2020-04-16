using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombre.Clear(); // Limpiar
            txtCategoria.Clear(); // Limpiar
            txtBasico.Text = string.Empty; // vacío
            txtBonificacion.Clear();
            txtPago.Clear();
            txtAFP.Clear();
            txtNeto.Clear();

            txtDNI.Focus();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Empleado_Dependiente x = new Empleado_Dependiente();
            x.dni = txtDNI.Text;
            x.nombre = txtNombre.Text;
            x.categoria = txtCategoria.Text;
            x.basico = double.Parse(txtBasico.Text);

            // Por ser heredado puedo ejecutar los metodos del padre
            txtBonificacion.Text = x.bonificacion().ToString();
            txtPago.Text = x.pago().ToString();
            txtAFP.Text = x.AFP().ToString();
            txtNeto.Text = x.Neto().ToString();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            // Instancia el Form 1
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
