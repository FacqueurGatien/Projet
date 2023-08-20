using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    /// <summary>
    /// Enfant de la classe <see cref="Collegue"/>
    /// </summary>
    public class SalleDeReunion : Collegue
    {
        /// <summary>
        /// Capacite en nombre de personne
        /// </summary>
        private int Capacite { get; }
        /// <summary>
        /// Liste des equipement dont la salle dispose
        /// </summary>
        private List<EnumEquipement> Equipements { get; }

        /// <summary>
        /// Constructeur d'une <see cref="SalleDeReunion"/>
        /// </summary>
        /// <param name="_mediateur">Instance du <see cref="IMediateur"/></param>
        /// <param name="_nom">Nom de la <see cref="SalleDeReunion"/></param>
        /// <param name="_capacite">Capacite d'acceuille en personne de la salle</param>
        /// <param name="_equipements">Liste des equipement dont la salle dispose</param>
        public SalleDeReunion(IMediateur _mediateur, string _nom, int _capacite, List<EnumEquipement> _equipements)
            : base(_mediateur, _nom)
        {
            Capacite = _capacite;
            Equipements = _equipements;
        }

        /// <summary>
        /// Permet de demander aux <see cref="IMediateur"/> d'annuler une <seealso cref="Reservation"/> en se basant sur une <seealso cref="SalleDeReunion"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_periode">Periode de date(<see cref="DateTime"/> de la <seealso cref="Reservation"/> à annuler</param>
        public override void AnnulerReservation(Periode _periode) => Mediateur.AnnulerReservationS(this.Reference(), _periode);
        /// <summary>
        /// Permet de verifier La disponibilite d'une <see cref="SalleDeReunion"/> pour une <seealso cref="Periode"/> donnée
        /// </summary>
        /// <param name="_periode">Periode de date à verifier</param>
        /// <returns>Un etat de disponiblité</returns>
        public EnumDisponibilite VerifierDisponibilité(Periode _periode) => Mediateur.VerifierDisponibilite(this.Reference(), _periode);

        /// <summary>
        /// Permet de verifier si une liste d'equipement donner est present dans la <see cref="SalleDeReunion"/>
        /// </summary>
        /// <param name="_equipements">Liste d'equipement</param>
        /// <returns>Un <see cref="bool"/> true ou false</returns>
        public bool VerifierEquipement(List<EnumEquipement> _equipements)
        {
            foreach (EnumEquipement equipement in _equipements)
            {
                if (!Equipements.Contains(equipement))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Permet de verifier si la salle à la capacité d'acceuille demandé
        /// </summary>
        /// <param name="_capacite">Capacité a verifier</param>
        /// <returns>Un <see cref="bool"/> true ou false</returns>
        public bool VerifierCapacite(int _capacite)=> Capacite >= _capacite;

        /// <summary>
        /// Permet de renvoyer la liste d'equipement de la salle
        /// </summary>
        /// <returns>Un <see cref="string"/> formater</returns>
        public string ToStringEquipement()
        {
            string result = "";
            foreach (EnumEquipement equipement in Equipements)
            {
                result += $"        {equipement.ToString()}\n";
            }
            result.Trim(',');
            return result;
        }
        /// <summary>
        /// Permet de renvoyer les caracteristiques de la <see cref="SalleDeReunion"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public override string ToStringCollegue() => string.Format("Salle de reunion\n    Nom : {0}\n    Capacite : {1} personnes\n    Liste d'équipements : \n{2}\n", Nom, Capacite, ToStringEquipement());
        /// <summary>
        /// Permet de renvoyer un moyen d'identification d'une <see cref="SalleDeReunion"/>
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public override string Reference()=> $"Salle {Nom}";
    }
}
