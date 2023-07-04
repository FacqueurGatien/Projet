namespace FFColorPreviewAlternativeMVC
{
    public partial class ColorPreviewAlternative : Form
    {
        private Color colorMain;
        public ColorPreviewAlternative()
        {
            InitializeComponent();
            colorMain = Color.FromArgb(0,0,0,0);
            UpdateIHM();
        }
        public ColorPreviewAlternative(Color _color)
        {
            InitializeComponent();
            colorMain = Color.FromArgb(0, 0, 0, 0);
            UpdateIHM();
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            switch (tb.Name)
            {
                case "trackBarRouge":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, tb.Value, trackBarVert.Value, trackBarBleu.Value);
                    break;
                case "trackBarVert":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, tb.Value, trackBarBleu.Value);
                    break;
                case "trackBarBleu":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, trackBarVert.Value, tb.Value);
                    break;
                case "trackBarAlpha":
                    colorMain = Color.FromArgb(tb.Value, trackBarRouge.Value, trackBarVert.Value, trackBarBleu.Value);
                    break;
                default:
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, trackBarVert.Value, trackBarBleu.Value);
                    break;
            }
            UpdateIHM();
        }
        private void NumericUp_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            switch (nud.Name)
            {

                case "numericUpDownRouge":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, decimal.ToInt32(nud.Value), trackBarVert.Value , trackBarBleu.Value);
                    break;
                case "numericUpDownVert":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, decimal.ToInt32(nud.Value), trackBarBleu.Value);
                    break;
                case "numericUpDownBleu":
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, trackBarVert.Value, decimal.ToInt32(nud.Value));
                    break;
                case "numericUpDownAlpha":
                    colorMain = Color.FromArgb(decimal.ToInt32(nud.Value), trackBarRouge.Value, trackBarVert.Value, trackBarBleu.Value);
                    break;
                default:
                    colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, trackBarVert.Value, trackBarBleu.Value);
                    break;
            }
            UpdateIHM();
        }
        private void ChangeNumericValue(NumericUpDown _nud,int _cv)
        {
            _nud.ValueChanged -= new System.EventHandler(this.NumericUp_ValueChanged);
            _nud.Value = _cv;
            _nud.ValueChanged += new System.EventHandler(this.NumericUp_ValueChanged);
        }
        private void UpdateIHM()
        {
            if (colorMain.R != trackBarRouge.Value || colorMain.R != decimal.ToInt32(numericUpDownRouge.Value))
            {
                trackBarRouge.Value = colorMain.R;
                ChangeNumericValue(numericUpDownRouge, colorMain.R);
            }
            if (colorMain.G != trackBarVert.Value || colorMain.G != decimal.ToInt32(numericUpDownVert.Value))
            {
                trackBarVert.Value = colorMain.G;
                ChangeNumericValue(numericUpDownVert, colorMain.G);
            }
            if (colorMain.B != trackBarBleu.Value || colorMain.B != decimal.ToInt32(numericUpDownBleu.Value))
            {
                trackBarBleu.Value = colorMain.B;
                ChangeNumericValue(numericUpDownBleu, colorMain.B);
            }
            if (colorMain.A != trackBarAlpha.Value || colorMain.A != decimal.ToInt32(numericUpDownAlpha.Value))
            {
                trackBarAlpha.Value = colorMain.A;
                ChangeNumericValue(numericUpDownAlpha, colorMain.A);
            }
            panelPreview.BackColor = colorMain;
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