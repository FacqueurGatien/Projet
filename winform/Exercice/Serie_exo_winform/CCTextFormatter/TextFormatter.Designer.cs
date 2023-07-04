namespace CCTextFormatter
{
    partial class TextFormatter
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
            this.gbBackColor = new System.Windows.Forms.GroupBox();
            this.rbBackColorBlue = new System.Windows.Forms.RadioButton();
            this.rbBackColorGreen = new System.Windows.Forms.RadioButton();
            this.rbBackColorRed = new System.Windows.Forms.RadioButton();
            this.gbFontColor = new System.Windows.Forms.GroupBox();
            this.rbFontColorBlack = new System.Windows.Forms.RadioButton();
            this.rbFontColorWhite = new System.Windows.Forms.RadioButton();
            this.rbFontColorRed = new System.Windows.Forms.RadioButton();
            this.gbCasse = new System.Windows.Forms.GroupBox();
            this.rbCasseUpper = new System.Windows.Forms.RadioButton();
            this.rbCasseLower = new System.Windows.Forms.RadioButton();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.cbCasse = new System.Windows.Forms.CheckBox();
            this.cbFontColor = new System.Windows.Forms.CheckBox();
            this.cbBackColor = new System.Windows.Forms.CheckBox();
            this.lTypeText = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.TextBox();
            this.gbBackColor.SuspendLayout();
            this.gbFontColor.SuspendLayout();
            this.gbCasse.SuspendLayout();
            this.gbChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBackColor
            // 
            this.gbBackColor.Controls.Add(this.rbBackColorBlue);
            this.gbBackColor.Controls.Add(this.rbBackColorGreen);
            this.gbBackColor.Controls.Add(this.rbBackColorRed);
            this.gbBackColor.Location = new System.Drawing.Point(22, 159);
            this.gbBackColor.Name = "gbBackColor";
            this.gbBackColor.Size = new System.Drawing.Size(95, 114);
            this.gbBackColor.TabIndex = 0;
            this.gbBackColor.TabStop = false;
            this.gbBackColor.Tag = System.Drawing.Color.WhiteSmoke;
            this.gbBackColor.Text = "Fond";
            this.gbBackColor.Visible = false;
            this.gbBackColor.VisibleChanged += new System.EventHandler(this.ChangeBackColor);
            // 
            // rbBackColorBlue
            // 
            this.rbBackColorBlue.AutoSize = true;
            this.rbBackColorBlue.Location = new System.Drawing.Point(10, 73);
            this.rbBackColorBlue.Name = "rbBackColorBlue";
            this.rbBackColorBlue.Size = new System.Drawing.Size(48, 19);
            this.rbBackColorBlue.TabIndex = 2;
            this.rbBackColorBlue.TabStop = true;
            this.rbBackColorBlue.Tag = System.Drawing.Color.Blue;
            this.rbBackColorBlue.Text = "Bleu";
            this.rbBackColorBlue.UseVisualStyleBackColor = true;
            this.rbBackColorBlue.CheckedChanged += new System.EventHandler(this.BackColor_RadioButtonClick);
            // 
            // rbBackColorGreen
            // 
            this.rbBackColorGreen.AutoSize = true;
            this.rbBackColorGreen.Location = new System.Drawing.Point(10, 48);
            this.rbBackColorGreen.Name = "rbBackColorGreen";
            this.rbBackColorGreen.Size = new System.Drawing.Size(45, 19);
            this.rbBackColorGreen.TabIndex = 1;
            this.rbBackColorGreen.TabStop = true;
            this.rbBackColorGreen.Tag = System.Drawing.Color.Green;
            this.rbBackColorGreen.Text = "Vert";
            this.rbBackColorGreen.UseVisualStyleBackColor = true;
            this.rbBackColorGreen.CheckedChanged += new System.EventHandler(this.BackColor_RadioButtonClick);
            // 
            // rbBackColorRed
            // 
            this.rbBackColorRed.AutoSize = true;
            this.rbBackColorRed.Checked = true;
            this.rbBackColorRed.Location = new System.Drawing.Point(10, 23);
            this.rbBackColorRed.Name = "rbBackColorRed";
            this.rbBackColorRed.Size = new System.Drawing.Size(59, 19);
            this.rbBackColorRed.TabIndex = 0;
            this.rbBackColorRed.TabStop = true;
            this.rbBackColorRed.Tag = System.Drawing.Color.Red;
            this.rbBackColorRed.Text = "Rouge";
            this.rbBackColorRed.UseVisualStyleBackColor = true;
            this.rbBackColorRed.CheckedChanged += new System.EventHandler(this.BackColor_RadioButtonClick);
            // 
            // gbFontColor
            // 
            this.gbFontColor.Controls.Add(this.rbFontColorBlack);
            this.gbFontColor.Controls.Add(this.rbFontColorWhite);
            this.gbFontColor.Controls.Add(this.rbFontColorRed);
            this.gbFontColor.Location = new System.Drawing.Point(123, 159);
            this.gbFontColor.Name = "gbFontColor";
            this.gbFontColor.Size = new System.Drawing.Size(98, 114);
            this.gbFontColor.TabIndex = 1;
            this.gbFontColor.TabStop = false;
            this.gbFontColor.Tag = System.Drawing.Color.Gray;
            this.gbFontColor.Text = "Caractères";
            this.gbFontColor.Visible = false;
            this.gbFontColor.VisibleChanged += new System.EventHandler(this.ChangeFontColor);
            // 
            // rbFontColorBlack
            // 
            this.rbFontColorBlack.AutoSize = true;
            this.rbFontColorBlack.Checked = true;
            this.rbFontColorBlack.Location = new System.Drawing.Point(6, 73);
            this.rbFontColorBlack.Name = "rbFontColorBlack";
            this.rbFontColorBlack.Size = new System.Drawing.Size(48, 19);
            this.rbFontColorBlack.TabIndex = 2;
            this.rbFontColorBlack.TabStop = true;
            this.rbFontColorBlack.Tag = System.Drawing.Color.Black;
            this.rbFontColorBlack.Text = "Noir";
            this.rbFontColorBlack.UseVisualStyleBackColor = true;
            this.rbFontColorBlack.CheckedChanged += new System.EventHandler(this.FontColor_RadioButtonClick);
            // 
            // rbFontColorWhite
            // 
            this.rbFontColorWhite.AutoSize = true;
            this.rbFontColorWhite.Location = new System.Drawing.Point(6, 48);
            this.rbFontColorWhite.Name = "rbFontColorWhite";
            this.rbFontColorWhite.Size = new System.Drawing.Size(54, 19);
            this.rbFontColorWhite.TabIndex = 1;
            this.rbFontColorWhite.TabStop = true;
            this.rbFontColorWhite.Tag = System.Drawing.Color.White;
            this.rbFontColorWhite.Text = "Blanc";
            this.rbFontColorWhite.UseVisualStyleBackColor = true;
            this.rbFontColorWhite.CheckedChanged += new System.EventHandler(this.FontColor_RadioButtonClick);
            // 
            // rbFontColorRed
            // 
            this.rbFontColorRed.AutoSize = true;
            this.rbFontColorRed.Location = new System.Drawing.Point(6, 22);
            this.rbFontColorRed.Name = "rbFontColorRed";
            this.rbFontColorRed.Size = new System.Drawing.Size(59, 19);
            this.rbFontColorRed.TabIndex = 0;
            this.rbFontColorRed.TabStop = true;
            this.rbFontColorRed.Tag = System.Drawing.Color.Red;
            this.rbFontColorRed.Text = "Rouge";
            this.rbFontColorRed.UseVisualStyleBackColor = true;
            this.rbFontColorRed.CheckedChanged += new System.EventHandler(this.FontColor_RadioButtonClick);
            // 
            // gbCasse
            // 
            this.gbCasse.Controls.Add(this.rbCasseUpper);
            this.gbCasse.Controls.Add(this.rbCasseLower);
            this.gbCasse.Location = new System.Drawing.Point(227, 197);
            this.gbCasse.Name = "gbCasse";
            this.gbCasse.Size = new System.Drawing.Size(124, 76);
            this.gbCasse.TabIndex = 2;
            this.gbCasse.TabStop = false;
            this.gbCasse.Tag = true;
            this.gbCasse.Text = "Casse";
            this.gbCasse.Visible = false;
            this.gbCasse.VisibleChanged += new System.EventHandler(this.ChangeCasse);
            // 
            // rbCasseUpper
            // 
            this.rbCasseUpper.AutoSize = true;
            this.rbCasseUpper.Location = new System.Drawing.Point(6, 47);
            this.rbCasseUpper.Name = "rbCasseUpper";
            this.rbCasseUpper.Size = new System.Drawing.Size(84, 19);
            this.rbCasseUpper.TabIndex = 1;
            this.rbCasseUpper.TabStop = true;
            this.rbCasseUpper.Tag = false;
            this.rbCasseUpper.Text = "Majuscules";
            this.rbCasseUpper.UseVisualStyleBackColor = true;
            this.rbCasseUpper.CheckedChanged += new System.EventHandler(this.CasseChoice_RadioButtonClick);
            // 
            // rbCasseLower
            // 
            this.rbCasseLower.AutoSize = true;
            this.rbCasseLower.Checked = true;
            this.rbCasseLower.Location = new System.Drawing.Point(6, 22);
            this.rbCasseLower.Name = "rbCasseLower";
            this.rbCasseLower.Size = new System.Drawing.Size(85, 19);
            this.rbCasseLower.TabIndex = 0;
            this.rbCasseLower.TabStop = true;
            this.rbCasseLower.Tag = true;
            this.rbCasseLower.Text = "Minuscules";
            this.rbCasseLower.UseVisualStyleBackColor = true;
            this.rbCasseLower.CheckedChanged += new System.EventHandler(this.CasseChoice_RadioButtonClick);
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.cbCasse);
            this.gbChoix.Controls.Add(this.cbFontColor);
            this.gbChoix.Controls.Add(this.cbBackColor);
            this.gbChoix.Location = new System.Drawing.Point(310, 12);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(199, 113);
            this.gbChoix.TabIndex = 3;
            this.gbChoix.TabStop = false;
            this.gbChoix.Text = "Choix";
            // 
            // cbCasse
            // 
            this.cbCasse.AutoSize = true;
            this.cbCasse.Location = new System.Drawing.Point(15, 74);
            this.cbCasse.Name = "cbCasse";
            this.cbCasse.Size = new System.Drawing.Size(56, 19);
            this.cbCasse.TabIndex = 2;
            this.cbCasse.Text = "Casse";
            this.cbCasse.UseVisualStyleBackColor = true;
            this.cbCasse.CheckedChanged += new System.EventHandler(this.OptionChoice_CheckBoxClick);
            // 
            // cbFontColor
            // 
            this.cbFontColor.AutoSize = true;
            this.cbFontColor.Location = new System.Drawing.Point(15, 49);
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.Size = new System.Drawing.Size(139, 19);
            this.cbFontColor.TabIndex = 1;
            this.cbFontColor.Text = "Couleur des caractèrs";
            this.cbFontColor.UseVisualStyleBackColor = true;
            this.cbFontColor.CheckedChanged += new System.EventHandler(this.OptionChoice_CheckBoxClick);
            // 
            // cbBackColor
            // 
            this.cbBackColor.AutoSize = true;
            this.cbBackColor.Location = new System.Drawing.Point(15, 24);
            this.cbBackColor.Name = "cbBackColor";
            this.cbBackColor.Size = new System.Drawing.Size(113, 19);
            this.cbBackColor.TabIndex = 0;
            this.cbBackColor.Text = "Couleur du fond";
            this.cbBackColor.UseVisualStyleBackColor = true;
            this.cbBackColor.CheckedChanged += new System.EventHandler(this.OptionChoice_CheckBoxClick);
            // 
            // lTypeText
            // 
            this.lTypeText.AutoSize = true;
            this.lTypeText.Location = new System.Drawing.Point(22, 9);
            this.lTypeText.Name = "lTypeText";
            this.lTypeText.Size = new System.Drawing.Size(95, 15);
            this.lTypeText.TabIndex = 4;
            this.lTypeText.Text = "Tapez votre texte";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(22, 41);
            this.input.Name = "input";
            this.input.PlaceholderText = "Entrez votre texte ici";
            this.input.Size = new System.Drawing.Size(256, 23);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show.ForeColor = System.Drawing.Color.Gray;
            this.show.Location = new System.Drawing.Point(22, 102);
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Size = new System.Drawing.Size(256, 23);
            this.show.TabIndex = 6;
            this.show.Tag = true;
            // 
            // TextFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 303);
            this.Controls.Add(this.show);
            this.Controls.Add(this.input);
            this.Controls.Add(this.lTypeText);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.gbCasse);
            this.Controls.Add(this.gbFontColor);
            this.Controls.Add(this.gbBackColor);
            this.Name = "TextFormatter";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulaire_FormClosing);
            this.gbBackColor.ResumeLayout(false);
            this.gbBackColor.PerformLayout();
            this.gbFontColor.ResumeLayout(false);
            this.gbFontColor.PerformLayout();
            this.gbCasse.ResumeLayout(false);
            this.gbCasse.PerformLayout();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbBackColor;
        private RadioButton rbBackColorBlue;
        private RadioButton rbBackColorGreen;
        private RadioButton rbBackColorRed;
        private GroupBox gbFontColor;
        private RadioButton rbFontColorBlack;
        private RadioButton rbFontColorWhite;
        private RadioButton rbFontColorRed;
        private GroupBox gbCasse;
        private GroupBox gbChoix;
        private CheckBox cbCasse;
        private CheckBox cbFontColor;
        private CheckBox cbBackColor;
        private Label lTypeText;
        private TextBox input;
        private TextBox show;
        private RadioButton rbCasseUpper;
        private RadioButton rbCasseLower;
    }
}