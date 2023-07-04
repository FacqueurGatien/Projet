﻿using SudokuGrille;
using SudokuAlgo.RechercheIndice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using SudokuAlgo.AlgoTraqueur;
using System.Reflection;
using SudokuAlgo.AlgoReduction;

namespace SudokuAlgo.AlgoAleatoire
{
    public class Generateur
    {
        public Grille GrilleDepart { get; }
        private Grille? grilleAGenerer;
        public Grille? GrilleAGenerer { get => grilleAGenerer; }

        public Generateur(Grille _grille)
        {
            GrilleDepart = _grille;
        }
        public Grille Generer()
        {

            //Etape 1 Rechercher les indices d'une ligne
            int grilleCompletion;
            int limiteBoucle=100;
            do
            {
                grilleAGenerer = new Grille(GrilleDepart);
                ResolutionGrilleAleatoire();
                if (grilleAGenerer!=null)
                {
                    ReductionIndices.Reduction(GrilleAGenerer);
                    grilleCompletion = GrilleAGenerer.CompterItterationTotal();
                }
                else
                {
                    grilleCompletion = int.MaxValue;
                }
                limiteBoucle--;
            }
            while ( grilleCompletion != 81 && limiteBoucle > 0);
            return GrilleAGenerer;
        }
        public void ResolutionGrilleAleatoire()
        {
            for(int i = 0; i<9;i++)
            {
                RechercerIndices.RechercherIndicesLigne(GrilleAGenerer, GrilleAGenerer.Rangees[i]);
                if (!LigneAResoudre(GrilleAGenerer.Rangees[i]))
                {
                    grilleAGenerer = null;
                    i = int.MaxValue-1;
                }
            }
        }
        public Case? SelectionCaseAChanger(Ligne _ligne)
        {
            Ligne index = new Ligne();
            index.Cases.Clear();
            int nombreCase = int.MaxValue;
            foreach (Case ca in _ligne.Cases)
            {
                if (ca.Contenu.Count > 1 && ca.Contenu.Count < nombreCase)
                {
                    index.Cases.Clear();
                    index.Cases.Add(ca);
                    nombreCase = ca.Contenu.Count;
                }
                else if (ca.Contenu.Count == nombreCase)
                {
                    index.Cases.Add(ca);
                }
            }

            ItterationGrille.CompterItteration(_ligne);
            List<int> itterationTrie = new List<int>();
            foreach (KeyValuePair<int, int> i in ItterationGrille.Itteration.OrderBy(key => key.Value))
            {
                if (i.Value >= 1)
                {
                    itterationTrie.Add(i.Key);
                }
            }

            if (index.Cases.Count > 1)
            {
                Ligne temp = new Ligne();
                temp.Cases.Clear();
                for (int i = 0; i < itterationTrie.Count; i++)
                {
                    foreach (Case ca in index.Cases)
                    {
                        if (ca.Contenu.Contains(itterationTrie[i]))
                        {
                            temp.Cases.Add(ca);
                        }
                    }
                    if (temp.Cases.Count > 0)
                    {
                        i = int.MaxValue - 1;
                    }
                }
                return temp.Cases[new Random().Next(0, temp.Cases.Count)];
            }
            else
            {
                if (index.Cases.Count!=0)
                {
                    return index.Cases[0];
                }
                return null;
            }
        }

        public void PlacerChiffreCase(Case _case)
        {
            ItterationGrille.CompterItteration(GrilleAGenerer.Rangees[_case.NumRangee]);
            List<int> itterationTrie = new List<int>();
            foreach (KeyValuePair<int, int> i in ItterationGrille.Itteration.OrderBy(key => key.Value))
            {
                if (i.Value >= 1)
                {
                    itterationTrie.Add(i.Key);
                }
            }
            for (int i = 0; i < itterationTrie.Count; i++)
            {
                if (_case.Contenu.Contains(itterationTrie[i]))
                {
                    _case.PlacerChiffre(itterationTrie[i]);
                    GrilleAGenerer.Rangees[_case.NumRangee].PurgerLigne(_case, itterationTrie[i]);
                    i = int.MaxValue - 1;
                }
            }
        }
        public bool LigneAResoudre(Ligne _ligne)
        {
            //Etape2 Copier la ligne
            Ligne ligneReference = new Ligne();
            ligneReference.Cases.Clear();
            foreach (Case ca in _ligne.Cases)
            {
                ligneReference.Cases.Add(ca);
            }

            //Etape3 Trier la ligne
            int boucle = 0;
            foreach (Case i in ligneReference.Cases.OrderBy(ca => ca.Contenu.Count))
            {
                if (i.Contenu.Count > 1)
                {
                    boucle++;
                }
            }

            //Etape5 placer un chiffre sur la case (Etape4 Selectionner la case à changer)
            while (boucle - 1 > 0)
            {
                boucle = ligneReference.Cases.Count;
                foreach (Case i in ligneReference.Cases)
                {
                    if (i.Contenu.Count == 1)
                    {
                        boucle--;
                    }
                }
                if (boucle != 0)
                {
                    Case? caseAChanger = SelectionCaseAChanger(ligneReference);
                    if (caseAChanger != null) 
                    {
                        PlacerChiffreCase(caseAChanger);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
