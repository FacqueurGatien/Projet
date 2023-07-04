using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTextFormatter;
using HHPhase4;

namespace HHPhase4Winform
{
    public partial class InputText : Form
    {
        Phase4 p4;
        public InputText()
        {
            InitializeComponent();
        }
        public string GetInputText()
        {
            return textBoxInputText.Text;
        }
        private void textBoxInputText_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            buttonInputText.Enabled = tb.Text.Length > 0;
        }

        private void buttonInputText_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void desactivate_FormCosing()
        {
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(Formulaire_FormClosing);
        }
    }
}
