namespace FFColorPreview
{
    public partial class ColorPreview : Form
    {
        Dictionary<TrackBar, NumericUpDown> tracBarAssociation;
        Dictionary<NumericUpDown, TrackBar> numericUpDownAssociation;
        Color colorMain;
        public ColorPreview()
        {
            InitializeComponent();
            colorMain = Color.Transparent;
            tracBarAssociation = new Dictionary<TrackBar, NumericUpDown>();
            tracBarAssociation.Add(trackBarRouge, numericUpDownRouge);
            tracBarAssociation.Add(trackBarVert, numericUpDownVert);
            tracBarAssociation.Add(trackBarBleu, numericUpDownBleu);
            tracBarAssociation.Add(trackBarAlpha, numericUpDownAlpha);

            numericUpDownAssociation = new Dictionary<NumericUpDown, TrackBar>();
            numericUpDownAssociation.Add(numericUpDownRouge, trackBarRouge);
            numericUpDownAssociation.Add(numericUpDownVert, trackBarVert);
            numericUpDownAssociation.Add(numericUpDownBleu, trackBarBleu);
            numericUpDownAssociation.Add(numericUpDownAlpha, trackBarAlpha);
            ChangeColor();
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            tracBarAssociation[tb].Value = tb.Value;
            ChangeColor();
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            numericUpDownAssociation[nud].Value = Decimal.ToInt32(nud.Value);
            ChangeColor();
        }
        private void ChangeColor()
        {
            colorMain = Color.FromArgb(trackBarAlpha.Value, trackBarRouge.Value, trackBarVert.Value, trackBarBleu.Value);
            panelPreview.BackColor=colorMain;
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