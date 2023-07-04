namespace AdittionneurWinform
{
    partial class Additionneur
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
            this.afficheur = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afficheur
            // 
            this.afficheur.BackColor = System.Drawing.Color.White;
            this.afficheur.Location = new System.Drawing.Point(12, 12);
            this.afficheur.Name = "afficheur";
            this.afficheur.ReadOnly = true;
            this.afficheur.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.afficheur.Size = new System.Drawing.Size(304, 116);
            this.afficheur.TabIndex = 13;
            this.afficheur.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 52);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(74, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 52);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(136, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 52);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(198, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 52);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Nb_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(260, 205);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 52);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Nb_Click);
            // 
            // vider
            // 
            this.vider.Enabled = false;
            this.vider.Location = new System.Drawing.Point(12, 285);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(118, 31);
            this.vider.TabIndex = 11;
            this.vider.Text = "Vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // calculer
            // 
            this.calculer.Enabled = false;
            this.calculer.Location = new System.Drawing.Point(198, 285);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(118, 31);
            this.calculer.TabIndex = 12;
            this.calculer.Text = "Calculer";
            this.calculer.UseVisualStyleBackColor = true;
            this.calculer.Click += new System.EventHandler(this.Calculer_Click);
            // 
            // Additionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.calculer);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.afficheur);
            this.Name = "Additionneur";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox afficheur;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button vider;
        private Button calculer;
    }
}