namespace Griddle
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(13, 480);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(176, 18);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "BUTTER (v0.0.0.0)";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(13, 516);
            this.CopyrightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(220, 13);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "© Ryan L. Boyd, Ph.D., 2019-present";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Interval = 4500;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullnameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.White;
            this.FullnameLabel.Location = new System.Drawing.Point(13, 500);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(324, 13);
            this.FullnameLabel.TabIndex = 3;
            this.FullnameLabel.Text = "Basic Unit-Transposable Text Experimentation Resource";
            this.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ArtistNameLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ArtistNameLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ArtistNameLabel.Location = new System.Drawing.Point(686, 521);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(109, 12);
            this.ArtistNameLabel.TabIndex = 5;
            this.ArtistNameLabel.Text = "Artwork: Allie Duyên";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::Griddle.Properties.Resources.AllieSplashArt_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.ControlBox = false;
            this.Controls.Add(this.ArtistNameLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.TitleLabel);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 536);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 536);
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label ArtistNameLabel;
    }
}