using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class CheckWord
    {
        public string Content { get; private set; }
        public Point Location { get; private set; }

        public CheckWord(string c,Point l)
        {
            Content = c;
            Location = l;
        }

        public int  WordCheck(Point lbl_location)
        {
            if(lbl_location.Y <= Location.Y+10 && lbl_location.Y >= Location.Y - 10)
            {
                return 1;
            }

            return 0;
        }


    }
}
