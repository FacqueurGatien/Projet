using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaquariumRe
{
    public class Fonction
    {
        public static int Randomize(int _min, int _max)
        {
            return new Random().Next(_min, _max);
        }
        public static string Sexe_aleatoire()
        {
            int r= Randomize(0, 2);
            if (r == 0)
            {
                return "male";
            }
            else
            {
                return "female";
            }
        }
        public static bool Est_il_mort(Forme_de_vie_aquatique etre_vivan)
        {
            if (etre_vivan.Pv<=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Regime_alimentaire Change_regime(string arg)
        {
            Regime_alimentaire Regime_Alimentaire = null;
            switch (arg)
            {
                case "Omnivore":
                    Regime_Alimentaire = new Omnivore();
                    break;
                case "Carnivore":
                    Regime_Alimentaire = new Carnivore();
                    break;
                case "Herbivore":
                    Regime_Alimentaire = new Herbivore();
                    break;
                default:
                    Console.WriteLine("Invalid race diferente");
                    break;
            }
            return Regime_Alimentaire;
        }
        public static bool A_t_il_faim(Forme_de_vie_aquatique etre_vivant)
        {
            if (etre_vivant.Pv < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Nom_aleatoire(string _sexe)
        {
            string[] nom_feminin = Enum.GetNames(typeof(Enum_nom_feminin));
            string[] nom_masculin = Enum.GetNames(typeof(Enum_nom_masculin));
            string[] nom_mixte = Enum.GetNames(typeof(Enum_nom_mixte));
            string retour = "none";
            switch (_sexe.ToLower())
            {
                case "male":
                    retour = nom_masculin[Randomize(0, nom_masculin.Length)];
                    break;
                case "female":
                    retour = nom_feminin[Randomize(0, nom_feminin.Length)];
                    break;
                case "mixte":
                    retour = nom_mixte[Randomize(0, nom_mixte.Length)];
                    break;
                case "none":
                    break;
                default:
                    Console.WriteLine("Invalid Nom");
                    break;
            }
            return retour;
        }
        public static int Combien_de_poisson(List<Forme_de_vie_aquatique> liste)
        {
            List<string> race_liste = new List<string>();
            foreach(Forme_de_vie_aquatique etre_vivant in liste)
            {
                if(etre_vivant.Race!="none" && etre_vivant.Race!="Algue" && !race_liste.Contains(etre_vivant.Race))
                {
                    race_liste.Add(etre_vivant.Race);
                }
            }
            return race_liste.Count();
        }
        public static int Combien_de_plante(List<Forme_de_vie_aquatique> liste)
        {
            List<string> race_liste = new List<string>();
            foreach (Forme_de_vie_aquatique etre_vivant in liste)
            {
                if (etre_vivant.Race == "Algue" && !race_liste.Contains(etre_vivant.Race))
                {
                    race_liste.Add(etre_vivant.Race);
                }
            }
            return race_liste.Count();
        }
        public static Forme_de_vie_aquatique Selection_etre_vivant(string _race="",string _genre="")
        {
            Forme_de_vie_aquatique etre_vivant = null;
            string[] race_value = Enum.GetNames(typeof(Enum_Forme_de_vie_aquatique));
            if (!race_value.Contains(_race.ToLower()) && _race!="none")
            {
                _race = race_value[Randomize(0, race_value.Length)];
            }
            string[] genre_value = Enum.GetNames(typeof(Enum_genre));
            if (!genre_value.Contains(_genre.ToLower()))
            {   
                _genre = genre_value[Randomize(0, genre_value.Length)];
            }
            
            switch (_race.ToLower())
            {
                case "null":
                    etre_vivant = new P_null("none");
                    break;
                case "algue":
                    etre_vivant = new Pl_algue(10);
                    break ;
                case "bar":
                    etre_vivant = new P_bar(_genre);
                    break ;
                case "carpe":
                    etre_vivant = new P_carpe(_genre);
                    break;
                case "merou":
                    etre_vivant = new P_merou(_genre);
                    break;
                case "poisson_clown":
                    etre_vivant = new P_poisson_clown(_genre);
                    break;
                case "sole":
                    etre_vivant = new P_sole(_genre);
                    break;
                case "thon":
                    etre_vivant = new P_thon(_genre);
                    break;
                default:
                    Console.WriteLine("Invalid Etre vivant");
                    break;
            }
            return etre_vivant;
        }
        
    }
}
