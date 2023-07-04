using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public abstract class Forme_de_vie_aquatique
    {

        private string? nom;
        private string? race;
        private int? age;
        private int? pv;
        private string? genre;
        private string? regime;
        private bool est_mort;
        private bool a_faim;
        private bool veux_s_accoupler;
        private bool canibal;

        public Forme_de_vie_aquatique()
        {
            this.Nom = nom;
            this.Race = race;
            this.Age = age;
            this.Pv = pv;
            this.Genre = genre;
            this.Regime = regime;
            this.Est_mort = false;
            this.A_faim = false;
            this.Veux_s_accoupler = false;
            this.Canibal = false;
    }
        public Forme_de_vie_aquatique(string _nom, string _race, int _age, int _pv)
        {
            this.nom = _nom;
            this.race = _race;
            this.age = _age;
            this.pv = _pv;
            this.Genre = genre;
            this.Regime = regime;
            this.Est_mort = false;
            this.A_faim = false;
            this.Veux_s_accoupler = false;
            this.Canibal = false;
        }
        public abstract void Nourir(Forme_de_vie_aquatique predateur, Forme_de_vie_aquatique proie);
        public abstract Forme_de_vie_aquatique Accouplement(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant);
        public abstract bool Peut_s_accoupler(Forme_de_vie_aquatique _aspirant, Forme_de_vie_aquatique _pretendant=null);
        public abstract void Mort(string arg);
        public abstract void Un_tour_passe();
        public abstract void Change_de_regime(string arg);


        public string? Nom { get => nom; set => nom = value; }
        public string? Race { get => race; set => race = value; }
        public int? Age { get => age; set => age = value; }
        public int? Pv { get => pv; set => pv = value; }
        public string? Genre { get => genre; set => genre = value; }
        public string? Regime { get => regime; set => regime = value; }
        public bool Est_mort { get => est_mort; set => est_mort = value; }
        public bool A_faim { get => a_faim; set => a_faim = value; }
        public bool Veux_s_accoupler { get => veux_s_accoupler; set => veux_s_accoupler = value; }
        public bool Canibal { get => canibal; set => canibal = value; }
    }
}
