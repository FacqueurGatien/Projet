using System.Text.RegularExpressions;
using BBSaisieUtilisateur;
using EEListBox2Model;
using GGSytheseEmpruntModel;
using NPOI.OpenXmlFormats.Dml;
using NPOI.SS.Formula.Atp;

namespace GGSytheseEmpruntWinform
{
    public partial class Emprunts : Form
    {
        private Emprunt emprunt;
        private string path;
        public Emprunts()
        {
            path = @"..\..\..\..\GGSytheseEmpruntModel\File\";
            InitializeComponent();
            this.listBoxPeriodicite.SelectedIndexChanged -= new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
            this.listBoxPeriodicite.SelectedItem = listBoxPeriodicite.Items[0];
            this.listBoxPeriodicite.Click += new System.EventHandler(ListClick);
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
            OpenForm("Vide");
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string pattern = "^([\\p{L}]{0,}?([-]{0,1}[\\p{L}]{1,}))$";
            if (Regex.Match(tb.Text, pattern).Success)
            {
                tb.BackColor = Color.LightGreen;
            }
            else if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.LightCoral;
            }
            emprunt.Nom = tb.Text;
            UpdateIHM();
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string pattern = "^[0-9]{3,10}$";
            if (Regex.Match(textBoxCapital.Text, pattern).Success)
            {
                emprunt.CapitalEmprunte = Int64.Parse(tb.Text);
                tb.BackColor = Color.LightGreen;
            }
            else if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.LightCoral;
            }
            emprunt.TauxInteret = 7;
            UpdateIHM();
        }

        private void trackBarDuree_Scroll(object sender, EventArgs e)
        {
            emprunt.DureeEnMoisRemboursement = trackBarDuree.Value * (int)listBoxPeriodicite.Tag;
            UpdateIHM();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            PeriodiciteSwitch();
            trackBarDuree.Value = emprunt.DureeEnMoisRemboursement / (int)listBoxPeriodicite.Tag;
            UpdateIHM();
        }
        private void ListClick(object sender, EventArgs e)
        {
            listBoxPeriodicite.SelectedIndexChanged -= new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
            trackBarReset();
            listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
        }
        private void trackBarReset()
        {
            PeriodiciteSwitch();
            emprunt.DureeEnMoisRemboursement = 1 * ((int)emprunt.Periodicite);
        }
        private void PeriodiciteSwitch()
        {
            switch (listBoxPeriodicite.SelectedItem)
            {
                case "Mensuelle":
                    emprunt.Periodicite = EnumTypePeriodicite.Mensuelle;
                    trackBarDuree.Maximum = 360;
                    listBoxPeriodicite.Tag = 1;
                    break;
                case "Bimestrielle":
                    emprunt.Periodicite = EnumTypePeriodicite.Bimestrielle;
                    trackBarDuree.Maximum = 180;
                    listBoxPeriodicite.Tag = 2;
                    break;
                case "Trimestrielle":
                    emprunt.Periodicite = EnumTypePeriodicite.Trimestrielle;
                    trackBarDuree.Maximum = 120;
                    listBoxPeriodicite.Tag = 3;
                    break;
                case "Semestrielle":
                    emprunt.Periodicite = EnumTypePeriodicite.Semestrielle;
                    trackBarDuree.Maximum = 60;
                    listBoxPeriodicite.Tag = 6;
                    break;
                case "Anuelle":
                    emprunt.Periodicite = EnumTypePeriodicite.Anuelle;
                    trackBarDuree.Maximum = 30;
                    listBoxPeriodicite.Tag = 12;
                    break;
                default:
                    break;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            groupBoxTauxInteret.Tag = (int)rb.Tag;
            emprunt.TauxInteret = (int)groupBoxTauxInteret.Tag;
            UpdateIHM();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            emprunt.UpdateNomEmprunt();
            int compteur = 0;
            string nomFichier = emprunt.NomEmprunt;
            string cheminComplet = path + nomFichier;

            if (File.Exists(cheminComplet + ".emprunt"))
            {
                do
                {
                    compteur++;
                }
                while (File.Exists(cheminComplet + compteur + ".emprunt"));
                SauvegarderEmprunt(nomFichier + compteur);
            }
            else
            {
                SauvegarderEmprunt(nomFichier);
            }
            ChargementEmprunt("Vide");
            UpdateIHM();
        }
        private void SauvegarderEmprunt(string _nom)
        {
            emprunt.SerialisationUniqueBin(_nom);
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            ChargementEmprunt(textBoxOuvrir.Text);

        }
        private void OpenForm(string _nomFichier)
        {
            try
            {
                ChargementEmprunt(_nomFichier);
            }
            catch (Exception)
            {
                emprunt = new(_nomFichier, 100, 120, EnumTypePeriodicite.Trimestrielle, 9);
                SauvegarderEmprunt(emprunt.NomEmprunt);
            }
            UpdateIHM();
        }
        private void ChargementEmprunt(string _nomFichier)
        {
            emprunt = (Emprunt)Emprunt.DeserialisationUniqueBin(_nomFichier);
            textBoxOuvrir.Clear();
            this.textBoxCapital.TextChanged -= new System.EventHandler(textBoxCapital_TextChanged);
            textBoxCapital.Text = emprunt.CapitalEmprunte.ToString();
            textBoxCapital.BackColor = Color.LightGreen;
            this.textBoxCapital.TextChanged += new System.EventHandler(textBoxCapital_TextChanged);
            UpdateIHM();
        }
        private void textBoxOuvrir_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (File.Exists(path + tb.Text + ".emprunt"))
            {
                buttonOuvrir.Enabled = true;
            }
            else
            {
                buttonOuvrir.Enabled = false;
            }
        }

        private void UpdateIHM()
        {
            desactiveEventeHandler();
            if (textBoxNom.Text != emprunt.Nom)
            {
                textBoxNom.Text = emprunt.Nom;
                textBoxNom.BackColor = Color.LightGreen;
            }
            if (textBoxCapital.Text != emprunt.CapitalEmprunte.ToString())
            {
                if (textBoxCapital.BackColor == Color.LightGreen)
                {
                    textBoxCapital.Text = emprunt.CapitalEmprunte.ToString();
                }
            }
            if (listBoxPeriodicite.SelectedItem.ToString() != emprunt.Periodicite.ToString())
            {
                int i = -1;
                do
                {
                    i++;
                    if (listBoxPeriodicite.Items[i].ToString() == emprunt.Periodicite.ToString())
                    {
                        listBoxPeriodicite.SelectedItem = listBoxPeriodicite.Items[i];
                    }
                } while (listBoxPeriodicite.Items[i].ToString() != emprunt.Periodicite.ToString());
                PeriodiciteSwitch();
            }
            if (trackBarDuree.Value * (int)listBoxPeriodicite.Tag != emprunt.DureeEnMoisRemboursement)
            {
                trackBarDuree.Value = emprunt.DureeEnMoisRemboursement / ((int)listBoxPeriodicite.Tag);
            }
            if (labelTrackBarDuree.Text != emprunt.DureeEnMoisRemboursement.ToString())
            {
                labelTrackBarDuree.Text = emprunt.DureeEnMoisRemboursement.ToString();
            }
            if ((int)groupBoxTauxInteret.Tag != emprunt.TauxInteret)
            {
                foreach (RadioButton rb in groupBoxTauxInteret.Controls)
                {
                    if ((int)rb.Tag == emprunt.TauxInteret)
                    {
                        rb.Checked = true;
                    }
                }
            }


            VerifierSiOK();
            ActiveEventHandler();
        }
        private void desactiveEventeHandler()
        {
            textBoxNom.TextChanged -= new System.EventHandler(textBoxNom_TextChanged);
            textBoxCapital.TextChanged -= new System.EventHandler(textBoxCapital_TextChanged);
            trackBarDuree.Scroll -= new System.EventHandler(trackBarDuree_Scroll);
            listBoxPeriodicite.Click -= new System.EventHandler(ListClick);
            listBoxPeriodicite.SelectedIndexChanged -= new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
            foreach (RadioButton rb in groupBoxTauxInteret.Controls)
            {
                rb.Click -= new System.EventHandler(radioButton_CheckedChanged);
            }
        }
        private void ActiveEventHandler()
        {
            textBoxNom.TextChanged += new System.EventHandler(textBoxNom_TextChanged);
            textBoxCapital.TextChanged += new System.EventHandler(textBoxCapital_TextChanged);
            trackBarDuree.Scroll += new System.EventHandler(trackBarDuree_Scroll);
            listBoxPeriodicite.Click += new System.EventHandler(ListClick);
            listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(listBoxPeriodicite_SelectedIndexChanged);
            foreach (RadioButton rb in groupBoxTauxInteret.Controls)
            {
                rb.Click += new System.EventHandler(radioButton_CheckedChanged);
            }
        }
        private void ResetIHM()
        {
            desactiveEventeHandler();
            emprunt.TauxInteret = 7;
            ActiveEventHandler();
        }
        private void VerifierSiOK()
        {
            if (textBoxCapital.BackColor == Color.LightGreen)
            {
                labelNombreRemboursement.Text = emprunt.NombreRemboursement().ToString();
                labelMontantDu.Text = emprunt.MontantRemboursement().ToString();
                if (textBoxNom.BackColor == Color.LightGreen)
                {
                    buttonOK.Enabled = true;
                }
                else
                {
                    buttonOK.Enabled = false;
                }
            }
            else
            {
                labelNombreRemboursement.Text = "--";
                labelMontantDu.Text = "--";
                buttonOK.Enabled = false;
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
