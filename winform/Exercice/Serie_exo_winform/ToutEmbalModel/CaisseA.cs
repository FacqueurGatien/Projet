using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalModel
{
    public class CaisseA : Caisse
    {
        public CaisseA()
        {
            this.model = "CaisseA";
            base.valide = base.ProductionValide();
        }

        public override Caisse Clone()
        {
            return new CaisseA();
        }
        public override int VitesseProduction()
        {
            return 1000;
        }
    }
}
