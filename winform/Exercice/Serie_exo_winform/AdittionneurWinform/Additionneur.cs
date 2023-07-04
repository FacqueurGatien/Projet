namespace AdittionneurWinform
{
    using Operations;
    public partial class Additionneur : Form
    {

        Operation addition;
        public Additionneur()
        {
            InitializeComponent();
            addition = new Operation();
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender , EventArgs e)
        {
            this.TopMost= true;
        }
        private void Nb_Click(object sender, EventArgs e)
        {
            if (!this.calculer.Enabled && addition.NumList.Count()>0)
            {
                this.calculer.Enabled = true;
            }
            if (!this.vider.Enabled)
            {
                this.vider.Enabled = true;
            }
            Button button = sender as Button;
            addition.Ajouter(int.Parse(button.Text));
            this.afficheur.Text += $"{button.Text}+";
        }
        private void Calculer_Click(object sender, EventArgs e)
        {
            this.afficheur.Text += $" ={addition.ResultatAddition()}+";
        }
        private void vider_Click(object sender, EventArgs e)
        {
            addition.Vider();
            this.afficheur.Text = "";
            this.calculer.Enabled = false;
            this.vider.Enabled = false;
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