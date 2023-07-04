using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaisieUtilisateurModel
{
    using BBSaisieUtilisateur;
    public class Formulaire
    {
        private string nom;
        private DateTime date;
        private float montant;
        private string codePostal;
        public Formulaire() 
            : this("Nom",
                  DateTime.Today.AddDays(1), 
                  0, 
                  "00000")
        {
        }
        public Formulaire(string _nom, DateTime _date, float _montant, string _codePostal)
        {
            AddNom(_nom);
            AddDate(_date);
            AddMontant(_montant,"","2",true);
            AddCodePostal(_codePostal);
        }
        public Formulaire(string _nom, string _date, string _montant, string _codePostal)
            :this(_nom , 
                 SaisieUtilisateur.ControleSaisieDate(_date) , 
                 SaisieUtilisateur.ControleSaisieFloat(_montant),
                 SaisieUtilisateur.ControleSaisieStringNumeric(_codePostal))
        {
        }

        public string Nom { get => nom; }
        public DateTime Date { get => date; }
        public float Montant { get => montant; }
        public string CodePostal { get => codePostal; }

        private void AddNom(string _nom)
        {
            nom = SaisieUtilisateur.ControleSaisieStringNomPrenom(_nom , 30);
        }
        private void AddDate(DateTime _date)
        {
            this.date = SaisieUtilisateur.ControleSaisieDateFutur(_date);
        }
        private void AddMontant(float _montant, string _limI, string _limD, bool _abs = false)
        {
            this.montant = SaisieUtilisateur.ControleSaisieFloat(_montant, _limI, _limD, _abs);
        }
        private void AddCodePostal(string _codePostal)
        {
            this.codePostal = SaisieUtilisateur.ControleSaisieStringNumeric(_codePostal, 5 , 5);
        }
        public override string ToString()
        {
            return $"Nom: {nom}\nDate: {date.Day}/{date.Month}/{date.Year}\nMontant: {montant}\nCode postal: {codePostal}\n";
        }
    }
}
