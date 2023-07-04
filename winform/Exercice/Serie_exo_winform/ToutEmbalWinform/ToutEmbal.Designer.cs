namespace ToutEmbalWinform
{
    partial class ToutEmbal
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
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            demarrerToolStripMenuItem = new ToolStripMenuItem();
            aDemarrerToolStripMenuItem = new ToolStripMenuItem();
            bDemarrerToolStripMenuItem = new ToolStripMenuItem();
            cDemarrerToolStripMenuItem = new ToolStripMenuItem();
            arreterToolStripMenuItem = new ToolStripMenuItem();
            aArreterToolStripMenuItem1 = new ToolStripMenuItem();
            bArreterToolStripMenuItem1 = new ToolStripMenuItem();
            cArreterToolStripMenuItem1 = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            aContinuerToolStripMenuItem2 = new ToolStripMenuItem();
            bContinuerToolStripMenuItem2 = new ToolStripMenuItem();
            cContinuerToolStripMenuItem2 = new ToolStripMenuItem();
            panelProgressBar = new Panel();
            panelProdGestionButton = new Panel();
            buttonGenerer = new Button();
            infoProd = new TabControl();
            comboBox1 = new ComboBox();
            textBoxGenerer = new TextBox();
            dataGridView1 = new DataGridView();
            productionSQLBindingSource1 = new BindingSource(components);
            productionSQLBindingSource = new BindingSource(components);
            productionCaisseBindingSource = new BindingSource(components);
            caisseSQLBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionSQLBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionSQLBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionCaisseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caisseSQLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1326, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demarrerToolStripMenuItem, arreterToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // demarrerToolStripMenuItem
            // 
            demarrerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDemarrerToolStripMenuItem, bDemarrerToolStripMenuItem, cDemarrerToolStripMenuItem });
            demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            demarrerToolStripMenuItem.Size = new Size(127, 22);
            demarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aDemarrerToolStripMenuItem
            // 
            aDemarrerToolStripMenuItem.Name = "aDemarrerToolStripMenuItem";
            aDemarrerToolStripMenuItem.Size = new Size(82, 22);
            aDemarrerToolStripMenuItem.Tag = "A";
            aDemarrerToolStripMenuItem.Text = "A";
            aDemarrerToolStripMenuItem.Click += DemarrerProd;
            // 
            // bDemarrerToolStripMenuItem
            // 
            bDemarrerToolStripMenuItem.Name = "bDemarrerToolStripMenuItem";
            bDemarrerToolStripMenuItem.Size = new Size(82, 22);
            bDemarrerToolStripMenuItem.Tag = "B";
            bDemarrerToolStripMenuItem.Text = "B";
            bDemarrerToolStripMenuItem.Click += DemarrerProd;
            // 
            // cDemarrerToolStripMenuItem
            // 
            cDemarrerToolStripMenuItem.Name = "cDemarrerToolStripMenuItem";
            cDemarrerToolStripMenuItem.Size = new Size(82, 22);
            cDemarrerToolStripMenuItem.Tag = "C";
            cDemarrerToolStripMenuItem.Text = "C";
            cDemarrerToolStripMenuItem.Click += DemarrerProd;
            // 
            // arreterToolStripMenuItem
            // 
            arreterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aArreterToolStripMenuItem1, bArreterToolStripMenuItem1, cArreterToolStripMenuItem1 });
            arreterToolStripMenuItem.Name = "arreterToolStripMenuItem";
            arreterToolStripMenuItem.Size = new Size(127, 22);
            arreterToolStripMenuItem.Text = "Arrêter";
            // 
            // aArreterToolStripMenuItem1
            // 
            aArreterToolStripMenuItem1.Name = "aArreterToolStripMenuItem1";
            aArreterToolStripMenuItem1.Size = new Size(82, 22);
            aArreterToolStripMenuItem1.Tag = "A";
            aArreterToolStripMenuItem1.Text = "A";
            aArreterToolStripMenuItem1.Click += PauseProd;
            // 
            // bArreterToolStripMenuItem1
            // 
            bArreterToolStripMenuItem1.Name = "bArreterToolStripMenuItem1";
            bArreterToolStripMenuItem1.Size = new Size(82, 22);
            bArreterToolStripMenuItem1.Tag = "B";
            bArreterToolStripMenuItem1.Text = "B";
            bArreterToolStripMenuItem1.Click += PauseProd;
            // 
            // cArreterToolStripMenuItem1
            // 
            cArreterToolStripMenuItem1.Name = "cArreterToolStripMenuItem1";
            cArreterToolStripMenuItem1.Size = new Size(82, 22);
            cArreterToolStripMenuItem1.Tag = "C";
            cArreterToolStripMenuItem1.Text = "C";
            cArreterToolStripMenuItem1.Click += PauseProd;
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aContinuerToolStripMenuItem2, bContinuerToolStripMenuItem2, cContinuerToolStripMenuItem2 });
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(127, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aContinuerToolStripMenuItem2
            // 
            aContinuerToolStripMenuItem2.Name = "aContinuerToolStripMenuItem2";
            aContinuerToolStripMenuItem2.Size = new Size(82, 22);
            aContinuerToolStripMenuItem2.Tag = "A";
            aContinuerToolStripMenuItem2.Text = "A";
            aContinuerToolStripMenuItem2.Click += RepriseProd;
            // 
            // bContinuerToolStripMenuItem2
            // 
            bContinuerToolStripMenuItem2.Name = "bContinuerToolStripMenuItem2";
            bContinuerToolStripMenuItem2.Size = new Size(82, 22);
            bContinuerToolStripMenuItem2.Tag = "B";
            bContinuerToolStripMenuItem2.Text = "B";
            bContinuerToolStripMenuItem2.Click += RepriseProd;
            // 
            // cContinuerToolStripMenuItem2
            // 
            cContinuerToolStripMenuItem2.Name = "cContinuerToolStripMenuItem2";
            cContinuerToolStripMenuItem2.Size = new Size(82, 22);
            cContinuerToolStripMenuItem2.Tag = "C";
            cContinuerToolStripMenuItem2.Text = "C";
            cContinuerToolStripMenuItem2.Click += RepriseProd;
            // 
            // panelProgressBar
            // 
            panelProgressBar.AutoScroll = true;
            panelProgressBar.Location = new Point(0, 363);
            panelProgressBar.Name = "panelProgressBar";
            panelProgressBar.Padding = new Padding(30, 30, 30, 30);
            panelProgressBar.Size = new Size(744, 248);
            panelProgressBar.TabIndex = 8;
            // 
            // panelProdGestionButton
            // 
            panelProdGestionButton.AutoScroll = true;
            panelProdGestionButton.Location = new Point(0, 27);
            panelProdGestionButton.Name = "panelProdGestionButton";
            panelProdGestionButton.Padding = new Padding(10, 10, 10, 10);
            panelProdGestionButton.Size = new Size(744, 112);
            panelProdGestionButton.TabIndex = 9;
            // 
            // buttonGenerer
            // 
            buttonGenerer.Enabled = false;
            buttonGenerer.Location = new Point(12, 241);
            buttonGenerer.Name = "buttonGenerer";
            buttonGenerer.Size = new Size(121, 23);
            buttonGenerer.TabIndex = 10;
            buttonGenerer.Text = "Generer";
            buttonGenerer.UseVisualStyleBackColor = true;
            buttonGenerer.Click += button1_Click;
            // 
            // infoProd
            // 
            infoProd.Location = new Point(268, 145);
            infoProd.Name = "infoProd";
            infoProd.SelectedIndex = 0;
            infoProd.Size = new Size(402, 212);
            infoProd.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxGenerer
            // 
            textBoxGenerer.Location = new Point(12, 212);
            textBoxGenerer.Name = "textBoxGenerer";
            textBoxGenerer.Size = new Size(121, 23);
            textBoxGenerer.TabIndex = 12;
            textBoxGenerer.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(750, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(576, 208);
            dataGridView1.TabIndex = 13;
            // 
            // productionSQLBindingSource1
            // 
            productionSQLBindingSource1.DataSource = typeof(Models.ProductionSQL);
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(750, 272);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(576, 327);
            tabControl1.TabIndex = 14;
            // 
            // ToutEmbal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1343, 597);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxGenerer);
            Controls.Add(comboBox1);
            Controls.Add(buttonGenerer);
            Controls.Add(panelProdGestionButton);
            Controls.Add(panelProgressBar);
            Controls.Add(infoProd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ToutEmbal";
            Text = "Form1";
            FormClosing += Formulaire_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionSQLBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionSQLBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionCaisseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)caisseSQLBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem demarrerToolStripMenuItem;
        private ToolStripMenuItem aDemarrerToolStripMenuItem;
        private ToolStripMenuItem bDemarrerToolStripMenuItem;
        private ToolStripMenuItem cDemarrerToolStripMenuItem;
        private ToolStripMenuItem arreterToolStripMenuItem;
        private ToolStripMenuItem aArreterToolStripMenuItem1;
        private ToolStripMenuItem bArreterToolStripMenuItem1;
        private ToolStripMenuItem cArreterToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aContinuerToolStripMenuItem2;
        private ToolStripMenuItem bContinuerToolStripMenuItem2;
        private ToolStripMenuItem cContinuerToolStripMenuItem2;
        private InformationproductionDock informationproductionDock1;
        private InformationproductionDock informationproductionDock2;
        private InformationproductionDock informationproductionDock3;
        private InformationproductionDock informationproductionDock4;
        private GestionProductionLabel1 gestionProductionLabel13;
        private Panel panelProgressBar;
        private Panel panelProdGestionButton;
        private Button buttonGenerer;
        private TabControl infoProd;
        private ComboBox comboBox1;
        private TextBox textBoxGenerer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodNomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodObjectifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionCaissesDataGridViewTextBoxColumn;
        private BindingSource productionSQLBindingSource;
        private BindingSource productionCaisseBindingSource;
        private BindingSource caisseSQLBindingSource;
        private DataGridViewTextBoxColumn caisseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caisseNomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caisseVitesseHeureDataGridViewTextBoxColumn;
        private BindingSource productionSQLBindingSource1;
        private TabControl tabControl1;
    }
}