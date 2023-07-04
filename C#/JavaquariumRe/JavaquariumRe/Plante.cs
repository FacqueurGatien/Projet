using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public abstract class Plante : Forme_de_vie_aquatique
    {
        private Regime_alimentaire? regime_Alimentaire;
        private Comportement_Sexe? sexe;

        public Plante(Regime_alimentaire _regime_Alimentaire, Comportement_Sexe _sexe)
            : base()
        {
            this.Regime_Alimentaire = _regime_Alimentaire;
            this.Sexe = _sexe;
        }
        public Plante()
            : base()
        {
            this.Regime_Alimentaire = regime_Alimentaire;
            this.Sexe = sexe;
        }
        public Regime_alimentaire Regime_Alimentaire { get => regime_Alimentaire; set => regime_Alimentaire = value; }
        public Comportement_Sexe Sexe { get => sexe; set => sexe = value; }
    }
}
