using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal class Lepidoptere
    {
        Stade stade;
        public Lepidoptere()
        {
            stade = new Oeuf();
        }

        internal Stade Stade { get => stade; set => stade = value; }

        public void Evolue()
        {
            stade=stade.Evolue();
        }
        public string SeDeplacer()
        {
            return stade.SeDeplacer();
        }
    }
}
