using System;
using System.Collections.Generic; // Libreria de las List
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_02
{
    public partial class Form2 : Form
    {
        // Declaramos la lista a nivel Form
        List<Recibo> recibos = new List<Recibo>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtCliente.Clear();
            txtDescripcion.Clear();
            txtMonto.Clear();
            dtFecha.Value = DateTime.Today;

            txtNumero.Focus(); // enfocar
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Utilizando Find: Buscar el elemento por su numero
            // Si lo encuentra, retorna un valor que NO es null
            if (recibos.Find( r => r.numero == txtNumero.Text ) != null)
            {
                MessageBox.Show("Ingrese otro número");
                return; // Salir del void
            }

            // Si no lo encuentra, instancia, agregar y listar
            Recibo reg = new Recibo();
            reg.numero = txtNumero.Text;
            reg.fecha = dtFecha.Value;
            reg.cliente = txtCliente.Text;
            reg.descripcion = txtDescripcion.Text;
            reg.monto = double.Parse(txtMonto.Text);

            recibos.Add(reg); // agregar
            dgRecibo.DataSource = recibos.ToArray(); // Listar

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Utilizando el Find buscamos al recibo por su numero
            // Si lo encuentra reg no es NULL y visualizo los datos
            Recibo reg = recibos.Find(r => r.numero == txtNumero.Text);

            if (reg != null)
            {
                txtNumero.Text = reg.numero;
                dtFecha.Value = reg.fecha;
                txtCliente.Text = reg.cliente;
                txtDescripcion.Text = reg.descripcion;
                txtMonto.Text = reg.monto.ToString();
            } else
            {
                MessageBox.Show("No lo encotró");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Utilizando un remove elimino por su numero
            // Retorna el número de elementos eliminados
            int c = recibos.RemoveAll(r => r.numero == txtNumero.Text);

            if (c == 0)
            {
                MessageBox.Show("No elimino recibos");
            } else
            {
                // Volver a listar
                dgRecibo.DataSource = recibos.ToArray();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar el numero del recibo
            Recibo reg = recibos.Find(r => r.numero == txtNumero.Text);

            if (reg != null) // Si lo encontro
            {
                //Cambiar los datos del recibo ubicado
                reg.fecha = dtFecha.Value;
                reg.cliente = txtCliente.Text;
                reg.descripcion = txtDescripcion.Text;
                reg.monto = double.Parse(txtMonto.Text);

                // Actualizar la lista
                dgRecibo.DataSource = recibos.ToArray();
            } else // Si no lo encontro
            {
                MessageBox.Show("No encontro el número");
            }
        }
    }
}
