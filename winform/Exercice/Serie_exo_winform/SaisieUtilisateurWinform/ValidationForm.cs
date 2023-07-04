using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaisieUtilisateurModel;
namespace BBSaisieUtilisateurWinform
{
    public partial class ValidationForm : Form
    {
        public ValidationForm(Formulaire _formulaire)
        {
            InitializeComponent();
            ((Label)Controls["lNom"]).Text += _formulaire.Nom;
            ((Label)Controls["lDate"]).Text += $"{_formulaire.Date.Day}/{_formulaire.Date.Month}/{_formulaire.Date.Year}";
            ((Label)Controls["lMontant"]).Text += _formulaire.Montant;
            ((Label)Controls["lCodePostal"]).Text += _formulaire.CodePostal;
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
