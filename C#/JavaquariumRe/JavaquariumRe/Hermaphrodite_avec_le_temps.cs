using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Hermaphrodite_avec_le_temps : Comportement_Sexe
    {
        public Hermaphrodite_avec_le_temps()
            : base()
        {

        }
        public override void Changement_de_sexe(Forme_de_vie_aquatique poisson1,Forme_de_vie_aquatique poisson2)
        {
            change_avec_age(poisson1);
            change_avec_age(poisson2);
        }
        public void change_avec_age(Forme_de_vie_aquatique _poisson)
        {
            if (_poisson.Age == 10)
            {
                if (_poisson.Genre == "Male")
                {
                    _poisson.Genre = "Female";
                }
                else
                {
                    _poisson.Genre = "Female";
                }
            }
        }
    }
}
