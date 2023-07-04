using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaires
{
    public class Banque
    {
        /// <summary>Attribut d'instance <see cref="List{T}"/> de <seealso cref="Banque"/> contenant des <seealso cref="CompteBancaire"/></summary>
        private List<CompteBancaire> mesComptes;
        /// <summary>Attribut d'instance <see cref="string"/> qui definit le nom de la <seealso cref="Banque"/></summary>
        private string nomBanque;
        /// <summary>Attribut d'instance <see cref="string"/> qui indique le nom de la ville ou ce situe la <seealso cref="Banque"/></summary>
        private string nomVille;

        /// <summary>Accesseur de l'atribut d'instance <see cref="List{T}"/> <seealso cref="mesComptes"/></summary>
        public List<CompteBancaire> MesComptes { get => mesComptes; }
        /// <summary>Accesseur de l'atribut d'instance <see cref="string"/> <seealso cref="nomBanque"/></summary>
        public string NomBanque { get => nomBanque; }
        /// <summary>Accesseur de l'atribut d'instance <see cref="string"/> <seealso cref="nomVille"/></summary>
        public string NomVille { get => nomVille; }

        /// <summary>
        /// Constructeur Complet d'une <see cref="Banque"/>
        /// </summary>
        /// <param name="_nomBanque">Paramettre qui donnera sa valeur à <see cref="nomBanque"/></param>
        /// <param name="_nomVille">Paramettre qui donnera sa valeur à <see cref="nomVille"/></param>
        public Banque(string _nomBanque , string _nomVille)
        {
            nomBanque = _nomBanque;
            nomVille = _nomVille;
            mesComptes = new();
        }
        /// <summary>
        /// Constructeur par défaut d'une <see cref="Banque"/>
        /// </summary>
        public Banque()
            :this("","")
        {

        }
        /// <summary>
        /// Constructeur de Clone d'une <see cref="Banque"/>
        /// </summary>
        /// <param name="_banque"><see cref="Banque"/> deja instancié qui servira de model au constructeur de clone</param>
        public Banque(Banque _banque)
            :this(_banque.NomBanque,_banque.NomVille)
        {
        }
        /// <summary>
        /// Méthode qui sert à ajouter un <see cref="CompteBancaire"/> a la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/>
        /// </summary>
        /// <param name="_compteBancaire"><see cref="CompteBancaire"/> donné en paramettre au constructeur de clone d <seealso cref="CompteBancaire"/> afin de l'ajouter à la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/></param>
        public void AjoutCompte(CompteBancaire _compteBancaire)
        {
            mesComptes.Add(_compteBancaire);
        }
        /// <summary>
        /// Méthode qui sert à ajouter un <see cref="CompteBancaire"/> a la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/>
        /// </summary>
        /// <param name="_nomProprietaireCompte">Nom du proprietaire à donné en paramettre au constructeur de <see cref="CompteBancaire"/> afin de l'ajouter à la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/></param>
        /// <param name="_soldeCompte">Montant monaitaire à donné en paramettre au constructeur de <see cref="CompteBancaire"/> afin de l'ajouter à la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/></param>
        /// <param name="_decouvert">Montant inferieur à 0 qui pourra etre ateint par le <see cref="soldeDuCompte"/> à donné en paramettre au constructeur de <see cref="CompteBancaire"/> afin de l'ajouter à la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/></param>
        public void AjoutCompte(string _nomProprietaireCompte , int _soldeCompte , int _decouvert)
        {
            AjoutCompte(new CompteBancaire(_nomProprietaireCompte,_soldeCompte,_decouvert));
        }
        /// <summary>
        /// Redefinition de la methode <see cref="System.Object.ToString"/> afin de la réutilisé dans la classe <see cref="Banque"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté affichant les caracteristiques actuel d'une <seealso cref="Banque"/></returns>
        public override string ToString()
        {
            string result = $"{base.ToString()}\n"+string.Format("{0, -20} {1,-15}\n","Nom de la banque",nomBanque);
            result += string.Format("{0, -20} {1,-15}\n", "Ville de la banque", NomVille);
            return result;
        }
        /// <summary>
        /// Méthode qui renvoie le <see cref="CompteBancaire"/> avec le plus grand <seealso cref="CompteBancaire.soldeDuCompte"/> contenue dans la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/>
        /// </summary>
        /// <returns>Le <see cref="CompteBancaire"/> avec le <seealso cref="CompteBancaire.soldeDuCompte"/> le plus grand de la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/></returns>
        public CompteBancaire? CompteSup()
        {
            List<CompteBancaire> tmp = new List<CompteBancaire>(mesComptes);
            if (tmp.Count() > 0)
            {
                tmp.Sort();
                return tmp[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Méthode qui renvoie le <see cref="CompteBancaire"/> de la <seealso cref="List{T}"/> <seealso cref="mesComptes"/> de la <seealso cref="Banque"/> (si il existe) ayant le <paramref name="_numeroCompte"/> donné en parametre
        /// </summary>
        /// <param name="_numeroCompte">Nombre donné en paramettre pour la recherche du <see cref="CompteBancaire.numeroCompteBancaire"/></param>
        /// <returns>Le <see cref="CompteBancaire"/> avec le <paramref name="_numeroCompte"/> correspondant au nombre donné en parametre</returns>
        public CompteBancaire? RendCompte(int _numeroCompte)
        {
            return mesComptes.Find(compte =>compte.NumeroCompteBancaire == _numeroCompte);
        }
        /// <summary>
        /// Méthode qui permet de transferer un montant du <see cref="CompteBancaire"/> associé au <paramref name="_numeroCompteDebit"/> donné en parametre , <br/>
        /// vers le <seealso cref="CompteBancaire"/> associé au <paramref name="_numeroCompteCredit"/> donné en parametre.
        /// </summary>
        /// <param name="_numeroCompteDebit"></param>
        /// <param name="_numeroCompteCredit"></param>
        /// <param name="_montant"></param>
        /// <returns></returns>
        public bool Transferer(int _numeroCompteDebit, int _numeroCompteCredit , int _montant)
        {
            CompteBancaire compteDebit=null;
            CompteBancaire compteCredit=null;
            if(mesComptes.Count() > 1)
            {
                foreach (CompteBancaire compte in mesComptes)
                {
                    if (compte.NumeroCompteBancaire == _numeroCompteDebit)
                    {
                        compteDebit = compte;
                    }
                    if (compte.NumeroCompteBancaire == _numeroCompteCredit)
                    {
                        compteCredit = compte;
                    }
                }
            }
            if (compteCredit != null && compteDebit != null)
            {
                return compteDebit.Transferer(compteCredit , _montant);
            }
            else
            {
                return false;
            }
        }
    }
}
