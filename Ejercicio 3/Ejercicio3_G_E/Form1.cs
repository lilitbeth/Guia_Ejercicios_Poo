using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_G_E
{
    public partial class Form1 : Form
    {
        private Moto moto;
        private carro carro;
        private Camion camion;
        public Form1()
        {
            InitializeComponent();
            moto = new Moto(pictureBox5);
            carro = new carro(pictureBox4);
            camion = new Camion(pctbCamion);
        }
        //Moto
        
        private void button2_Click(object sender, EventArgs e)
        {
            moto.Avanzar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moto.Frenar();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left += 5;

        }
        //Carro

        private void button5_Click(object sender, EventArgs e)
        {
            carro.Avanzar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            carro.Frenar();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left += 5;
        }

        //Camión

        private void button8_Click(object sender, EventArgs e)
        {
            camion.Avanzar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            camion.Frenar();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pctbCamion.Left += 5;
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
