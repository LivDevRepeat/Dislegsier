﻿using Disleksia;
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
            
            //FRM_Text Text = new FRM_Text();
            //Text.Visible = true;

            FRM_Level_2 level_2 = new FRM_Level_2();
            level_2.Visible = true;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FRM_Startscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
