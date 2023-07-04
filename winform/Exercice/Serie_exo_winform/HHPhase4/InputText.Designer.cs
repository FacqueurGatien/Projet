namespace HHPhase4Winform
{
    partial class InputText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInputText = new Label();
            textBoxInputText = new TextBox();
            buttonInputText = new Button();
            SuspendLayout();
            // 
            // labelInputText
            // 
            labelInputText.AutoSize = true;
            labelInputText.Location = new Point(12, 9);
            labelInputText.Name = "labelInputText";
            labelInputText.Size = new Size(95, 15);
            labelInputText.TabIndex = 0;
            labelInputText.Text = "Tapez votre texte";
            // 
            // textBoxInputText
            // 
            textBoxInputText.Location = new Point(12, 27);
            textBoxInputText.Name = "textBoxInputText";
            textBoxInputText.Size = new Size(294, 23);
            textBoxInputText.TabIndex = 1;
            textBoxInputText.TextChanged += textBoxInputText_TextChanged;
            // 
            // buttonInputText
            // 
            buttonInputText.Location = new Point(331, 26);
            buttonInputText.Name = "buttonInputText";
            buttonInputText.Size = new Size(95, 24);
            buttonInputText.TabIndex = 2;
            buttonInputText.Text = "Valider";
            buttonInputText.UseVisualStyleBackColor = true;
            buttonInputText.Click += buttonInputText_Click;
            // 
            // InputText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 78);
            Controls.Add(buttonInputText);
            Controls.Add(textBoxInputText);
            Controls.Add(labelInputText);
            Name = "InputText";
            Text = "InputText";
            FormClosing += Formulaire_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInputText;
        private TextBox textBoxInputText;
        private Button buttonInputText;
    }
}