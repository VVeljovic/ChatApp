using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Chat
{
   public static class Utils
    {
        public static int GetTextHeight(Control control)
        {
            if (control is Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneLabel)
            {
                using (Graphics g = control.CreateGraphics())
                {
                    SizeF size = g.MeasureString(siticoneLabel.Text, siticoneLabel.Font, 495);
                    return (int)Math.Ceiling(size.Height);
                }
            }
            else
            {
                
                return -1;
            }
        }
    }
}
