
namespace WindowsFormsApp1
{
    partial class Authenticator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authenticator));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.title1 = new System.Windows.Forms.Label();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.enterkeyLabel = new System.Windows.Forms.Label();
            this.submitKey = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(150, 150);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(168, 12);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(299, 45);
            this.title1.TabIndex = 1;
            this.title1.Text = "Checking whitelist...";
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("loadingAnimation.Image")));
            this.loadingAnimation.Location = new System.Drawing.Point(618, 136);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(150, 150);
            this.loadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingAnimation.TabIndex = 2;
            this.loadingAnimation.TabStop = false;
            // 
            // keyInput
            // 
            this.keyInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput.ForeColor = System.Drawing.Color.White;
            this.keyInput.Location = new System.Drawing.Point(12, 264);
            this.keyInput.MaxLength = 16;
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(346, 22);
            this.keyInput.TabIndex = 3;
            this.keyInput.Text = "Enter key here";
            this.keyInput.Visible = false;
            // 
            // enterkeyLabel
            // 
            this.enterkeyLabel.AutoSize = true;
            this.enterkeyLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterkeyLabel.ForeColor = System.Drawing.Color.White;
            this.enterkeyLabel.Location = new System.Drawing.Point(4, 216);
            this.enterkeyLabel.Name = "enterkeyLabel";
            this.enterkeyLabel.Size = new System.Drawing.Size(78, 45);
            this.enterkeyLabel.TabIndex = 4;
            this.enterkeyLabel.Text = "Key:";
            this.enterkeyLabel.Visible = false;
            // 
            // submitKey
            // 
            this.submitKey.BackColor = System.Drawing.Color.Transparent;
            this.submitKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitKey.BackgroundImage")));
            this.submitKey.ButtonText = "Submit";
            this.submitKey.ButtonTextMarginLeft = 0;
            this.submitKey.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.submitKey.DisabledFillColor = System.Drawing.Color.Gray;
            this.submitKey.DisabledForecolor = System.Drawing.Color.White;
            this.submitKey.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitKey.ForeColor = System.Drawing.Color.White;
            this.submitKey.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.submitKey.IconPadding = 10;
            this.submitKey.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.submitKey.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.submitKey.IdleBorderRadius = 1;
            this.submitKey.IdleBorderThickness = 0;
            this.submitKey.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.submitKey.IdleIconLeftImage = null;
            this.submitKey.IdleIconRightImage = null;
            this.submitKey.Location = new System.Drawing.Point(367, 264);
            this.submitKey.Name = "submitKey";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.submitKey.onHoverState = stateProperties1;
            this.submitKey.Size = new System.Drawing.Size(100, 22);
            this.submitKey.TabIndex = 5;
            this.submitKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitKey.Visible = false;
            this.submitKey.Click += new System.EventHandler(this.submitKey_Click);
            // 
            // Authenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(780, 298);
            this.Controls.Add(this.submitKey);
            this.Controls.Add(this.enterkeyLabel);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.loadingAnimation);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.logoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authenticator";
            this.Text = "SoundID - Authenticator";
            this.Load += new System.EventHandler(this.Authenticator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.PictureBox loadingAnimation;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label enterkeyLabel;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton submitKey;
    }
}

