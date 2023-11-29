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
            }
        }

        public Image Avatar { get; set; }
        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
             
        }
    }
}
