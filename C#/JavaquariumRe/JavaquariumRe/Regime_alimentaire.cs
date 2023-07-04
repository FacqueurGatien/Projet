using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public abstract class Regime_alimentaire
    {
        public Regime_alimentaire()
            :base()
        {

        }
        public abstract void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie);
    }
}
