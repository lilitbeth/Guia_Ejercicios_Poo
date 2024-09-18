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
using System.Reflection.Emit;

namespace Ejercicio1_G_E
{
    public partial class Form1 : Form
    {
        Password contraseña = new Password();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            string password = contraseña.generarPassword();
            txtcontraseña.Text = password;
            
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtcontraseña.Text;
            string url = "C:\\POO\\" + usuario + ".txt";
            if (File.Exists(url)) //verifica que el archive exista
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado
                txtUsuario.Clear(); //limpiamos todos los textbox
                txtcontraseña.Clear();
            }
            else
            {
                File.WriteAllText(url, contra);
                MessageBox.Show("Usuario Registrado con éxito");
                txtUsuario.Clear();
                txtcontraseña.Clear();
            }
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            bool isValid = contraseña.esFuerte();
            if (isValid)
            {
                MessageBox.Show("La contraseña es segura");
            }
            else
            {
                MessageBox.Show("La contraseña no es segura ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;

            // Get the first letter of the name and last name
            char primeraLetraNombre = nombre[0];
            char primeraLetraApellido = apellido[0];

            
            int numero1 = random.Next(00, 99);
            int numero2 = random.Next(00, 99);
            int numero3 = random.Next(00, 99);
            
            string carné = $"{primeraLetraNombre}{primeraLetraApellido}{numero1}{numero2}{numero3}";

            txtUsuario.Text = carné;
        }
    }
}
