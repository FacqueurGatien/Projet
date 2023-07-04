using JavaquariumRe;
Aquarium aquarium = new Aquarium("Mon Aquarium");
int tour = 1;
aquarium.Creation_aquarium();
for(int i =0; i< 10; i++)
{
    aquarium.Ajout_dans_aquarium(Fonction.Selection_etre_vivant());
}
Console.WriteLine("\t\t\t\t _______________ \n" +
    "\t\t\t\t|   Tour N°" + tour + "\t|\n" +
    "\t\t\t\t|_______________|");

aquarium.Affichage_aquarium();
aquarium.Listing_apres_un_tour();
tour++;
for (int i =0; i< 19; i++)
{
    aquarium.Manger();
    aquarium.Reproduction();
    Console.WriteLine("\t\t\t\t _______________ \n" +
    "\t\t\t\t|   Tour N°" + tour + "\t|\n" +
    "\t\t\t\t|_______________|");
    aquarium.Affichage_aquarium();
    aquarium.Listing_apres_un_tour();
    tour++;
}
