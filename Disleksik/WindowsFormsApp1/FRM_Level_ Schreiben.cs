using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Disleksia
{
    public partial class FRM_Level_Schreiben : Form
    { 

         public Form Parent { get; private set; }
    Updater u = new Updater();
        Font font_ui_Text = new Font("Applau", 12, FontStyle.Regular);
        Font font_ui_Text_big = new Font("Applau", 18, FontStyle.Regular);
        Font font_player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);

       string[] words_to_display;
        int Fehler = 0;

        string[] words_to_check =
         {
            "Ich mag Züge!",
            "Wo sind alle Blumen?",
            "Wasserhahn ist im Kuchen ",
            "Superkalifragilistischexpialighetische Bananenbrotbacker sind super.",
            "Rindfleischetikettierungsüberwachungsaufgabenübertragungsgesetz macht mega viel Spaß!",
            " "

        };
        int current_word_index =0 ;
        int current_string_index = 0;
        string current_string;
        
        public FRM_Level_Schreiben(Form parent)
        {
            InitializeComponent();
            Parent = parent;

            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, "Du sollst Die Sätze mitschreiben", font_ui_Text_big)));
            
            current_string = words_to_check[current_string_index];
            Word_Seperation();
            Display_Seperatet_Words();
            u.Updating();

        }

        public void Display_Seperatet_Words()
        {
            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, words_to_check[current_string_index], font_ui_Text)));
current_string_index++;

            //if (current_word_index == words_to_display.Length-1)
            //{
            //    LBX_MainWindow.Items.Clear();
            //    LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, "Du sollst Die Vokabeln mitschreiben", ui_Text)));
            //    current_word_index = 0;
            //    current_string_index++;
            //    current_string = words_to_check[current_string_index];
            //    Word_Seperation();
            //    wait = true;

            //}

        }
        public void Word_Seperation()
        {
           // words_to_display = current_string.Split((char)32);
            words_to_display = current_string.Split((char)32);
        }

        public void WordCheck()
        {

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


        bool wait = false;
        bool closesoon = false;
        private void imput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    if (TBX_Input.Text != "" && current_string_index < words_to_check.Count())
                    {

                        if (!wait)
                        {
                          
                        string outInBox = Wordscramble(TBX_Input.Text);
                        LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, outInBox, font_player_Text_Handwritten)));

                        if (outInBox != words_to_check[current_string_index])
                        {
                            Fehler++;
                            label2.Text = ($"FEHLER:    {Fehler}");
                        }

                        
                        TBX_Input.Clear();
                        

                        }
                        else
                        {
                            wait = false;
                        }

                        
                        Display_Seperatet_Words();

                        int counter = LBX_MainWindow.Items.Count;
                        while (counter > 16)
                        {
                            LBX_MainWindow.Items.RemoveAt(0);
                            counter = LBX_MainWindow.Items.Count;
                        }


                    }
                        if (current_string_index> words_to_check.Count() - 1)
                        {
                            if (closesoon) { this.Close(); }
                            closesoon = true;
                            LBX_MainWindow.Items.Clear();
                            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, $" Du hast dich {Fehler} mal verschrieben!", font_ui_Text_big)));

                        }
                    break;



            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            MyListBoxItem item = LBX_MainWindow.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
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
        /// <summary>
        /// is an one Testing bit for testing movement
        /// /do not remove 
        /// 
        ///  /moves test Button
        /// </summary>

        public void WibblWoble()
        {
            Random r = new Random();
            r.Next(-1, 2);
            int j = 0;
            int i = 100;
            i--;
            if (i== 0)
            {
                i = 100;
                j++;

            }
            LBX_MainWindow.Location = new Point(r.Next(9+j, 15+j), r.Next(190+j, 196+j));
            

        }

      
        


        /// <summary>
        /// function to mix Up words from the input consolos onto the 
        /// lBx_MainWindow
        /// </summary>
        /// <param name="playerimput"></param>
        /// <returns></returns>
        public string Wordscramble(string playerimput)
        {
            Random random = new Random();
            int scramble = random.Next(0, 8);
            scramble = 0;
            switch (scramble)
            {
                case 0:
                    playerimput = playerimput.Replace('b', 'd');

                    playerimput = playerimput.Replace('m', 'n');
                    playerimput = playerimput.Replace('z', 'c');
                    playerimput = playerimput.Replace('I', 'l');
                    playerimput = playerimput.Replace('q', 'p');



                    break;

                case 1:
                    playerimput = playerimput.Replace((char)32, (char)0);

                    break;
                case 2:
                    playerimput = playerimput.ToLower(); 
                    break;
                case 3:
                    playerimput = playerimput.Remove(2,4);
                    break;
                case 4:
                    playerimput = playerimput + playerimput;
                    break;
                case 5:
                    playerimput = "ts4zt";
                    break;



            }

            return playerimput;
        }
        private void FRM_Level_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.ShowInTaskbar = true;
            this.Parent.BringToFront();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
