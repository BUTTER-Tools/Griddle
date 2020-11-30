namespace Griddle
{
    partial class GriddleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GriddleForm));
            this.griddleImageBox = new System.Windows.Forms.PictureBox();
            this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
            this.LaunchButterButton = new System.Windows.Forms.Button();
            this.LaunchBlueberriesButton = new System.Windows.Forms.Button();
            this.ProgramDetailsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.griddleImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // griddleImageBox
            // 
            this.griddleImageBox.Image = global::Griddle.Properties.Resources.butter_icon;
            this.griddleImageBox.InitialImage = global::Griddle.Properties.Resources.griddle;
            this.griddleImageBox.Location = new System.Drawing.Point(40, 3);
            this.griddleImageBox.Name = "griddleImageBox";
            this.griddleImageBox.Size = new System.Drawing.Size(212, 161);
            this.griddleImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.griddleImageBox.TabIndex = 0;
            this.griddleImageBox.TabStop = false;
            // 
            // buttonImageList
            // 
            this.buttonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImageList.ImageStream")));
            this.buttonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImageList.Images.SetKeyName(0, "blueberries.png");
            this.buttonImageList.Images.SetKeyName(1, "butter_icon.png");
            // 
            // LaunchButterButton
            // 
            this.LaunchButterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButterButton.ImageIndex = 1;
            this.LaunchButterButton.ImageList = this.buttonImageList;
            this.LaunchButterButton.Location = new System.Drawing.Point(328, 47);
            this.LaunchButterButton.Name = "LaunchButterButton";
            this.LaunchButterButton.Size = new System.Drawing.Size(193, 69);
            this.LaunchButterButton.TabIndex = 1;
            this.LaunchButterButton.Text = "   Launch BUTTER";
            this.LaunchButterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchButterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LaunchButterButton.UseVisualStyleBackColor = true;
            this.LaunchButterButton.Click += new System.EventHandler(this.LaunchButterButton_Click);
            // 
            // LaunchBlueberriesButton
            // 
            this.LaunchBlueberriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchBlueberriesButton.ImageIndex = 0;
            this.LaunchBlueberriesButton.ImageList = this.buttonImageList;
            this.LaunchBlueberriesButton.Location = new System.Drawing.Point(328, 129);
            this.LaunchBlueberriesButton.Name = "LaunchBlueberriesButton";
            this.LaunchBlueberriesButton.Size = new System.Drawing.Size(193, 69);
            this.LaunchBlueberriesButton.TabIndex = 2;
            this.LaunchBlueberriesButton.Text = "   Update Plugins";
            this.LaunchBlueberriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchBlueberriesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LaunchBlueberriesButton.UseVisualStyleBackColor = true;
            this.LaunchBlueberriesButton.Click += new System.EventHandler(this.LaunchBlueberriesButton_Click);
            // 
            // ProgramDetailsLabel
            // 
            this.ProgramDetailsLabel.AutoSize = true;
            this.ProgramDetailsLabel.Location = new System.Drawing.Point(10, 152);
            this.ProgramDetailsLabel.Name = "ProgramDetailsLabel";
            this.ProgramDetailsLabel.Size = new System.Drawing.Size(273, 52);
            this.ProgramDetailsLabel.TabIndex = 3;
            this.ProgramDetailsLabel.Text = "Basic Unit-Transposable Text Experimentation Resource\r\nVersion x.x.x.x\r\n(c) 2019-" +
    "present\r\nRyan L. Boyd, Ph.D.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProgramDetailsLabel);
            this.panel1.Controls.Add(this.griddleImageBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 221);
            this.panel1.TabIndex = 4;
            // 
            // GriddleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 245);
            this.Controls.Add(this.LaunchBlueberriesButton);
            this.Controls.Add(this.LaunchButterButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GriddleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Griddle: The BUTTER Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.griddleImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox griddleImageBox;
        private System.Windows.Forms.ImageList buttonImageList;
        private System.Windows.Forms.Button LaunchButterButton;
        private System.Windows.Forms.Button LaunchBlueberriesButton;
        private System.Windows.Forms.Label ProgramDetailsLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

