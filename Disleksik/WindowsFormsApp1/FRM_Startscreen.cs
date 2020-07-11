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
        Form child;
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            
            //FRM_Text Text = new FRM_Text();
            //Text.Visible = true;

            child  = new FRM_Text();
            child.Location = this.Location;
            child.Visible = true;
            child.ShowInTaskbar = false;
           // this.Visible = false;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FRM_Startscreen_Load(object sender, EventArgs e)
        {

        }

        private void FRM_Startscreen_Move(object sender, EventArgs e)
        {
            if (child!= null)
            {

                child.Location = this.Location;
                child.TopLevel = true;

            }
        }
    }
}
