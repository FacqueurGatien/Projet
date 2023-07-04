using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbalWinform
{
    public partial class ProgressionBarDock : UserControl
    {
        public ProgressionBarDock()
        {
            InitializeComponent();
        }

        private void ProgressionBarDock_Resize(object sender, EventArgs e)
        {
            progressBar1.Size = new System.Drawing.Size((int)(this.Size.Width / 1.5f), this.Size.Height);
            label1.Size = new System.Drawing.Size(this.Size.Width / 4, this.Size.Height);
            label1.Font = new Font("Segoe UI", this.Size.Height * 0.3f, FontStyle.Bold, GraphicsUnit.Point);
            this.Padding = new System.Windows.Forms.Padding((int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f));

        }

        public ProgressBar ProgressionBar { get => progressBar1; set => progressBar1 = value; }
        public Label ProgressionBarlabel { get => label1; set => label1 = value; }
    }
}
