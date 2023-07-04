namespace EEListBox2Winform
{
    partial class ListBoxTransfert
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
            this.labelSource = new System.Windows.Forms.Label();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonVersCible = new System.Windows.Forms.Button();
            this.buttonVersCibleTout = new System.Windows.Forms.Button();
            this.buttonVersSource = new System.Windows.Forms.Button();
            this.buttonVersSourceTout = new System.Windows.Forms.Button();
            this.buttonHaut = new System.Windows.Forms.Button();
            this.buttonBas = new System.Windows.Forms.Button();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(44, 7);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(43, 15);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(295, 7);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(34, 15);
            this.labelCible.TabIndex = 0;
            this.labelCible.Text = "Cible";
            // 
            // buttonVersCible
            // 
            this.buttonVersCible.Enabled = false;
            this.buttonVersCible.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVersCible.Location = new System.Drawing.Point(156, 34);
            this.buttonVersCible.Name = "buttonVersCible";
            this.buttonVersCible.Size = new System.Drawing.Size(75, 32);
            this.buttonVersCible.TabIndex = 1;
            this.buttonVersCible.Text = ">";
            this.buttonVersCible.UseVisualStyleBackColor = true;
            this.buttonVersCible.Click += new System.EventHandler(this.buttonVersCible_Click);
            // 
            // buttonVersCibleTout
            // 
            this.buttonVersCibleTout.Enabled = false;
            this.buttonVersCibleTout.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVersCibleTout.Location = new System.Drawing.Point(156, 72);
            this.buttonVersCibleTout.Name = "buttonVersCibleTout";
            this.buttonVersCibleTout.Size = new System.Drawing.Size(75, 32);
            this.buttonVersCibleTout.TabIndex = 1;
            this.buttonVersCibleTout.Text = ">>";
            this.buttonVersCibleTout.UseVisualStyleBackColor = true;
            this.buttonVersCibleTout.Click += new System.EventHandler(this.buttonVersCibleTout_Click);
            // 
            // buttonVersSource
            // 
            this.buttonVersSource.Enabled = false;
            this.buttonVersSource.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVersSource.Location = new System.Drawing.Point(156, 148);
            this.buttonVersSource.Name = "buttonVersSource";
            this.buttonVersSource.Size = new System.Drawing.Size(75, 32);
            this.buttonVersSource.TabIndex = 1;
            this.buttonVersSource.Text = "<";
            this.buttonVersSource.UseVisualStyleBackColor = true;
            this.buttonVersSource.Click += new System.EventHandler(this.buttonVersSource_Click);
            // 
            // buttonVersSourceTout
            // 
            this.buttonVersSourceTout.Enabled = false;
            this.buttonVersSourceTout.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVersSourceTout.Location = new System.Drawing.Point(156, 186);
            this.buttonVersSourceTout.Name = "buttonVersSourceTout";
            this.buttonVersSourceTout.Size = new System.Drawing.Size(75, 32);
            this.buttonVersSourceTout.TabIndex = 1;
            this.buttonVersSourceTout.Text = "<<";
            this.buttonVersSourceTout.UseVisualStyleBackColor = true;
            this.buttonVersSourceTout.Click += new System.EventHandler(this.buttonVersSourceTout_Click);
            // 
            // buttonHaut
            // 
            this.buttonHaut.Enabled = false;
            this.buttonHaut.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHaut.Location = new System.Drawing.Point(264, 224);
            this.buttonHaut.Name = "buttonHaut";
            this.buttonHaut.Size = new System.Drawing.Size(38, 42);
            this.buttonHaut.TabIndex = 1;
            this.buttonHaut.Text = "↑";
            this.buttonHaut.UseVisualStyleBackColor = true;
            this.buttonHaut.Click += new System.EventHandler(this.buttonHaut_Click);
            // 
            // buttonBas
            // 
            this.buttonBas.Enabled = false;
            this.buttonBas.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBas.Location = new System.Drawing.Point(319, 224);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(38, 42);
            this.buttonBas.TabIndex = 1;
            this.buttonBas.Text = "↓";
            this.buttonBas.UseVisualStyleBackColor = true;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(7, 34);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(143, 23);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.ItemHeight = 15;
            this.listBoxCible.Location = new System.Drawing.Point(237, 34);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(164, 184);
            this.listBoxCible.TabIndex = 3;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // ListBoxTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.buttonHaut);
            this.Controls.Add(this.buttonVersSourceTout);
            this.Controls.Add(this.buttonVersSource);
            this.Controls.Add(this.buttonVersCibleTout);
            this.Controls.Add(this.buttonVersCible);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.labelSource);
            this.Name = "ListBoxTransfert";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSource;
        private Label labelCible;
        private Button buttonVersCible;
        private Button buttonVersCibleTout;
        private Button buttonVersSource;
        private Button buttonVersSourceTout;
        private Button buttonHaut;
        private Button buttonBas;
        private ComboBox comboBoxSource;
        private ListBox listBoxCible;
    }
}