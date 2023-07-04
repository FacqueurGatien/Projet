using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal class Chenille : Stade
    {
        public override Stade Evolue()
        {
            return new Chrysalide();
        }

        public override string SeDeplacer()
        {
            return "Rampe";
        }
    }
}
