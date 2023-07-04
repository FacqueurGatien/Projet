namespace FFColorPreview
{
    partial class ColorPreview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.trackBarRouge = new System.Windows.Forms.TrackBar();
            this.trackBarBleu = new System.Windows.Forms.TrackBar();
            this.trackBarVert = new System.Windows.Forms.TrackBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxRouge = new System.Windows.Forms.PictureBox();
            this.pictureBoxBleu = new System.Windows.Forms.PictureBox();
            this.pictureBoxVert = new System.Windows.Forms.PictureBox();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.groupBoxImg = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            this.groupBoxImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(10, 12);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(41, 15);
            this.labelRouge.TabIndex = 0;
            this.labelRouge.Text = "Rouge";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(10, 113);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(30, 15);
            this.labelBleu.TabIndex = 1;
            this.labelBleu.Text = "Bleu";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(10, 62);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(27, 15);
            this.labelVert.TabIndex = 2;
            this.labelVert.Text = "Vert";
            // 
            // trackBarRouge
            // 
            this.trackBarRouge.Location = new System.Drawing.Point(69, 12);
            this.trackBarRouge.Maximum = 255;
            this.trackBarRouge.Name = "trackBarRouge";
            this.trackBarRouge.Size = new System.Drawing.Size(243, 45);
            this.trackBarRouge.TabIndex = 3;
            this.trackBarRouge.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarBleu
            // 
            this.trackBarBleu.Location = new System.Drawing.Point(69, 113);
            this.trackBarBleu.Maximum = 255;
            this.trackBarBleu.Name = "trackBarBleu";
            this.trackBarBleu.Size = new System.Drawing.Size(243, 45);
            this.trackBarBleu.TabIndex = 4;
            this.trackBarBleu.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarVert
            // 
            this.trackBarVert.Location = new System.Drawing.Point(69, 62);
            this.trackBarVert.Maximum = 255;
            this.trackBarVert.Name = "trackBarVert";
            this.trackBarVert.Size = new System.Drawing.Size(243, 45);
            this.trackBarVert.TabIndex = 5;
            this.trackBarVert.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(318, 12);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownRouge.TabIndex = 6;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(318, 111);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownBleu.TabIndex = 7;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(318, 62);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownVert.TabIndex = 8;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // pictureBoxRouge
            // 
            this.pictureBoxRouge.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRouge.Location = new System.Drawing.Point(411, 12);
            this.pictureBoxRouge.Name = "pictureBoxRouge";
            this.pictureBoxRouge.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxRouge.TabIndex = 9;
            this.pictureBoxRouge.TabStop = false;
            // 
            // pictureBoxBleu
            // 
            this.pictureBoxBleu.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBleu.Location = new System.Drawing.Point(411, 111);
            this.pictureBoxBleu.Name = "pictureBoxBleu";
            this.pictureBoxBleu.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxBleu.TabIndex = 10;
            this.pictureBoxBleu.TabStop = false;
            // 
            // pictureBoxVert
            // 
            this.pictureBoxVert.BackColor = System.Drawing.Color.Green;
            this.pictureBoxVert.Location = new System.Drawing.Point(411, 62);
            this.pictureBoxVert.Name = "pictureBoxVert";
            this.pictureBoxVert.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxVert.TabIndex = 11;
            this.pictureBoxVert.TabStop = false;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(13, 166);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(38, 15);
            this.labelAlpha.TabIndex = 13;
            this.labelAlpha.Text = "Alpha";
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(69, 160);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(243, 45);
            this.trackBarAlpha.TabIndex = 14;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.Location = new System.Drawing.Point(318, 158);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownAlpha.TabIndex = 15;
            this.numericUpDownAlpha.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.Transparent;
            this.panelPreview.Location = new System.Drawing.Point(0, 0);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(257, 165);
            this.panelPreview.TabIndex = 16;
            // 
            // groupBoxImg
            // 
            this.groupBoxImg.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxImg.BackgroundImage = global::FFColorPreview.Properties.Resources.okamibebe;
            this.groupBoxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxImg.Controls.Add(this.panelPreview);
            this.groupBoxImg.Location = new System.Drawing.Point(100, 220);
            this.groupBoxImg.Name = "groupBoxImg";
            this.groupBoxImg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxImg.Size = new System.Drawing.Size(257, 165);
            this.groupBoxImg.TabIndex = 18;
            this.groupBoxImg.TabStop = false;
            // 
            // ColorPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.groupBoxImg);
            this.Controls.Add(this.numericUpDownAlpha);
            this.Controls.Add(this.trackBarAlpha);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.pictureBoxVert);
            this.Controls.Add(this.pictureBoxBleu);
            this.Controls.Add(this.pictureBoxRouge);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.trackBarVert);
            this.Controls.Add(this.trackBarBleu);
            this.Controls.Add(this.trackBarRouge);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.labelRouge);
            this.Name = "ColorPreview";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            this.groupBoxImg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRouge;
        private Label labelBleu;
        private Label labelVert;
        private TrackBar trackBarRouge;
        private TrackBar trackBarBleu;
        private TrackBar trackBarVert;
        private NumericUpDown numericUpDownRouge;
        private NumericUpDown numericUpDownBleu;
        private NumericUpDown numericUpDownVert;
        private PictureBox pictureBoxRouge;
        private PictureBox pictureBoxBleu;
        private PictureBox pictureBoxVert;
        private Label labelAlpha;
        private TrackBar trackBarAlpha;
        private NumericUpDown numericUpDownAlpha;
        private Panel panelPreview;
        private GroupBox groupBoxImg;
    }
}