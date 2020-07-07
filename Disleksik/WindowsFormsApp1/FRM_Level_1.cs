using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Disleksia
{
    public partial class FRM_Level_1 : Form
    {
        Updater u = new Updater();
        Font ui_Text = new Font("Applau", 12, FontStyle.Regular);
        Font player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);
        string[] words_to_display;

        List<string> words_to_check = new List<string>()
        {
            "Ich mag Züge",
            "Wo sind alle Blumen?",
            "Wasserhahn ist im Kuchen",
            "Superkalifragilistischexpialighetische Bananenbrotbacker sind super.",
            "Rindfleischetikettierungsüberwachungsaufgabenübertragungsgesetz macht mega viel Spaß!"
        };
        int current_string_index = 0;
        string current_string;

        public FRM_Level_1()
        {
            InitializeComponent();

            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, "Du sollst Die Vokabeln mitschreiben", ui_Text)));
            Display_Seperatet_Words();
            current_string = words_to_check[current_string_index];
            
            u.Updating();
        }

        public void Display_Seperatet_Words()
        {
            foreach(string word in words_to_display)
            {
                LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, "Du sollst Die Vokabeln mitschreiben", ui_Text)));
            }
        }
        public void Word_Seperation()
        {
            words_to_display = current_string.Split((char)32);
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
         


        private void imput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    if (imput.Text != "")
                    {
                        string outInBox = Wordscramble(imput.Text);

                        //listBox1.Items.Add(new MyListBoxItem(Color.DarkBlue, imput.Text, new Font("With My Woes", 12, FontStyle.Bold)));
                        LBX_MainWindow.Items.Add(new MyListBoxItem(Color.DarkBlue, outInBox, player_Text_Handwritten));
                        LBX_MainWindow.ItemHeight = 28;
                        //lBx_MainWindow.ItemHeight++;
                        // listBox1.Items.Add(new MyListBoxItem(Color.Red, ($"{listBox1.ItemHeight}"), new Font("ApplauseFon", 22, FontStyle.Bold)));
                        // listBox1.Items.Add(imput.Text);
                        int counter = LBX_MainWindow.Items.Count;
                        while (counter > 16)
                        {
                            LBX_MainWindow.Items.RemoveAt(0);
                            counter = LBX_MainWindow.Items.Count;
                        }

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
                    break;

                case 1:
                    playerimput = playerimput.Replace((char)32, (char)0);

                    break;
                case 2:
                    playerimput = playerimput.ToLower(); 
                    break;

            }

            return playerimput;
        }
        private void FRM_Level_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason != CloseReason.ApplicationExitCall)
            {
              // Environment.Exit(0);

            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
