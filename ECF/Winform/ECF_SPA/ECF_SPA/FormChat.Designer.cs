namespace ECF_SPA
{
    partial class FormChat
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
            labelPuce = new Label();
            textBoxPuce = new TextBox();
            labelNom = new Label();
            textBoxNom = new TextBox();
            labelAge = new Label();
            labelRace = new Label();
            comboBoxRace = new ComboBox();
            buttonModifier = new Button();
            numericUpDownAge = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // labelPuce
            // 
            labelPuce.AutoSize = true;
            labelPuce.Location = new Point(29, 27);
            labelPuce.Name = "labelPuce";
            labelPuce.Size = new Size(33, 15);
            labelPuce.TabIndex = 0;
            labelPuce.Text = "Puce";
            // 
            // textBoxPuce
            // 
            textBoxPuce.Location = new Point(68, 24);
            textBoxPuce.Name = "textBoxPuce";
            textBoxPuce.ReadOnly = true;
            textBoxPuce.Size = new Size(259, 23);
            textBoxPuce.TabIndex = 1;
            textBoxPuce.TextChanged += textBoxRef_TextChanged;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(28, 82);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 2;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(68, 79);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(111, 23);
            textBoxNom.TabIndex = 3;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(224, 87);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(28, 132);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 6;
            labelRace.Text = "Race";
            // 
            // comboBoxRace
            // 
            comboBoxRace.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(68, 129);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(144, 23);
            comboBoxRace.TabIndex = 7;
            comboBoxRace.SelectedIndexChanged += comboBoxRace_SelectedIndexChanged;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(275, 172);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(90, 30);
            buttonModifier.TabIndex = 8;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(258, 82);
            numericUpDownAge.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 9;
            numericUpDownAge.ValueChanged += numericUpDownAge_ValueChanged;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 228);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonModifier);
            Controls.Add(comboBoxRace);
            Controls.Add(labelRace);
            Controls.Add(labelAge);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Controls.Add(textBoxPuce);
            Controls.Add(labelPuce);
            Name = "FormChat";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuce;
        private TextBox textBoxPuce;
        private Label labelNom;
        private TextBox textBoxNom;
        private Label labelAge;
        private Label labelRace;
        private ComboBox comboBoxRace;
        private Button buttonModifier;
        private NumericUpDown numericUpDownAge;
    }
}