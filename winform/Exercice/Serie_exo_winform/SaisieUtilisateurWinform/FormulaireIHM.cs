using BBErrorPersonalise;
using BBSaisieUtilisateur;
using BBSaisieUtilisateurWinform;
using SaisieUtilisateurModel;
using System.Globalization;

namespace SaisieUtilisateurWinform
{
    public partial class FormulaireIHM : Form
    {
        Dictionary<string, ErrorProvider> epList;
        List<TextBox> tbList;
        Formulaire formulaire;
        public FormulaireIHM()
        {
            InitializeComponent();
            epList = new Dictionary<string, ErrorProvider>();
            formulaire = new Formulaire();
            epList.Add(tbNom.Name, epNom);
            epList.Add(tbDate.Name, epDate);
            epList.Add(tbMontant.Name, epMontant);
            epList.Add(tbCodePostal.Name, epCodePostal);
            tbList = new List<TextBox>() { tbNom, tbDate, tbMontant, tbCodePostal };
            this.Click += new System.EventHandler(PremierPlan);
        }
        private void PremierPlan(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void ControlButtonValiderEffacer()
        {
            valider.Enabled = true;
            effacer.Enabled = false;
            foreach (var tb in tbList)
            {
                if (tb.BackColor != Color.LightGreen)
                {
                    valider.Enabled = false;
                }
                if (tb.Text.Length >= 1)
                {
                    effacer.Enabled = true;
                }
            }
        }
        private void TextErrorShow(ErrorProvider _error, string _messageError, TextBox _textBox)
        {
            _error.SetError(_textBox, _messageError);
            _textBox.BackColor = Color.LightCoral;
        }
        private void NoError(TextBox _textBox)
        {
            _textBox.BackColor = Color.LightGreen;
            epList[_textBox.Name].Clear();
            ControlButtonValiderEffacer();
        }
        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string errorTemp = "";
            if (textBox.Text.Length == 0)
            {
                textBox.BackColor = Color.White;
                epList[textBox.Name].Clear();
            }
            else
            {
                try
                {
                    SaisieUtilisateur.ControleSaisieStringNomPrenom(textBox.Text);
                    NoError(textBox);
                }
                catch (NameFormatException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                try
                {
                    SaisieUtilisateur.ControleSaisieStringLimite(textBox.Text, 30);
                    NoError(textBox);
                }
                catch (StringLimitException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                if (errorTemp.Length != 0)
                {
                    TextErrorShow(epList[textBox.Name], errorTemp, textBox);
                }
            }

        }
        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 0)
            {
                textBox.BackColor = Color.White;
                epList[textBox.Name].Clear();
            }
            else
            {
                try
                {
                    SaisieUtilisateur.ControleSaisieDateFutur(SaisieUtilisateur.ControleSaisieDate(textBox.Text));
                    NoError(textBox);
                }
                catch (DateFormatException ex)
                {
                    TextErrorShow(epList[textBox.Name], ex.Message, textBox);
                }
                catch (DateWasNotFuturException ex)
                {
                    TextErrorShow(epList[textBox.Name], ex.Message, textBox);
                }
            }

        }
        private void tbMontant_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string errorTemp = "";
            float? nbTemp = null;
            string[] floatArrayTemp = textBox.Text.Split(',');
            if (textBox.Text.Length == 0)
            {
                textBox.BackColor = Color.White;
                epList[textBox.Name].Clear();
            }
            else
            {
                try
                {
                    nbTemp = SaisieUtilisateur.ControleSaisieFloat(textBox.Text);
                    NoError(textBox);
                }
                catch (DecimalFormatException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                if (nbTemp != null)
                {
                    try
                    {
                        SaisieUtilisateur.ControleDecimalAbsolute(nbTemp);
                        NoError(textBox);
                    }
                    catch (DecimalAbsoluteException ex)
                    {
                        errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                    }
                }
                if (floatArrayTemp.Length > 0 && floatArrayTemp[0] != "")
                {
                    try
                    {
                        SaisieUtilisateur.ControleSaisieStringNumericDecimalInt(floatArrayTemp[0]);
                        NoError(textBox);
                    }
                    catch (NumericFormatException ex)
                    {
                        errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                    }
                    try
                    {
                        SaisieUtilisateur.ControleIntDecimaleLimite(floatArrayTemp[0], "");
                    }
                    catch (IntegerlLimitException ex)
                    {
                        errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                    }
                    if (floatArrayTemp.Length > 1 && floatArrayTemp[1] != "")
                    {
                        try
                        {
                            SaisieUtilisateur.ControleSaisieStringNumericDecimalFloat(floatArrayTemp[0]);
                            NoError(textBox);
                        }
                        catch (NumericFormatException ex)
                        {
                            errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                        }
                        try
                        {
                            SaisieUtilisateur.ControleFloatDecimaleLimite(floatArrayTemp[1], "2");
                        }
                        catch (IntegerlLimitException ex)
                        {
                            errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                        }
                    }
                }
                try
                {
                    SaisieUtilisateur.ControleFloatLimite(textBox.Text, 10);
                }
                catch (DecimalLimitException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
            }
            if (errorTemp.Length != 0)
            {
                TextErrorShow(epList[textBox.Name], errorTemp, textBox);
            }
        }
        private void tbCodePostal_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string errorTemp = "";
            if (textBox.Text.Length == 0)
            {
                textBox.BackColor = Color.White;
                epList[textBox.Name].Clear();
            }
            else
            {
                try
                {
                    SaisieUtilisateur.ControleSaisieStringNumeric(textBox.Text);
                    NoError(textBox);
                }
                catch (NumericFormatException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                try
                {
                    SaisieUtilisateur.ControleSaisieStringLimite(textBox.Text, 5);
                    NoError(textBox);
                }
                catch (StringLimitException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                try
                {
                    SaisieUtilisateur.ControleSaisieStringLimiteMin(textBox.Text, 5);
                    NoError(textBox);
                }
                catch (StringLimitMinException ex)
                {
                    errorTemp += errorTemp.Length == 0 ? ex.Message : ";\n" + ex.Message;
                }
                if (errorTemp.Length != 0)
                {
                    TextErrorShow(epList[textBox.Name], errorTemp, textBox);
                }
            }
        }
        private void Effacer()
        {
            foreach (var tb in tbList)
            {
                tb.Text = "";
                tb.BackColor = Color.White;
            }
            valider.Enabled = false;
        }
        private void effacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }
        private void valider_Click(object sender, EventArgs e)
        {

            formulaire = new Formulaire(
                ((TextBox)Controls["tbNom"]).Text,
                ((TextBox)Controls["tbDate"]).Text,
                ((TextBox)Controls["tbMontant"]).Text,
                ((TextBox)Controls["tbCodePostal"]).Text);
            new ValidationForm(formulaire).Show();
            Effacer();
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