using System.Text.RegularExpressions;

namespace DDListBox
{
    public partial class ListManagement : Form
    {
        public ListManagement()
        {
            InitializeComponent();
            tbItemCount.Text = lbList.Items.Count.ToString();
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void AddListInput()
        {
            lbList.Items.Add(tbAddList.Text.Trim(' '));
        }
        private void ClearListInput()
        {
            tbAddList.Clear();
        }
        private void LbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            ChangeTexteIndex(lb.SelectedIndex);
            tbIndexElement.Clear();
        }
        private void TbAddList_TextChanged(object sender, EventArgs e)
        {
            if (tbAddList.Text.Trim(' ').Length != 0 && !lbList.Items.Contains(tbAddList.Text))
            {
                bAddList.Enabled = true;
            }
            else
            {
                bAddList.Enabled=false;
            }
        }
        private void TbIndexElement_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string pattern = "^[0-9]*$";
            if (tb.Text.Length > 0 && Regex.Match(tb.Text,pattern).Success && lbList.Items.Count > int.Parse(tb.Text))
            {
                bSelection.Enabled = true;
            }
            else
            {
                bSelection.Enabled=false;
            }
        }
        private void ChangeTexteIndex(int _index)
        {
            tbIndexSelect.Text = _index.ToString();
            tbText.Text = lbList.Items[_index].ToString();
        }
        private void BSelection_Click(object sender, EventArgs e)
        {
            ChangeTexteIndex(int.Parse(tbIndexElement.Text));
            bSelection.Enabled = false;
            tbIndexElement.Clear();
        }
        private void BVider_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            bVider.Enabled = false;
            tbItemCount.Text = lbList.Items.Count.ToString();
            tbIndexElement.Clear();
            tbIndexSelect.Clear();
            tbText.Clear();
        }
        private void BAddList_Click(object sender, EventArgs e)
        {
            AddListInput();
            bVider.Enabled = true;
            tbItemCount.Text = lbList.Items.Count.ToString();
            bAddList.Enabled = false;
            ClearListInput();
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