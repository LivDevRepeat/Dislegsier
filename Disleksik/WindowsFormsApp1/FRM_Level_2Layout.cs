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

        public  Updater u = new Updater();
        Updater uname = new Updater();

        private FRM_Level_2 frm_Level_2;
        public CheckWord Location_of_Word;
        public int words_to_check_index = 0;
        public List<CheckWord> words_to_check = new List<CheckWord>()
        {
            new CheckWord( "sehr",      new Point(283,100) ),
            new CheckWord( "Straßen",   new Point(308,60) ),
            new CheckWord( "Bahnhof",   new Point(189,20) ),
            new CheckWord( "eine",      new Point(287,-20) ),
            new CheckWord( "Uhr",       new Point(244,-60) ),
            new CheckWord( "später",    new Point(34,-100) ),
            new CheckWord( "geglaubt",  new Point(264,-140) ),
            new CheckWord( "beeilen",   new Point(94,-180) ),
            new CheckWord( "diese",     new Point(126,-220) ),
            new CheckWord( "Weg",       new Point(219,-260) ),
            new CheckWord( "dieser",    new Point(140,-300) ),
            new CheckWord( "gut",       new Point(190,-340) ),
            new CheckWord( "Nähe",      new Point(133,-420) ),
            new CheckWord( "Er",        new Point(386,-500) ),
            new CheckWord( "Weg",       new Point(112,-540) ),
            new CheckWord( "Ja",        new Point(379,-580) ),
            new CheckWord( "finden",    new Point(92,-620) ),
            new CheckWord( "auf",       new Point(203,-660) ),
            new CheckWord( "großen",    new Point(232,-740) ),
            new CheckWord( "Leute",     new Point(282,-780) )
        };


        public FRM_Level_2Layout(FRM_Level_2 fRM_Level_2)
        {
            InitializeComponent();
            frm_Level_2 = fRM_Level_2;
            this.ShowInTaskbar = false;
            this.TransparencyKey = panel1.BackColor;
            u.Updating();
            uname.Updating();


            u.intervall = 100;
            u.updating += Lable_updater;
            u.updating += GeralUpdatere;

            uname.updating += Searched_Word_Display_Updater;

        }

        int i = 0;
        bool runter = true;
        public void GeralUpdatere()
        {
            Location_of_Word = words_to_check[words_to_check_index];
            KeyCheck();
        }

        public void Searched_Word_Display_Updater()
        {
    

            LBL_SearchedWord.Text = $"{words_to_check[words_to_check_index].Content}";
            

        }

        public void DotheWobbleDobble()
        {
            if (runter)
            {
                LBL_SearchedWord.Location = new Point(LBL_SearchedWord.Location.X, LBL_SearchedWord.Location.Y - 2);
                i++;
                if (i == 26)
                {
                    runter = false;
                }

            }
            if (!runter)
            {
                LBL_SearchedWord.Location = new Point(LBL_SearchedWord.Location.X, LBL_SearchedWord.Location.Y + 2);
                i--;
                if (i == -26)
                {
                    runter = true;

                }

            }


            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((frm_Level_2.PNL_Text.Location.X <= 210) & (frm_Level_2.PNL_Text.Location.X >= 190))
            {
                LBL_SearchedWord.Text = "hurray";
            }
            else
            {
                //LBL_SearchedWord.Text = "nah bruh";
            }

        }

        //     public void Word_LocationCheck;

        public void Lable_updater()
        {
           
            label2.Text = $"{ frm_Level_2.PNL_Text.Location}";
        }

        private void FRM_Level_2Layout_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Level_2.Close();
        }

        private void FRM_Level_2Layout_Move(object sender, EventArgs e)
        {
            this.Location = frm_Level_2.Location;

        }

        private void FRM_Level_2Layout_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.W):
                    LBL_SearchedWord.Text = "Itried";
                    frm_Level_2.PNL_Text.Location = new Point(frm_Level_2.PNL_Text.Location.X, frm_Level_2.PNL_Text.Location.Y - 40);

                    break;
                case (Keys.A):
                    frm_Level_2.PNL_Text.Location = new Point(frm_Level_2.PNL_Text.Location.X - 1, frm_Level_2.PNL_Text.Location.Y);
                    break;
                case (Keys.S):
                    frm_Level_2.PNL_Text.Location = new Point(frm_Level_2.PNL_Text.Location.X, frm_Level_2.PNL_Text.Location.Y + 40);
                    break;
                case (Keys.D):
                    frm_Level_2.PNL_Text.Location = new Point(frm_Level_2.PNL_Text.Location.X + 1, frm_Level_2.PNL_Text.Location.Y);
                    break;
                case (Keys.Q):
                    if (words_to_check_index >= 19)
                    {
                        words_to_check_index = 0;
                    }
                    else
                    {
                        words_to_check_index++;
                    }
                    break;
                case (Keys.Enter):
                    u.updating -= DotheWobbleDobble;
                    InputValidationCheck();
                    words_to_check_index++;

                    break;


            }

        }

        public void InputValidationCheck()
        {
           label1.Text = $"{words_to_check[words_to_check_index].WordCheck(LBL_SearchedWord.Location)}";
        }

        private void KeyCheck()
        {

        }

        private void FRM_Level_2Layout_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.updating -= DotheWobbleDobble;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            u.updating += DotheWobbleDobble;
        }
    }
}
