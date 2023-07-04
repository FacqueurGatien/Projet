using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal class Oeuf : Stade
    {
        public override string Cry()
        {
            return "---";
        }

        public override Stade Evolue()
        {
            return new Chenille();
        }
        public override string SeDeplacer()
        {
            return "Reste immobile";
        }
    }
}
