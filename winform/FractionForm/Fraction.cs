using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionForm
{
    /// <summary>
    /// Genere une instance de Fraction
    /// </summary>
    internal class Fraction
    {
        /// <summary>Denominateur de la fraction (partie basse)</summary>
        int denominator;
        /// <summary>Numerateur de la fraction (partie haute)</summary>
        int numerator;

        public int Denominator { get => denominator; set => denominator = value; }
        public int Numerator { get => numerator; set => numerator = value; }

        /// <summary>
        /// Constructeur de la classe Fraction
        /// </summary>
        public Fraction()
        {
            denominator = 1;
            numerator = 0;
        }
        /// <summary>
        /// Clone du Constructeur de la classe Fraction
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction(Fraction _fraction)
        {
            denominator = _fraction.denominator;
            numerator = _fraction.numerator;
        }
        /// <summary>
        /// Constructeur de la classe Fraction a partir d'un numerateur
        /// </summary>
        /// <param name="_numerator"></param>
        public Fraction(int _numerator)
        {
            denominator = 1;
            numerator = _numerator;
        }
        /// <summary>
        /// Constructeur de la classe Fraction a partir d'un numerateur et d'un denomitateur
        /// </summary>
        /// <param name="_numerator"></param>
        /// <param name="denominator"></param>
        public Fraction(int _numerator, int _denominator)
        {
            denominator = _denominator;
            numerator = _numerator;
        }
        /// <summary>
        /// Fonction d'affichage de la classe Fraction
        /// </summary>
        /// <returns> Renvoie un resultat textuel des element de la fraction</returns>
        public string ToDisplay()
        {
            /*
            string resultat = "";
            int temp;
            if(numerator.ToString().Length > denominator.ToString().Length)
            {
                temp = numerator.ToString().Length;
            }
            else
            {
                temp = denominator.ToString().Length;
            }
            for(int i = 0; i<temp;i++)
            {
                resultat += "-";
            }
            return $"{numerator}\n{resultat}\n{denominator}";
            */
            return $"{numerator}/{denominator}";
        }
        /// <summary>
        /// Divisie la fraction par une autre
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns></returns>
        public Fraction Divide(Fraction _otherFraction)
        {
            Fraction temp = new(_otherFraction);
            temp.Invert();
            temp = Multiply(temp);
            temp.Reduce();
            return temp;
        }
        /// <summary>
        /// Verifie si la fraction et egal a l'autre
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>Un booleen true si les fraction sont egale</returns>
        public bool EqualeTo(Fraction _otherFraction)
        {
            return numerator / denominator == _otherFraction.numerator / _otherFraction.denominator ? true : false;
        }
        /// <summary>
        /// cherche le PGCD de la fraction
        /// </summary>
        /// <returns>Le PGCD de la fraction</returns>
        public int GetPgcd()
        {
            int a = this.numerator;
            int b = this.denominator;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }
        /// <summary>
        /// Permet de calculer la valeur en decimale de la fraction
        /// </summary>
        /// <returns> LA valeur de la fraction en decimale</returns>
        public float GetValue()
        {
            return numerator / (float)denominator;
        }
        /// <summary>
        /// Inverse le numerateur et le denominateur
        /// </summary>
        public void Invert()
        {
            denominator = numerator + denominator;
            numerator = denominator - numerator;
            denominator -= numerator;
        }
        /// <summary>
        /// Creer une nouvelle fraction en soustraiant la fraction avec l'autre fraction et la reduit
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>la fraction reduite, créer a partir des 2 autres</returns>
        public Fraction Sub(Fraction _otherFraction)
        {
            Fraction temp = new(_otherFraction);
            temp.Oposite();
            temp = Add(temp);
            temp.Reduce();
            return temp;
        }
        /// <summary>
        /// Creer une nouvelle fraction en multipliant la fraction avec l'autre fraction et la reduit
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>la fraction reduite, créer a partir des 2 autres</returns>
        public Fraction Multiply(Fraction _otherFraction)
        {
            int newNumerator = numerator * _otherFraction.numerator;
            int newDenominator = denominator * _otherFraction.denominator;
            Fraction fracTemp = new(newNumerator, newDenominator);
            fracTemp.Reduce();
            return fracTemp;
        }
        /// <summary>
        /// inverse le signe de la fraction
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>la fraction reduite, créer a partir des 2 autres</returns>
        public void Oposite()
        {
            numerator = -numerator;
            if (numerator < 0 && denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }
        /// <summary>
        /// Creer une nouvelle fraction en additionnant la fraction avec l'autre fraction et la reduit
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>la fraction reduite, créer a partir des 2 autres</returns>
        public Fraction Add(Fraction _otherFraction)
        {
            int newNumerator = (numerator * _otherFraction.denominator) + (_otherFraction.numerator * denominator);
            int newDenominator = (denominator * _otherFraction.denominator);
            Fraction fracTemp = new(newNumerator, newDenominator);
            fracTemp.Reduce();
            return fracTemp;
        }
        /// <summary>
        /// Permet de reduire la fraction au plus petit
        /// </summary>
        public void Reduce()
        {
            int temp = 1;
            int pdcg = GetPgcd();
            if (numerator / denominator < 0)
            {
                temp = -1;
            }
            numerator = Math.Abs(numerator) / pdcg * temp;
            denominator /= Math.Abs(pdcg);
        }
        /// <summary>
        /// Permet de verifier si la fraction ets superieur a l'autre fraction
        /// </summary>
        /// <param name="_otherFraction">Fraction envoyé en parametre de la fonction</param>
        /// <returns>Un booleen qui retourne true si la fraction est superieur a l'autre</returns>
        public bool SupTo(Fraction _otherFraction)
        {
            return numerator / denominator > _otherFraction.numerator / _otherFraction.denominator ? true : false;
        }
    }
}
