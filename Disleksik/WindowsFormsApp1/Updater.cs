﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Updater
    {
        public event Action updating;
        public int intervall = 5; 
        public Updater() { }
        /// <summary>
        /// creates timer 
        /// </summary>
        public void Updating()
        {
            // reaccurringActions += Movethings
            Timer trytimer = new Timer();
            trytimer.Interval = intervall;
            trytimer.Tick += new EventHandler(myUpdatingTry);
            trytimer.Start();
        }
        /// <summary>
        /// starts event Action updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void myUpdatingTry(object sender, EventArgs e)
        {
            updating?.Invoke();
        }
    }
}
