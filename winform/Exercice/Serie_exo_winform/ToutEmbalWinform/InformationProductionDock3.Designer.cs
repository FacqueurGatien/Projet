namespace ToutEmbalWinform
{
    partial class InformationProductionDock3
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
            InformationProduction1 = new InformationproductionDock();
            InformationProduction2 = new InformationproductionDock();
            InformationProduction3 = new InformationproductionDock();
            SuspendLayout();
            // 
            // InformationProduction1
            // 
            InformationProduction1.Dock = DockStyle.Top;
            InformationProduction1.Location = new Point(0, 0);
            InformationProduction1.MinimumSize = new Size(35, 14);
            InformationProduction1.Name = "InformationProduction1";
            InformationProduction1.Padding = new Padding(9);
            InformationProduction1.Size = new Size(450, 50);
            InformationProduction1.TabIndex = 0;
            // 
            // InformationProduction2
            // 
            InformationProduction2.Dock = DockStyle.Top;
            InformationProduction2.Location = new Point(0, 50);
            InformationProduction2.MinimumSize = new Size(35, 14);
            InformationProduction2.Name = "InformationProduction2";
            InformationProduction2.Padding = new Padding(9);
            InformationProduction2.Size = new Size(450, 50);
            InformationProduction2.TabIndex = 0;
            // 
            // InformationProduction3
            // 
            InformationProduction3.Dock = DockStyle.Top;
            InformationProduction3.Location = new Point(0, 100);
            InformationProduction3.MinimumSize = new Size(35, 14);
            InformationProduction3.Name = "InformationProduction3";
            InformationProduction3.Padding = new Padding(9);
            InformationProduction3.Size = new Size(450, 50);
            InformationProduction3.TabIndex = 0;
            // 
            // InformationProductionDock3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InformationProduction3);
            Controls.Add(InformationProduction2);
            Controls.Add(InformationProduction1);
            Name = "InformationProductionDock3";
            Size = new Size(450, 150);
            Resize += InformationProductionDock3_Resize;
            ResumeLayout(false);
        }

        #endregion
        private InformationproductionDock InformationProduction1;
        private InformationproductionDock InformationProduction2;
        private InformationproductionDock InformationProduction3;
    }
}
