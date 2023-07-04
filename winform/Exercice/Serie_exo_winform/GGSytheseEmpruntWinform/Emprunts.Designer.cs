namespace GGSytheseEmpruntWinform
{
    partial class Emprunts
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
            this.labelMontantDu = new System.Windows.Forms.Label();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.radioButton7P = new System.Windows.Forms.RadioButton();
            this.trackBarDuree = new System.Windows.Forms.TrackBar();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.radioButton9P = new System.Windows.Forms.RadioButton();
            this.labelNombreRemboursement = new System.Windows.Forms.Label();
            this.groupBoxTauxInteret = new System.Windows.Forms.GroupBox();
            this.radioButton8P = new System.Windows.Forms.RadioButton();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.labelPeriodiciteDeRemboursement = new System.Windows.Forms.Label();
            this.labelDureeEnMoisDuRemboursement = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelTrackBarDuree = new System.Windows.Forms.Label();
            this.textBoxOuvrir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuree)).BeginInit();
            this.groupBoxTauxInteret.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMontantDu
            // 
            this.labelMontantDu.AutoSize = true;
            this.labelMontantDu.Location = new System.Drawing.Point(466, 237);
            this.labelMontantDu.Name = "labelMontantDu";
            this.labelMontantDu.Size = new System.Drawing.Size(17, 15);
            this.labelMontantDu.TabIndex = 41;
            this.labelMontantDu.Text = "--";
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.ItemHeight = 15;
            this.listBoxPeriodicite.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Anuelle"});
            this.listBoxPeriodicite.Location = new System.Drawing.Point(13, 201);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(258, 79);
            this.listBoxPeriodicite.TabIndex = 39;
            this.listBoxPeriodicite.Tag = 1;
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Enabled = false;
            this.buttonOuvrir.Location = new System.Drawing.Point(510, 113);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(88, 23);
            this.buttonOuvrir.TabIndex = 38;
            this.buttonOuvrir.Text = "Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(510, 27);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 23);
            this.buttonOK.TabIndex = 37;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(133, 54);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(138, 23);
            this.textBoxCapital.TabIndex = 36;
            this.textBoxCapital.TextChanged += new System.EventHandler(this.textBoxCapital_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(133, 16);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(138, 23);
            this.textBoxNom.TabIndex = 35;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // radioButton7P
            // 
            this.radioButton7P.AutoSize = true;
            this.radioButton7P.Location = new System.Drawing.Point(28, 30);
            this.radioButton7P.Name = "radioButton7P";
            this.radioButton7P.Size = new System.Drawing.Size(44, 19);
            this.radioButton7P.TabIndex = 0;
            this.radioButton7P.TabStop = true;
            this.radioButton7P.Tag = 7;
            this.radioButton7P.Text = "7 %";
            this.radioButton7P.UseVisualStyleBackColor = true;
            this.radioButton7P.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // trackBarDuree
            // 
            this.trackBarDuree.LargeChange = 10;
            this.trackBarDuree.Location = new System.Drawing.Point(179, 108);
            this.trackBarDuree.Maximum = 360;
            this.trackBarDuree.Minimum = 1;
            this.trackBarDuree.Name = "trackBarDuree";
            this.trackBarDuree.Size = new System.Drawing.Size(201, 45);
            this.trackBarDuree.TabIndex = 34;
            this.trackBarDuree.Value = 1;
            this.trackBarDuree.Scroll += new System.EventHandler(this.trackBarDuree_Scroll);
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(26, 57);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(99, 15);
            this.labelCapitalEmprunte.TabIndex = 29;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // radioButton9P
            // 
            this.radioButton9P.AutoSize = true;
            this.radioButton9P.Location = new System.Drawing.Point(28, 108);
            this.radioButton9P.Name = "radioButton9P";
            this.radioButton9P.Size = new System.Drawing.Size(44, 19);
            this.radioButton9P.TabIndex = 2;
            this.radioButton9P.TabStop = true;
            this.radioButton9P.Tag = 9;
            this.radioButton9P.Text = "9 %";
            this.radioButton9P.UseVisualStyleBackColor = true;
            this.radioButton9P.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelNombreRemboursement
            // 
            this.labelNombreRemboursement.AutoSize = true;
            this.labelNombreRemboursement.Location = new System.Drawing.Point(386, 201);
            this.labelNombreRemboursement.Name = "labelNombreRemboursement";
            this.labelNombreRemboursement.Size = new System.Drawing.Size(17, 15);
            this.labelNombreRemboursement.TabIndex = 40;
            this.labelNombreRemboursement.Text = "--";
            // 
            // groupBoxTauxInteret
            // 
            this.groupBoxTauxInteret.Controls.Add(this.radioButton9P);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton8P);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton7P);
            this.groupBoxTauxInteret.Location = new System.Drawing.Point(386, 16);
            this.groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            this.groupBoxTauxInteret.Size = new System.Drawing.Size(97, 151);
            this.groupBoxTauxInteret.TabIndex = 33;
            this.groupBoxTauxInteret.TabStop = false;
            this.groupBoxTauxInteret.Tag = 7;
            this.groupBoxTauxInteret.Text = "Taux d\'interêt";
            // 
            // radioButton8P
            // 
            this.radioButton8P.AutoSize = true;
            this.radioButton8P.Location = new System.Drawing.Point(28, 69);
            this.radioButton8P.Name = "radioButton8P";
            this.radioButton8P.Size = new System.Drawing.Size(44, 19);
            this.radioButton8P.TabIndex = 1;
            this.radioButton8P.TabStop = true;
            this.radioButton8P.Tag = 8;
            this.radioButton8P.Text = "8 %";
            this.radioButton8P.UseVisualStyleBackColor = true;
            this.radioButton8P.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRemboursements.Location = new System.Drawing.Point(429, 201);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(106, 15);
            this.labelRemboursements.TabIndex = 32;
            this.labelRemboursements.Text = "Remboursements";
            // 
            // labelPeriodiciteDeRemboursement
            // 
            this.labelPeriodiciteDeRemboursement.AutoSize = true;
            this.labelPeriodiciteDeRemboursement.Location = new System.Drawing.Point(13, 183);
            this.labelPeriodiciteDeRemboursement.Name = "labelPeriodiciteDeRemboursement";
            this.labelPeriodiciteDeRemboursement.Size = new System.Drawing.Size(167, 15);
            this.labelPeriodiciteDeRemboursement.TabIndex = 31;
            this.labelPeriodiciteDeRemboursement.Text = "Périodicité de remboursement";
            // 
            // labelDureeEnMoisDuRemboursement
            // 
            this.labelDureeEnMoisDuRemboursement.AutoSize = true;
            this.labelDureeEnMoisDuRemboursement.Location = new System.Drawing.Point(13, 106);
            this.labelDureeEnMoisDuRemboursement.MaximumSize = new System.Drawing.Size(100, 50);
            this.labelDureeEnMoisDuRemboursement.Name = "labelDureeEnMoisDuRemboursement";
            this.labelDureeEnMoisDuRemboursement.Size = new System.Drawing.Size(100, 30);
            this.labelDureeEnMoisDuRemboursement.TabIndex = 30;
            this.labelDureeEnMoisDuRemboursement.Text = "Durée en mois du remboursement";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(26, 19);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 28;
            this.labelNom.Text = "Nom";
            // 
            // labelTrackBarDuree
            // 
            this.labelTrackBarDuree.AutoSize = true;
            this.labelTrackBarDuree.Location = new System.Drawing.Point(135, 108);
            this.labelTrackBarDuree.Name = "labelTrackBarDuree";
            this.labelTrackBarDuree.Size = new System.Drawing.Size(13, 15);
            this.labelTrackBarDuree.TabIndex = 42;
            this.labelTrackBarDuree.Text = "0";
            // 
            // textBoxOuvrir
            // 
            this.textBoxOuvrir.Location = new System.Drawing.Point(489, 81);
            this.textBoxOuvrir.Name = "textBoxOuvrir";
            this.textBoxOuvrir.Size = new System.Drawing.Size(130, 23);
            this.textBoxOuvrir.TabIndex = 43;
            this.textBoxOuvrir.TextChanged += new System.EventHandler(this.textBoxOuvrir_TextChanged);
            // 
            // Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 303);
            this.Controls.Add(this.textBoxOuvrir);
            this.Controls.Add(this.labelTrackBarDuree);
            this.Controls.Add(this.labelMontantDu);
            this.Controls.Add(this.listBoxPeriodicite);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.trackBarDuree);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.labelNombreRemboursement);
            this.Controls.Add(this.groupBoxTauxInteret);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.labelPeriodiciteDeRemboursement);
            this.Controls.Add(this.labelDureeEnMoisDuRemboursement);
            this.Controls.Add(this.labelNom);
            this.Name = "Emprunts";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuree)).EndInit();
            this.groupBoxTauxInteret.ResumeLayout(false);
            this.groupBoxTauxInteret.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMontantDu;
        private ListBox listBoxPeriodicite;
        private Button buttonOuvrir;
        private Button buttonOK;
        private TextBox textBoxCapital;
        private TextBox textBoxNom;
        private RadioButton radioButton7P;
        private TrackBar trackBarDuree;
        private Label labelCapitalEmprunte;
        private RadioButton radioButton9P;
        private Label labelNombreRemboursement;
        private GroupBox groupBoxTauxInteret;
        private RadioButton radioButton8P;
        private Label labelRemboursements;
        private Label labelPeriodiciteDeRemboursement;
        private Label labelDureeEnMoisDuRemboursement;
        private Label labelNom;
        private Label labelTrackBarDuree;
        private TextBox textBoxOuvrir;
    }
}