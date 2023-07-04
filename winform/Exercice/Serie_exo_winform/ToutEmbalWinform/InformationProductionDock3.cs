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
    public partial class InformationProductionDock3 : UserControl
    {
        public InformationProductionDock3()
        {
            InitializeComponent();
        }

        private void InformationProductionDock3_Resize(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Size = new Size(this.Size.Height, this.Size.Height/ Controls.Count);
            }
        }
        public InformationproductionDock InfoProd1 { get=>InformationProduction1; set=>InformationProduction1=value; }
        public InformationproductionDock InfoProd2 { get => InformationProduction2; set => InformationProduction2 = value; }
        public InformationproductionDock InfoProd3 { get => InformationProduction3; set => InformationProduction3 = value; }
    }
}
