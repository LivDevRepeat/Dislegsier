using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disleksia
{
    public partial class Form1 : Form
    {
        public event Action reaccurringActions;
        public event Action oneTimeAction;

        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add((new MyListBoxItem(Color.DarkSeaGreen, "Du sollst Die Vokabeln mitschreiben",ui_Text )));
            Updating();
        }

        Font ui_Text = new Font("Applau", 12, FontStyle.Regular);
        Font player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);
        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m,Font f)
            {
                ItemColor = c;
                Message = m;
                Fontstyle = f;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
            public Font Fontstyle { get; set; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private   bool moves_already = true;
        private void imput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)13:
                    if (imput.Text != "")
                    {
                        string outInBox = Wörterscramble(imput.Text);

                        //listBox1.Items.Add(new MyListBoxItem(Color.DarkBlue, imput.Text, new Font("With My Woes", 12, FontStyle.Bold)));
                        listBox1.Items.Add(new MyListBoxItem(Color.DarkBlue, outInBox, player_Text_Handwritten));
                        listBox1.ItemHeight = 28;
                        listBox1.ItemHeight++;
                       // listBox1.Items.Add(new MyListBoxItem(Color.Red, ($"{listBox1.ItemHeight}"), new Font("ApplauseFon", 22, FontStyle.Bold)));
                        // listBox1.Items.Add(imput.Text);
                    
                        if (listBox1.Items.Count>10)
                        {
                            listBox1.Items.RemoveAt(0);
                            listBox1.Items.RemoveAt(1);

                        }
                        listBox1.TopIndex = listBox1.Items.Count - 1;

                    }
                    break;

                case 'm':
                    if (moves_already == false)
                    {
                        reaccurringActions += Movethings;
                        moves_already = true;
                    }
                    break;
                case 'r':
                    if (moves_already == true)
                    {
                        reaccurringActions -= Movethings;
                        moves_already = false;
                    }
                    break;



            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = listBox1.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
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

        public void Movethings()
        {
            int i = btn_test.Location.X ;
            i++;
            btn_test.Location = new Point(i, btn_test.Location.Y);
            if (btn_test.Location.X >=600)
            {
                btn_test.Location = new Point(600,btn_test.Location.Y);
                
            }
            

        }
  

        public string Wörterscramble(string playerimput)
        {
            Random random = new Random();
            int scramble = random.Next(0, 8);
            scramble = 0;
            switch(scramble)
            {
                case 0:
                   playerimput = playerimput.Replace('b', 'd');

                   playerimput = playerimput.Replace('m', 'n');
                    playerimput = playerimput.Replace('z', 'c');
      
                break;
            }

            return playerimput;
        }


        public void Updating()
        {
            reaccurringActions += Movethings;
            Timer trytimer = new Timer();
            trytimer.Interval = 1;
            trytimer.Tick += new EventHandler(myUpdatingTry);
            trytimer.Start();
        }

        private void myUpdatingTry(object sender, EventArgs e)
        {
            reaccurringActions?.Invoke();
            maskedTextBox1.Text = btn_test.Location.ToString();
        }



    }
}
