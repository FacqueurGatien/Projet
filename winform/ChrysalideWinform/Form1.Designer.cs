namespace ChrysalideWinform
{
    partial class Form1
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
            this.affichage = new System.Windows.Forms.PictureBox();
            this.evolution = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.renaitre = new System.Windows.Forms.Button();
            this.cry = new System.Windows.Forms.Button();
            this.labelCry = new System.Windows.Forms.Label();
            this.imageDeplacer = new System.Windows.Forms.PictureBox();
            this.deplacer = new System.Windows.Forms.Button();
            this.stopDeplace = new System.Windows.Forms.Button();
            this.deplacerLAbel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.affichage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDeplacer)).BeginInit();
            this.SuspendLayout();
            // 
            // affichage
            // 
            this.affichage.BackgroundImage = global::ChrysalideWinform.Properties.Resources.chenipan;
            this.affichage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.affichage.Location = new System.Drawing.Point(148, 12);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(413, 333);
            this.affichage.TabIndex = 0;
            this.affichage.TabStop = false;
            // 
            // evolution
            // 
            this.evolution.Location = new System.Drawing.Point(12, 12);
            this.evolution.Name = "evolution";
            this.evolution.Size = new System.Drawing.Size(130, 23);
            this.evolution.TabIndex = 1;
            this.evolution.Text = "Evolution";
            this.evolution.UseVisualStyleBackColor = true;
            this.evolution.Click += new System.EventHandler(this.evolution_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(12, 325);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(130, 23);
            this.quit.TabIndex = 2;
            this.quit.Text = "Quiter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // renaitre
            // 
            this.renaitre.Location = new System.Drawing.Point(12, 154);
            this.renaitre.Name = "renaitre";
            this.renaitre.Size = new System.Drawing.Size(130, 23);
            this.renaitre.TabIndex = 3;
            this.renaitre.Text = "Refaire un oeuf";
            this.renaitre.UseVisualStyleBackColor = true;
            this.renaitre.Click += new System.EventHandler(this.button1_Click);
            // 
            // cry
            // 
            this.cry.Location = new System.Drawing.Point(12, 75);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(130, 23);
            this.cry.TabIndex = 4;
            this.cry.Text = "Crier";
            this.cry.UseVisualStyleBackColor = true;
            this.cry.Click += new System.EventHandler(this.cry_Click);
            // 
            // labelCry
            // 
            this.labelCry.AutoSize = true;
            this.labelCry.Location = new System.Drawing.Point(155, 325);
            this.labelCry.Name = "labelCry";
            this.labelCry.Size = new System.Drawing.Size(0, 15);
            this.labelCry.TabIndex = 5;
            // 
            // imageDeplacer
            // 
            this.imageDeplacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageDeplacer.Image = global::ChrysalideWinform.Properties.Resources.ChenipanRampe;
            this.imageDeplacer.Location = new System.Drawing.Point(148, 12);
            this.imageDeplacer.Name = "imageDeplacer";
            this.imageDeplacer.Size = new System.Drawing.Size(413, 333);
            this.imageDeplacer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDeplacer.TabIndex = 6;
            this.imageDeplacer.TabStop = false;
            this.imageDeplacer.Visible = false;
            // 
            // deplacer
            // 
            this.deplacer.Location = new System.Drawing.Point(12, 231);
            this.deplacer.Name = "deplacer";
            this.deplacer.Size = new System.Drawing.Size(130, 23);
            this.deplacer.TabIndex = 7;
            this.deplacer.Text = "Demo deplacement";
            this.deplacer.UseVisualStyleBackColor = true;
            this.deplacer.Click += new System.EventHandler(this.deplacer_Click);
            // 
            // stopDeplace
            // 
            this.stopDeplace.Enabled = false;
            this.stopDeplace.Location = new System.Drawing.Point(12, 260);
            this.stopDeplace.Name = "stopDeplace";
            this.stopDeplace.Size = new System.Drawing.Size(130, 23);
            this.stopDeplace.TabIndex = 8;
            this.stopDeplace.Text = "Stop deplacement";
            this.stopDeplace.UseVisualStyleBackColor = true;
            this.stopDeplace.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deplacerLAbel
            // 
            this.deplacerLAbel.AutoSize = true;
            this.deplacerLAbel.Location = new System.Drawing.Point(12, 213);
            this.deplacerLAbel.Name = "deplacerLAbel";
            this.deplacerLAbel.Size = new System.Drawing.Size(0, 15);
            this.deplacerLAbel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 375);
            this.Controls.Add(this.deplacerLAbel);
            this.Controls.Add(this.stopDeplace);
            this.Controls.Add(this.deplacer);
            this.Controls.Add(this.imageDeplacer);
            this.Controls.Add(this.labelCry);
            this.Controls.Add(this.cry);
            this.Controls.Add(this.renaitre);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.evolution);
            this.Controls.Add(this.affichage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.affichage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDeplacer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox affichage;
        private Button evolution;
        private Button quit;
        private Button renaitre;
        private Button cry;
        private Label labelCry;
        private PictureBox imageDeplacer;
        private Button deplacer;
        private Button stopDeplace;
        private Label deplacerLAbel;
    }
}