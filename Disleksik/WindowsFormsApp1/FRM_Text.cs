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
        Form child;

        /// <summary>
        /// hir kann du ein beisoiel liste nachschlagen
        /// </summary>
        List<Awnsers> Awnsers_Test = new List<Awnsers>()
        {
            new Awnsers(0,0,9,"Hi"),

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

            new Awnsers(7,0,6,"I'm ready now"),
            new Awnsers(7,0,7,"Still need some time"),

            new Awnsers(8,0,9,"This bitch empty"),

            new Awnsers(10,0,14,"This bitch emptier"),
            new Awnsers(10,0,14,"This bitch emptier"),
            new Awnsers(10,0,11,"This bitch emptier"),
            new Awnsers(10,0,11,"This bitch emptier"),



            new Awnsers(14,0,10,"This bitch emptier"),







        };
        /// <summary>
        /// Wenn eine Frage keine antworten hat wird die nächste gleich darunter angezeit
        /// </summary>
        List<string> Questions_Test = new List<string>()
        {
         "welcome ",//0
         "How are you",//1
         "Thats a shame. But lets begin any way ", //2
         "Oh thats good lets begin",//3
         "I'm Slartyblartfast lets go on an adventure", //4
         "We are about to uncover a totally secret Are you ready for level 1?", //5
         "Wow was it? ",// 6
         "No worries just tell me once you are",//7
         "Thats Good to know ready for level 2?",//8
         "Yeeeeeeeeeeeeeeeeeeeet", //9
         "Yeet",//10
         "Teeeeeeeeeeeeeeeast1", //11
         "TEeeeeeeeeeeeeeeat ich habe einen Großen text.....................................................................................................--.......maxländge", //12
         "TEeeeeeeeeeeeeeeat", //13
         "TEeeeeeeeeeeeeeeat er ist super lang ", //14


        };
        List<Awnsers> Awnsers_Kapite_1 = new List<Awnsers>()
        { 
        
        };


        List<string> Questions_Kapite_1 = new List<string>()
        {
        };

        List<Awnsers> Awnsers_Kapite_2 = new List<Awnsers>()
        {

        };


        List<string> Questions_Kapite_2 = new List<string>()
        {

        };
        
        List<Awnsers> Awnsers_Kapite_3 = new List<Awnsers>()
        {

        };


        List<string> Questions_Kapite_3 = new List<string>()
        {
        };





        List<Awnsers> current_Awnserlist ;
        List<string> current_Questionlist ;

        public FRM_Text()
        {
            InitializeComponent();

        
            current_Awnserlist = Awnsers_Test;
            current_Questionlist = (Questions_Test);
        
           
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


        public void Display_awnsers_and_question()
        {
            int counter = LBX_MainWindow.Items.Count;
            while (counter > 16)
            {
                LBX_MainWindow.Items.RemoveAt(0);
                counter = LBX_MainWindow.Items.Count;
            }
            LBX_Awnsers.Items.Clear();
            current_awnsers.Clear();
            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black,$"{current_Questionlist[current_question_index]}", font_ui_Text)));
            
            int awnsercounter = 0;
            foreach (Awnsers awnser in current_Awnserlist)
            {
                if (awnser.Index_of_asked_question == current_question_index)
                {
                    current_awnsers.Add(awnser);
                    LBX_Awnsers.Items.Add($"'{awnser.Content}'");
                    awnsercounter++;
                }
            }

            if (awnsercounter == 0)
            {
                if(current_question_index < current_Questionlist.Count - 1)
                {
                current_question_index ++ ;

                }
                Display_awnsers_and_question();
            } 

        }


        /// <summary>
        /// function to mix Up words from the input consolos onto the 
        /// lBx_MainWindow
        /// </summary>
        /// <param name="playerimput"></param>
        /// <returns></returns>
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
                        case 2:
                            child = new FRM_Level_1();
                            child.Visible = true;
                            child.Location = this.Location;
                            break;
                        case 1:
                            child  = new FRM_Level_2();
                            child.Visible = true;
                            child.Location = this.Location;
                            break;
                    }
                }

            
            }
        }

        private void LBX_Awnsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    if (LBX_Awnsers.SelectedIndex > -1)
                    {
                        Awnsers selected_awnser = current_awnsers[LBX_Awnsers.SelectedIndex];
                        current_question_index = selected_awnser.Index_of_next_question;
                        LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, $"`{selected_awnser.Content}´", font_player_Text_Handwritten)));
                        Display_awnsers_and_question();
                        if (selected_awnser.Index_of_awnser != 0)
                        {
                            switch (selected_awnser.Index_of_awnser)
                            {
                                case 2:
                                    child = new FRM_Level_1();
                                    child.Visible = true;
                                    child.Location = this.Location;
                                    break;
                                case 1:
                                    child = new FRM_Level_2();
                                    child.Visible = true;
                                    child.Location = this.Location;
                                    break;
                            }
                        }


                    }
                    break;
                case 'w':
                    LBX_Awnsers.SelectedIndex--;
                    break;
                case 's':
                    LBX_Awnsers.SelectedIndex++;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void FRM_Level_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
