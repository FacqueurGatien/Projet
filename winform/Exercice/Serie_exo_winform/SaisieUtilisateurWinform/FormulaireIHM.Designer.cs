namespace SaisieUtilisateurWinform
{
    partial class FormulaireIHM
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
            components = new System.ComponentModel.Container();
            nom = new Label();
            date = new Label();
            montant = new Label();
            codePostal = new Label();
            tbNom = new TextBox();
            tbDate = new TextBox();
            tbMontant = new TextBox();
            tbCodePostal = new TextBox();
            dateFormat = new Label();
            valider = new Button();
            effacer = new Button();
            epNom = new ErrorProvider(components);
            epDate = new ErrorProvider(components);
            epMontant = new ErrorProvider(components);
            epCodePostal = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCodePostal).BeginInit();
            SuspendLayout();
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Location = new Point(26, 43);
            nom.Name = "nom";
            nom.Size = new Size(34, 15);
            nom.TabIndex = 0;
            nom.Text = "Nom";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(26, 106);
            date.Name = "date";
            date.Size = new Size(31, 15);
            date.TabIndex = 1;
            date.Text = "Date";
            // 
            // montant
            // 
            montant.AutoSize = true;
            montant.Location = new Point(26, 172);
            montant.Name = "montant";
            montant.Size = new Size(53, 15);
            montant.TabIndex = 2;
            montant.Text = "Montant";
            // 
            // codePostal
            // 
            codePostal.AutoSize = true;
            codePostal.Location = new Point(26, 240);
            codePostal.Name = "codePostal";
            codePostal.Size = new Size(70, 15);
            codePostal.TabIndex = 3;
            codePostal.Text = "Code Postal";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(111, 40);
            tbNom.Name = "tbNom";
            tbNom.PlaceholderText = "Michelle";
            tbNom.Size = new Size(213, 23);
            tbNom.TabIndex = 4;
            tbNom.TextChanged += tbNom_TextChanged;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(111, 103);
            tbDate.Name = "tbDate";
            tbDate.PlaceholderText = "//";
            tbDate.Size = new Size(147, 23);
            tbDate.TabIndex = 5;
            tbDate.TextChanged += tbDate_TextChanged;
            // 
            // tbMontant
            // 
            tbMontant.Location = new Point(111, 169);
            tbMontant.Name = "tbMontant";
            tbMontant.PlaceholderText = "500,50";
            tbMontant.Size = new Size(147, 23);
            tbMontant.TabIndex = 6;
            tbMontant.TextChanged += tbMontant_TextChanged;
            // 
            // tbCodePostal
            // 
            tbCodePostal.Location = new Point(111, 237);
            tbCodePostal.Name = "tbCodePostal";
            tbCodePostal.PlaceholderText = "02000";
            tbCodePostal.Size = new Size(100, 23);
            tbCodePostal.TabIndex = 7;
            tbCodePostal.TextChanged += tbCodePostal_TextChanged;
            // 
            // dateFormat
            // 
            dateFormat.AutoSize = true;
            dateFormat.Location = new Point(286, 106);
            dateFormat.Name = "dateFormat";
            dateFormat.Size = new Size(79, 15);
            dateFormat.TabIndex = 8;
            dateFormat.Text = "JJ/MM/AAAA";
            // 
            // valider
            // 
            valider.Enabled = false;
            valider.Location = new Point(286, 237);
            valider.Name = "valider";
            valider.Size = new Size(75, 23);
            valider.TabIndex = 9;
            valider.Text = "Valider";
            valider.UseVisualStyleBackColor = true;
            valider.Click += valider_Click;
            // 
            // effacer
            // 
            effacer.Enabled = false;
            effacer.Location = new Point(286, 275);
            effacer.Name = "effacer";
            effacer.Size = new Size(75, 23);
            effacer.TabIndex = 10;
            effacer.Text = "Effacer";
            effacer.UseVisualStyleBackColor = true;
            effacer.Click += effacer_Click;
            // 
            // epNom
            // 
            epNom.ContainerControl = this;
            // 
            // epDate
            // 
            epDate.ContainerControl = this;
            // 
            // epMontant
            // 
            epMontant.ContainerControl = this;
            // 
            // epCodePostal
            // 
            epCodePostal.ContainerControl = this;
            // 
            // FormulaireIHM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 323);
            Controls.Add(effacer);
            Controls.Add(valider);
            Controls.Add(dateFormat);
            Controls.Add(tbCodePostal);
            Controls.Add(tbMontant);
            Controls.Add(tbDate);
            Controls.Add(tbNom);
            Controls.Add(codePostal);
            Controls.Add(montant);
            Controls.Add(date);
            Controls.Add(nom);
            Name = "FormulaireIHM";
            Text = "Form1";
            FormClosing += Formulaire_FormClosing;
            ((System.ComponentModel.ISupportInitialize)epNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)epDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)epMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCodePostal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nom;
        private Label date;
        private Label montant;
        private Label codePostal;
        private TextBox tbNom;
        private TextBox tbDate;
        private TextBox tbMontant;
        private TextBox tbCodePostal;
        private Label dateFormat;
        private Button valider;
        private Button effacer;
        private ErrorProvider epNom;
        private ErrorProvider epDate;
        private ErrorProvider epMontant;
        private ErrorProvider epCodePostal;
    }
}