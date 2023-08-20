using SalleDeReunionExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationWinform
{
    /// <summary>
    /// Formulaire de r�servation de salle.
    /// </summary>
    public partial class ReservationSalleForm : Form
    {
        /// <summary>
        /// Instance du Mediateur
        /// </summary>
        private IMediateur mediateur;
        /// <summary>
        /// <see cref="List{T}"/> des <seealso cref="CheckBox"/> concernant les equipements
        /// </summary>
        private List<CheckBox> checkBoxEquip;
        /// <summary>
        /// Instance de l'<seealso cref="Employee"/> actuelement selectionn� dans la <seealso cref="ComboBox"/> permettant d'effectuer les <seealso cref="Reservation"/> (<seealso cref="CBemployeeR"/>)
        /// </summary>
        private string? employeSelectionne;
        /// <summary>
        /// Instance de la <see cref="Periode"/> actuelement selectionn� dans l'IHM
        /// </summary>
        private Periode periodeSelectionne;
        /// <summary>
        /// <see cref="List{T}"/> d'equipement actuelement selectionn� dans l'IHM
        /// </summary>
        private List<EnumEquipement> equipementSelectionne;

        /// <summary>
        /// Constructeur par d�faut du formulaire.
        /// </summary>
        public ReservationSalleForm()
        {
            InitializeComponent();
            Chargement();
            UpdateIHM();
        }

        /// <summary>
        /// Cr�ation des Salle et Employ�e et initialisation des element de l'IHM
        /// </summary>
        private void Chargement()
        {
            mediateur = new Mediateur();

            DTperiodeDebut.Value = DateTime.Now;
            DTperiodeFin.Value = DateTime.Now;
            NUDheureDebut.Value = 13;
            NUDheureDebut.Value = 13;

            equipementSelectionne = new List<EnumEquipement>();

            CBXequipement1.Tag = EnumEquipement.Ordinateur;
            CBXequipement2.Tag = EnumEquipement.VideoProjecteur;
            CBXequipement3.Tag = EnumEquipement.Climatisation;
            CBXequipement4.Tag = EnumEquipement.Insonorisation;
            checkBoxEquip = new List<CheckBox>() { CBXequipement1, CBXequipement2, CBXequipement3, CBXequipement4 };

            SalleDeReunion s1 = new SalleDeReunion(mediateur, "Grenier", 50, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.Insonorisation });
            SalleDeReunion s2 = new SalleDeReunion(mediateur, "Chalet", 10, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.VideoProjecteur, EnumEquipement.Ordinateur });
            SalleDeReunion s3 = new SalleDeReunion(mediateur, "Arel3", 100, new List<EnumEquipement>() { EnumEquipement.Climatisation });
            SalleDeReunion s4 = new SalleDeReunion(mediateur, "Geek", 25, new List<EnumEquipement>() { EnumEquipement.Insonorisation, EnumEquipement.Ordinateur, EnumEquipement.VideoProjecteur });

            Employee e1 = new Employee(mediateur, "ESTJ001", "Antoine", "Daniel");
            Employee e2 = new Employee(mediateur, "ESTJ002", "Frederic", "Molas");
            Employee e3 = new Employee(mediateur, "ESTJ003", "Sebastien", "Rassiat");
            Employee e4 = new Employee(mediateur, "ESTJ004", "Mathieu", "Sommet");
            Employee e5 = new Employee(mediateur, "ESTJ005", "Lucas", "Hauchard");
            Employee e6 = new Employee(mediateur, "ESTJ006", "Bruce", "Benamran");

            ((Mediateur)mediateur).Salles.AddRange(new List<SalleDeReunion>() { s1, s2, s3, s4 });
            ((Mediateur)mediateur).Employees.AddRange(new List<Employee>() { e1, e2, e3, e4, e5, e6 });

            CBemployeeR.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBEmployeesListe.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBsalleListe.Items.AddRange(new string[] { s1.Reference(), s2.Reference(), s3.Reference(), s4.Reference() });
        }

        /// <summary>
        /// G�re la s�lection d'un employ� pour la r�servation.
        /// </summary>
        private void SelectionneEmployeePourReservation(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            string matricule = cb.SelectedItem.ToString().Split(':')[0].Trim(' ');
            employeSelectionne = ((Mediateur)mediateur).RecupererEmployer(matricule);

            UpdateIHM();
        }

        /// <summary>
        /// Effectue la r�servation de salle lorsque le bouton "Valider" est cliqu�.
        /// </summary>
        private void Bvalider_Click(object sender, EventArgs e)
        {
            ((Mediateur)mediateur).ReserverSalle(employeSelectionne, CBsalleDispo.SelectedItem.ToString(), periodeSelectionne, equipementSelectionne, (int)NUDcapacite.Value);
            CBsalleDispo.Items.Clear();
            Bvalider.Enabled = false;
            ResetSelection();
            UpdateIHM();
        }

        /// <summary>
        /// Mise a jours de l'IHM
        /// </summary>
        private void UpdateIHM()
        {
            try
            {
                UpdatePeriode();
            }
            catch (ArgumentException)
            {
                DateTime now = DateTime.Now;
                DTperiodeDebut.ValueChanged -= ValueChange;
                DTperiodeFin.ValueChanged -= ValueChange;
                DTperiodeDebut.Value = now.AddDays(1);
                DTperiodeFin.Value = now.AddDays(1);
                DTperiodeDebut.ValueChanged += ValueChange;
                DTperiodeFin.ValueChanged += ValueChange;
                NUDheureDebut.Value = 6;
                NUDheureFin.Value = 6;
                NUDminuteDebut.Value = 0;
                NUDminuteFin.Value = 15;
            }
            if (employeSelectionne != null)
            {
                CBsalleDispo.Items.Clear();
                RemplirListeSalleDispo(employeSelectionne, periodeSelectionne, equipementSelectionne, (int)NUDcapacite.Value);
            }
        }
        /// <summary>
        /// Apelle la methode UpdateIHM quand certaint element de l'IHM change de valeur
        /// </summary>
        private void ValueChange(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        /// <summary>
        /// Remplit la liste des salles disponibles pour la r�servation.
        /// </summary>
        /// <param name="_employee">Instance d'un <see cref="Employee"/></param>
        /// <param name="_periode">Instace d'une <see cref="Periode"/></param>
        /// <param name="_equipements"><see cref="List{T}"/> d'equipement souhait�</param>
        /// <param name="_capacite">Capacit� de personne max souhait�</param>
        private void RemplirListeSalleDispo(string _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            List<string> salleList = ((Mediateur)mediateur).RecupererSallesDispo(_employee, _periode, _equipements, _capacite);
            CBsalleDispo.Items.Clear();
            salleList.ForEach(s => CBsalleDispo.Items.Add(s));
        }

        /// <summary>
        /// G�re la s�lection d'une salle disponible dans la ComboBox.
        /// </summary>
        private void CBsalleDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                Bvalider.Enabled = true;
            }
            else
            {
                Bvalider.Enabled = false;
            }
        }

        /// <summary>
        /// Met � jour la p�riode de r�servation en fonction des valeurs s�lectionn�es.
        /// </summary>
        private void UpdatePeriode()
        {
            periodeSelectionne = new Periode(
                new DateTime(//date de Debut
                    DTperiodeDebut.Value.Year,
                    DTperiodeDebut.Value.Month,
                    DTperiodeDebut.Value.Day,
                    (int)NUDheureDebut.Value,
                    (int)NUDminuteDebut.Value,
                    0),
                new DateTime(//Date de Fin
                    DTperiodeFin.Value.Year,
                    DTperiodeFin.Value.Month,
                    DTperiodeFin.Value.Day,
                    (int)NUDheureFin.Value,
                    (int)NUDminuteFin.Value,
                    0));
        }
        /// <summary>
        /// Met a jour la liste d'equipement selectionn�e
        /// </summary>
        private void CBXequipement1_CheckedChanged(object sender, EventArgs e)
        {
            equipementSelectionne.Clear();
            checkBoxEquip.ForEach(e =>
            {
                if (e.Checked == true)
                {
                    equipementSelectionne.Add((EnumEquipement)e.Tag);
                }
            });
            UpdateIHM();
        }


        /// <summary>
        /// Permet de mettre a jour la <see cref="ComboBox"/> des <seealso cref="Periode"/> correspondant � un <seealso cref="Employee"/> sel�ctionn�
        /// </summary>
        private void CBEmployeesListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodeEmployee.Items.Clear();
            CBEmployeeSalle.Items.Clear();
            if (CBEmployeesListe.SelectedItem != null)
            {
                List<Periode> periodes = ((Mediateur)mediateur).RecupererPeriodesEmployee(((ComboBox)sender).SelectedItem.ToString());
                if (periodes.Count > 0)
                {
                    periodes.ForEach(p =>
                    {
                        if (!PeriodeEmployee.Items.Contains(p.Reference()))
                        {
                            PeriodeEmployee.Items.Add(p.Reference());
                        }
                    });
                }
            }
            else
            {
                CBEmployeeSalle.Items.Clear();
                PeriodeEmployee.Items.Clear();
            }
            BannulerEmployeeSalle.Enabled = false;
        }
        /// <summary>
        /// Permet de mettre a jour la <see cref="ComboBox"/> des <seealso cref="SalleDeReunion"/> correspondant � un <seealso cref="Employee"/> et une <seealso cref="Periode"/> sel�ctionn�
        /// </summary>
        private void PeriodeEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBEmployeeSalle.Items.Clear();
            if (PeriodeEmployee.SelectedItem != null)
            {
                List<string> salles = ((Mediateur)mediateur).RecupererSalle(CBEmployeesListe.SelectedItem.ToString(), PeriodeEmployee.SelectedItem.ToString());
                if (salles.Count > 0)
                {
                    CBEmployeeSalle.Items.Clear();
                    salles.ForEach(s => CBEmployeeSalle.Items.Add(s));
                }
            }
            else
            {
                CBEmployeeSalle.Items.Clear();
            }
            BannulerEmployeeSalle.Enabled = false;
        }
        /// <summary>
        /// Permet de mettre a jours le <see cref="Button"/> d'annulation concernant la recuperation de <seealso cref="Reservation"/> d'un <seealso cref="Employee"/>
        /// </summary>
        private void CBEmployeeSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEmployeeSalle.SelectedItem != null)
            {
                BannulerEmployeeSalle.Enabled = true;
            }
            else
            {
                BannulerEmployeeSalle.Enabled = false;
            }
        }
        /// <summary>
        /// Permet d'annuler la <see cref="Reservation"/> d'un <seealso cref="Employee"/>
        /// </summary>
        private void BannulerEmployeeSalle_Click(object sender, EventArgs e)
        {
            string? salle = ((Mediateur)mediateur).RecupererSalleDeReunion(CBEmployeeSalle.SelectedItem.ToString());
            string? employee = ((Mediateur)mediateur).RecupererEmployer(CBEmployeesListe.SelectedItem.ToString().Split(':')[0].Trim(' '));
            List<Periode>? periodes = ((Mediateur)mediateur).RecupererPeriodesEmployee(employee.ToString());
            Periode? periode = periodes.Find(p => p.Reference() == PeriodeEmployee.SelectedItem.ToString());
            if (salle != null && employee != null && periode != null)
            {
                ((Mediateur)mediateur).AnnulerReservation(employee, salle, periode);
                ResetSelection();
                DTperiodeDebut.Value = (DTperiodeFin.Value).AddDays(1);
            }
        }

        /// <summary>
        /// Permet de mettre a jour la <see cref="ComboBox"/> des <seealso cref="Periode"/> correspondant � une <seealso cref="SalleDeReunion"/> sel�ctionn�
        /// </summary>
        private void CBsalleListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodeSalle.Items.Clear();
            CBSalleEmployee.Items.Clear();
            if (CBsalleListe.SelectedItem != null)
            {
                List<Periode> periodes = ((Mediateur)mediateur).RecupererPeriodesSalle(((ComboBox)sender).SelectedItem.ToString());
                if (periodes.Count > 0)
                {
                    periodes.ForEach(p =>
                    {
                        if (!PeriodeSalle.Items.Contains(p.Reference()))
                        {
                            PeriodeSalle.Items.Add(p.Reference());
                        }
                    });
                }
            }
            else
            {
                CBEmployeeSalle.Items.Clear();
                PeriodeSalle.Items.Clear();
            }
            BannulerSalleEmployee.Enabled = false;
        }
        /// <summary>
        /// Permet de mettre a jour la <see cref="ComboBox"/> des <seealso cref="Employee"/> correspondant � une <seealso cref="SalleDeReunion"/> et une <seealso cref="Periode"/> sel�ctionn�
        /// </summary>
        private void PeriodeSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBSalleEmployee.Items.Clear();
            if (PeriodeSalle.SelectedItem != null)
            {
                List<string> emp = ((Mediateur)mediateur).RecupererEmployee(CBsalleListe.SelectedItem.ToString(), PeriodeSalle.SelectedItem.ToString());
                if (emp.Count > 0)
                {
                    CBSalleEmployee.Items.Clear();
                    emp.ForEach(s => CBSalleEmployee.Items.Add(s));
                }
            }
            else
            {
                CBSalleEmployee.Items.Clear();
            }
            BannulerSalleEmployee.Enabled = false;
        }
        /// <summary>
        /// Permet de mettre a jours le <see cref="Button"/> d'annulation concernant la recuperation de <seealso cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/>
        /// </summary>
        private void CBSalleEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSalleEmployee.SelectedItem != null)
            {
                BannulerSalleEmployee.Enabled = true;
            }
            else
            {
                BannulerSalleEmployee.Enabled = false;
            }
        }
        /// <summary>
        /// Permet d'annuler la <see cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/>
        /// </summary>
        private void BannulerSalleEmployee_Click(object sender, EventArgs e)
        {
            string? salle = ((Mediateur)mediateur).RecupererSalleDeReunion(CBsalleListe.SelectedItem.ToString());
            string? employee = ((Mediateur)mediateur).RecupererEmployer(CBSalleEmployee.SelectedItem.ToString().Split(':')[0].Trim(' '));
            List<Periode>? periodes = ((Mediateur)mediateur).RecupererPeriodesSalle(salle);
            Periode? periode = periodes.Find(p => p.Reference() == PeriodeSalle.SelectedItem.ToString());
            if (salle != null && employee != null && periode != null)
            {
                ((Mediateur)mediateur).AnnulerReservation(employee, salle, periode);
                ResetSelection();
                DTperiodeDebut.Value = (DTperiodeFin.Value).AddDays(1);
            }
        }
        /// <summary>
        /// Remise a vide des <see cref="ComboBox"/> de selection de <seealso cref="Reservation"/>
        /// </summary>
        private void ResetSelection()
        {
            CBsalleListe.SelectedItem = null;
            CBEmployeesListe.SelectedItem = null;
            CBSalleEmployee.SelectedItem = null;
            CBEmployeeSalle.SelectedItem = null;
            PeriodeSalle.SelectedItem = null;
            PeriodeEmployee.SelectedItem = null;
            BannulerEmployeeSalle.Enabled = false;
            BannulerSalleEmployee.Enabled = false;
        }
    }
}
