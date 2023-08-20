using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Mediateur : IMediateur
    {
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="SalleDeReunion"/>
        /// </summary>
        public List<SalleDeReunion> Salles { get; }
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="Employee"/>
        /// </summary>
        public List<Employee> Employees { get; }
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="Reservation"/>
        /// </summary>
        public List<Reservation> Reservations { get; }

        /// <summary>
        /// Constructeur du <see cref="Mediateur"/>
        /// </summary>
        public Mediateur()
        {
            Salles = new List<SalleDeReunion>();
            Employees = new List<Employee>();
            Reservations = new List<Reservation>();
        }

        //Methode de l'interface
        /// <summary>
        /// Permet d'effectuer la <see cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> sous certaines condition
        /// </summary>
        /// <param name="_employee"><see cref="Employee"/> qui effectue la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> de date(<see cref="DateTime"/>) de la <seealso cref="Reservation"/></param>
        /// <param name="_equipements">Liste d'equipement que la <see cref="SalleDeReunion"/> doit disposer</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _uniqueReservation = true)
        {
            if (Salles.Count > 0 && Employees.Count > 0)
            {
                Reservation? reservation = Reservations.Find(r => r.Employee.Reference() == _employee.Reference() && r.Periode.Reference() == _periode.Reference());
                if ((_uniqueReservation && reservation == null) || !_uniqueReservation)
                {
                    foreach (SalleDeReunion salle in Salles)
                    {
                        if (salle.VerifierEquipement(_equipements) &&
                            salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                            salle.VerifierCapacite(_capacite))
                        {
                            AjouterReservation(new Reservation(salle, _employee, _periode));
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool ReserverSalle(string _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _UniqueReservation = true)
        {
            return Employees.Find(e => e.Reference() == _employee).ReserverSalle(_periode, _equipements, _capacite, true);
        }
        /// <summary>
        /// Permet d'effectuer la <see cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> en ciblant une salle et en verifiant si les critere de <seealso cref="Reservation"/> son respecté
        /// </summary>
        /// <param name="_employee"><see cref="Employee"/> qui effectue la <seealso cref="Reservation"/></param>
        /// <param name="_salle">Une information qui permet de cibler une <see cref="SalleDeReunion"/> en particulier</param>
        /// <param name="_periode"><see cref="Periode"/> de date(<see cref="DateTime"/>) de la <seealso cref="Reservation"/></param>
        /// <param name="_equipements">Liste d'equipement que la <see cref="SalleDeReunion"/> doit disposer</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        /// <param name="_uniqueReservation">Un <see cref="bool"/> qui specifie si la <seealso cref="Reservation"/> de plusieurs <seealso cref="SalleDeReunion"/> est possible pour un meme <seealso cref="Employee"/> a une meme <seealso cref="Periode"/></param> (par defaut sur true)
        /// <returns>Un <see cref="bool"/> (true ou false)</returns>
        public bool ReserverSalle(string _employee, string _salle, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _UniqueReservation = true)
        {
            SalleDeReunion salle = Salles.Find(s => s.Reference() == _salle);
            if (salle != null)
            {
                Reservation? reservation = Reservations.Find(r => r.Employee.Reference() == _employee && r.Periode.Reference() == _periode.Reference());
                if ((reservation == null || (!_UniqueReservation && reservation != null)) && Salles.Count > 0 && Employees.Count > 0)
                {
                    if (salle.VerifierEquipement(_equipements) &&
                        salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                        salle.VerifierCapacite(_capacite))
                    {
                        AjouterReservation(new Reservation(salle, Employees.Find(e=>e.Reference()==_employee), _periode));
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Permet l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> en se basant sur une <seealso cref="SalleDeReunion"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_salle"><see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> concerner par la <seealso cref="Reservation"/></param>
        public void AnnulerReservationS(string _salle, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Periode.DateDebut == _periode.DateDebut && r.Periode.DateFin == _periode.DateFin && r.Salle.Reference() == _salle);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        /// <summary>
        /// Permet l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> en se basant sur un <seealso cref="Employee"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_salle"><see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> concerner par la <seealso cref="Reservation"/></param>
        public void AnnulerReservationE(string _employee, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Periode.DateDebut == _periode.DateDebut && r.Periode.DateFin == _periode.DateFin && r.Employee.Reference() == _employee);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        /// <summary>
        /// Permet l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> en se basant sur une <seealso cref="Reservation"/>
        /// </summary>
        /// <param name="_reservation"><see cref="Reservation"/> precise ciblé pour l'annulation</param>
        public void AnnulerReservation(string _employee, string _salle, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Employee.Reference() == _employee &&
                r.Salle.Reference() == _salle &&
                r.Periode.Reference() == _periode.Reference());

            if (reservation != null)
            {
                Reservations.Remove(reservation);
            }
        }
        /// <summary>
        /// Permet de verifier la disponibilité d'une <see cref="SalleDeReunion"/> en fonction d'une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_salle">Une instance de <see cref="SalleDeReunion"/></param>
        /// <param name="_periode">Une <see cref="Periode"/></param>
        /// <returns></returns>     
        public EnumDisponibilite VerifierDisponibilite(string _salle, Periode _periode)
        {
            EnumDisponibilite etat = EnumDisponibilite.Disponible;
            foreach (Reservation reservation in Reservations)
            {
                if (reservation.Salle.Reference() == _salle &&
                    (!(_periode.DateDebut < reservation.Periode.DateDebut && _periode.DateFin < reservation.Periode.DateDebut) &&
                    !(_periode.DateDebut > reservation.Periode.DateFin && _periode.DateFin > reservation.Periode.DateFin)))
                {
                    etat = EnumDisponibilite.Occupe;
                }
            }
            return etat;
        }

        //Methode Utiliser juste dans la classe
        /// <summary>
        /// Permet d'ajouter une <see cref="Reservation"/> a la liste <seealso cref="Reservations"/>
        /// </summary>
        /// <param name="_reservation"></param>
        private void AjouterReservation(Reservation _reservation) => Reservations.Add(_reservation);
        /// <summary>
        /// Permet d'ôter une <see cref="Reservation"/> de la liste <seealso cref="Reservations"/>
        /// </summary>
        /// <param name="_reservation"></param>
        private void EnleverReservation(Reservation _reservation) => Reservations.Remove(_reservation);

        //Pour l'IHM Console
        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de toute les <see cref="SalleDeReunion"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringSalles()
        {
            string result = "Liste des salles\n-------------------\n";
            foreach (SalleDeReunion salle in Salles)
            {
                result += string.Format("{0}\n", salle.ToStringCollegue());
            }
            return result;
        }
        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de tout les <see cref="Employee"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringEmployees()
        {
            string result = "Liste des employees\n-------------------\n";
            foreach (Employee employee in Employees)
            {
                result += string.Format("{0}\n", employee.ToStringCollegue());
            }
            return result;
        }
        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de toute les <see cref="Reservation"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringReservation()
        {
            string result = "";
            string separateur = "_________________________";
            if (Reservations.Count > 0)
            {
                foreach (Reservation reservation in Reservations)
                {
                    result += string.Format("{0}\nInformation sur la salle : \n{1}\n\nInformation sur l'employée : \n{2}\nPeriode de reservation : \n{3}\n{0}\n",
                        separateur, reservation.Salle.ToStringCollegue(), reservation.Employee.ToStringCollegue(), reservation.Periode.ToStringPeriode(), separateur);
                }
            }
            else
            {
                result += "Aucune Reservation enregistré";
            }
            return result;
        }

        //PourL'IHM Winform
        public List<string> RecupererSallesDispo(string _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite, bool _uniqueReservation = true)
        {
            List<string> salles = new List<string>();
            List<Reservation> reservations = Reservations.FindAll(r => r.Employee.Reference() == _employee);
            if (reservations.Count > 0)
            {
                foreach (Reservation r in reservations)
                {
                    if (!(((_periode.DateDebut < r.Periode.DateDebut && _periode.DateFin <= r.Periode.DateDebut) ||
                        (_periode.DateDebut >= r.Periode.DateFin && _periode.DateFin > r.Periode.DateFin)) &&
                        _periode.DateDebut < _periode.DateFin))
                    {
                        return new List<string>();
                    }
                }
            }

            Reservation? reservation = Reservations.Find(r => r.Employee.Reference() == _employee && r.Periode.Reference() == _periode.Reference());
            if (Salles.Count > 0 && Employees.Count > 0 && ((_uniqueReservation && reservation == null) || !_uniqueReservation))
            {
                foreach (SalleDeReunion salle in Salles)
                {
                    if (!_uniqueReservation || (_uniqueReservation && reservation == null))
                    {
                        if (salle.VerifierEquipement(_equipements) &&
                        salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                        salle.VerifierCapacite(_capacite))
                        {
                            if (!_uniqueReservation || (_uniqueReservation && reservation == null))
                            {
                                salles.Add(salle.Reference());
                            }
                        }
                    }
                }
            }
            return salles;
        }
        public List<Periode> RecupererPeriodesEmployee(string _employee)
        {
            Employee? emp = Employees.Find(e => e.Reference() == _employee);
            List<Periode> periodes = new List<Periode>();
            if (emp != null)
            {
                List<Reservation> reservations = Reservations.FindAll(r => r.Employee.Matricule == emp.Matricule);
                reservations.ForEach(rp => periodes.Add(rp.Periode));
                return periodes;
            }
            return periodes;
        }
        public List<Periode> RecupererPeriodesSalle(string _salle)
        {
            SalleDeReunion? sal = Salles.Find(e => e.Reference() == _salle);
            List<Periode> periodes = new List<Periode>();
            if (sal != null)
            {
                List<Reservation> reservations = Reservations.FindAll(r => r.Salle.Reference() == sal.Reference());
                reservations.ForEach(rp => periodes.Add(rp.Periode));
                return periodes;
            }
            return periodes;
        }
        public List<string>? RecupererSalle(string _employee, string _periode)
        {
            List<Reservation>? reservation = Reservations.FindAll(r => r.Employee.Reference() == _employee && r.Periode.Reference() == _periode);
            List<string> salles = new List<string>();
            if (reservation.Count > 0)
            {
                reservation.ForEach(r => salles.Add(r.Salle.Reference()));
            }
            return salles;
        }
        public List<string>? RecupererEmployee(string _salle, string _periode)
        {
            List<Reservation>? reservation = Reservations.FindAll(r => r.Salle.Reference() == _salle && r.Periode.Reference() == _periode);
            List<string> employees = new List<string>();
            if (reservation.Count > 0)
            {
                reservation.ForEach(r => employees.Add(r.Employee.Reference()));
            }
            return employees;
        }
        public string? RecupererEmployer(string _matricule)
        {
            return Employees.Find(e => e.Matricule == _matricule).Reference();
        }
        public string? RecupererSalleDeReunion(string _salleRef)
        {
            return Salles.Find(s => s.Reference() == _salleRef).Reference();
        }

    }
}
