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
    public partial class Outgoing : UserControl
    {
        public Outgoing()
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
            label1.Height =50+ Utils.GetTextHeight(label1);
            siticoneCustomGradientPanel1.Height = (siticoneCustomGradientPanel1.Top + label1.Height + label1.Top) +50;
            this.Height = siticoneCustomGradientPanel1.Bottom + 10;

        }
        public Image Avatar { get; set; }
        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
