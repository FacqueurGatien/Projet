namespace ZZZTchatWinform
{
    partial class ClientTchat
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
            buttonEnvoyer = new Button();
            textBoxEcrir = new TextBox();
            richTextBoxTchat = new RichTextBox();
            SuspendLayout();
            // 
            // buttonEnvoyer
            // 
            buttonEnvoyer.Dock = DockStyle.Left;
            buttonEnvoyer.Enabled = false;
            buttonEnvoyer.Location = new Point(390, 337);
            buttonEnvoyer.Name = "buttonEnvoyer";
            buttonEnvoyer.Size = new Size(94, 113);
            buttonEnvoyer.TabIndex = 5;
            buttonEnvoyer.Text = "Envoyer";
            buttonEnvoyer.UseVisualStyleBackColor = true;
            buttonEnvoyer.Click += buttonEnvoyer_Click;
            // 
            // textBoxEcrir
            // 
            textBoxEcrir.Dock = DockStyle.Left;
            textBoxEcrir.Location = new Point(0, 337);
            textBoxEcrir.Multiline = true;
            textBoxEcrir.Name = "textBoxEcrir";
            textBoxEcrir.Size = new Size(390, 113);
            textBoxEcrir.TabIndex = 4;
            textBoxEcrir.TextChanged += textBoxEcrir_TextChanged;
            // 
            // richTextBoxTchat
            // 
            richTextBoxTchat.BackColor = Color.White;
            richTextBoxTchat.Dock = DockStyle.Top;
            richTextBoxTchat.Location = new Point(0, 0);
            richTextBoxTchat.Name = "richTextBoxTchat";
            richTextBoxTchat.ReadOnly = true;
            richTextBoxTchat.Size = new Size(486, 337);
            richTextBoxTchat.TabIndex = 6;
            richTextBoxTchat.Text = "";
            // 
            // ClientTchat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(buttonEnvoyer);
            Controls.Add(textBoxEcrir);
            Controls.Add(richTextBoxTchat);
            Name = "ClientTchat";
            Text = "ClientTchat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnvoyer;
        private TextBox textBoxEcrir;
        private RichTextBox richTextBoxTchat;
    }
}