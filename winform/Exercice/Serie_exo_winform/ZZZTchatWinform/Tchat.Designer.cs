namespace ZZZTchatWinform
{
    partial class Tchat
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
            panel1 = new Panel();
            groupBoxPseudo = new GroupBox();
            textBoxPseudo = new TextBox();
            groupBoxPort = new GroupBox();
            textBoxPort = new TextBox();
            groupBoxIp = new GroupBox();
            textBoxIp = new TextBox();
            buttonStart = new Button();
            panel1.SuspendLayout();
            groupBoxPseudo.SuspendLayout();
            groupBoxPort.SuspendLayout();
            groupBoxIp.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxPseudo);
            panel1.Controls.Add(groupBoxPort);
            panel1.Controls.Add(groupBoxIp);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 191);
            panel1.TabIndex = 1;
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
            textBoxPseudo.Text = "server";
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
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Right;
            buttonStart.Location = new Point(252, 0);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(84, 191);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Lancer Server";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Tchat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 191);
            Controls.Add(buttonStart);
            Controls.Add(panel1);
            Name = "Tchat";
            Text = "²²";
            panel1.ResumeLayout(false);
            groupBoxPseudo.ResumeLayout(false);
            groupBoxPseudo.PerformLayout();
            groupBoxPort.ResumeLayout(false);
            groupBoxPort.PerformLayout();
            groupBoxIp.ResumeLayout(false);
            groupBoxIp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBoxPort;
        private TextBox textBoxIp;
        private TextBox textBoxPort;
        private GroupBox groupBoxPseudo;
        private TextBox textBoxPseudo;
        private GroupBox groupBoxIp;
        private Button buttonStart;
    }
}