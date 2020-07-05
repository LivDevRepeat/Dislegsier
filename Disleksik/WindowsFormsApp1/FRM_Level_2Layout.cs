using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRM_Level_2Layout : Form
    {
            Updater u = new Updater();
        public FRM_Level_2Layout()
        {
            InitializeComponent();
            this.TransparencyKey = panel1.BackColor;
            u.Updating();
            u.intervall = 100;

        }

        int i = 0;
        bool runter = true;

        public void DotheWobbleDobble()
        {
            if (runter)
            {
                LBL_SearchedWord.Location = new Point(LBL_SearchedWord.Location.X, LBL_SearchedWord.Location.Y - 2);
                i++;
                if (i == 20)
                {
                    runter = false;
                }

            }
            if (!runter)
            {
                LBL_SearchedWord.Location = new Point(LBL_SearchedWord.Location.X, LBL_SearchedWord.Location.Y + 2);
                i--;
                if (i == -20)
                {
                    runter = true;
                   
                }

            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.updating += DotheWobbleDobble;

        }
    }
}
