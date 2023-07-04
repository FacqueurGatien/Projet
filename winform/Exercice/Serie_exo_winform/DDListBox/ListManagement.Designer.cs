namespace DDListBox
{
    partial class ListManagement
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
            this.lNewElement = new System.Windows.Forms.Label();
            this.tbAddList = new System.Windows.Forms.TextBox();
            this.bAddList = new System.Windows.Forms.Button();
            this.lListe = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.lIndexElement = new System.Windows.Forms.Label();
            this.tbIndexElement = new System.Windows.Forms.TextBox();
            this.bSelection = new System.Windows.Forms.Button();
            this.bVider = new System.Windows.Forms.Button();
            this.lPropriete = new System.Windows.Forms.Label();
            this.lItemCount = new System.Windows.Forms.Label();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.lIndexSelect = new System.Windows.Forms.Label();
            this.tbIndexSelect = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lTexte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNewElement
            // 
            this.lNewElement.AutoSize = true;
            this.lNewElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lNewElement.Location = new System.Drawing.Point(22, 9);
            this.lNewElement.Name = "lNewElement";
            this.lNewElement.Size = new System.Drawing.Size(96, 15);
            this.lNewElement.TabIndex = 0;
            this.lNewElement.Text = "Nouvel Elément";
            // 
            // tbAddList
            // 
            this.tbAddList.Location = new System.Drawing.Point(22, 41);
            this.tbAddList.Name = "tbAddList";
            this.tbAddList.Size = new System.Drawing.Size(156, 23);
            this.tbAddList.TabIndex = 1;
            this.tbAddList.TextChanged += new System.EventHandler(this.TbAddList_TextChanged);
            // 
            // bAddList
            // 
            this.bAddList.Enabled = false;
            this.bAddList.Location = new System.Drawing.Point(22, 86);
            this.bAddList.Name = "bAddList";
            this.bAddList.Size = new System.Drawing.Size(156, 23);
            this.bAddList.TabIndex = 2;
            this.bAddList.Text = "Ajout Liste";
            this.bAddList.UseVisualStyleBackColor = true;
            this.bAddList.Click += new System.EventHandler(this.BAddList_Click);
            // 
            // lListe
            // 
            this.lListe.AutoSize = true;
            this.lListe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lListe.Location = new System.Drawing.Point(22, 135);
            this.lListe.Name = "lListe";
            this.lListe.Size = new System.Drawing.Size(33, 15);
            this.lListe.TabIndex = 3;
            this.lListe.Text = "Liste";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 15;
            this.lbList.Location = new System.Drawing.Point(22, 172);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(156, 139);
            this.lbList.TabIndex = 4;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.LbListe_SelectedIndexChanged);
            // 
            // lIndexElement
            // 
            this.lIndexElement.AutoSize = true;
            this.lIndexElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lIndexElement.Location = new System.Drawing.Point(287, 9);
            this.lIndexElement.Name = "lIndexElement";
            this.lIndexElement.Size = new System.Drawing.Size(88, 15);
            this.lIndexElement.TabIndex = 5;
            this.lIndexElement.Text = "Index Elément";
            // 
            // tbIndexElement
            // 
            this.tbIndexElement.Location = new System.Drawing.Point(287, 42);
            this.tbIndexElement.Name = "tbIndexElement";
            this.tbIndexElement.Size = new System.Drawing.Size(53, 23);
            this.tbIndexElement.TabIndex = 6;
            this.tbIndexElement.TextChanged += new System.EventHandler(this.TbIndexElement_TextChanged);
            // 
            // bSelection
            // 
            this.bSelection.Enabled = false;
            this.bSelection.Location = new System.Drawing.Point(369, 41);
            this.bSelection.Name = "bSelection";
            this.bSelection.Size = new System.Drawing.Size(156, 23);
            this.bSelection.TabIndex = 7;
            this.bSelection.Text = "Sélectionner";
            this.bSelection.UseVisualStyleBackColor = true;
            this.bSelection.Click += new System.EventHandler(this.BSelection_Click);
            // 
            // bVider
            // 
            this.bVider.Enabled = false;
            this.bVider.Location = new System.Drawing.Point(369, 86);
            this.bVider.Name = "bVider";
            this.bVider.Size = new System.Drawing.Size(156, 23);
            this.bVider.TabIndex = 8;
            this.bVider.Text = "Vider Liste";
            this.bVider.UseVisualStyleBackColor = true;
            this.bVider.Click += new System.EventHandler(this.BVider_Click);
            // 
            // lPropriete
            // 
            this.lPropriete.AutoSize = true;
            this.lPropriete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lPropriete.Location = new System.Drawing.Point(287, 135);
            this.lPropriete.Name = "lPropriete";
            this.lPropriete.Size = new System.Drawing.Size(65, 15);
            this.lPropriete.TabIndex = 9;
            this.lPropriete.Text = "Propriétés";
            // 
            // lItemCount
            // 
            this.lItemCount.AutoSize = true;
            this.lItemCount.Location = new System.Drawing.Point(287, 172);
            this.lItemCount.Name = "lItemCount";
            this.lItemCount.Size = new System.Drawing.Size(112, 15);
            this.lItemCount.TabIndex = 10;
            this.lItemCount.Text = "Nombre d\'élements";
            // 
            // tbItemCount
            // 
            this.tbItemCount.Enabled = false;
            this.tbItemCount.Location = new System.Drawing.Point(409, 169);
            this.tbItemCount.Multiline = true;
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(47, 26);
            this.tbItemCount.TabIndex = 11;
            // 
            // lIndexSelect
            // 
            this.lIndexSelect.AutoSize = true;
            this.lIndexSelect.Location = new System.Drawing.Point(287, 223);
            this.lIndexSelect.Name = "lIndexSelect";
            this.lIndexSelect.Size = new System.Drawing.Size(100, 15);
            this.lIndexSelect.TabIndex = 12;
            this.lIndexSelect.Text = "Index Selectionné";
            // 
            // tbIndexSelect
            // 
            this.tbIndexSelect.Enabled = false;
            this.tbIndexSelect.Location = new System.Drawing.Point(409, 220);
            this.tbIndexSelect.Multiline = true;
            this.tbIndexSelect.Name = "tbIndexSelect";
            this.tbIndexSelect.Size = new System.Drawing.Size(47, 26);
            this.tbIndexSelect.TabIndex = 13;
            // 
            // tbText
            // 
            this.tbText.Enabled = false;
            this.tbText.Location = new System.Drawing.Point(409, 268);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(116, 26);
            this.tbText.TabIndex = 15;
            // 
            // lTexte
            // 
            this.lTexte.AutoSize = true;
            this.lTexte.Location = new System.Drawing.Point(287, 271);
            this.lTexte.Name = "lTexte";
            this.lTexte.Size = new System.Drawing.Size(34, 15);
            this.lTexte.TabIndex = 14;
            this.lTexte.Text = "Texte";
            // 
            // ListManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 343);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lTexte);
            this.Controls.Add(this.tbIndexSelect);
            this.Controls.Add(this.lIndexSelect);
            this.Controls.Add(this.tbItemCount);
            this.Controls.Add(this.lItemCount);
            this.Controls.Add(this.lPropriete);
            this.Controls.Add(this.bVider);
            this.Controls.Add(this.bSelection);
            this.Controls.Add(this.tbIndexElement);
            this.Controls.Add(this.lIndexElement);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.lListe);
            this.Controls.Add(this.bAddList);
            this.Controls.Add(this.tbAddList);
            this.Controls.Add(this.lNewElement);
            this.Name = "ListManagement";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNewElement;
        private TextBox tbAddList;
        private Button bAddList;
        private Label lListe;
        private ListBox lbList;
        private Label lIndexElement;
        private TextBox tbIndexElement;
        private Button bSelection;
        private Button bVider;
        private Label lPropriete;
        private Label lItemCount;
        private TextBox tbItemCount;
        private Label lIndexSelect;
        private TextBox tbIndexSelect;
        private TextBox tbText;
        private Label lTexte;
    }
}