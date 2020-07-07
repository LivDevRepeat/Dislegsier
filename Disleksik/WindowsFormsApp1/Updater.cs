using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Updater
    {
        public event Action updating;
        public int intervall = 5;
        public int waitingtime = 0;
            
        private  Timer trytimer = new Timer();
        public Updater() { }
        /// <summary>
        /// creates timer 
        /// </summary>
        public void Updating()
        {
            // reaccurringActions += Movethings
            trytimer.Interval = intervall;
            trytimer.Tick += new EventHandler(myUpdatingTry);
            trytimer.Start();
        }
        public void Stoping()
        {
            trytimer.Stop();
        }
        /// <summary>
        /// starts event Action updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

         void myUpdatingTry(object sender, EventArgs e)
        {
            if (waitingtime!=0)
            {
                waitingtime--;
                return;
            }
            updating?.Invoke();
        }


        
    }
}
