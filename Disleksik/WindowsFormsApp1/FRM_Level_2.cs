using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRM_Level_2 : Form
    {
        Updater u = new Updater();
        Point test1 = new Point();
       // Font font_test = new Font();
        Font font_ui_Text = new Font("Applau", 20, FontStyle.Regular);
        Font font_ui_Text_Tiny = new Font("Applau", 11, FontStyle.Regular);
        Font font_player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);

        public FRM_Level_2()
        {
            InitializeComponent();
           // u.intervall = 100;
            u.Updating();
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "12.03.14,", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "      Kafka", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Es war sehr früh am Morgen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Es war sehr früh am Morgen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Es war sehr früh am Morgen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Es war sehr früh am Morgen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          die Straßen rein und leer,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Size = new Size(600, (LBX_Text.Items.Count * LBX_Text.ItemHeight));
            PNL_Text.Size =new Size ( 640,LBX_Text.Size.Height +40);
            LBX_Text.Location = new Point(20, 20);
            

            //this.TransparencyKey = panel3.BackColor ;
            FRM_Level_2Layout layover = new FRM_Level_2Layout();
            layover.Visible = true;
            layover.TopMost = true;


//
// "))
        }
        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m, Font f)
            {
                ItemColor = c;
                Message = m;
                Fontstyle = f;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
            public Font Fontstyle { get; set; }
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = LBX_Text.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {

                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    item.Fontstyle, // Take the font from the listbox

                    new SolidBrush(item.ItemColor), // Set the color 

                    e.Bounds // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
                //listBox1.TopIndex = listBox1.Items.Count - 1;

            }
            else
            {
                // The item isn't a MyListBoxItem, do  something about it
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.updating += Mover_Panel;
          //  u.updating += Mover_Listbox;
            u.updating += Label_Wobbel;
            //  u.updating += DotheWobble;
            //layover
          
        }

        int i = 0;
        bool runter = true;
        //public void DotheWobble()
        //{
        //    if (runter)
        //    {
        //        LBX_Text.Location = new Point(LBX_Text.Location.X, LBX_Text.Location.Y - 2);
        //        i++;
        //        if( i == 5)
        //        {
        //            runter = false;
        //        }

        //    }
        //    if (!runter)
        //    {
        //        LBX_Text.Location = new Point(LBX_Text.Location.X, LBX_Text.Location.Y + 2);
        //        i--;
        //        if (i == 0)
        //        {
        //            runter = true;
        //        }

        //    }



      //  }  
        public void Label_Wobbel()
        {
            label1.Location = UpAndDown(label1.Location);
        }
        public Point UpAndDown(Point point)
        {
            if (runter)
            {
                if( i == 5)
                {
                    runter = false;
                }
                i++;
                return new Point(point.X, point.Y - 2);

            }
           else  if (!runter)
            {
                if (i == 0)
                {
                    runter = true;
                }
                i--;
               return new Point(point.X, point.Y + 2);

            }

            return point; 



        }

        //public void DothemovingX()
        //{
        //    LBX_Text.Location = new Point(LBX_Text.Location.X - 2,LBX_Text.Location.Y);
        //    if(LBX_Text.Location.X <= 35)
        //    {

        //        u.updating += DothemovingY;
        //        u.updating -= DothemovingX;
        //    }
        //}

        //public void DothemovingY()
        //{
        //    LBX_Text.Location = new Point(LBX_Text.Location.X + 33, LBX_Text.Location.Y-4);

        //    if (LBX_Text.Location.X >= 365)
        //    {
        //        u.updating += DothemovingX;
        //        u.updating -= DothemovingY;
        //    }
        //}  



        bool seite = true;           
        public Point Mover(Point point)
        {


            if (seite )
            {
                
                if (point.X <= 35)
                {
                    seite = false;
                }
                
                return new Point(point.X - 3, point.Y);


            }
            if (!seite)
            {
                if (point.X >= 365)
                {
                    seite = true;
                }
               return  new Point(point.X + 33, point.Y - 4);

            }

            return point;
        }

        public void Mover_Panel()
        {
            PNL_Text.Location = Mover(PNL_Text.Location);
        }

        public void Mover_Listbox()
        {
            LBX_Text.Location = Mover(LBX_Text.Location);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Level_2_Load(object sender, EventArgs e)
        {

        }


    }
}
