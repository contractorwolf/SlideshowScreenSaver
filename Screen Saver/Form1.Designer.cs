namespace Screen_Saver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerImageFlip = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.addRegButton = new System.Windows.Forms.Button();
            this.removeRegButton = new System.Windows.Forms.Button();
            this.labelLastDownloaded = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // timerImageFlip
            // 
            this.timerImageFlip.Interval = 5000;
            this.timerImageFlip.Tick += new System.EventHandler(this.timerImageFlip_Tick);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(61, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(41, 21);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueButton.Location = new System.Drawing.Point(0, 459);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(60, 21);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // addRegButton
            // 
            this.addRegButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addRegButton.Location = new System.Drawing.Point(524, 459);
            this.addRegButton.Name = "addRegButton";
            this.addRegButton.Size = new System.Drawing.Size(58, 21);
            this.addRegButton.TabIndex = 6;
            this.addRegButton.Text = "AddReg";
            this.addRegButton.UseVisualStyleBackColor = true;
            this.addRegButton.Click += new System.EventHandler(this.addRegButton_Click);
            // 
            // removeRegButton
            // 
            this.removeRegButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeRegButton.Location = new System.Drawing.Point(582, 459);
            this.removeRegButton.Name = "removeRegButton";
            this.removeRegButton.Size = new System.Drawing.Size(58, 21);
            this.removeRegButton.TabIndex = 7;
            this.removeRegButton.Text = "XReg";
            this.removeRegButton.UseVisualStyleBackColor = true;
            this.removeRegButton.Click += new System.EventHandler(this.removeRegButton_Click);
            // 
            // labelLastDownloaded
            // 
            this.labelLastDownloaded.AutoSize = true;
            this.labelLastDownloaded.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLastDownloaded.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastDownloaded.ForeColor = System.Drawing.Color.White;
            this.labelLastDownloaded.Location = new System.Drawing.Point(12, 26);
            this.labelLastDownloaded.Name = "labelLastDownloaded";
            this.labelLastDownloaded.Size = new System.Drawing.Size(0, 13);
            this.labelLastDownloaded.TabIndex = 8;
            // 
            // version
            // 
            this.version.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(118, 458);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(68, 13);
            this.version.TabIndex = 9;
            this.version.Text = "version: 2.05";
            // 
            // timerStart
            // 
            this.timerStart.Enabled = true;
            this.timerStart.Interval = 60000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.version);
            this.Controls.Add(this.labelLastDownloaded);
            this.Controls.Add(this.removeRegButton);
            this.Controls.Add(this.addRegButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerImageFlip;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button addRegButton;
        private System.Windows.Forms.Button removeRegButton;
        private System.Windows.Forms.Label labelLastDownloaded;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Timer timerStart;

    }
}

