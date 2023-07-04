namespace ToutEmbalModel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Production prodCaisseA = new Production(new CaisseA(),100, "Production A");
            prodCaisseA.EventProductionChange += CheckProd;
            prodCaisseA.EventProductionStop += CheckProdFinish;
            prodCaisseA.EventProductionStart += StartProd;
            prodCaisseA.EventProductionCaisseValide += Valide;


            Production prodCaisseB = new Production(new CaisseB(), 100, "Production B");
            prodCaisseB.EventProductionChange += CheckProd;
            prodCaisseB.EventProductionStop += CheckProdFinish;
            prodCaisseB.EventProductionStart += StartProd;            
            prodCaisseB.EventProductionCaisseValide += Valide;


            Production prodCaisseC = new Production(new CaisseC(), 100, "Production B");
            prodCaisseC.EventProductionChange += CheckProd;
            prodCaisseC.EventProductionStop += CheckProdFinish;
            prodCaisseC.EventProductionStart += StartProd;            
            prodCaisseC.EventProductionCaisseValide += Valide;



            prodCaisseA.StartProduction();
            prodCaisseB.StartProduction();
            prodCaisseC.StartProduction();

        }
        public static void Valide(Production p)
        {
            if (p.CaisseProduite[p.CaisseProduite.Count-1].Valide)
            {
                Console.WriteLine($"La caisse N° {p.CaisseProduite.Count} est valide.");
            }
            else
            {
                Console.WriteLine($"La caisse N° {p.CaisseProduite.Count} n'est pas valide.");
            }

        }
        public static void StartProd(Production p)
        {
            Console.WriteLine($"La production Commence.");
        }
        public static void CheckProd(Production p)
        {
            Console.WriteLine($"La production  de {p.Model.Model} est actuellement {p.CaisseProduite.Count} Caisse(s).");
        }
        public static void CheckProdFinish(Production p)
        {
            Console.WriteLine($"La production de {p.Model.Model} est Terminé!");
        }
    }
}