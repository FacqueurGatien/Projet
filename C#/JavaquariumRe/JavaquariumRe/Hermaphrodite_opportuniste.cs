using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Hermaphrodite_opportuniste : Comportement_Sexe
    {
        public Hermaphrodite_opportuniste()
            : base()
        {

        }
        public override void Changement_de_sexe(Forme_de_vie_aquatique poisson1, Forme_de_vie_aquatique poisson2)
        {
            if (poisson1.Genre == poisson2.Genre && poisson1.Race==poisson2.Race)
            {
                if (poisson1.Genre == "Male")
                {
                    poisson1.Genre = "Female";
                }
                else
                {
                    poisson1.Genre = "Male";
                }
            }
        }
    }
}
