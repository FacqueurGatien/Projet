using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalModel
{
    public enum EnumEtat
    {
        Actif,
        Inactif,
        Pause
    }
    public class Production
    {

        public delegate void ProductionStart(Production p);
        public event ProductionStart EventProductionStart;

        public delegate void ProductionChange(Production p);
        public event ProductionChange EventProductionChange;

        public delegate void ProductionCaisseValide(Production p);
        public event ProductionCaisseValide EventProductionCaisseValide;

        public delegate void ProductionStop(Production p);
        public event ProductionStop EventProductionStop;

        public delegate void ProductionPause(Production p);
        public event ProductionPause EventProductionPause;

        public delegate void ProductionReprise(Production p);
        public event ProductionReprise EventProductionReprise;

        public delegate void ProductionEnregistrer(Production p);
        public event ProductionEnregistrer EventProductionEnregistrer;

        private Caisse model;
        private int productionObjectif;
        private List<Caisse> caisseProduite;
        private EnumEtat etat = EnumEtat.Inactif;
        private Thread temp;
        private string nomProd;

        public Production(Caisse _model, int _productionObjectif,string _nom)
        {
            nomProd = "Production " + _nom;
            Model = _model;
            ProductionObjectif = _productionObjectif;
            caisseProduite = new List<Caisse>();
            temp = new Thread(new ThreadStart(Start));
            
        }

        public Production() : this(null, 0,"")
        {
        }
        public Production(Production _p) : this(_p.model, _p.productionObjectif,_p.nomProd)
        {
        }
        public float NombreInvalid()
        {
            int compteur = 0;
            foreach (Caisse c in caisseProduite)
            {
                if (!c.Valide)
                {
                    compteur++;
                }
            }
            return compteur*100/caisseProduite.Count;
        }
        public float NombreInvalidHeure()
        {
            if (caisseProduite.Count > model.VitesseProduction())
            {
                int compteur=0;
                for (int i = caisseProduite.Count-model.VitesseProduction();i<caisseProduite.Count; i++)
                {
                    if (!caisseProduite[i].Valide)
                    {
                        compteur++;
                    }
                }
                return compteur * 100 /caisseProduite.Count - model.VitesseProduction();
            }
            else
            {
                return NombreInvalid(); 
            }
        }
        public int ProductionObjectif { get => productionObjectif; set => productionObjectif = value; }
        public Caisse Model { get => model; set => model = value; }
        public EnumEtat Etat { get => etat;set => etat = value; }
        public List<Caisse> CaisseProduite
        {
            get => caisseProduite;
            set
            {
                caisseProduite = value;
            }
        }

        public Thread Temp { get => temp; set => temp = value; }
        public string NomProd { get => nomProd; set => nomProd = value; }


        private void ResetProduction()
        {
            caisseProduite.Clear();
        }

        public void StartProduction()
        {
            temp = new Thread(new ThreadStart(Start));
            temp.Start();
            this.etat = EnumEtat.Actif;
        }
        public void BreakProduction()
        {
            if (EventProductionPause!=null)
            {
                EventProductionPause(this);
            }
            this.etat = EnumEtat.Pause;
        }
        public void ContinueProduction()
        {
            if (EventProductionReprise!=null)
            {
                EventProductionReprise(this);
            }
            this.etat = EnumEtat.Actif;
        }

        private void Start()
        {
            if (EventProductionStart != null)
            {
                EventProductionStart(this);
            }
            while (productionObjectif > caisseProduite.Count && etat!=EnumEtat.Inactif)
            {
                if (etat!=EnumEtat.Pause)
                {
                    CaisseProduite.Add(Model.Clone());
                    if (EventProductionChange != null)
                    {
                        EventProductionChange(this);
                    }
                    if (EventProductionCaisseValide != null && caisseProduite.Count > 0)
                    {
                        EventProductionCaisseValide(this);
                    }
                    Thread.Sleep((int)((Model.VitesseProduction() / 3600f) * 1000));
                }
            }
            etat = EnumEtat.Inactif;
            ResetProduction();
            if (EventProductionStop != null)
            {
                EventProductionStop(this);
                if (EventProductionEnregistrer != null)
                {
                    EventProductionEnregistrer(this);
                }
            }
        }
    }
}
