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
            if(lbl_location.Y >= 50 && lbl_location.Y <= 54)
            {
                return 0;
            }
            
            else if(lbl_location.Y >= 42 && lbl_location.Y <= 62)
            {
                return 3;
            }
            else if (lbl_location.Y >= 32 && lbl_location.Y <= 72)
            {
                return 6;
            }
            else if (lbl_location.Y >= 22 && lbl_location.Y <= 82)
            {
                return 10;
            }

            else if (lbl_location.Y >= 0 && lbl_location.Y <= 104)
            {
                return 20;
            }

            return 10;
        }


    }
}
