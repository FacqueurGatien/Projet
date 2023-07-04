using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Bouteille
    {
        private int capaciteActuelEnMl;
        private int capaciteMaxEnMl;
        private bool estOuverte;

        public int CapaciteActuelEnMl { get => capaciteActuelEnMl; set => capaciteActuelEnMl = value; }
        public int CapaciteMaxEnMl { get => capaciteMaxEnMl; set => capaciteMaxEnMl = value; }
        public bool EstOuverte { get => estOuverte; set => estOuverte = value; }

        public Bouteille(int _capaciteMaxEnMl)
        {
            capaciteMaxEnMl = _capaciteMaxEnMl;
            capaciteActuelEnMl = _capaciteMaxEnMl;
            estOuverte = false;
        }
        public bool OuvrirBouteille()
        {
            return !estOuverte ? estOuverte = true : false;
        }
        public bool FermerBouteille()
        {
            return estOuverte ? (estOuverte = false)==false : false;
        }
        public bool viderBouteil()
        {
            return viderBouteil(capaciteActuelEnMl);
        }
        public bool remplirBouteil()
        {
            return remplirBouteil(capaciteMaxEnMl - capaciteActuelEnMl);
        }
        public bool viderBouteil(int _quantiteEnMl)
        {
            if (estOuverte && _quantiteEnMl > 0 && capaciteActuelEnMl - _quantiteEnMl >= 0)
            {
                capaciteActuelEnMl -= _quantiteEnMl;
                return true;
            }
            return false;
        }
        public bool remplirBouteil(int _quantiteEnMl)
        {
            if (estOuverte && _quantiteEnMl > 0 && _quantiteEnMl + capaciteActuelEnMl <= capaciteMaxEnMl)
            {
                capaciteActuelEnMl += _quantiteEnMl;
                return true;
            }
            return false;
        }
    }
}
