using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Aquarium
    {
        private string nom;
        private int taille;
        private List<Forme_de_vie_aquatique> listing_aquarium;
        private int place_libre;

        public Aquarium(string _nom)
        {
            this.nom = _nom;
            this.taille = 20;
            this.listing_aquarium = new List<Forme_de_vie_aquatique>();
            this.place_libre = taille;
        }

        public void Creation_aquarium()
        {
            for(int itteration = 0; itteration < taille; itteration++)
            {
                listing_aquarium.Add(new P_null(""));
            }
        }

        public void Ajout_dans_aquarium(Forme_de_vie_aquatique etre_vivant)
        {
            if (place_libre > 0)
            {
                int nombre = 1;
                int index=0;
                while (nombre > 0 && index<listing_aquarium.Count())
                {
                    if (listing_aquarium[index].Race == "none")
                    {
                        listing_aquarium[index] = etre_vivant;
                        nombre--;
                        place_libre--;
                    }
                    index++;
                }
            }
        }
        public void Affichage_aquarium()
        {
            Console.WriteLine(" _____________________________________________________________________________________________________________");
            int num = 1;
            foreach (Forme_de_vie_aquatique etre_vivant in listing_aquarium)
            {
                Console.WriteLine("|\tN°" + num +
                    "\t : nom:" + etre_vivant.Nom +
                    "\t | sexe:" + etre_vivant.Genre + 
                    "\t | age:" + etre_vivant.Age +
                    "\t | pv: " + etre_vivant.Pv +
                    "\t | race:" + etre_vivant.Race +
                    "\n|_____________________________________________________________________________________________________________|");
                num++;
            }
        }
        public void Manger()
        {
            int predateur = 0;
            while (predateur < listing_aquarium.Count())
            {
                int proie = 0;
                if (listing_aquarium[predateur].Race != "none" && listing_aquarium[predateur].A_faim)
                {
                    while(proie<listing_aquarium.Count() && listing_aquarium[predateur].A_faim)
                    {
                        if(predateur != proie 
                            && listing_aquarium[proie].Race != "none" 
                            && 
                            (listing_aquarium[predateur].Canibal 
                            || 
                            listing_aquarium[proie].Race != listing_aquarium[predateur].Race))
                        {
                            listing_aquarium[predateur].Nourir(listing_aquarium[predateur],listing_aquarium[proie]);
                            if (listing_aquarium[proie].Est_mort)
                                {
                                listing_aquarium[proie].Mort("mange");
                                listing_aquarium[proie] = new P_null("none");
                                place_libre++;
                            }
                            
                        }
                        proie++;
                    }
                }
                predateur++;
            }
        }
        public void Reproduction()
        {
            int aspirant = 0;
            if (place_libre > 0)
            {
                while (aspirant < listing_aquarium.Count())
                {
                    int pretendant = 0;
                    if (listing_aquarium[aspirant].Race != "none" && listing_aquarium[aspirant].Veux_s_accoupler)
                    {
                        while (pretendant < listing_aquarium.Count() && listing_aquarium[aspirant].Veux_s_accoupler)
                        {
                            if ((listing_aquarium[aspirant].Race=="Algue" 
                                && listing_aquarium[aspirant].Peut_s_accoupler(listing_aquarium[aspirant])
                                || 
                                (aspirant != pretendant
                                && listing_aquarium[aspirant].Race!="Algue"
                                && listing_aquarium[pretendant].Race != "none"
                                && listing_aquarium[pretendant].Veux_s_accoupler
                                && listing_aquarium[aspirant].Peut_s_accoupler(listing_aquarium[aspirant], listing_aquarium[pretendant]))))
                            {
                                Forme_de_vie_aquatique nouveau_nee =listing_aquarium[aspirant].Accouplement(listing_aquarium[aspirant], listing_aquarium[pretendant]);
                                Ajout_dans_aquarium(nouveau_nee);
                            }
                            pretendant++;
                        }
                    }
                    aspirant++;
                }
            }
        }
        public void Listing_apres_un_tour()
        {
            foreach (Forme_de_vie_aquatique etre_vivant in listing_aquarium)
            {
                if (etre_vivant.Race != "none")
                {
                    etre_vivant.Un_tour_passe();
                    if (etre_vivant.Age > 20)
                    {
                        etre_vivant.Est_mort = true;
                        etre_vivant.Mort("temps");
                    }
                    else
                    {
                        switch (etre_vivant.Pv)
                        {
                            case <= 0:
                                etre_vivant.Est_mort = true;
                                etre_vivant.Mort("faim");
                                break;
                            case < 5:
                                etre_vivant.Est_mort = false;
                                etre_vivant.A_faim = true;
                                etre_vivant.Veux_s_accoupler = false;
                                break;
                            case >= 5:
                                etre_vivant.Est_mort = false;
                                etre_vivant.A_faim = false;
                                etre_vivant.Veux_s_accoupler = true;
                                break;
                            default:
                                Console.WriteLine("Invalid Pv");
                                break;
                        }
                    }
                }
            }
            Retrait_mort();
            int nombre_poisson_diferente = Fonction.Combien_de_poisson(listing_aquarium);
            int nombre_plante_diferente = Fonction.Combien_de_plante(listing_aquarium);
            foreach (Forme_de_vie_aquatique etre_vivant in listing_aquarium)
            {
                if (etre_vivant.Regime == "Carnivore" && nombre_poisson_diferente == 1 && nombre_plante_diferente == 1 && etre_vivant.Pv <= 3)
                {
                    etre_vivant.Change_de_regime("Omnivore");
                }
                else if (etre_vivant.Regime == "Herbivore" && nombre_plante_diferente == 0 && etre_vivant.Pv <= 2 && nombre_poisson_diferente > 1)
                {
                    etre_vivant.Change_de_regime("Omnivore");
                }
                else if (nombre_plante_diferente == 0 && nombre_poisson_diferente == 1 && (etre_vivant.Regime=="Carnivore" || etre_vivant.Regime=="Herbivore"))
                {
                    etre_vivant.Change_de_regime("Omnivore");
                    etre_vivant.Canibal = true;
                }
                else if (nombre_plante_diferente > 0 && etre_vivant.Regime == "Herbivore")
                {
                    etre_vivant.Change_de_regime("Herbivore");
                }
                else if (nombre_poisson_diferente>1 && etre_vivant.Regime == "Carnivore")
                {
                    etre_vivant.Change_de_regime("Carnivore");
                }
                else
                {
                    //Nothing
                }

            }
            //Place_disponible();
        }
        public void Retrait_mort()
        {
            for(int index = 0; index < listing_aquarium.Count(); index++)
            {
                if (listing_aquarium[index].Est_mort)
                {
                    listing_aquarium[index] = new P_null("none");
                    place_libre++;
                }
            }
        }
        public void Place_disponible()
        {
            this.place_libre = 0;
            foreach (Forme_de_vie_aquatique etre_vivant in listing_aquarium)
            {
                if(etre_vivant.Race == "none")
                {
                    this.place_libre++;
                }
            }
        }

        public string Nom { get => nom; set => nom = value; }
        public int Taille { get => taille; set => taille = value; }
        public List<Forme_de_vie_aquatique> Listing_aquarium { get => listing_aquarium; set => listing_aquarium = value; }
        public int Place_libre { get => place_libre; set => place_libre = value; }
    }
}
