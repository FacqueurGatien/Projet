using NPOI.OpenXmlFormats.Wordprocessing;
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
    public partial class InformationproductionDock : UserControl
    {
        public InformationproductionDock()
        {
            InitializeComponent();
        }

        private void InformationproductionDock_Resize(object sender, EventArgs e)
        {
            /*            foreach (Control c in Controls)
                        {
                            c.Size = new Size(c.Size.Width, this.Size.Height / Controls.Count);
                            c.Font = new Font("Segoe UI", this.Size.Height * 0.5f, FontStyle.Regular, GraphicsUnit.Point);
                            if (c.Controls.Count > 0)
                            {
                                foreach (Control cP in c.Controls)
                                {
                                    cP.Size = new Size(c.Size.Width / c.Controls.Count, c.Size.Height / c.Controls.Count);
                                    cP.Font = new Font("Segoe UI", this.Size.Height * 0.5f, FontStyle.Regular, GraphicsUnit.Point);
                                }
                            }
                        }*/

            textBox1.Size = new System.Drawing.Size(this.Size.Width / 3, this.Size.Height / Controls.Count);
            label1.Size = new System.Drawing.Size((int)(this.Size.Width / 1.5), this.Size.Height / Controls.Count);
            textBox1.Font = new Font("Segoe UI", this.Size.Height * 0.2f, FontStyle.Regular, GraphicsUnit.Point);
            label1.Font = new Font("Segoe UI", this.Size.Height * 0.2f, FontStyle.Regular, GraphicsUnit.Point);
            this.Padding = new System.Windows.Forms.Padding((int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f), (int)(this.label1.Height * 0.3f));
        }
        public Label LabelInfo { get => label1; set => label1 = value; }
        public TextBox TextBoxInfo { get => textBox1; set => textBox1 = value; }
    }
}
