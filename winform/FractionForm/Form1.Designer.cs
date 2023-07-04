namespace FractionForm
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
            this.submitFrac1 = new System.Windows.Forms.Button();
            this.submitFrac2 = new System.Windows.Forms.Button();
            this.numeratorFrac1 = new System.Windows.Forms.TextBox();
            this.numeratorFrac2 = new System.Windows.Forms.TextBox();
            this.denominatorFrac1 = new System.Windows.Forms.TextBox();
            this.denominatorFrac2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.opositButton2 = new System.Windows.Forms.Button();
            this.InvertButton2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.denominator3 = new System.Windows.Forms.Label();
            this.numerator3 = new System.Windows.Forms.Label();
            this.denominator2 = new System.Windows.Forms.Label();
            this.numerator2 = new System.Windows.Forms.Label();
            this.denominator1 = new System.Windows.Forms.Label();
            this.numerator1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.reduceButton2 = new System.Windows.Forms.Button();
            this.opositButton1 = new System.Windows.Forms.Button();
            this.invertButton1 = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.reduceButton1 = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.valueFrac1 = new System.Windows.Forms.Label();
            this.valueFrac2 = new System.Windows.Forms.Label();
            this.valueFrac3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitFrac1
            // 
            this.submitFrac1.Enabled = false;
            this.submitFrac1.Location = new System.Drawing.Point(38, 142);
            this.submitFrac1.Name = "submitFrac1";
            this.submitFrac1.Size = new System.Drawing.Size(100, 23);
            this.submitFrac1.TabIndex = 0;
            this.submitFrac1.Text = "Valider";
            this.submitFrac1.UseVisualStyleBackColor = true;
            this.submitFrac1.Click += new System.EventHandler(this.submitFrac1_Click);
            // 
            // submitFrac2
            // 
            this.submitFrac2.Enabled = false;
            this.submitFrac2.Location = new System.Drawing.Point(605, 142);
            this.submitFrac2.Name = "submitFrac2";
            this.submitFrac2.Size = new System.Drawing.Size(100, 23);
            this.submitFrac2.TabIndex = 2;
            this.submitFrac2.Text = "Valider";
            this.submitFrac2.UseVisualStyleBackColor = true;
            this.submitFrac2.Click += new System.EventHandler(this.submitFrac2_Click);
            // 
            // numeratorFrac1
            // 
            this.numeratorFrac1.Location = new System.Drawing.Point(38, 84);
            this.numeratorFrac1.Name = "numeratorFrac1";
            this.numeratorFrac1.PlaceholderText = "Numerateur";
            this.numeratorFrac1.Size = new System.Drawing.Size(100, 23);
            this.numeratorFrac1.TabIndex = 3;
            this.numeratorFrac1.TextChanged += new System.EventHandler(this.numeratorFrac1_TextChanged);
            // 
            // numeratorFrac2
            // 
            this.numeratorFrac2.Location = new System.Drawing.Point(605, 84);
            this.numeratorFrac2.Name = "numeratorFrac2";
            this.numeratorFrac2.PlaceholderText = "Numerateur";
            this.numeratorFrac2.Size = new System.Drawing.Size(100, 23);
            this.numeratorFrac2.TabIndex = 4;
            this.numeratorFrac2.TextChanged += new System.EventHandler(this.numeratorFrac2_TextChanged);
            // 
            // denominatorFrac1
            // 
            this.denominatorFrac1.Location = new System.Drawing.Point(38, 113);
            this.denominatorFrac1.Name = "denominatorFrac1";
            this.denominatorFrac1.PlaceholderText = "Denominateur";
            this.denominatorFrac1.Size = new System.Drawing.Size(100, 23);
            this.denominatorFrac1.TabIndex = 5;
            this.denominatorFrac1.TextChanged += new System.EventHandler(this.denominatorFrac1_TextChanged);
            // 
            // denominatorFrac2
            // 
            this.denominatorFrac2.Location = new System.Drawing.Point(605, 113);
            this.denominatorFrac2.Name = "denominatorFrac2";
            this.denominatorFrac2.PlaceholderText = "Denominateur";
            this.denominatorFrac2.Size = new System.Drawing.Size(100, 23);
            this.denominatorFrac2.TabIndex = 6;
            this.denominatorFrac2.TextChanged += new System.EventHandler(this.denominatorFrac2_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(163, 84);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Additionner";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Enabled = false;
            this.SubButton.Location = new System.Drawing.Point(269, 84);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(100, 23);
            this.SubButton.TabIndex = 8;
            this.SubButton.Text = "Soustraire";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Enabled = false;
            this.MultiplyButton.Location = new System.Drawing.Point(375, 84);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(100, 23);
            this.MultiplyButton.TabIndex = 9;
            this.MultiplyButton.Text = "Multiplier";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Enabled = false;
            this.DivideButton.Location = new System.Drawing.Point(481, 84);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(100, 23);
            this.DivideButton.TabIndex = 10;
            this.DivideButton.Text = "Diviser";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // opositButton2
            // 
            this.opositButton2.Enabled = false;
            this.opositButton2.Location = new System.Drawing.Point(605, 200);
            this.opositButton2.Name = "opositButton2";
            this.opositButton2.Size = new System.Drawing.Size(100, 23);
            this.opositButton2.TabIndex = 12;
            this.opositButton2.Text = "Oposer";
            this.opositButton2.UseVisualStyleBackColor = true;
            this.opositButton2.Click += new System.EventHandler(this.OpositeButton2_Click);
            // 
            // InvertButton2
            // 
            this.InvertButton2.Enabled = false;
            this.InvertButton2.Location = new System.Drawing.Point(605, 229);
            this.InvertButton2.Name = "InvertButton2";
            this.InvertButton2.Size = new System.Drawing.Size(100, 23);
            this.InvertButton2.TabIndex = 13;
            this.InvertButton2.Text = "Inverser";
            this.InvertButton2.UseVisualStyleBackColor = true;
            this.InvertButton2.Click += new System.EventHandler(this.InvertButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueFrac3);
            this.groupBox1.Controls.Add(this.valueFrac2);
            this.groupBox1.Controls.Add(this.valueFrac1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.denominator3);
            this.groupBox1.Controls.Add(this.numerator3);
            this.groupBox1.Controls.Add(this.denominator2);
            this.groupBox1.Controls.Add(this.numerator2);
            this.groupBox1.Controls.Add(this.denominator1);
            this.groupBox1.Controls.Add(this.numerator1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(163, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // denominator3
            // 
            this.denominator3.AutoSize = true;
            this.denominator3.Location = new System.Drawing.Point(318, 67);
            this.denominator3.Name = "denominator3";
            this.denominator3.Size = new System.Drawing.Size(0, 15);
            this.denominator3.TabIndex = 10;
            this.denominator3.Click += new System.EventHandler(this.label11_Click);
            // 
            // numerator3
            // 
            this.numerator3.AutoSize = true;
            this.numerator3.Location = new System.Drawing.Point(318, 43);
            this.numerator3.Name = "numerator3";
            this.numerator3.Size = new System.Drawing.Size(0, 15);
            this.numerator3.TabIndex = 9;
            this.numerator3.Click += new System.EventHandler(this.label10_Click);
            // 
            // denominator2
            // 
            this.denominator2.AutoSize = true;
            this.denominator2.Location = new System.Drawing.Point(212, 67);
            this.denominator2.Name = "denominator2";
            this.denominator2.Size = new System.Drawing.Size(0, 15);
            this.denominator2.TabIndex = 8;
            // 
            // numerator2
            // 
            this.numerator2.AutoSize = true;
            this.numerator2.Location = new System.Drawing.Point(212, 43);
            this.numerator2.Name = "numerator2";
            this.numerator2.Size = new System.Drawing.Size(0, 15);
            this.numerator2.TabIndex = 7;
            // 
            // denominator1
            // 
            this.denominator1.AutoSize = true;
            this.denominator1.Location = new System.Drawing.Point(106, 67);
            this.denominator1.Name = "denominator1";
            this.denominator1.Size = new System.Drawing.Size(0, 15);
            this.denominator1.TabIndex = 6;
            // 
            // numerator1
            // 
            this.numerator1.AutoSize = true;
            this.numerator1.Location = new System.Drawing.Point(106, 43);
            this.numerator1.Name = "numerator1";
            this.numerator1.Size = new System.Drawing.Size(0, 15);
            this.numerator1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fraction3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fraction2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fraction1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denominateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numerateur";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(269, 9);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 16;
            this.error.Click += new System.EventHandler(this.label6_Click);
            // 
            // reduceButton2
            // 
            this.reduceButton2.Location = new System.Drawing.Point(605, 171);
            this.reduceButton2.Name = "reduceButton2";
            this.reduceButton2.Size = new System.Drawing.Size(100, 23);
            this.reduceButton2.TabIndex = 17;
            this.reduceButton2.Text = "Reduce";
            this.reduceButton2.UseVisualStyleBackColor = true;
            this.reduceButton2.Click += new System.EventHandler(this.reduceButton2_Click);
            // 
            // opositButton1
            // 
            this.opositButton1.Enabled = false;
            this.opositButton1.Location = new System.Drawing.Point(38, 199);
            this.opositButton1.Name = "opositButton1";
            this.opositButton1.Size = new System.Drawing.Size(100, 23);
            this.opositButton1.TabIndex = 12;
            this.opositButton1.Text = "Oposer";
            this.opositButton1.UseVisualStyleBackColor = true;
            this.opositButton1.Click += new System.EventHandler(this.OpositeButton_Click);
            // 
            // invertButton1
            // 
            this.invertButton1.Enabled = false;
            this.invertButton1.Location = new System.Drawing.Point(38, 228);
            this.invertButton1.Name = "invertButton1";
            this.invertButton1.Size = new System.Drawing.Size(100, 23);
            this.invertButton1.TabIndex = 13;
            this.invertButton1.Text = "Inverser";
            this.invertButton1.UseVisualStyleBackColor = true;
            this.invertButton1.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(320, 122);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculer";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.GetValueButton_Click);
            // 
            // reduceButton1
            // 
            this.reduceButton1.Location = new System.Drawing.Point(38, 170);
            this.reduceButton1.Name = "reduceButton1";
            this.reduceButton1.Size = new System.Drawing.Size(100, 23);
            this.reduceButton1.TabIndex = 17;
            this.reduceButton1.Text = "Reduce";
            this.reduceButton1.UseVisualStyleBackColor = true;
            this.reduceButton1.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(320, 285);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 23);
            this.quitButton.TabIndex = 18;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valeur calculé";
            // 
            // valueFrac1
            // 
            this.valueFrac1.AutoSize = true;
            this.valueFrac1.Location = new System.Drawing.Point(106, 95);
            this.valueFrac1.Name = "valueFrac1";
            this.valueFrac1.Size = new System.Drawing.Size(0, 15);
            this.valueFrac1.TabIndex = 12;
            // 
            // valueFrac2
            // 
            this.valueFrac2.AutoSize = true;
            this.valueFrac2.Location = new System.Drawing.Point(212, 95);
            this.valueFrac2.Name = "valueFrac2";
            this.valueFrac2.Size = new System.Drawing.Size(0, 15);
            this.valueFrac2.TabIndex = 13;
            // 
            // valueFrac3
            // 
            this.valueFrac3.AutoSize = true;
            this.valueFrac3.Location = new System.Drawing.Point(318, 95);
            this.valueFrac3.Name = "valueFrac3";
            this.valueFrac3.Size = new System.Drawing.Size(0, 15);
            this.valueFrac3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.reduceButton1);
            this.Controls.Add(this.reduceButton2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.invertButton1);
            this.Controls.Add(this.opositButton1);
            this.Controls.Add(this.InvertButton2);
            this.Controls.Add(this.opositButton2);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.denominatorFrac2);
            this.Controls.Add(this.denominatorFrac1);
            this.Controls.Add(this.numeratorFrac2);
            this.Controls.Add(this.numeratorFrac1);
            this.Controls.Add(this.submitFrac2);
            this.Controls.Add(this.submitFrac1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitFrac1;
        private Button submitFrac2;
        private TextBox numeratorFrac1;
        private TextBox numeratorFrac2;
        private TextBox denominatorFrac1;
        private TextBox denominatorFrac2;
        private Button AddButton;
        private Button SubButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button opositButton2;
        private Button InvertButton2;
        private GroupBox groupBox1;
        private Label denominator3;
        private Label numerator3;
        private Label denominator2;
        private Label numerator2;
        private Label denominator1;
        private Label numerator1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label error;
        private Button reduceButton2;
        private Button opositButton1;
        private Button invertButton1;
        private Button calculateButton;
        private Button reduceButton1;
        private Button quitButton;
        private Label valueFrac3;
        private Label valueFrac2;
        private Label valueFrac1;
        private Label label6;
    }
}