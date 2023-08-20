using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Reservation
    {
        /// <summary>
        /// <see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/>
        /// </summary>
        public SalleDeReunion Salle { get; }
        /// <summary>
        /// <see cref="Employee"/> concerner par la <seealso cref="Reservation"/>
        /// </summary>
        public Employee Employee { get; }
        /// <summary>
        /// <see cref="Periode"/> de date (<seealso cref="DateTime"/> concerner par la <seealso cref="Reservation"/>
        /// </summary>
        public Periode Periode { get; }
        /// <summary>
        /// Constructeur d'une <see cref="Reservation"/>
        /// </summary>
        /// <param name="_salle"><see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_employee"><see cref="Employee"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> de date (<seealso cref="DateTime"/> concerner par la <seealso cref="Reservation"/></param>
        public Reservation(SalleDeReunion _salle,Employee _employee, Periode _periode)
        {
            Salle = _salle;
            Employee = _employee;
            Periode = _periode;
        }
    }
}
