using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Periode
    {
        /// <summary>
        /// Date(<see cref="DateTime"/>) correspondant au commencement de la <seealso cref="Periode"/>
        /// </summary>
        public DateTime DateDebut { get; }
        /// <summary>
        /// Date(<see cref="DateTime"/>) correspondant à la fin de la <seealso cref="Periode"/>
        /// </summary>
        public DateTime DateFin { get; }
        /// <summary>
        /// Constructeur d'une <see cref="Periode"/>
        /// </summary>
        /// <param name="_dateDebut">Date(<see cref="DateTime"/>) correspondant au commencement de la <seealso cref="Periode"/></param>
        /// <param name="_dateFin">Date(<see cref="DateTime"/>) correspondant à la fin de la <seealso cref="Periode"/></param>
        /// <exception cref="ArgumentException"></exception>
        public Periode(DateTime _dateDebut,DateTime _dateFin)
        {
            DateDebut = _dateDebut;
            if (_dateFin>_dateDebut&& _dateDebut>DateTime.Now)
            {
                DateFin = _dateFin;
            }
            else
            {
                throw new ArgumentException("La date de fin doit succeder la date de debut de la reservation");
            }

        }
        /// <summary>
        /// Permet le retour textuel des caracteristique d'une <see cref="Periode"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringPeriode()=> string.Format("{0}\n{1}\n", DateDebut.ToString(), DateFin.ToString());
        /// <summary>
        /// Permet de renvoyer un moyen d'identification de la <see cref="Periode"/>
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public string Reference() => string.Format("{0} - {1}", DateDebut.ToString(), DateFin.ToString());

    }
}
