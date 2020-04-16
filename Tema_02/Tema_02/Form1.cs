using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; /* Librería del ArrayList */

namespace Tema_02
{
    public partial class Form1 : Form
    {
        /* Declarar a nivel form la colección ArrayList */
        ArrayList recibos = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtDescripcion.Clear();
            txtCliente.Text = "";
            txtMonto.Text = "";
            dtFecha.Value = DateTime.Today; /* colocar hoy */

            txtNumero.Focus(); // enfocar
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Primero verificamos que el numero no se repita
            foreach(Recibo item in recibos)
            {
                // Item leera cada uno de los objetos almacenados
                if(item.numero == txtNumero.Text)
                {
                    MessageBox.Show("Ingrese otro Numero");
                    return; // Salir del void
                }
            }
            
            // Instanciar la Clase
            Recibo reg = new Recibo();

            reg.numero = txtNumero.Text;
            reg.fecha = dtFecha.Value;
            reg.cliente = txtCliente.Text;
            reg.descripcion = txtDescripcion.Text;
            reg.monto = double.Parse(txtMonto.Text);

            // Agregar reg a la coleccion recibos
            recibos.Add(reg);

            // Visualizar en el DatagridView: dgRecibos
            dgRecibo.DataSource = null;
            dgRecibo.DataSource = recibos;
        }
    }
}
