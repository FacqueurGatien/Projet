using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEListBox2Model
{
    [Serializable]
    public abstract class Fichier 
    {
        public string Nom { get ; set ; }

        public void EnvoyerFichier(Dossier dossier)
        {
            dossier.DossierListe.Add(this);
        }
        public override string ToString()
        {
            return this.Nom;
        }
        public abstract string afficher(); //tostring??
    }
}
