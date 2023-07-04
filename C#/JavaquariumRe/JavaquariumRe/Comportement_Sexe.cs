using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public abstract class Comportement_Sexe
    {
        public Comportement_Sexe()
            :base()
        {
            
        }
        public abstract void Changement_de_sexe(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique pretendant);
    }
}
