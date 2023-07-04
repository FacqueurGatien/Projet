namespace FFColorPreviewAlternativeMVC
{
    partial class ColorPreviewAlternative
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
            this.groupBoxImg = new System.Windows.Forms.GroupBox();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.pictureBoxVert = new System.Windows.Forms.PictureBox();
            this.pictureBoxBleu = new System.Windows.Forms.PictureBox();
            this.pictureBoxRouge = new System.Windows.Forms.PictureBox();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.trackBarVert = new System.Windows.Forms.TrackBar();
            this.trackBarBleu = new System.Windows.Forms.TrackBar();
            this.trackBarRouge = new System.Windows.Forms.TrackBar();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.labelRouge = new System.Windows.Forms.Label();
            this.groupBoxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRouge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxImg
            // 
            this.groupBoxImg.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxImg.BackgroundImage = global::FFColorPreviewAlternativeMVC.Properties.Resources.okamiRun;
            this.groupBoxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxImg.Controls.Add(this.panelPreview);
            this.groupBoxImg.Location = new System.Drawing.Point(102, 217);
            this.groupBoxImg.Name = "groupBoxImg";
            this.groupBoxImg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxImg.Size = new System.Drawing.Size(257, 165);
            this.groupBoxImg.TabIndex = 34;
            this.groupBoxImg.TabStop = false;
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.Transparent;
            this.panelPreview.Location = new System.Drawing.Point(0, 0);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(257, 165);
            this.panelPreview.TabIndex = 16;
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.Location = new System.Drawing.Point(320, 155);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownAlpha.TabIndex = 33;
            this.numericUpDownAlpha.ValueChanged += new System.EventHandler(this.NumericUp_ValueChanged);
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(71, 157);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(243, 45);
            this.trackBarAlpha.TabIndex = 32;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(15, 163);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(38, 15);
            this.labelAlpha.TabIndex = 31;
            this.labelAlpha.Text = "Alpha";
            // 
            // pictureBoxVert
            // 
            this.pictureBoxVert.BackColor = System.Drawing.Color.Green;
            this.pictureBoxVert.Location = new System.Drawing.Point(413, 59);
            this.pictureBoxVert.Name = "pictureBoxVert";
            this.pictureBoxVert.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxVert.TabIndex = 30;
            this.pictureBoxVert.TabStop = false;
            // 
            // pictureBoxBleu
            // 
            this.pictureBoxBleu.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBleu.Location = new System.Drawing.Point(413, 108);
            this.pictureBoxBleu.Name = "pictureBoxBleu";
            this.pictureBoxBleu.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxBleu.TabIndex = 29;
            this.pictureBoxBleu.TabStop = false;
            // 
            // pictureBoxRouge
            // 
            this.pictureBoxRouge.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRouge.Location = new System.Drawing.Point(413, 9);
            this.pictureBoxRouge.Name = "pictureBoxRouge";
            this.pictureBoxRouge.Size = new System.Drawing.Size(70, 23);
            this.pictureBoxRouge.TabIndex = 28;
            this.pictureBoxRouge.TabStop = false;
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(320, 59);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownVert.TabIndex = 27;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.NumericUp_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(320, 108);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownBleu.TabIndex = 26;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.NumericUp_ValueChanged);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(320, 9);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(87, 23);
            this.numericUpDownRouge.TabIndex = 25;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.NumericUp_ValueChanged);
            // 
            // trackBarVert
            // 
            this.trackBarVert.Location = new System.Drawing.Point(71, 59);
            this.trackBarVert.Maximum = 255;
            this.trackBarVert.Name = "trackBarVert";
            this.trackBarVert.Size = new System.Drawing.Size(243, 45);
            this.trackBarVert.TabIndex = 24;
            this.trackBarVert.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarBleu
            // 
            this.trackBarBleu.Location = new System.Drawing.Point(71, 110);
            this.trackBarBleu.Maximum = 255;
            this.trackBarBleu.Name = "trackBarBleu";
            this.trackBarBleu.Size = new System.Drawing.Size(243, 45);
            this.trackBarBleu.TabIndex = 23;
            this.trackBarBleu.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarRouge
            // 
            this.trackBarRouge.Location = new System.Drawing.Point(71, 9);
            this.trackBarRouge.Maximum = 255;
            this.trackBarRouge.Name = "trackBarRouge";
            this.trackBarRouge.Size = new System.Drawing.Size(243, 45);
            this.trackBarRouge.TabIndex = 22;
            this.trackBarRouge.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(12, 59);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(27, 15);
            this.labelVert.TabIndex = 21;
            this.labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(12, 110);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(30, 15);
            this.labelBleu.TabIndex = 20;
            this.labelBleu.Text = "Bleu";
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(12, 9);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(41, 15);
            this.labelRouge.TabIndex = 19;
            this.labelRouge.Text = "Rouge";
            // 
            // ColorPreviewAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 396);
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
            this.Name = "ColorPreviewAlternative";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            this.groupBoxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRouge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxImg;
        private Panel panelPreview;
        private NumericUpDown numericUpDownAlpha;
        private TrackBar trackBarAlpha;
        private Label labelAlpha;
        private PictureBox pictureBoxVert;
        private PictureBox pictureBoxBleu;
        private PictureBox pictureBoxRouge;
        private NumericUpDown numericUpDownVert;
        private NumericUpDown numericUpDownBleu;
        private NumericUpDown numericUpDownRouge;
        private TrackBar trackBarVert;
        private TrackBar trackBarBleu;
        private TrackBar trackBarRouge;
        private Label labelVert;
        private Label labelBleu;
        private Label labelRouge;
    }
}