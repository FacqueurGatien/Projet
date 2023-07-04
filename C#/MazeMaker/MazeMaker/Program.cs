using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Donnée d'entrée
            string entry = "10 6 ########## #........# ###.####.# #..S.###.# #....#...# ##########";
            //string entry = "10 5 ########## #S.......# ##.#####.# ##.......# ##########";
            //string entry = "10 5 #.######## #.##..#### ..##..#... ####..#S## #....#####";
            //string entry = "15 10 ............... ......#........ ............... ............... ............... ............#.. ............#.. ............... S.............. .#............. ";
            //string entry = "19 7 ....#...#.......... ....#####.......... ....#...#.......... ....#.#.#.......... ......#............ ...S#####.......... ....#...#..........";
            //string entry = "27 13 ###########.###.###.###.### #.........#..............S# ###########.....#########.# .....#...#.......#...#..... ####...#...#.......#...#### #....#...###....#######...# #.#######..#............#.# #...#........############. #....#.#####....#.........# #.....#......##...##.###.#. .....#.#.....#.###.###.###. ..................#.......# ###.###.###.###.###.###.###";
            //string entry = "5 5 ..... ..... .###. .#S#. .###.";

            string[] inputs = entry.Split(' ');
            int w = int.Parse(inputs[0]);
            int h = int.Parse(inputs[1]);

            //Initialisation de la liste
            string[,] maze = new string[h, w];

            //Creation du tableau
            for (int i = 0; i < h; i++)
            {
                string ROW = inputs[i + 2];
                for (int y = 0; y < w; y++)
                {
                    maze[i, y] = ROW[y].ToString();
                }
            }

            int marker = 0;

            //Creation du tableau de conversion final
            char[] value = new char[36];
            int chiffre = 48;
            int lettre = 65;
            for (int i = 0; i < value.Count(); i++)
            {
                if (i <= 9)
                {
                    value[i] = Convert.ToChar(chiffre++);
                }
                else
                {

                    value[i] = Convert.ToChar(lettre++);
                }
            }

            //generation des point de direction
            Point CibleHaut = new(-1, 0);
            Point CibleBas = new(1, 0);
            Point CibleGauche = new(0, -1);
            Point CibleDroite = new(0, 1);

            //instanciation de la variable de resultat
            string result = "";


            //Recherche du point de depart
            for (int i = 0; i < h; i++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (maze[i, y] == "S")
                    {
                        maze[i, y] = marker.ToString();
                        i = h; y = w;
                        marker = 0;
                    }
                }
            }

            //Traitement
            for (int i = 0; i < h; i++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (maze[i, y] == marker.ToString())
                    {
                        CheckCase(i, y);
                    }

                    if (i == h - 1 && y == w - 1 && VerifCaseLibre())
                    {
                        i = 0;
                        y = -1;
                        marker++;
                    }
                }
            }

            bool VerifCaseLibre()
            {
                for (int i = 0; i < h; i++)
                {
                    for (int y = 0; y < w; y++)
                    {
                        if (maze[i, y].ToString() == (marker).ToString())
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            void CheckCase(int i, int y)
            {
                CalculCible(new(i, y));

                if (ControleCase(CibleHaut.X, CibleHaut.Y))
                {
                    maze[CibleHaut.X, CibleHaut.Y] = (marker + 1).ToString();
                }
                if (ControleCase(CibleBas.X, CibleBas.Y))
                {
                    maze[CibleBas.X, CibleBas.Y] = (marker + 1).ToString();
                }
                if (ControleCase(CibleGauche.X, CibleGauche.Y))
                {
                    maze[CibleGauche.X, CibleGauche.Y] = (marker + 1).ToString();
                }
                if (ControleCase(CibleDroite.X, CibleDroite.Y))
                {
                    maze[CibleDroite.X, CibleDroite.Y] = (marker + 1).ToString();
                }
            }

            bool ControleCase(int i, int y)
            {
                return Regex.Match(maze[i, y], "[\\.]").Success;
            }

            void CalculCible(Point pos)
            {
                if (pos.X == 0)
                {
                    CibleHaut = new(h - 1, pos.Y);
                }
                else
                {
                    CibleHaut = new(pos.X - 1, pos.Y);
                }

                if (pos.X == h - 1)
                {
                    CibleBas = new(0, pos.Y);
                }
                else
                {
                    CibleBas = new(pos.X + 1, pos.Y);
                }

                if (pos.Y == 0)
                {
                    CibleGauche = new(pos.X, w - 1);
                }
                else
                {
                    CibleGauche = new(pos.X, pos.Y - 1);
                }

                if (pos.Y == w - 1)
                {
                    CibleDroite = new(pos.X, 0);
                }
                else
                {
                    CibleDroite = new(pos.X, pos.Y + 1);
                }

            }

            //Affichage
            for (int i = 0; i < h; i++)
            {
                for (int y = 0; y < w; y++)
                {

                    if (!Regex.Match(maze[i, y].ToString(), "[0-9]").Success)
                    {
                        result += maze[i, y];
                    }
                    else
                    {
                        result += value[int.Parse(maze[i, y])].ToString();
                    }
                }
                if (i < h)
                {
                    result += "\n";
                }
            }

            Console.WriteLine(result);
        }
    }
}