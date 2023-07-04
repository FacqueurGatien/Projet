using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalModel
{
    public class CaisseB : Caisse
    {
        public CaisseB()
        {
            this.model = "CaisseB";
            base.valide = base.ProductionValide();
        }
        public override Caisse Clone()
        {
            return new CaisseB();
        }
        public override int VitesseProduction()
        {
            return 5000;
        }
    }
}
