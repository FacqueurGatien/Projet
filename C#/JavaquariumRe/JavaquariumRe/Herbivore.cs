using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Herbivore : Regime_alimentaire
    {
        public Herbivore()
            : base()
        {
        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            if (proie.Race=="Algue") {
                predateur.Pv += 4;
                proie.Pv -= 2;
                Console.WriteLine(predateur.Nom + "(" + predateur.Race + ") a ataqué une algue!");
                if (Fonction.Est_il_mort(proie))
                {
                    proie.Est_mort = true;
                }
                if (!Fonction.A_t_il_faim(predateur))
                {
                    predateur.A_faim = false;
                }
            }
        }
    }
}
