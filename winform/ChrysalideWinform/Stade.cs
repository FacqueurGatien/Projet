using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrysalideWinform
{
    internal abstract class Stade
    {
        public Stade()
        {

        }
        public string ToDisplay()
        {
            return $"Mon stade Actuel: {GetType().Name}.";
        }
        public virtual string Cry()
        {
            return "pouic-pouic";
        }
        public abstract string SeDeplacer();
        public abstract Stade Evolue();
    }
}
