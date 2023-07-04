using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Pl_algue : Plante
    {
        public Pl_algue(int Pv)
            : base(new Herbivore(), new Monosexue())
        {
            this.Race = "Algue";
            this.Regime = "Photosynthese";
            this.Genre = "Assexue";
            this.Age = 0;
            this.Pv = 10;
            this.Nom = "none";
        }
        public Pl_algue()
            : base(new Herbivore(), new Monosexue())
        {
            this.Race = "Algue";
            this.Regime = "Photosynthese";
            this.Genre = "Assexue";
            this.Age = 0;
            this.Pv = 10;
            this.Nom = "none";
        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            this.Regime_Alimentaire.Nourir(predateur, proie);
        }
        public override void Change_de_regime(string arg)
        {
            //Nothing
        }
        public override bool Peut_s_accoupler(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant=null)
        {
            if (_aspirant.Age==10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Forme_de_vie_aquatique Accouplement(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant)
        {
            _aspirant.Pv /= 2;
            return new Pl_algue(int.Parse(_aspirant.Pv.ToString()));
        }
        public override void Mort(string arg)
        {
            switch (arg)
            {
                case "temps":
                    Console.WriteLine("Une Algue c'est fanée");
                    break;
                case "mange":
                    Console.WriteLine("Une Algue à été dévoré");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
        public override void Un_tour_passe()
        {
            this.Age++;
            this.Pv++;
        }
    }
}
