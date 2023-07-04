namespace HHPhase4
{
    partial class Phase4
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
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            sidentifierToolStripMenuItem = new ToolStripMenuItem();
            seDeconnecterToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            additionneur = new ToolStripMenuItem();
            saisieFormulaire = new ToolStripMenuItem();
            textFormatter = new ToolStripMenuItem();
            inputTextToolStripMenuItem = new ToolStripMenuItem();
            appToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ToolStripMenuItem();
            listBox2 = new ToolStripMenuItem();
            colorPreview = new ToolStripMenuItem();
            emprunt = new ToolStripMenuItem();
            fenetres = new ToolStripMenuItem();
            horizontaleToolStripMenuItem = new ToolStripMenuItem();
            verticaleToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, additionneur, saisieFormulaire, textFormatter, listBox1, listBox2, colorPreview, emprunt, fenetres });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = fenetres;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(854, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sidentifierToolStripMenuItem, seDeconnecterToolStripMenuItem, quitterToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            sidentifierToolStripMenuItem.Size = new Size(156, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += sidentifierToolStripMenuItem_Click;
            // 
            // seDeconnecterToolStripMenuItem
            // 
            seDeconnecterToolStripMenuItem.Enabled = false;
            seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            seDeconnecterToolStripMenuItem.Size = new Size(156, 22);
            seDeconnecterToolStripMenuItem.Text = "Se Deconnecter";
            seDeconnecterToolStripMenuItem.Click += seDeconnecterToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(156, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // additionneur
            // 
            additionneur.Enabled = false;
            additionneur.Name = "additionneur";
            additionneur.Size = new Size(89, 20);
            additionneur.Text = "Additionneur";
            additionneur.Click += additionneur_Click;
            // 
            // saisieFormulaire
            // 
            saisieFormulaire.Enabled = false;
            saisieFormulaire.Name = "saisieFormulaire";
            saisieFormulaire.Size = new Size(108, 20);
            saisieFormulaire.Text = "Saisie Formulaire";
            saisieFormulaire.Click += saisieFormulaire_Click;
            // 
            // textFormatter
            // 
            textFormatter.DropDownItems.AddRange(new ToolStripItem[] { inputTextToolStripMenuItem, appToolStripMenuItem });
            textFormatter.Enabled = false;
            textFormatter.Name = "textFormatter";
            textFormatter.Size = new Size(92, 20);
            textFormatter.Text = "TextFormatter";
            // 
            // inputTextToolStripMenuItem
            // 
            inputTextToolStripMenuItem.Name = "inputTextToolStripMenuItem";
            inputTextToolStripMenuItem.Size = new Size(123, 22);
            inputTextToolStripMenuItem.Text = "InputText";
            inputTextToolStripMenuItem.Click += inputTextToolStripMenuItem_Click;
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(123, 22);
            appToolStripMenuItem.Text = "App";
            appToolStripMenuItem.Click += appToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(57, 20);
            listBox1.Text = "ListBox";
            listBox1.Click += listBox1_Click;
            // 
            // listBox2
            // 
            listBox2.Enabled = false;
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(63, 20);
            listBox2.Text = "ListBox2";
            listBox2.Click += listBox2_Click;
            // 
            // colorPreview
            // 
            colorPreview.Enabled = false;
            colorPreview.Name = "colorPreview";
            colorPreview.Size = new Size(92, 20);
            colorPreview.Text = "Color Preview";
            colorPreview.Click += colorPreview_Click;
            // 
            // emprunt
            // 
            emprunt.Enabled = false;
            emprunt.Name = "emprunt";
            emprunt.Size = new Size(65, 20);
            emprunt.Text = "Emprunt";
            emprunt.Click += emprunt_Click;
            // 
            // fenetres
            // 
            fenetres.DropDownItems.AddRange(new ToolStripItem[] { horizontaleToolStripMenuItem, verticaleToolStripMenuItem, cascadeToolStripMenuItem, toolStripSeparator1 });
            fenetres.Enabled = false;
            fenetres.Name = "fenetres";
            fenetres.Size = new Size(63, 20);
            fenetres.Text = "Fenêtres";
            fenetres.Click += fenetres_Click;
            // 
            // horizontaleToolStripMenuItem
            // 
            horizontaleToolStripMenuItem.Name = "horizontaleToolStripMenuItem";
            horizontaleToolStripMenuItem.Size = new Size(129, 22);
            horizontaleToolStripMenuItem.Text = "Horizontal";
            horizontaleToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // verticaleToolStripMenuItem
            // 
            verticaleToolStripMenuItem.Name = "verticaleToolStripMenuItem";
            verticaleToolStripMenuItem.Size = new Size(129, 22);
            verticaleToolStripMenuItem.Text = "Vertical";
            verticaleToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(129, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(126, 6);
            // 
            // Phase4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Phase4";
            Text = "Phase 4";
            FormClosing += Formulaire_FormClosing;
            Load += Phase4_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem additionneur;
        private ToolStripMenuItem saisieFormulaire;
        private ToolStripMenuItem textFormatter;
        private ToolStripMenuItem fenetres;
        private ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private ToolStripMenuItem listBox1;
        private ToolStripMenuItem listBox2;
        private ToolStripMenuItem colorPreview;
        private ToolStripMenuItem emprunt;
        private ToolStripMenuItem inputTextToolStripMenuItem;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem horizontaleToolStripMenuItem;
        private ToolStripMenuItem verticaleToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private HHPhase4Winform.UserControl1 userControl11;
        private HHPhase4Winform.UserControl1 userControl12;
    }
}