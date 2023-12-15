using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Chat.ChatItems
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

       public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text=value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            label1.AutoSizeHeightOnly = true;
            siticoneImageButton2.Location = new Point(4, 3);
            label1.Height =  Utils.GetTextHeight(label1)+50;
            controler.Height =  (controler.Top + label1.Height + label1.Top)+50;
            this.Height = controler.Bottom + 10;

        }
        public Image Avatar { get; set; }
        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        
    }
}
