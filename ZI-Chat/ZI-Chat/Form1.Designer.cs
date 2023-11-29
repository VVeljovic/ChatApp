
namespace ZI_Chat
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneImageButton2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnClose = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.txtMessage = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.switchOption = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.switchOption);
            this.panel1.Controls.Add(this.siticoneImageButton2);
            this.panel1.Controls.Add(this.siticoneHtmlLabel2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 100);
            this.panel1.TabIndex = 0;
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton2.Image")));
            this.siticoneImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton2.ImageRotate = 0F;
            this.siticoneImageButton2.Location = new System.Drawing.Point(3, 3);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Size = new System.Drawing.Size(61, 59);
            this.siticoneImageButton2.TabIndex = 5;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(12, 66);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(50, 23);
            this.siticoneHtmlLabel2.TabIndex = 4;
            this.siticoneHtmlLabel2.Text = "Online";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(280, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(27, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.siticoneSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 76);
            this.panel2.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSend.ImageRotate = 0F;
            this.btnSend.Location = new System.Drawing.Point(250, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.Size = new System.Drawing.Size(69, 73);
            this.btnSend.TabIndex = 2;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderThickness = 2;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(3, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "Enter message";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(244, 73);
            this.txtMessage.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtMessage.TabIndex = 1;
          
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator1.FillThickness = 2;
            this.siticoneSeparator1.Location = new System.Drawing.Point(0, 0);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(319, 10);
            this.siticoneSeparator1.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(319, 274);
            this.pnlContainer.TabIndex = 2;
            // 
            // switchOption
            // 
            this.switchOption.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchOption.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchOption.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchOption.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchOption.Location = new System.Drawing.Point(70, 69);
            this.switchOption.Name = "switchOption";
            this.switchOption.Size = new System.Drawing.Size(35, 20);
            this.switchOption.TabIndex = 6;
            this.switchOption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchOption.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchOption.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchOption.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnClose;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private System.Windows.Forms.Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.Panel pnlContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnSend;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch switchOption;
    }
}

