using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal class Papillon : Stade
    {
        public override Stade Evolue()
        {
            return new Mort();
        }
        public override string SeDeplacer()
        {
            return "Vole";
        }
    }
}
