using EEListBox2Model;
using System.Security.Cryptography;

namespace EEListBox2Winform
{
    public partial class ListBoxTransfert : Form
    {
        Dossier source;
        Dossier cible;
        public ListBoxTransfert()
        {
            InitializeComponent();
            OpenForm();
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void OpenForm()
        {
            source = Dossier.DeserialisationDossierBin("Source");
            cible = Dossier.DeserialisationDossierBin("Cible");
            ActualiserListe();
            VerifierBoutton();
        }
        private void ActualiserListe()
        {
            foreach (Fichier f in source.DossierListe)
            {
                comboBoxSource.Items.Add(f);
            }
            foreach (Fichier f in cible.DossierListe)
            {
                listBoxCible.Items.Add(f);
            }

        }
        private void VerifierBoutton()
        {
            if (comboBoxSource.Items.Count > 0)
            {
                buttonVersCibleTout.Enabled = true;
            }
            else
            {
                buttonVersCibleTout.Enabled = false;
            }
            if (listBoxCible.Items.Count > 0)
            {
                buttonVersSourceTout.Enabled = true;
            }
            else
            {
                buttonVersSourceTout.Enabled = false;
            }
        }
        private void CloseForm()
        {
            source.DossierListe.Clear();
            cible.DossierListe.Clear();
            foreach (Fichier f in comboBoxSource.Items)
            {
                source.DossierListe.Add(f);
            }
            foreach (Fichier f in listBoxCible.Items)
            {
                cible.DossierListe.Add(f);
            }
            source.SerialisationDossierBin("Source");
            cible.SerialisationDossierBin("Cible");
        }
        private void SourceVerseCible(Fichier _f)
        {
            listBoxCible.Items.Add(_f);
        }
        private void CibleVersSource(Fichier _f)
        {
            comboBoxSource.Items.Add(_f);
        }
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonVersCible.Enabled = true;
        }
        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonVersSource.Enabled = true;
            if (listBoxCible.Items.Count > 1)
            {
                buttonBas.Enabled = false;
                buttonHaut.Enabled = false;
                if (listBoxCible.SelectedIndex == 0)
                {
                    buttonBas.Enabled = true;

                }
                else if (listBoxCible.SelectedIndex == listBoxCible.Items.Count - 1)
                {
                    buttonHaut.Enabled = true;
                }
                else
                {
                    buttonBas.Enabled = true;
                    buttonHaut.Enabled = true;
                }
            }
            else
            {
                buttonBas.Enabled = false;
                buttonHaut.Enabled = false;
            }

        }
        private void buttonVersCible_Click(object sender, EventArgs e)
        {
            SourceVerseCible((Fichier)comboBoxSource.SelectedItem);
            comboBoxSource.Items.Remove((Fichier)comboBoxSource.SelectedItem);
            comboBoxSource.SelectedItem = false;
            buttonVersCible.Enabled = false;
            VerifierBoutton();
        }
        private void buttonVersCibleTout_Click(object sender, EventArgs e)
        {
            foreach (Fichier f in comboBoxSource.Items)
            {
                SourceVerseCible(f);
            }
            comboBoxSource.Items.Clear();
            VerifierBoutton();
        }
        private void buttonVersSource_Click(object sender, EventArgs e)
        {
            CibleVersSource((Fichier)listBoxCible.SelectedItem);
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            listBoxCible.SelectedItem = false;
            buttonVersSource.Enabled = false;
            VerifierBoutton();
        }
        private void buttonVersSourceTout_Click(object sender, EventArgs e)
        {
            foreach (Fichier f in listBoxCible.Items)
            {
                CibleVersSource(f);
            }
            listBoxCible.Items.Clear();
            VerifierBoutton();
        }
        private void buttonHaut_Click(object sender, EventArgs e)
        {
            Fichier fTemp = (Fichier)listBoxCible.SelectedItem;
            int iTemp = listBoxCible.SelectedIndex - 1;
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            listBoxCible.Items.Insert(iTemp, fTemp);
            listBoxCible.SelectedIndex = iTemp;
        }
        private void buttonBas_Click(object sender, EventArgs e)
        {
            Fichier fTemp = (Fichier)listBoxCible.SelectedItem;
            int iTemp = listBoxCible.SelectedIndex + 1;
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            listBoxCible.Items.Insert(iTemp, fTemp);
            listBoxCible.SelectedIndex = iTemp;
        }
        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Voulez vous quitter?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                CloseForm();
            }
        }
        public void desactivate_FormCosing()
        {
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(Formulaire_FormClosing);
        }
    }
}