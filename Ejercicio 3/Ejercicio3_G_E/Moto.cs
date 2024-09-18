using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Ejercicio3_G_E
{
    public class Moto : IVehiculo
    {
        
        public System.Windows.Forms.Timer timer1;
        public PictureBox pictureBox;
        public bool isMoving;
        

        public Moto(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 20;
            timer1.Tick += Timer_Tick;
        }
        public void Avanzar()
        {
           
            isMoving = true;
            timer1.Start();
        }

        public void Frenar()
        {
           
            isMoving = false;
            timer1.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                pictureBox.Left = Math.Max(0, pictureBox.Left - 5);
            }
        }
    }
}
