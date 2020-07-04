using System;
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

        public FRM_Level_1()
        {
            InitializeComponent();

            lBx_MainWindow.Items.Add((new MyListBoxItem(Color.DarkSeaGreen, "Du sollst Die Vokabeln mitschreiben", ui_Text)));
            
            u.Updating();
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
 
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
                        lBx_MainWindow.Items.Add(new MyListBoxItem(Color.DarkBlue, outInBox, player_Text_Handwritten));
                        lBx_MainWindow.ItemHeight = 28;
                        //lBx_MainWindow.ItemHeight++;
                        // listBox1.Items.Add(new MyListBoxItem(Color.Red, ($"{listBox1.ItemHeight}"), new Font("ApplauseFon", 22, FontStyle.Bold)));
                        // listBox1.Items.Add(imput.Text);

                        if (lBx_MainWindow.Items.Count > 10)
                        {
                            lBx_MainWindow.Items.RemoveAt(0);
                            lBx_MainWindow.Items.RemoveAt(1);

                        }
                        lBx_MainWindow.TopIndex = lBx_MainWindow.Items.Count - 1;

                    }
                    break;

                 case 't':
                    u.updating -= Movethings;
                    HittingTest(btn_test.Location);
                    btn_test.Location = new Point(50, 50);
                    break;
                case 's':
                    u.updating += Movethings;
                    break;

            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = lBx_MainWindow.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
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
        public void Movethings()
        {
            int i = btn_test.Location.X;
            i++;
            btn_test.Location = new Point(i, btn_test.Location.Y);
            if (btn_test.Location.X >= 600)
            {
                btn_test.Location = new Point(600, btn_test.Location.Y);

            }


        }
        private int waitingtime;
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

        }

        
        public void HittingTest( Point point)

        {
            Wait(100);
            Point target = new Point(200,200);
            if (point.X == target.X) 
            {
                lBx_MainWindow.Items.Add(new MyListBoxItem(Color.Black, "Ya get 50 points", ui_Text));
            }
            if (point.X >= target.X + 10 && point.X <= target.X+25)
            {

                lBx_MainWindow.Items.Add(new MyListBoxItem(Color.Black, "Yes 20 points a little bit more left would be the jackpod", ui_Text));
            }
            if (point.X <= target.X  -10 && point.X <= target.X - 25)
            {

                lBx_MainWindow.Items.Add(new MyListBoxItem(Color.Black, "Yes 20 points", ui_Text));
            }
            if (point.X > target.X + 25 )
            {

                lBx_MainWindow.Items.Add(new MyListBoxItem(Color.Black, "Big OOff not right enough", ui_Text));
            }

            if (point.X < target.X - 25)
            {

                lBx_MainWindow.Items.Add(new MyListBoxItem(Color.Black, "Big OOff not left enough", ui_Text));
            }
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
