using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Carnivore  : Regime_alimentaire
    {
        public Carnivore()
            :base()
        {

        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            if (proie.Race!="Algue") {
                predateur.Pv += 5;
                proie.Pv -= 4;
                Console.WriteLine(predateur.Nom + "(" + predateur.Race + ") a ataqué " + proie.Nom + "(" + proie.Race + ")!");
                if (Fonction.Est_il_mort(proie))
                {
                    proie.Est_mort = true;
                }
                predateur.A_faim = false;
            }
        }
    }
}
