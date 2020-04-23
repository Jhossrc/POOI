using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Streams

namespace Tema_03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            // Cuadro de dialogo para crear un archivo y guardar contenido
            SaveFileDialog op = new SaveFileDialog();

            // Solo guardará archivo txt
            op.Filter = "Archivo de texto|*.txt";

            // Si presionas el boton aceptar (OK)
            if (op.ShowDialog() == DialogResult.OK )
            {
                // Definir el StreamWriter con el archivo del Save
                StreamWriter escritor = new StreamWriter(op.FileName);

                // Escribir utilizando el contenido del TextBox
                escritor.Write(txtBloc.Text);
                escritor.Close(); // Cerrar
            }
        }

        private void txtAbrir_Click(object sender, EventArgs e)
        {
            // Definir un cuadro de dialogo para buscar y abrir archivos txt
            OpenFileDialog op = new OpenFileDialog();
            // Buscar solo txt: filter
            op.Filter = "Archivo de texto |*.txt";

            // Si presionaste el boton Aceptar (ok)
            if (op.ShowDialog() == DialogResult.OK )
            {
                // Definir al lector con el archivo seleccionado
                StreamReader lector = new StreamReader(op.FileName);

                // leer todo y visualizar en el textBox
                txtBloc.Text = lector.ReadToEnd();

                lector.Close(); // Cerrar
            }
        }
    }
}
