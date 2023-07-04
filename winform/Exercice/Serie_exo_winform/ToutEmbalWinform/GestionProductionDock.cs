using NPOI.Util;
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
    public partial class GestionProductionDock : UserControl
    {
        public GestionProductionDock()
        {
            InitializeComponent();
        }

        private void GestionProductionDock_Resize_1(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Size = new Size(this.Size.Width / this.Controls.Count, this.Size.Height);
            }
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
        }

        public Button BreakButton { get => breakButton; set => breakButton = value; }
        public Button ContinueButton { get => continueButton; set => continueButton = value; }
        public Button StartButton { get => startButton; set => startButton = value; }
    }
}
