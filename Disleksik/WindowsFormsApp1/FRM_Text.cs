using Disleksia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class FRM_Text : Form
    {
        Updater updater = new Updater();
        Font font_ui_Text = new Font("Applau", 12, FontStyle.Regular);
        Font font_player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);
        Font font_player_Text_Handwritten_larger = new Font("ApplauseFont", 30, FontStyle.Bold);
        int current_question_index = 0;
        List<Awnsers> current_awnsers = new List<Awnsers>();
        
       

        public FRM_Text()
        {
            InitializeComponent();

           // LBX_MainWindow.Items.Add((new MyListBoxItem(Color.DarkSeaGreen, "Du sollst Die Vokabeln mitschreiben", font_ui_Text)));
           
            updater.Updating();
            Display_awnsers_and_question();
            
            
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


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //case (char)13:
                //    if (imput.Text != "")
                //    {
                //        string outInBox = Wordscramble(imput.Text);

                //        //listBox1.Items.Add(new MyListBoxItem(Color.DarkBlue, imput.Text, new Font("With My Woes", 12, FontStyle.Bold)));
                //        lBx_MainWindow.Items.Add(new MyListBoxItem(Color.DarkBlue, outInBox, player_Text_Handwritten));
                //        lBx_MainWindow.ItemHeight = 28;
                //        //lBx_MainWindow.ItemHeight++;
                //        // listBox1.Items.Add(new MyListBoxItem(Color.Red, ($"{listBox1.ItemHeight}"), new Font("ApplauseFon", 22, FontStyle.Bold)));
                //        // listBox1.Items.Add(imput.Text);

                //        if (lBx_MainWindow.Items.Count > 10)
                //        {
                //            lBx_MainWindow.Items.RemoveAt(0);
                //            lBx_MainWindow.Items.RemoveAt(1);

                //        }
                //        lBx_MainWindow.TopIndex = lBx_MainWindow.Items.Count - 1;

                //    }
                //    break;



            }

        }

        /// <summary>
        /// is an one Testing bit for testing movement
        /// /do not remove 
        /// 
        ///  /moves test Button
        /// </summary>

        private int waitingtime;
        public event Action waiting;
        public void Wait(int inputwaitingtime)
        {
            waitingtime = inputwaitingtime;
            Timer timer = new Timer();
            timer.Interval = 5;
            timer.Tick += new EventHandler(WaitingTimer);
            timer.Start();
            if (waitingtime == 0)
            {
                timer.Stop();
            }
        }
        public void WaitingTimer(object sender, EventArgs e)
        {
            waitingtime--;
            if (waitingtime <= 0)
            {
                waiting?.Invoke();
            }

        }

        public void Display_awnsers_and_question()
        {
            LBX_Awnsers.Items.Clear();
            if (LBX_MainWindow.Items.Count > 17) 
            {
                LBX_MainWindow.Items.RemoveAt(0);
                LBX_MainWindow.Items.RemoveAt(0);
            }
            current_awnsers.Clear();
            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black,$"'{current_question[current_question_index]}'", font_ui_Text)));
            foreach (Awnsers awnser in testiscripts)
            {
                if (awnser.Index_of_asked_question == current_question_index)
                {
                    current_awnsers.Add(awnser);
                    //LBX_Awnsers.Items.Add((new MyListBoxItem(Color.Blue, awnser.Content, player_Text_Handwritten_larger)));
                    LBX_Awnsers.Items.Add($"'{awnser.Content}'");
                }
            }

        }


        /// <summary>
        /// function to mix Up words from the input consolos onto the 
        /// lBx_MainWindow
        /// </summary>
        /// <param name="playerimput"></param>
        /// <returns></returns>

        private void FRM_Level_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        List<string> exclamitions = new List<string>()
        {
            "Welcome Blahbla blah blah blah blah"
        };


        //Dictionary<int, Awnsers> questions = new Dictionary<int, Awnsers>()
        //{
        //    {10000,new Awnsers(10000,0,"Das ist eine Default Question") },

        //}; 
        //Dictionary<int, Awnsers> awnsers = new Dictionary<int, Awnsers>()
        //{
        //    {10000,new Awnsers(10000,0,"Das ist eine Default Question") },

        //};

        List<Awnsers> testiscripts = new List<Awnsers>()
        {
            new Awnsers(0,0,1,"Hi"),

            new Awnsers(1,0,2,"I'm pretty bad"),
            new Awnsers(1,0,3,"I´m really good"),
            new Awnsers(1,0,4,"Who the hell are you "),

            new Awnsers(2,0,2,"Nah dont wanna "),
            new Awnsers(2,0,5,"I guess why not "),

            new Awnsers(3,0,5,"YEEEES"),
            new Awnsers(3,0,5,"yes"),
            new Awnsers(3,0,5,"yes?"),

            new Awnsers(4,0,4,"Why should i go whith you?"),
            new Awnsers(4,0,5,"My choices seem very limetet right now"),


            new Awnsers(5,1,6,"Yes!"),
            new Awnsers(5,0,7,"I'm not ready!"),
            
            
            new Awnsers(6,0,8,"Horrible"),

            new Awnsers(7,1,6,"I'm ready now"),
            new Awnsers(7,0,7,"Still need some time"),

             new Awnsers(8,2,0,"Yes i gues")





        };

        List<string> current_question = new List<string>()
        { 
         "welcome ",//0
         "How are you",//1
         "Thats a shame. But lets begin any way ",//2
         "Oh thats good lets begin",//3
         "I'm Slartyblartfast lets go on an adventure",//4
         "We are about to uncover a totally secret Are you ready for level 1?",//5
         "Wow was it? ",// 6
         "No worries just tell me once you are",//7
         "Thats Good to know ready for level 2?"//8


        }; 

   
        private void LBX_Awnsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Awnsers.SelectedIndex >-1) 
            { 
                Awnsers selected_awnser = current_awnsers[LBX_Awnsers.SelectedIndex];
                current_question_index = selected_awnser.Index_of_next_question;
                LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Blue,$"`{selected_awnser.Content}´",font_player_Text_Handwritten)));
                Display_awnsers_and_question();
                if (selected_awnser.Index_of_awnser!=0)
                {
                    switch (selected_awnser.Index_of_awnser)
                    {
                        case 1:
                            FRM_Level_1 level1 = new FRM_Level_1();
                            level1.Visible = true;
                            break;
                        case 2:
                            FRM_Level_2 level2 = new FRM_Level_2();
                            level2.Visible = true;
                            break;
                    }
                }

            
            }
        }
    }
}
