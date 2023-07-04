using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalModel
{
    public class CaisseC : Caisse
    {
        public CaisseC()
        {
            this.model = "CaisseC";
            base.valide = base.ProductionValide();
        }
        public override Caisse Clone()
        {
            return new CaisseC();
        }
        public override int VitesseProduction()
        {
            return 10000;
        }
    }
}
