using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Omnivore : Regime_alimentaire
    {
        public Omnivore()
            : base()
        {
        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            if (proie.Race == "Algue")
            {
                predateur.Pv += 1;
                proie.Pv -= 2;
                Console.WriteLine(predateur.Nom + "(" + predateur.Race + ") a ataqué une algue!");
            }
            else
            {
                if (predateur.Race == proie.Race && predateur.Canibal)
                {
                    predateur.Pv += 3;
                    proie.Pv -= 2;
                    Console.WriteLine(predateur.Nom + "(" + predateur.Race + ") a ataqué " + proie.Nom + " de la meme race!");
                }
                else
                {
                    predateur.Pv += 4;
                    proie.Pv -= 2;
                    Console.WriteLine(predateur.Nom + "(" + predateur.Race + ") a ataqué " + proie.Nom + "(" + proie.Race + ")!");
                }

            }
            if (Fonction.Est_il_mort(proie))
            {
                proie.Est_mort = true;
            }
            predateur.A_faim = false;
        }
    }
}
