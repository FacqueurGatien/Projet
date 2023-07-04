using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal class Chrysalide : Stade
    {
        public override Stade Evolue()
        {
            return new Papillon();
        }
        public override string SeDeplacer()
        {
            return "Reste immobile";
        }
    }
}
