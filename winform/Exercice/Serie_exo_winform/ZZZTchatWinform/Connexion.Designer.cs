namespace ZZZTchatWinform
{
    partial class Connexion
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
            groupBoxIp = new GroupBox();
            textBoxIp = new TextBox();
            panel1 = new Panel();
            groupBoxPseudo = new GroupBox();
            textBoxPseudo = new TextBox();
            groupBoxPort = new GroupBox();
            textBoxPort = new TextBox();
            buttonStart = new Button();
            groupBoxIp.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxPseudo.SuspendLayout();
            groupBoxPort.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIp
            // 
            groupBoxIp.Controls.Add(textBoxIp);
            groupBoxIp.Dock = DockStyle.Top;
            groupBoxIp.Location = new Point(0, 0);
            groupBoxIp.Name = "groupBoxIp";
            groupBoxIp.Size = new Size(250, 63);
            groupBoxIp.TabIndex = 1;
            groupBoxIp.TabStop = false;
            groupBoxIp.Text = "IP";
            // 
            // textBoxIp
            // 
            textBoxIp.Dock = DockStyle.Left;
            textBoxIp.Location = new Point(3, 19);
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(121, 23);
            textBoxIp.TabIndex = 1;
            textBoxIp.Text = "127.0.0.1";
            textBoxIp.TextChanged += textBoxIp_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxPseudo);
            panel1.Controls.Add(groupBoxPort);
            panel1.Controls.Add(groupBoxIp);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 196);
            panel1.TabIndex = 4;
            // 
            // groupBoxPseudo
            // 
            groupBoxPseudo.Controls.Add(textBoxPseudo);
            groupBoxPseudo.Dock = DockStyle.Top;
            groupBoxPseudo.Location = new Point(0, 126);
            groupBoxPseudo.Name = "groupBoxPseudo";
            groupBoxPseudo.Size = new Size(250, 63);
            groupBoxPseudo.TabIndex = 1;
            groupBoxPseudo.TabStop = false;
            groupBoxPseudo.Text = "Pseudo";
            // 
            // textBoxPseudo
            // 
            textBoxPseudo.Dock = DockStyle.Left;
            textBoxPseudo.Location = new Point(3, 19);
            textBoxPseudo.Name = "textBoxPseudo";
            textBoxPseudo.Size = new Size(121, 23);
            textBoxPseudo.TabIndex = 1;
            textBoxPseudo.Text = "kita";
            textBoxPseudo.TextChanged += textBoxPseudo_TextChanged;
            // 
            // groupBoxPort
            // 
            groupBoxPort.Controls.Add(textBoxPort);
            groupBoxPort.Dock = DockStyle.Top;
            groupBoxPort.Location = new Point(0, 63);
            groupBoxPort.Name = "groupBoxPort";
            groupBoxPort.Size = new Size(250, 63);
            groupBoxPort.TabIndex = 0;
            groupBoxPort.TabStop = false;
            groupBoxPort.Text = "Port";
            // 
            // textBoxPort
            // 
            textBoxPort.Dock = DockStyle.Left;
            textBoxPort.Location = new Point(3, 19);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(121, 23);
            textBoxPort.TabIndex = 1;
            textBoxPort.Text = "1111";
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Right;
            buttonStart.Location = new Point(249, 0);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(84, 196);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Connection";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 196);
            Controls.Add(panel1);
            Controls.Add(buttonStart);
            Name = "Connexion";
            Text = "Connexion";
            groupBoxIp.ResumeLayout(false);
            groupBoxIp.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxPseudo.ResumeLayout(false);
            groupBoxPseudo.PerformLayout();
            groupBoxPort.ResumeLayout(false);
            groupBoxPort.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIp;
        private TextBox textBoxIp;
        private Panel panel1;
        private GroupBox groupBoxPseudo;
        private TextBox textBoxPseudo;
        private GroupBox groupBoxPort;
        private TextBox textBoxPort;
        private Button buttonStart;
    }
}