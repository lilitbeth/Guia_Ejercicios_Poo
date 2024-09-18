using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string isbn = txtisbn.Text;
            string titulo = txttitulo.Text;
            string autor = txtautor.Text;
            int numpaginas = int.Parse(txtnumpaginas.Text);

            Libro libro = new Libro()
            {
                ISBN = isbn,
                Titulo = titulo,
                Autor = autor,
                NumPaginas = numpaginas
            };

            MessageBox.Show(libro.ToString(), "información libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtisbn.Clear();
            txttitulo.Clear();
            txtautor.Clear();
            txtnumpaginas.Clear();
        }
    }
}
