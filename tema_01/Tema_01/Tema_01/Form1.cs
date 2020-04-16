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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtBasico.Text = "";
            txtPago.Text = "";
            txtDNI.Focus(); // Enfocar en el contorno.
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Instanciar la clase
            Empleado c = new Empleado();

            // Pasar los valores
            c.dni = txtDNI.Text;
            c.nombre = txtNombre.Text;
            c.categoria = txtCategoria.Text.ToUpper(); // Convertir a mayuscula
            c.basico = double.Parse(txtBasico.Text);

            // Ejecutar los métodos: La derecha debe ser compatible al tipo de la izquierda
            txtBonificacion.Text = c.bonificacion().ToString();
            txtPago.Text = c.pago().ToString();
        }
    }
}
