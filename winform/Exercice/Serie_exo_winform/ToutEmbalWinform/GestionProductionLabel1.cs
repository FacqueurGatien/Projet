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
    public partial class GestionProductionLabel1 : UserControl
    {
        public GestionProductionLabel1()
        {
            InitializeComponent();
        }

        private void GestionProductionLabel1_Resize_1(object sender, EventArgs e)
        {
            gestionProductionDock1.Size = new Size(this.Size.Width, (int)(this.Size.Height / 1.2));
            label1.Size = new Size(this.Size.Width, (int)(this.Size.Height / 6));
            label1.Font = new Font("Segoe UI", this.Size.Height * 0.1f, FontStyle.Bold, GraphicsUnit.Point);
            int temp = this.Width + 10;
            this.Resize -= GestionProductionLabel1_Resize_1;
            this.Size = new Size(temp, this.Height);
            this.Resize += GestionProductionLabel1_Resize_1;
        }

        public GestionProductionDock GestionProd { get => gestionProductionDock1; set => gestionProductionDock1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}
