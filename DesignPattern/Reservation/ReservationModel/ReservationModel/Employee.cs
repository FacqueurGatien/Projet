using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    /// <summary>
    /// Enfant de la superclasse <see cref="Collegue"/>
    /// </summary>
    public class Employee : Collegue
    {
        /// <summary>
        /// Une chaine de caractere qui permet d'identifier un <see cref="Employee"/> de facon Unique
        /// </summary>
        public string Matricule { get; }
        /// <summary>
        /// Prenom d'un <see cref="Employee"/>
        /// </summary>
        private string Prenom { get; }

        /// <summary>
        /// Constructeur d'un <see cref="Employee"/>
        /// </summary>
        /// <param name="_mediateur">Instance du <see cref="IMediateur"/></param>
        /// <param name="_matricule">Une chaine de caractere qui permet d'identifier un <see cref="Employee"/> de facon Unique</param>
        /// <param name="_nom"><see cref="Nom"/> d'un <see cref="Employee"/></param>
        /// <param name="_prenom">Prenom d'un <see cref="Employee"/></param>
        public Employee(IMediateur _mediateur,string _matricule, string _nom, string _prenom)
            :base(_mediateur,_nom)
        {
            Matricule = _matricule;
            Prenom = _prenom;
        }

        /// <summary>
        /// Permet de demander au <see cref="IMediateur"/> de réaliser la <seealso cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> en fonction de certain paramettres
        /// </summary>
        /// <param name="_periode">Periode de date souhaité</param>
        /// <param name="_equipements">Liste d'equipement exigée que la <see cref="SalleDeReunion"/> doit posseder</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(Periode _periode, List<EnumEquipement> _equipements, int _capacite,bool _uniqueReservation=true) => Mediateur.ReserverSalle(this.Reference(), _periode, _equipements, _capacite, _uniqueReservation);
        /// <summary>
        /// Permet de demander au <see cref="IMediateur"/> de réaliser la <seealso cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> Precise en fonction de certain paramettres
        /// </summary>
        /// <param name="_periode">Periode de date souhaité</param>
        /// <param name="_salle">Un <see cref="string"/> permetant d'identifier une <seealso cref="SalleDeReunion"/></param>
        /// <param name="_equipements">Liste d'equipement exigée que la <see cref="SalleDeReunion"/> doit posseder</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(Periode _periode,string _salle, List<EnumEquipement> _equipements, int _capacite,bool _uniqueReservation=true) => Mediateur.ReserverSalle(this.Reference(),_salle, _periode, _equipements, _capacite, _uniqueReservation);
        /// <summary>
        /// Permet de demander aux <see cref="IMediateur"/> d'annuler une <seealso cref="Reservation"/> en se basant sur un <seealso cref="Employee"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_periode"><see cref="Periode"/> de date(<see cref="DateTime"/>) de la <seealso cref="Reservation"/> à annuler</param>
        public override void AnnulerReservation(Periode _periode) => Mediateur.AnnulerReservationE(this.Reference(), _periode);

        /// <summary>
        /// Permet de renvoyer les caracteristiques de la <see cref="Employee"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public override string ToStringCollegue()=> string.Format("Employée\n    Matricule : {0}\n    Nom : {1}\n    Prenom : {2}\n", Matricule, Nom, Prenom);
        /// <summary>
        /// Permet de renvoyer un moyen d'identification unique
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public override string Reference() => $"{Matricule} : {Nom} - {Prenom}";
    }
}
