namespace BBSaisieUtilisateurWinform
{
    partial class ValidationForm
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
            this.lNom = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lMontant = new System.Windows.Forms.Label();
            this.lCodePostal = new System.Windows.Forms.Label();
            this.bValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(33, 25);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(43, 15);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom : ";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(33, 65);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(40, 15);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Date : ";
            // 
            // lMontant
            // 
            this.lMontant.AutoSize = true;
            this.lMontant.Location = new System.Drawing.Point(33, 104);
            this.lMontant.Name = "lMontant";
            this.lMontant.Size = new System.Drawing.Size(62, 15);
            this.lMontant.TabIndex = 2;
            this.lMontant.Text = "Montant : ";
            // 
            // lCodePostal
            // 
            this.lCodePostal.AutoSize = true;
            this.lCodePostal.Location = new System.Drawing.Point(33, 141);
            this.lCodePostal.Name = "lCodePostal";
            this.lCodePostal.Size = new System.Drawing.Size(44, 15);
            this.lCodePostal.TabIndex = 3;
            this.lCodePostal.Text = "Code : ";
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(89, 184);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 4;
            this.bValider.Text = "OK";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // ValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 238);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.lCodePostal);
            this.Controls.Add(this.lMontant);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lNom);
            this.Name = "ValidationForm";
            this.Text = "Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNom;
        private Label lDate;
        private Label lMontant;
        private Label lCodePostal;
        private Button bValider;
    }
}