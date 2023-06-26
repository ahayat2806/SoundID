
namespace SoundID
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.title1 = new System.Windows.Forms.Label();
            this.signOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.file1button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.file1name = new System.Windows.Forms.Label();
            this.file2name = new System.Windows.Forms.Label();
            this.file2button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.analyseButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exportData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.progressBar = new Bunifu.UI.Winforms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("loadingAnimation.Image")));
            this.loadingAnimation.Location = new System.Drawing.Point(688, 9);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(100, 100);
            this.loadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingAnimation.TabIndex = 5;
            this.loadingAnimation.TabStop = false;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(4, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(244, 45);
            this.title1.TabIndex = 6;
            this.title1.Text = "SoundID - Main";
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
            this.signOut.IdleBorderColor = System.Drawing.Color.OrangeRed;
            this.signOut.IdleBorderRadius = 1;
            this.signOut.IdleBorderThickness = 0;
            this.signOut.IdleFillColor = System.Drawing.Color.Tomato;
            this.signOut.IdleIconLeftImage = null;
            this.signOut.IdleIconRightImage = null;
            this.signOut.Location = new System.Drawing.Point(688, 408);
            this.signOut.Name = "signOut";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.signOut.onHoverState = stateProperties1;
            this.signOut.Size = new System.Drawing.Size(100, 30);
            this.signOut.TabIndex = 7;
            this.signOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // file1button
            // 
            this.file1button.BackColor = System.Drawing.Color.Transparent;
            this.file1button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("file1button.BackgroundImage")));
            this.file1button.ButtonText = "Select File";
            this.file1button.ButtonTextMarginLeft = 0;
            this.file1button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.file1button.DisabledFillColor = System.Drawing.Color.Gray;
            this.file1button.DisabledForecolor = System.Drawing.Color.White;
            this.file1button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1button.ForeColor = System.Drawing.Color.White;
            this.file1button.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.file1button.IconPadding = 10;
            this.file1button.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.file1button.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.file1button.IdleBorderRadius = 1;
            this.file1button.IdleBorderThickness = 0;
            this.file1button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.file1button.IdleIconLeftImage = null;
            this.file1button.IdleIconRightImage = null;
            this.file1button.Location = new System.Drawing.Point(12, 57);
            this.file1button.Name = "file1button";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.file1button.onHoverState = stateProperties2;
            this.file1button.Size = new System.Drawing.Size(100, 30);
            this.file1button.TabIndex = 9;
            this.file1button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.file1button.Click += new System.EventHandler(this.file1_Click);
            // 
            // file1name
            // 
            this.file1name.AutoSize = true;
            this.file1name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1name.ForeColor = System.Drawing.Color.White;
            this.file1name.Location = new System.Drawing.Point(112, 57);
            this.file1name.Name = "file1name";
            this.file1name.Size = new System.Drawing.Size(169, 30);
            this.file1name.TabIndex = 10;
            this.file1name.Text = "(No file selected)";
            // 
            // file2name
            // 
            this.file2name.AutoSize = true;
            this.file2name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2name.ForeColor = System.Drawing.Color.White;
            this.file2name.Location = new System.Drawing.Point(112, 93);
            this.file2name.Name = "file2name";
            this.file2name.Size = new System.Drawing.Size(169, 30);
            this.file2name.TabIndex = 12;
            this.file2name.Text = "(No file selected)";
            // 
            // file2button
            // 
            this.file2button.BackColor = System.Drawing.Color.Transparent;
            this.file2button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("file2button.BackgroundImage")));
            this.file2button.ButtonText = "Select File";
            this.file2button.ButtonTextMarginLeft = 0;
            this.file2button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.file2button.DisabledFillColor = System.Drawing.Color.Gray;
            this.file2button.DisabledForecolor = System.Drawing.Color.White;
            this.file2button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2button.ForeColor = System.Drawing.Color.White;
            this.file2button.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.file2button.IconPadding = 10;
            this.file2button.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.file2button.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.file2button.IdleBorderRadius = 1;
            this.file2button.IdleBorderThickness = 0;
            this.file2button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.file2button.IdleIconLeftImage = null;
            this.file2button.IdleIconRightImage = null;
            this.file2button.Location = new System.Drawing.Point(12, 93);
            this.file2button.Name = "file2button";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.file2button.onHoverState = stateProperties3;
            this.file2button.Size = new System.Drawing.Size(100, 30);
            this.file2button.TabIndex = 11;
            this.file2button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.file2button.Click += new System.EventHandler(this.file2button_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(12, 239);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(670, 199);
            this.outputBox.TabIndex = 13;
            this.outputBox.Text = "SoundID Output will appear here.\n\nClick Export to save the output to a text file " +
    "which\nwill be stored in \'exports\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Output:";
            // 
            // elipse1
            // 
            this.elipse1.ElipseRadius = 15;
            this.elipse1.TargetControl = this.outputBox;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Sound";
            this.openFileDialog1.Filter = "WAV Files|*.wav|MP3 Files|*.mp3";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.ButtonText = "Close";
            this.close.ButtonTextMarginLeft = 0;
            this.close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.close.DisabledFillColor = System.Drawing.Color.Gray;
            this.close.DisabledForecolor = System.Drawing.Color.White;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.close.IconPadding = 10;
            this.close.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.close.IdleBorderColor = System.Drawing.Color.OrangeRed;
            this.close.IdleBorderRadius = 1;
            this.close.IdleBorderThickness = 0;
            this.close.IdleFillColor = System.Drawing.Color.Tomato;
            this.close.IdleIconLeftImage = null;
            this.close.IdleIconRightImage = null;
            this.close.Location = new System.Drawing.Point(688, 372);
            this.close.Name = "close";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.close.onHoverState = stateProperties4;
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 15;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // analyseButton
            // 
            this.analyseButton.BackColor = System.Drawing.Color.Transparent;
            this.analyseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("analyseButton.BackgroundImage")));
            this.analyseButton.ButtonText = "Analyse";
            this.analyseButton.ButtonTextMarginLeft = 0;
            this.analyseButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.analyseButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.analyseButton.DisabledForecolor = System.Drawing.Color.White;
            this.analyseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyseButton.ForeColor = System.Drawing.Color.White;
            this.analyseButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.analyseButton.IconPadding = 10;
            this.analyseButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.analyseButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.analyseButton.IdleBorderRadius = 1;
            this.analyseButton.IdleBorderThickness = 0;
            this.analyseButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.analyseButton.IdleIconLeftImage = null;
            this.analyseButton.IdleIconRightImage = null;
            this.analyseButton.Location = new System.Drawing.Point(12, 129);
            this.analyseButton.Name = "analyseButton";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.analyseButton.onHoverState = stateProperties5;
            this.analyseButton.Size = new System.Drawing.Size(269, 30);
            this.analyseButton.TabIndex = 16;
            this.analyseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.analyseButton.Click += new System.EventHandler(this.analyseButton_Click);
            // 
            // exportData
            // 
            this.exportData.BackColor = System.Drawing.Color.Transparent;
            this.exportData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportData.BackgroundImage")));
            this.exportData.ButtonText = "Export";
            this.exportData.ButtonTextMarginLeft = 0;
            this.exportData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.exportData.DisabledFillColor = System.Drawing.Color.Gray;
            this.exportData.DisabledForecolor = System.Drawing.Color.White;
            this.exportData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exportData.IconPadding = 10;
            this.exportData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exportData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.exportData.IdleBorderRadius = 1;
            this.exportData.IdleBorderThickness = 0;
            this.exportData.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.exportData.IdleIconLeftImage = null;
            this.exportData.IdleIconRightImage = null;
            this.exportData.Location = new System.Drawing.Point(688, 336);
            this.exportData.Name = "exportData";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.exportData.onHoverState = stateProperties6;
            this.exportData.Size = new System.Drawing.Size(100, 30);
            this.exportData.TabIndex = 18;
            this.exportData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Animation = 0;
            this.progressBar.AnimationStep = 10;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.progressBar.BorderRadius = 5;
            this.progressBar.BorderThickness = 2;
            this.progressBar.Location = new System.Drawing.Point(97, 223);
            this.progressBar.MaximumValue = 100;
            this.progressBar.MinimumValue = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.progressBar.ProgressColorLeft = System.Drawing.Color.DarkGreen;
            this.progressBar.ProgressColorRight = System.Drawing.Color.Lime;
            this.progressBar.Size = new System.Drawing.Size(585, 10);
            this.progressBar.TabIndex = 19;
            this.progressBar.Value = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.exportData);
            this.Controls.Add(this.analyseButton);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.file2name);
            this.Controls.Add(this.file2button);
            this.Controls.Add(this.file1name);
            this.Controls.Add(this.file1button);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.loadingAnimation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundID - Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingAnimation;
        private System.Windows.Forms.Label title1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton signOut;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton file1button;
        private System.Windows.Forms.Label file1name;
        private System.Windows.Forms.Label file2name;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton file2button;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse elipse1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton close;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton analyseButton;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton exportData;
        public Bunifu.UI.Winforms.BunifuProgressBar progressBar;
    }
}