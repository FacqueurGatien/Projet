namespace AAAATestWinform
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPeriodiciteDeRembourcement = new System.Windows.Forms.ListBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.radioButton9Pourcent = new System.Windows.Forms.RadioButton();
            this.radioButton8Pourcent = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton7Pourcent = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.groupBoxTauxInteret = new System.Windows.Forms.GroupBox();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.labelPeriodiciteDeRemboursement = new System.Windows.Forms.Label();
            this.labelDureeEnMoisDuRemboursement = new System.Windows.Forms.Label();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxTauxInteret.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "--";
            // 
            // listBoxPeriodiciteDeRembourcement
            // 
            this.listBoxPeriodiciteDeRembourcement.FormattingEnabled = true;
            this.listBoxPeriodiciteDeRembourcement.ItemHeight = 15;
            this.listBoxPeriodiciteDeRembourcement.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Anuelle"});
            this.listBoxPeriodiciteDeRembourcement.Location = new System.Drawing.Point(141, 278);
            this.listBoxPeriodiciteDeRembourcement.Name = "listBoxPeriodiciteDeRembourcement";
            this.listBoxPeriodiciteDeRembourcement.Size = new System.Drawing.Size(258, 79);
            this.listBoxPeriodiciteDeRembourcement.TabIndex = 25;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Enabled = false;
            this.buttonAnnuler.Location = new System.Drawing.Point(572, 159);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(88, 23);
            this.buttonAnnuler.TabIndex = 24;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(572, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(261, 131);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(138, 23);
            this.textBoxCapitalEmprunte.TabIndex = 22;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(261, 93);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(138, 23);
            this.textBoxNom.TabIndex = 21;
            // 
            // radioButton9Pourcent
            // 
            this.radioButton9Pourcent.AutoSize = true;
            this.radioButton9Pourcent.Location = new System.Drawing.Point(28, 108);
            this.radioButton9Pourcent.Name = "radioButton9Pourcent";
            this.radioButton9Pourcent.Size = new System.Drawing.Size(44, 19);
            this.radioButton9Pourcent.TabIndex = 2;
            this.radioButton9Pourcent.TabStop = true;
            this.radioButton9Pourcent.Text = "9 %";
            this.radioButton9Pourcent.UseVisualStyleBackColor = true;
            // 
            // radioButton8Pourcent
            // 
            this.radioButton8Pourcent.AutoSize = true;
            this.radioButton8Pourcent.Location = new System.Drawing.Point(28, 69);
            this.radioButton8Pourcent.Name = "radioButton8Pourcent";
            this.radioButton8Pourcent.Size = new System.Drawing.Size(44, 19);
            this.radioButton8Pourcent.TabIndex = 1;
            this.radioButton8Pourcent.TabStop = true;
            this.radioButton8Pourcent.Text = "8 %";
            this.radioButton8Pourcent.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(261, 185);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(181, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Value = 1;
            // 
            // radioButton7Pourcent
            // 
            this.radioButton7Pourcent.AutoSize = true;
            this.radioButton7Pourcent.Location = new System.Drawing.Point(28, 30);
            this.radioButton7Pourcent.Name = "radioButton7Pourcent";
            this.radioButton7Pourcent.Size = new System.Drawing.Size(44, 19);
            this.radioButton7Pourcent.TabIndex = 0;
            this.radioButton7Pourcent.TabStop = true;
            this.radioButton7Pourcent.Text = "7 %";
            this.radioButton7Pourcent.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(448, 278);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 15);
            this.label.TabIndex = 26;
            this.label.Text = "--";
            // 
            // groupBoxTauxInteret
            // 
            this.groupBoxTauxInteret.Controls.Add(this.radioButton9Pourcent);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton8Pourcent);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton7Pourcent);
            this.groupBoxTauxInteret.Location = new System.Drawing.Point(448, 93);
            this.groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            this.groupBoxTauxInteret.Size = new System.Drawing.Size(97, 151);
            this.groupBoxTauxInteret.TabIndex = 19;
            this.groupBoxTauxInteret.TabStop = false;
            this.groupBoxTauxInteret.Text = "Taux d\'interêt";
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRemboursements.Location = new System.Drawing.Point(491, 278);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(106, 15);
            this.labelRemboursements.TabIndex = 18;
            this.labelRemboursements.Text = "Remboursements";
            // 
            // labelPeriodiciteDeRemboursement
            // 
            this.labelPeriodiciteDeRemboursement.AutoSize = true;
            this.labelPeriodiciteDeRemboursement.Location = new System.Drawing.Point(141, 260);
            this.labelPeriodiciteDeRemboursement.Name = "labelPeriodiciteDeRemboursement";
            this.labelPeriodiciteDeRemboursement.Size = new System.Drawing.Size(167, 15);
            this.labelPeriodiciteDeRemboursement.TabIndex = 17;
            this.labelPeriodiciteDeRemboursement.Text = "Périodicité de remboursement";
            // 
            // labelDureeEnMoisDuRemboursement
            // 
            this.labelDureeEnMoisDuRemboursement.AutoSize = true;
            this.labelDureeEnMoisDuRemboursement.Location = new System.Drawing.Point(141, 183);
            this.labelDureeEnMoisDuRemboursement.MaximumSize = new System.Drawing.Size(100, 50);
            this.labelDureeEnMoisDuRemboursement.Name = "labelDureeEnMoisDuRemboursement";
            this.labelDureeEnMoisDuRemboursement.Size = new System.Drawing.Size(100, 30);
            this.labelDureeEnMoisDuRemboursement.TabIndex = 16;
            this.labelDureeEnMoisDuRemboursement.Text = "Durée en mois du remboursement";
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(154, 134);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(99, 15);
            this.labelCapitalEmprunte.TabIndex = 15;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(154, 96);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 14;
            this.labelNom.Text = "Nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPeriodiciteDeRembourcement);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBoxTauxInteret);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.labelPeriodiciteDeRemboursement);
            this.Controls.Add(this.labelDureeEnMoisDuRemboursement);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.labelNom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxTauxInteret.ResumeLayout(false);
            this.groupBoxTauxInteret.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBoxPeriodiciteDeRembourcement;
        private Button buttonAnnuler;
        private Button buttonOK;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxNom;
        private RadioButton radioButton9Pourcent;
        private RadioButton radioButton8Pourcent;
        private TrackBar trackBar1;
        private RadioButton radioButton7Pourcent;
        private Label label;
        private GroupBox groupBoxTauxInteret;
        private Label labelRemboursements;
        private Label labelPeriodiciteDeRemboursement;
        private Label labelDureeEnMoisDuRemboursement;
        private Label labelCapitalEmprunte;
        private Label labelNom;
    }
}