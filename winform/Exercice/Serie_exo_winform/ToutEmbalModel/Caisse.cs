using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalModel
{
    public abstract class Caisse
    {
        protected string model;
        protected bool valide;
        public Caisse()
        {

        }
        public bool ProductionValide()
        {
            return new Random().Next(0, 100) < 90;
        }
        public string Model { get => model; }
        public bool Valide { get => valide; }
        public abstract int VitesseProduction();
        public abstract Caisse Clone();
    }
}
