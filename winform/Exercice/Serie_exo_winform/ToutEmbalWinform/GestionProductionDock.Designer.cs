namespace ToutEmbalWinform
{
    partial class GestionProductionDock
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
            breakButton = new Button();
            continueButton = new Button();
            startButton = new Button();
            SuspendLayout();
            // 
            // breakButton
            // 
            breakButton.BackgroundImage = Properties.Resources.Break;
            breakButton.BackgroundImageLayout = ImageLayout.Zoom;
            breakButton.Dock = DockStyle.Right;
            breakButton.Location = new Point(158, 0);
            breakButton.Name = "breakButton";
            breakButton.Size = new Size(75, 152);
            breakButton.TabIndex = 0;
            breakButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.BackgroundImage = Properties.Resources.Continue;
            continueButton.BackgroundImageLayout = ImageLayout.Zoom;
            continueButton.Dock = DockStyle.Right;
            continueButton.Location = new Point(83, 0);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(75, 152);
            continueButton.TabIndex = 0;
            continueButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.BackgroundImage = Properties.Resources.Start;
            startButton.BackgroundImageLayout = ImageLayout.Zoom;
            startButton.Dock = DockStyle.Right;
            startButton.Location = new Point(6, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(77, 152);
            startButton.TabIndex = 0;
            startButton.UseVisualStyleBackColor = true;
            // 
            // GestionProductionDock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(startButton);
            Controls.Add(continueButton);
            Controls.Add(breakButton);
            Name = "GestionProductionDock";
            Padding = new Padding(5, 0, 5, 0);
            Size = new Size(238, 152);
            Resize += GestionProductionDock_Resize_1;
            ResumeLayout(false);
        }

        #endregion

        private Button breakButton;
        private Button continueButton;
        private Button startButton;
    }
}
