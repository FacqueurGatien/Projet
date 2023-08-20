using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    /// <summary>
    /// Superclasse abstraite
    /// </summary>
    public abstract class Collegue
    {
        /// <summary>
        /// Nom qui est un attibut commun à tout les enfant de la superclass
        /// </summary>
        protected string Nom { get; }
        /// <summary>
        /// Reference du <seealso cref="IMediateur"/> permettant de mettre les diferenttes classes en relation
        /// </summary>
        protected IMediateur Mediateur { get; }

        /// <summary>
        /// Constructeur de la superclasse <see cref="Collegue"/>
        /// </summary>
        /// <param name="_mediateur">Instance du <see cref="IMediateur"/> permettant de mettre les diferenttes classes en relation</param>
        /// <param name="_nom">Nom qui est un attibut commun à tout les enfant de la superclass <see cref="Collegue"/></param>
        public Collegue(IMediateur _mediateur,string _nom)
        {
            Mediateur = _mediateur;
            Nom = _nom;
        }
        /// <summary>
        /// Methode abstract qu'auront tout les enfant de <see cref="Collegue"/> et qui permettra de demander au mediateur l'annulation d'une <seealso cref="Reservation"/> sur la base d'une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_periode">Periode de date de la <see cref="Reservation"/> à annuler</param>
        public abstract void AnnulerReservation(Periode _periode);

        /// <summary>
        /// Classe abstract qui permet d'implementer le retour textuelle des caracteristique de chaque Enfant de la superclase <see cref="Collegue"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public abstract string ToStringCollegue();

        public abstract string Reference();

    }
}
