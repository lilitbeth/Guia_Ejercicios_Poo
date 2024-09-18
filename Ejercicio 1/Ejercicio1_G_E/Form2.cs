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

namespace Ejercicio1_G_E
{
    public partial class Form2 : Form
    {
        string password;
        public Form2()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text; //capturamos los valores de usuario y contraseña
            string contra = txtpass.Text;
            string url = "C:\\POO\\" + usuario + ".txt";
            if (File.Exists(url)) //verifica si existe
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                if (contra.Equals(password)) //verifica si contraseña es igual al archivo
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");//login fallido
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto
            }
        }
    }
}
