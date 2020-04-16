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
    }
}
