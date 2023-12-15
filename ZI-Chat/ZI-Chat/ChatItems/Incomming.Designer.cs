
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
            this.siticoneImageButton2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.controler = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.controler.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTaskBarProgress1
            // 
            this.siticoneTaskBarProgress1.TargetForm = null;
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton2.Image")));
            this.siticoneImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton2.ImageRotate = 0F;
            this.siticoneImageButton2.Location = new System.Drawing.Point(3, 7);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Size = new System.Drawing.Size(61, 56);
            this.siticoneImageButton2.TabIndex = 6;
            // 
            // controler
            // 
            this.controler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controler.BackColor = System.Drawing.Color.White;
            this.controler.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.controler.BorderRadius = 30;
            this.controler.Controls.Add(this.label1);
            this.controler.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.controler.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.controler.Location = new System.Drawing.Point(70, 3);
            this.controler.Name = "controler";
            this.controler.Size = new System.Drawing.Size(364, 91);
            this.controler.TabIndex = 7;
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
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello world";
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.controler);
            this.Controls.Add(this.siticoneImageButton2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(437, 97);
            this.controler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress siticoneTaskBarProgress1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel controler;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label1;
    }
}
