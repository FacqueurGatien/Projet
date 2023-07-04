using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class P_thon : Poisson
    {
        public P_thon(string _genre = "")
            :base(new Carnivore(),new Monosexue())
        {
            this.Race = "Thon";
            this.Regime = "Carnivore";
            this.Genre = _genre;
            this.Age = 0;
            this.Pv = 10;
            this.Nom = Fonction.Nom_aleatoire(_genre);
        }
        public P_thon()
            :base(new Carnivore(), new Monosexue())
        {
            this.Race = "Thon";
            this.Regime = "Carnivore";
            this.Genre = Fonction.Sexe_aleatoire();
            this.Age = 0;
            this.Pv = 10;
            this.Nom = Fonction.Nom_aleatoire(this.Genre);
        }
        public override bool Peut_s_accoupler(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant)
        {
            if (_aspirant.Race==_pretendant.Race 
                && _aspirant.Genre!=_pretendant.Genre)
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
            Console.WriteLine("Une fécondation a eu lieu entre " + _aspirant.Nom + " et " + _pretendant.Nom + " les " + _aspirant.Race + "s!");
            _aspirant.Veux_s_accoupler = false;
            _pretendant.Veux_s_accoupler = false;
            Forme_de_vie_aquatique nouveau_nee = new P_thon();
            Console.WriteLine(nouveau_nee.Nom + " le Thon est née!");
            return nouveau_nee;
        }
        public override void Change_de_regime(string arg)
        {
            this.Regime_Alimentaire=Fonction.Change_regime(arg);
        }
        public override void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie)
        {
            this.Regime_Alimentaire.Nourir(predateur, proie);
        }
        public override void Mort(string arg)
        {
            switch (arg)
            {
                case "faim":
                    Console.WriteLine(this.Nom + " le Thon est mort de faim!");
                    break;
                case "temps":
                    Console.WriteLine(this.Nom + " le Thon est mort de veillesse!");
                    break;
                case "mange":
                    Console.WriteLine(this.Nom + " le Thon à été dévoré!");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}

