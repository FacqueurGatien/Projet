namespace CCTextFormatter
{
    public partial class TextFormatter : Form
    {
        private Dictionary<string, GroupBox> gbList;
        public TextFormatter():this("")
        {
        }
        public TextFormatter(string text)
        {
            InitializeComponent();
            gbList = new Dictionary<string, GroupBox>();
            gbList.Add(cbBackColor.Name, gbBackColor);
            gbList.Add(cbFontColor.Name, gbFontColor);
            gbList.Add(cbCasse.Name, gbCasse);
            input.Text = text;
            this.Click += new System.EventHandler(PremierPlan);

        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void OptionChoice_CheckBoxClick(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            gbList[cb.Name].Visible = cb.Checked;
        }
        private void ChangeBackColor(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)sender;
            if (gb.Visible)
            {
                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        show.BackColor = (Color)rb.Tag; ;
                    }
                }
            }
            else
            {
                show.BackColor = (Color)gb.Tag;
            }
        }
        private void ChangeFontColor(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)sender;
            if (gb.Visible)
            {
                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        if (rb.Checked)
                        {
                            show.ForeColor = (Color)rb.Tag;
                        }
                    }
                }
            }
            else
            {
                show.ForeColor = (Color)gb.Tag;
            }
        }
        private void ChangeCasse(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)sender;
            InputChange();
        }
        private void BackColor_RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            show.BackColor = (Color)cb.Tag;
        }
        private void FontColor_RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            show.ForeColor = (Color)cb.Tag;
        }
        private void CasseChoice_RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            if (cb.Checked)
            {
                show.Tag = (bool)cb.Tag;
            }
            ChangeCasse();
        }
        private void InputChange()
        {
            show.Text = input.Text;
            if (gbCasse.Visible)
            {
                ChangeCasse();
            }
            else
            {
                show.Text = input.Text;
            }
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            InputChange();
        }
        private void ChangeCasse()
        {
            if ((bool)show.Tag)
            {
                show.Text = input.Text.ToLower();
            }
            else
            {
                show.Text = input.Text.ToUpper();
            }
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