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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // A traves del foreach realizo la busqueda
            // Comparando con numero

            foreach(Recibo item in recibos)
            {
                // Si lo encuentra
                if(item.numero == txtNumero.Text)
                {
                    // Visualizo los datos en los controles
                    dtFecha.Value = item.fecha;
                    txtCliente.Text = item.cliente;
                    txtDescripcion.Text = item.descripcion;
                    txtMonto.Text = item.monto.ToString();

                    return; // Salir del metodo, ya lo encontraste
                }
            }
            // Si el for no lo encontró
            MessageBox.Show("No encontró el número");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico si el textBox esta vacio
            if(txtNumero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar un número");
                return; // Salir
            }

            // Si no esta vacio lo busco para eliminar
            foreach(Recibo item in recibos)
            {
                if (item.numero == txtNumero.Text)
                {
                    // Quitar items
                    recibos.Remove(item);
                    dgRecibo.DataSource = null;
                    dgRecibo.DataSource = recibos;
                    return;
                }
            }

            // Si no lo encontró
            MessageBox.Show("No existe el numero del recibo");
        }
    }
}
