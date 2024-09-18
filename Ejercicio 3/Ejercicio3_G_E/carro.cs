using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Ejercicio3_G_E
{
    internal class carro : IVehiculo
    {
        
        private System.Windows.Forms.Timer timer2;
        public PictureBox pictureBox;
        public bool isMoving;


        public carro(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 20;
            timer2.Tick += Timer_Tick;
        }
        public void Avanzar()
        {
            
            isMoving = true;
            timer2.Start();
        }

        public void Frenar()
        {
            
            isMoving = false;
            timer2.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                pictureBox.Left = Math.Min(pictureBox.Parent.ClientSize.Width - pictureBox.Width, pictureBox.Left + 5);
            }
        }
    }
}
