using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tema_03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            // Cuadro de dialogo para guardar en txt o sql
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "Archivo de texto|*.txt|Archivo sql|*.sql";

            if (op.ShowDialog() == DialogResult.OK)
            {
                // Para guardar el fileStream creará el archivo para guardar contenido
                FileStream f = new FileStream(op.FileName, FileMode.Create);

                // Definir al escritor el cual apunta a f
                StreamWriter escritor = new StreamWriter(f);

                // Escribir
                escritor.Write(txtBloc.Text);

                escritor.Close(); f.Close(); // Cerrar
            }

        }

        private void txtAbrir_Click(object sender, EventArgs e)
        {
            // Cuadro de dialogo para abrir txt o sql
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo de texto|*.txt|Archivo sql|*.sql";

            if(op.ShowDialog() == DialogResult.OK)
            {
                // FileStream para abrir el archivo en el Buffer
                FileStream f = new FileStream(op.FileName, FileMode.Open);

                // Definir al lector el cual apuntaa f (esta abriendo el archivo)
                StreamReader lector = new StreamReader(f);

                // Leer todo y visualizar en el TextBox
                txtBloc.Text = lector.ReadToEnd();

                lector.Close(); f.Close(); // Cerrar
            }
        }
    }
}
