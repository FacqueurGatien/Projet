using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CompteBancaires
{
    public class CompteBancaire : IComparable<CompteBancaire>
    {
        /// <summary>Attribut de classe <see cref="int"/> incrementé à chaque création d'instance de <seealso cref="CompteBancaire"/></summary>
        private static int numeroGenerer = 0;
        /// <summary>Attribut d'instance <see cref="int"/> qui prend la valeur du numero généré par l'attribut de classe <seealso cref="numeroGenerer"/> a l'instanciation d'un <seealso cref="CompteBancaire"/></summary>
        private int numeroCompteBancaire;
        /// <summary>Attribut d'instance <see cref="string"/> qui prend la valeur du nom du proprietaire du <seealso cref="CompteBancaire"/> Instancié</summary>
        private string nomProprietaireDuCompte;
        /// <summary>Attribut d'instance <see cref="double"/> qui prend la valeur du montant monaitaire actuelement possédé par le <seealso cref="CompteBancaire"/> instancié </summary>
        private double soldeDuCompte;
        /// <summary>Attribut <see cref="int"/> qui prend la valeur du montant inferieur à 0 que le <seealso cref="soldeDuCompte"/> pourra ateindre par le <seealso cref="CompteBancaire"/></summary>
        private int decouvertAutoriserDuCompte;

        /// <summary>Accesseur de l'attribut d'instance <see cref="int"/> <seealso cref="numeroCompteBancaire"/></summary>
        public int NumeroCompteBancaire { get => numeroCompteBancaire; }
        /// <summary>Accesseur de l'attribut d'instance <see cref="string"/> <seealso cref="soldeDuCompte"/></summary>
        public double SoldeDuCompte { get => soldeDuCompte; }
        /// <summary>Accesseur de l'attribut d'instance <see cref="double"/> <seealso cref="decouvertAutoriserDuCompte"/></summary>
        public int DecouvertAutoriserDuCompte { get => decouvertAutoriserDuCompte; }
        /// <summary>Accesseur de l'attribut d'instance <see cref="int"/> <seealso cref="nomProprietaireDuCompte"/></summary>
        public string NomProprietaireDuCompte { get => nomProprietaireDuCompte; }
        /// <summary>Accesseur de l'attribut de classe <see cref="int"/> <seealso cref="numeroGenerer"/></summary>
        public static int NumeroGenerer { get => numeroGenerer; set => numeroGenerer = value; }
        /// <summary>
        /// Constructeur complet d'un <see cref="CompteBancaire"/> a partir des parametres <paramref name="_nom"/>, <paramref name="_solde"/>, <paramref name="_decouvert"/>
        /// </summary>
        /// <param name="_nom">Paramettre qui donnera sa valeur à <see cref="nomProprietaireDuCompte"/><br/>
        /// Il sagira du nom du proprietaire du <seealso cref="CompteBancaire"/> instancié</param>
        /// <param name="_solde">Paramettre qui donnera sa valeur à <see cref="soldeDuCompte"/><br/>
        /// Il sagira du montant monaitaire disponible sur le <seealso cref="CompteBancaire"/></param>
        /// <param name="_decouvert">Paramettre qui donnera sa valeur à <see cref="decouvertAutoriserDuCompte"/><br/>
        /// Il sagira du montant inferieur à 0 qui pourra etre ateint par le <seealso cref="soldeDuCompte"/></param>
        public CompteBancaire(string _nom, double _solde, int _decouvert)
        {
            numeroCompteBancaire = ++numeroGenerer;
            nomProprietaireDuCompte = _nom;
            soldeDuCompte = _solde;
            decouvertAutoriserDuCompte = _decouvert;
        }
        /// <summary>
        /// Constructeur minimum d'un <see cref="CompteBancaire"/> qui construit un compte a partir du seul argument <paramref name="_nom"/>
        /// </summary>
        /// <param name="_nom">Paramettre qui donnera sa valeur a <see cref="nomProprietaireDuCompte"/><br/>
        /// Il sagira du nom du proprietaire du <seealso cref="CompteBancaire"/> instancié</param>
        public CompteBancaire(string _nom)
            : this(_nom, 0, 0)
        {
            numeroCompteBancaire = ++numeroGenerer;
        }
        /// <summary>
        /// Constructeur par defaut d'un <see cref="CompteBancaire"/>
        /// </summary>
        public CompteBancaire()
            :this("",0,0)
        {

        }
        /// <summary>
        /// Constructeur de clone d'un <see cref="CompteBancaire"/>
        /// </summary>
        /// <param name="_compteBancaire"><see cref="CompteBancaire"/> deja instancié qui servira de model au constructeur de clone</param>
        public CompteBancaire(CompteBancaire _compteBancaire)
            : this(_compteBancaire.nomProprietaireDuCompte, _compteBancaire.soldeDuCompte, _compteBancaire.decouvertAutoriserDuCompte)
        {
            numeroCompteBancaire = _compteBancaire.numeroCompteBancaire;
        }
        /// <summary>
        /// Redefinition de la methode <see cref="System.Object.ToString"/> afin de la réutilisé dans la classe <see cref="CompteBancaire"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté affichant les caracteristiques actuel d'un <seealso cref="CompteBancaire"/></returns>
        public override string ToString()
        {
            string result = $"{base.ToString()}\n" + string.Format("{0,-25} {1,-10}\n", "nom:", nomProprietaireDuCompte);
            result += string.Format("{0,-25} {1,-10}\n", "numero:", numeroCompteBancaire);
            result += string.Format("{0,-25} {1,-10}\n", "solde:", soldeDuCompte);
            result += string.Format("{0,-25} {1,-10}\n", "decouvert:", decouvertAutoriserDuCompte);
            return result;
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un <paramref name="_montant"/> <see cref="double"/> envoyé en parametre au <seealso cref="SoldeDuCompte"/>
        /// </summary>
        /// <param name="_montant">Montant à ajouter au <see cref="soldeDuCompte"/></param>
        public void Crediter(double _montant)
        {
            try
            {
                if (_montant > 0)
                {
                    soldeDuCompte += _montant;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ex)
            {
                //
            }
        }
        /// <summary>
        /// Méthode qui permet de soustriare un <paramref name="_montant"/> au <see cref="soldeDuCompte"/><br/>
        /// du moment que le <seealso cref="CompteBancaire"/> possede les fonds suffisants
        /// </summary>
        /// <param name="_montant">Montant à soustraire au <see cref="soldeDuCompte"/></param>
        /// <returns>Un <see cref="bool"/> si l'operation est réalisable</returns>
        public bool Debiter(double _montant)
        {
            try
            {
                if (_montant > 0)
                {
                    if (soldeDuCompte - _montant >= decouvertAutoriserDuCompte)
                    {
                        soldeDuCompte -= _montant;
                        return true;
                    }
                    return false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode qui permet de transferer un <paramref name="_montant"/> au <see cref="soldeDuCompte"/><br/>
        /// (du moment que le <seealso cref="CompteBancaire"/> possede les fonds suffisants) sur le <paramref name="_autreCompteBancaire"/> donné en paramettre
        /// </summary>
        /// <param name="_autreCompteBancaire"><see cref="CompteBancaire"/> qui sera debité</param>
        /// <param name="_montant">Montant à transférer du <see cref="CompteBancaire"/> utilisé pour appeler la méthode au <paramref name="_autreCompteBancaire"/> donné en parametre </param>
        /// <returns>Un <see cref="bool"/> si l'operation est réalisable</returns>
        public bool Transferer(CompteBancaire _autreCompteBancaire, double _montant)
        {
            if (this != _autreCompteBancaire)
            {
                if (Debiter(_montant))
                {
                    _autreCompteBancaire.Crediter(_montant);
                    return true;
                }
                return false;
            }
            return false;
        }
        public int CompareTo(CompteBancaire other)
        {
            return other.soldeDuCompte.CompareTo(this.soldeDuCompte);
        }
        public static bool operator >(CompteBancaire _compte1, CompteBancaire _compte2)
        {
            return _compte1.soldeDuCompte > _compte2.soldeDuCompte;
        }
        public static bool operator <(CompteBancaire _compte1, CompteBancaire _compte2)
        {
            return _compte1.soldeDuCompte < _compte2.soldeDuCompte;
        }
    }
}
