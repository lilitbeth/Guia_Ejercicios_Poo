using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Ejercicio3_G_E
{
    internal class Camion: IVehiculo
    {
       
        private System.Windows.Forms.Timer timer3;
        public PictureBox pictureBox;
        public bool isMoving;


        public Camion(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            timer3 = new System.Windows.Forms.Timer();
            timer3.Interval = 20;
            timer3.Tick += Timer_Tick;
        }
        public bool IsMoving { get => isMoving; set => isMoving = value; }
        public void Avanzar()
        {
          
            isMoving = true;
            timer3.Start();
        }

        public void Frenar()
        {
           
            isMoving = false;
            timer3.Stop();
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
