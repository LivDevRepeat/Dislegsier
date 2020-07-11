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
    public partial class FRM_Level_Lesen : Form
    {
        public Form Parent{ get;private set; }
        Updater u = new Updater();
        bool seite = true;
        int moving_counter = 1;

        Font font_ui_Text = new Font("Applau", 20, FontStyle.Regular);
        Font font_ui_Text_Tiny = new Font("Applau", 11, FontStyle.Regular);
        Font font_player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);
        FRM_Level_Lesen_Layover layover;

        Point PNLpoinzero { get; set; }

        public FRM_Level_Lesen(Form parent)
        { // genara Manditory Code for an Level

            InitializeComponent();
            u.Updating();
            Parent = parent;
            parent.ShowInTaskbar = false;
            this.ShowInTaskbar = true;
            this.Select();
            Configuration_Text();
            Configuration_Overlay();
            Cursor.Hide();

            u.intervall = 60;
            u.updating += Mover_Panel;

            PNL_Kopie.Parent = panel2;
            PNL_Kopie.Location = PNL_Text.Location;
      
            PNLpoinzero = PNL_Text.Location;


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
            Environment.Exit(0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
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
         

        public Point Mover(Point point)
        {


            if (seite )
            {
                
                if (point.X <= 33)
                {
                    seite = false;
                }
                
                return new Point(point.X - 1, point.Y);


            }
            if (!seite)
            {
                if (point.X >= 433| moving_counter ==10  )
                {
                    seite = true;
                    moving_counter = 0;
                }
                moving_counter++;
               
               return  new Point(point.X + 40, point.Y - 4);

            }

            return point;
        }

        bool moving = true;

        public void Mover_Panel()
        {

         //   PNL_Text.Location = Mover(PNL_Text.Location);
            // for (int i = 10; i== 0; i--)
            //{
            PNL_Kopie.Location = Mover(PNL_Kopie.Location);
            PNL_Text.Location= Shake_it_like_a_polariod_picture(0,
                PNL_Kopie.Location);
            PNLpoinzero = PNL_Kopie.Location; 

           // PNL_Text.Location = layover.words_to_check[layover.words_to_check_index].-Location;
            Halt_At_Word();

            //}
            
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

        private void FRM_Level_2_Move(object sender, EventArgs e)
        {
            layover.Location = this.Location;
           
        }

        private void FRM_Level_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            u.Stoping();
            layover.Close();
            Gametatus.Gamestatus = 0; 
            this.Parent.BringToFront();
            this.Parent.ShowInTaskbar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);

        }

        private void Halt_At_Word()
        {

            if (PNL_Kopie.Location == layover.words_to_check[layover.words_to_check_index].Location)
            {
                moving = false;
                u.updating -= Mover_Panel;
       
                layover.u.updating += layover.DotheWobbleDobble;
                

            }


        }

        private void Configuration_Text()
        {
            LBX_Text_Items_Adder();
            LBX_Text.Size = new Size(600, (LBX_Text.Items.Count * LBX_Text.ItemHeight));
            PNL_Text.Size = new Size(640, LBX_Text.Size.Height + 40);
            PNL_Kopie.Size = new Size(640, LBX_Text.Size.Height + 40);
            LBX_Text.Location = new Point(20, 20);

        }
        private void LBX_Text_Items_Adder()
        {
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "12.03.14,", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "      Kafka", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text_Tiny));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Es war sehr früh am Morgen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          die Straßen rein und leer,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich ging zum Bahnhof.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Als ich eine Turmuhr", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          mit meiner Uhr verglich, ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          sah ich, dass es schon viel später war,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          als ich geglaubt hatte,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich musste mich sehr beeilen,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          der Schrecken über diese Entdeckung", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ließ mich im Weg unsicher werden, ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich kannte mich in dieser Stadt", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          noch nicht sehr gut aus,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          glücklicherweise war ein", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Schutzmann in der Nähe, ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          ich lief zu ihm und", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          Er lächelte und sagte: ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          'Von mir willst du den Weg erfahren ?' ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          'Ja', sagte ich,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          'da ich ihn selbst nicht finden kann.'", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          'Gibs auf, gibs auf',", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          sagte er und wandte sich", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          mit einem großen Schwunge ab,", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          so wie Leute, die ", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "          mit ihrem Lachen allein sein wollen.", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
            LBX_Text.Items.Add(new MyListBoxItem(Color.DarkGray, "", font_ui_Text));
        }

        private void Configuration_Overlay()
        {

            layover = new FRM_Level_Lesen_Layover(this);
            layover.Visible = true;
            layover.TopMost = true;
            layover.Location = this.Location;
        }

        private void input(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case (char)13:
                    InputCheck();
                    break;

            }


        }

      

        public Point Shake_it_like_a_polariod_picture(int shakefactor, Point location) 
        {
            Random random = new Random();
            return new Point(PNLpoinzero.X + (random.Next(-shakefactor, shakefactor)), PNLpoinzero.Y + (random.Next(-shakefactor, shakefactor)));
            
        
        }

       
       public void InputCheck()
        {
            if(moving == false)
            {
             layover.u.updating -= layover.DotheWobbleDobble;
             Gametatus.Gamestatus = Gametatus.Gamestatus + layover.words_to_check[layover.words_to_check_index].WordCheck(layover.LBL_SearchedWord.Location);
          
                Gamestatuscheck();

                layover.words_to_check_index++;
                moving = true;

            }

           


        }

        public void Gamestatuscheck()
        {
            u.updating += Mover_Panel;
            if (Gametatus.Gamestatus >= 80)
            {
                u.intervall = 1;
                u.updating += OoofSize15;
                u.updating -= OoofSize4;


                return;
            }

            
            if (Gametatus.Gamestatus >= 60 )
            {
                u.intervall = 5;
                u.updating += OoofSize4;
                u.updating -= OoofSize3;
                return;
            }

            if (Gametatus.Gamestatus >= 40)
            {
                u.intervall = 20;
                u.updating += OoofSize3;
                u.updating -= OoofSize2;
                                            
                return;
            }
            if (Gametatus.Gamestatus >= 15)
            {
                u.intervall = 30;
                u.updating += OoofSize2;
                u.updating -= OoofSize1;
                return;
            }

            if (Gametatus.Gamestatus >= 3)
            {
                u.intervall = 60;
                u.updating += OoofSize1;
                return;
            }          
            



        }
 

        public void OoofSize1()
        {
            
            PNL_Text.Location = Shake_it_like_a_polariod_picture(1, PNL_Text.Location);


        }    
        public void OoofSize2()
        {
            
            PNL_Text.Location = Shake_it_like_a_polariod_picture(5, PNL_Text.Location);
            layover.mockinglables[1].Visible = true;
            layover.mockinglables[2].Visible = true;
            layover.mockinglables[3].Visible = true;
            layover.mockinglables[4].Visible = true;




        }       
        public void OoofSize3()
        {
            
            PNL_Text.Location = Shake_it_like_a_polariod_picture(20, PNL_Text.Location);
            layover.mockinglables[5].Visible = true;
            layover.mockinglables[6].Visible = true;
            layover.mockinglables[7].Visible = true;
            layover.mockinglables[8].Visible = true;
            layover.mockinglables[9].Visible = true;
            layover.mockinglables[10].Visible = true;
            layover.mockinglables[11].Visible = true;
            layover.mockinglables[12].Visible = true; 
            layover.mockinglables[13].Visible = true;


        }       
        public void OoofSize4()
        {
            
            PNL_Text.Location = Shake_it_like_a_polariod_picture(50, PNL_Text.Location);
            layover.mockinglables[14].Visible = true;
            layover.mockinglables[15].Visible = true;
            layover.mockinglables[16].Visible = true; 
            layover.mockinglables[17].Visible = true;
            layover.mockinglables[18].Visible = true;
            layover.mockinglables[19].Visible = true;
            layover.mockinglables[20].Visible = true;
            layover.mockinglables[21].Visible = true;
            layover.mockinglables[22].Visible = true; 
            layover.mockinglables[23].Visible = true;
            layover.mockinglables[24].Visible = true;
            layover.mockinglables[25].Visible = true;

        }
        public void OoofSize15()
        {
           for(int i =26; i <= 50;i++)
            {
                layover.mockinglables[i].Visible = true;
            }

            PNL_Text.Location = Shake_it_like_a_polariod_picture(200, PNL_Text.Location);
            Updater nu = new Updater();
            nu.waitingtime = 100;
            nu.updating += this.Close;
            nu.Updating();

        }

        private void PNL_Kopie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
