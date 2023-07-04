namespace ToutEmbalWinform
{
    partial class GestionProductionLabel1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            gestionProductionDock1 = new GestionProductionDock();
            label1 = new Label();
            SuspendLayout();
            // 
            // gestionProductionDock1
            // 
            gestionProductionDock1.Dock = DockStyle.Top;
            gestionProductionDock1.Location = new Point(0, 0);
            gestionProductionDock1.Name = "gestionProductionDock1";
            gestionProductionDock1.Padding = new Padding(5, 0, 0, 0);
            gestionProductionDock1.Size = new Size(229, 140);
            gestionProductionDock1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 140);
            label1.Name = "label1";
            label1.Size = new Size(229, 60);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // GestionProductionLabel1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(label1);
            Controls.Add(gestionProductionDock1);
            Name = "GestionProductionLabel1";
            Size = new Size(229, 200);
            Resize += GestionProductionLabel1_Resize_1;
            ResumeLayout(false);
        }

        #endregion

        private GestionProductionDock gestionProductionDock1;
        private Label label1;
    }
}
