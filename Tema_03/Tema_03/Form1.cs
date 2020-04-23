using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_03
{
    public partial class Form1 : Form
    {
        // Definir la colección comprobantes que es un List tipo comprobante
        public List<Comprobante> comprobantes = new List<Comprobante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtDescripcion.Clear();
            dtFecha.Value = DateTime.Today;
            txtCliente.Clear();
            txtMonto.Clear();

            txtNumero.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar el numero no se repita en la colección comprobantes
            if ( comprobantes.Find(r => r.numero == int.Parse(txtNumero.Text)) != null) 
            {
                MessageBox.Show("Ingrese otro numero");
                return;
            }

            // Si no se ah repetido instanciar, agregar a la coleccion y listar
            Comprobante reg = new Comprobante();
            reg.numero = int.Parse(txtNumero.Text);
            reg.fecha = dtFecha.Value;
            reg.cliente = txtCliente.Text;
            reg.descripcion = txtDescripcion.Text;
            reg.monto = double.Parse(txtMonto.Text);

            comprobantes.Add(reg); // Agregar

            dgComprobantes.DataSource = comprobantes.ToArray();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminando utilizando, el foreach?
            foreach( Comprobante comp in comprobantes )
            {
                if (comp.numero == int.Parse(txtNumero.Text) )
                {
                    comprobantes.Remove(comp);
                }
            }

            // Eliminando utilizando el for?
            for (int i = 0; i < comprobantes.Count ; i++)
            {
                if (comprobantes[i].numero == int.Parse(txtNumero.Text))
                {
                    comprobantes.Remove(comprobantes[i]);
                    dgComprobantes.DataSource = null;
                    dgComprobantes.DataSource = comprobantes.ToArray();
                    return;
                }
            }

            // Utilizando el RemoveAll para eliminar una condición
            // Este metodo retorna un valor numérico, indica la cantidad de registros eliminados
            comprobantes.RemoveAll(r => r.numero == int.Parse(txtNumero.Text));
            dgComprobantes.DataSource = comprobantes.ToArray();
        }
    }
}
