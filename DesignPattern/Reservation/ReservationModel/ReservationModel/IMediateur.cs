using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public interface IMediateur
    {
        //Fonction minimum requise pour l'interface
        /// <summary>
        /// Permet de faire les lien entre les classe et d'effectuer la <see cref="Reservation"/> de la premiere <seealso cref="SalleDeReunion"/> correspondant aux attentes
        /// </summary>
        /// <param name="_employee">Une <see cref="string"/> qui permet d'identifier un <see cref="Employee"/></param>
        /// <param name="_periode">Une instance de <see cref="Periode"/></param>
        /// <param name="_equipements">Une <see cref="List{T}"/> d'equipement</param>
        /// <param name="_capacite">Un <see cref="int"/> corespondant à la capacité désiré</param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(string _employee, string _salle, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _UniqueReservation = true);
        /// <summary>
        /// Permet de faire les lien entre les classe et d'effectuer la <see cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> precise
        /// </summary>
        /// <param name="_employee">Une <see cref="string"/> qui permet d'identifier un <see cref="Employee"/></param>
        /// <param name="_periode">Une instance de <see cref="Periode"/></param>
        /// <param name="_equipements">Une <see cref="List{T}"/> d'equipement</param>
        /// <param name="_capacite">Un <see cref="int"/> corespondant à la capacité désiré</param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(string _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _uniqueReservation = true);
        /// <summary>
        /// Permet de faire les lien entre les classe et d'effectuer l'annulation d'une (ou plusieur) <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> 
        /// </summary>
        /// <param name="_employee">Une instance d'<see cref="Employee"/></param>
        /// <param name="_periode">Une instance de <see cref="Periode"/></param>
        public void AnnulerReservationE(string _employee, Periode _periode);
        /// <summary>
        /// Permet de faire les lien entre les classe et d'effectuer l'annulation d'une (ou plusieur) <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> 
        /// </summary>
        /// <param name="_salle">Une instance de <see cref="SalleDeReunion"/></param>
        /// <param name="_periode">Une instance de <see cref="Periode"/></param>
        public void AnnulerReservationS(string _salle, Periode _periode);
        /// <summary>
        /// Permet de faire les lien entre les classe et d'effectuer l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> Precise
        /// </summary>
        /// <param name="_reservation">Une instance de <see cref="Reservation"/></param>
        public void AnnulerReservation(string _salle,string _employee,Periode _periode); //Dans le cas ou un employee peut reserver plusieur salle à la meme Periode
        /// <summary>
        /// Permet de faire le lien entre les classe et de verifier si une <see cref="SalleDeReunion"/> ne fait pas deja l'objet d'une <seealso cref="Reservation"/> pour une <seealso cref="Periode"/> precise
        /// </summary>
        /// <param name="_salle">Une instance de <see cref="SalleDeReunion"/></param>
        /// <param name="_periode">Une instance de <see cref="Periode"/></param>
        /// <returns>Un <see cref="EnumDisponibilite"/> indicant si la salle est <seealso cref="EnumDisponibilite.Disponible"/> ou <seealso cref="EnumDisponibilite.Occupe"/></returns>
        public EnumDisponibilite VerifierDisponibilite(string _salle, Periode _periode);
    }
}
