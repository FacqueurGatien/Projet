using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class P_null : Poisson
    {
        public P_null(string _genre = "")
        : base(new Photosynthese(), new Monosexue())
        {
            this.Race = "none";
            this.Regime = "none";
            this.Genre = "none";
            this.Age = 0;
            this.Pv = 0;
            this.Nom = Fonction.Nom_aleatoire("none");
        }
        public P_null()
            : base()
        {

        }
        public override void Change_de_regime(string arg)
        {
            //Nothing
        }
        public override bool Peut_s_accoupler(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant)
        {
                return false;
        }
        public override Forme_de_vie_aquatique Accouplement(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant)
        {
            return new P_null();
        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            //Nothing
        }
        public override void Mort(string arg)
        {
            //Nothing
        }
    }
}
