using Disleksia;
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
    public partial class FRM_Startscreen : Form
    {
        public FRM_Startscreen()
        {
            InitializeComponent();

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            FRM_Level_1 level_1 = new FRM_Level_1();
            level_1.Visible = true;
            this.Visible = false;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
