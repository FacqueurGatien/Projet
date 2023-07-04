namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bouteillPicB = new System.Windows.Forms.PictureBox();
            this.bouchonDessin = new System.Windows.Forms.PictureBox();
            this.liquide = new System.Windows.Forms.PictureBox();
            this.viderTout = new System.Windows.Forms.Button();
            this.remplirTout = new System.Windows.Forms.Button();
            this.ouvrirBouteille = new System.Windows.Forms.Button();
            this.fermerBouteille = new System.Windows.Forms.Button();
            this.quantiteRemplir = new System.Windows.Forms.TextBox();
            this.quantiteVider = new System.Windows.Forms.TextBox();
            this.remplirTant = new System.Windows.Forms.Button();
            this.viderTant = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bouteillPicB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bouchonDessin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquide)).BeginInit();
            this.SuspendLayout();
            // 
            // bouteillPicB
            // 
            this.bouteillPicB.BackColor = System.Drawing.Color.Transparent;
            this.bouteillPicB.BackgroundImage = global::WinFormsApp1.Properties.Resources.bouteille;
            this.bouteillPicB.InitialImage = null;
            this.bouteillPicB.Location = new System.Drawing.Point(324, 29);
            this.bouteillPicB.Name = "bouteillPicB";
            this.bouteillPicB.Size = new System.Drawing.Size(82, 380);
            this.bouteillPicB.TabIndex = 1;
            this.bouteillPicB.TabStop = false;
            // 
            // bouchonDessin
            // 
            this.bouchonDessin.BackColor = System.Drawing.Color.Transparent;
            this.bouchonDessin.Image = ((System.Drawing.Image)(resources.GetObject("bouchonDessin.Image")));
            this.bouchonDessin.Location = new System.Drawing.Point(324, 31);
            this.bouchonDessin.Name = "bouchonDessin";
            this.bouchonDessin.Size = new System.Drawing.Size(82, 45);
            this.bouchonDessin.TabIndex = 2;
            this.bouchonDessin.TabStop = false;
            // 
            // liquide
            // 
            this.liquide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.liquide.Location = new System.Drawing.Point(330, 125);
            this.liquide.Name = "liquide";
            this.liquide.Size = new System.Drawing.Size(70, 273);
            this.liquide.TabIndex = 3;
            this.liquide.TabStop = false;
            this.liquide.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // viderTout
            // 
            this.viderTout.Location = new System.Drawing.Point(177, 141);
            this.viderTout.Name = "viderTout";
            this.viderTout.Size = new System.Drawing.Size(107, 23);
            this.viderTout.TabIndex = 4;
            this.viderTout.Text = "Vider tout";
            this.viderTout.UseVisualStyleBackColor = true;
            this.viderTout.Click += new System.EventHandler(this.button1_Click);
            // 
            // remplirTout
            // 
            this.remplirTout.Location = new System.Drawing.Point(177, 112);
            this.remplirTout.Name = "remplirTout";
            this.remplirTout.Size = new System.Drawing.Size(107, 23);
            this.remplirTout.TabIndex = 5;
            this.remplirTout.Text = "Remplir tout";
            this.remplirTout.UseVisualStyleBackColor = true;
            this.remplirTout.Click += new System.EventHandler(this.remplirTout_Click);
            // 
            // ouvrirBouteille
            // 
            this.ouvrirBouteille.Location = new System.Drawing.Point(177, 83);
            this.ouvrirBouteille.Name = "ouvrirBouteille";
            this.ouvrirBouteille.Size = new System.Drawing.Size(107, 23);
            this.ouvrirBouteille.TabIndex = 6;
            this.ouvrirBouteille.Text = "Ouvrir bouteille";
            this.ouvrirBouteille.UseVisualStyleBackColor = true;
            this.ouvrirBouteille.Click += new System.EventHandler(this.ouvrirBouteille_Click);
            // 
            // fermerBouteille
            // 
            this.fermerBouteille.Location = new System.Drawing.Point(177, 170);
            this.fermerBouteille.Name = "fermerBouteille";
            this.fermerBouteille.Size = new System.Drawing.Size(107, 23);
            this.fermerBouteille.TabIndex = 7;
            this.fermerBouteille.Text = "Fermer bouteille";
            this.fermerBouteille.UseVisualStyleBackColor = true;
            this.fermerBouteille.Click += new System.EventHandler(this.fermerBouteille_Click);
            // 
            // quantiteRemplir
            // 
            this.quantiteRemplir.Location = new System.Drawing.Point(64, 83);
            this.quantiteRemplir.Name = "quantiteRemplir";
            this.quantiteRemplir.PlaceholderText = "Quantite a remplir";
            this.quantiteRemplir.Size = new System.Drawing.Size(107, 23);
            this.quantiteRemplir.TabIndex = 8;
            this.quantiteRemplir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantiteVider
            // 
            this.quantiteVider.Location = new System.Drawing.Point(64, 141);
            this.quantiteVider.Name = "quantiteVider";
            this.quantiteVider.PlaceholderText = "Quantite a vider";
            this.quantiteVider.Size = new System.Drawing.Size(107, 23);
            this.quantiteVider.TabIndex = 9;
            this.quantiteVider.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // remplirTant
            // 
            this.remplirTant.Location = new System.Drawing.Point(64, 112);
            this.remplirTant.Name = "remplirTant";
            this.remplirTant.Size = new System.Drawing.Size(107, 23);
            this.remplirTant.TabIndex = 10;
            this.remplirTant.Text = "Remplir tant";
            this.remplirTant.UseVisualStyleBackColor = true;
            this.remplirTant.Click += new System.EventHandler(this.remplirTant_Click);
            // 
            // viderTant
            // 
            this.viderTant.Location = new System.Drawing.Point(64, 170);
            this.viderTant.Name = "viderTant";
            this.viderTant.Size = new System.Drawing.Size(107, 23);
            this.viderTant.TabIndex = 11;
            this.viderTant.Text = "Vider Tant";
            this.viderTant.UseVisualStyleBackColor = true;
            this.viderTant.Click += new System.EventHandler(this.viderTant_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(27, 13);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 12;
            this.error.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantite
            // 
            this.quantite.AutoSize = true;
            this.quantite.Location = new System.Drawing.Point(64, 224);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(12, 15);
            this.quantite.TabIndex = 13;
            this.quantite.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.error);
            this.Controls.Add(this.viderTant);
            this.Controls.Add(this.remplirTant);
            this.Controls.Add(this.quantiteVider);
            this.Controls.Add(this.quantiteRemplir);
            this.Controls.Add(this.fermerBouteille);
            this.Controls.Add(this.ouvrirBouteille);
            this.Controls.Add(this.remplirTout);
            this.Controls.Add(this.viderTout);
            this.Controls.Add(this.bouchonDessin);
            this.Controls.Add(this.liquide);
            this.Controls.Add(this.bouteillPicB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bouteillPicB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bouchonDessin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox bouteillPicB;
        private PictureBox bouchonDessin;
        private PictureBox liquide;
        private Button viderTout;
        private Button remplirTout;
        private Button ouvrirBouteille;
        private Button fermerBouteille;
        private TextBox quantiteRemplir;
        private TextBox quantiteVider;
        private Button remplirTant;
        private Button viderTant;
        private Label error;
        private Label quantite;
    }
}