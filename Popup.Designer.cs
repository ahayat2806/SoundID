
namespace WindowsFormsApp1
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.title = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.button1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.button2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.signOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(65, 21);
            this.title.TabIndex = 0;
            this.title.Text = "TitleText";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(12, 116);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(152, 32);
            this.message.TabIndex = 1;
            this.message.Text = "MessageText";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "button 1";
            this.button1.ButtonTextMarginLeft = 0;
            this.button1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.button1.DisabledFillColor = System.Drawing.Color.Gray;
            this.button1.DisabledForecolor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IconPadding = 10;
            this.button1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button1.IdleBorderRadius = 1;
            this.button1.IdleBorderThickness = 0;
            this.button1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button1.IdleIconLeftImage = null;
            this.button1.IdleIconRightImage = null;
            this.button1.Location = new System.Drawing.Point(565, 222);
            this.button1.Name = "button1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.button1.onHoverState = stateProperties1;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ButtonText = "button 2";
            this.button2.ButtonTextMarginLeft = 0;
            this.button2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.button2.DisabledFillColor = System.Drawing.Color.Gray;
            this.button2.DisabledForecolor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button2.IconPadding = 10;
            this.button2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button2.IdleBorderRadius = 1;
            this.button2.IdleBorderThickness = 0;
            this.button2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button2.IdleIconLeftImage = null;
            this.button2.IdleIconRightImage = null;
            this.button2.Location = new System.Drawing.Point(459, 222);
            this.button2.Name = "button2";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.button2.onHoverState = stateProperties2;
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("loadingAnimation.Image")));
            this.loadingAnimation.Location = new System.Drawing.Point(615, 12);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(50, 50);
            this.loadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingAnimation.TabIndex = 4;
            this.loadingAnimation.TabStop = false;
            // 
            // signOut
            // 
            this.signOut.BackColor = System.Drawing.Color.Transparent;
            this.signOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOut.BackgroundImage")));
            this.signOut.ButtonText = "Sign Out";
            this.signOut.ButtonTextMarginLeft = 0;
            this.signOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.signOut.DisabledFillColor = System.Drawing.Color.Gray;
            this.signOut.DisabledForecolor = System.Drawing.Color.White;
            this.signOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.ForeColor = System.Drawing.Color.White;
            this.signOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.signOut.IconPadding = 10;
            this.signOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.signOut.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.signOut.IdleBorderRadius = 1;
            this.signOut.IdleBorderThickness = 0;
            this.signOut.IdleFillColor = System.Drawing.Color.Tomato;
            this.signOut.IdleIconLeftImage = null;
            this.signOut.IdleIconRightImage = null;
            this.signOut.Location = new System.Drawing.Point(565, 222);
            this.signOut.Name = "signOut";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.signOut.onHoverState = stateProperties3;
            this.signOut.Size = new System.Drawing.Size(100, 30);
            this.signOut.TabIndex = 5;
            this.signOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signOut.Visible = false;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(677, 264);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.loadingAnimation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label message;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton button1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton button2;
        private System.Windows.Forms.PictureBox loadingAnimation;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton signOut;
    }
}