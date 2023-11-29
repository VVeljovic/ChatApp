
namespace ZI_Chat.ChatItems
{
    partial class Incomming
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomming));
            this.siticoneTaskBarProgress1 = new Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress(this.components);
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneImageButton2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTaskBarProgress1
            // 
            this.siticoneTaskBarProgress1.TargetForm = null;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.siticoneCustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.siticoneCustomGradientPanel1.BorderRadius = 30;
            this.siticoneCustomGradientPanel1.Controls.Add(this.label1);
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(95, 7);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(336, 59);
            this.siticoneCustomGradientPanel1.TabIndex = 2;
            this.siticoneCustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCustomGradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello world";
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton2.Image")));
            this.siticoneImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton2.ImageRotate = 0F;
            this.siticoneImageButton2.Location = new System.Drawing.Point(17, 7);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Size = new System.Drawing.Size(61, 56);
            this.siticoneImageButton2.TabIndex = 6;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneImageButton2);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(437, 79);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress siticoneTaskBarProgress1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label1;
    }
}
