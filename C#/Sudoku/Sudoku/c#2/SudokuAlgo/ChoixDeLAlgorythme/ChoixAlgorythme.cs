﻿using SudokuAlgo.AlgoAleatoire;
using SudokuAlgo.AlgoReduction;
using SudokuAlgo.AlgoTraqueur;
using SudokuAlgo.RechercheIndice;
using SudokuGrille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SudokuAlgo.ChoixDeLAlgorythme
{
    public static class ChoixAlgorythme
    {
        public static Grille Redirection(Grille _grille)
        {
            string result = "";
            Grille reduction = AlgoReduction(_grille);

            if (reduction.EtatGrille == EnumEtatGrille.Complette)
            {
                result += "Grille Resolu par l'algorythme de Reduction";
                reduction.ResolutionMessage = EtatGrilleApresTraitement(reduction, result);
                return reduction;
            }
            else
            {
                int niveauDifficulte = reduction.CompterItterationTotal();
                Grille grilleFinal;
                if (niveauDifficulte < 180 || niveauDifficulte > 400)
                {
                    grilleFinal = AlgoPseudoAleatoire(_grille);
                    result += "Grille Resolu par l'algorythme pseudo aleatoire et l'algorythme de Reduction";
                }

                else
                {
                    grilleFinal = AlgoTraqueur(_grille);
                    result += "Grille Resolu par l'algorythme Traqueur et l'algorythme de Reduction";
                }
                grilleFinal.ResolutionMessage = EtatGrilleApresTraitement(grilleFinal, result);
                return grilleFinal;
            }
        }
        public static Grille AlgoReduction(Grille _grille)
        {
            Grille reduction = new Grille(_grille);
            ReductionIndices.Reduction(reduction);
            reduction.VerifierEtatGrille();
            return reduction;
        }
        public static Grille AlgoPseudoAleatoire(Grille _grille)
        {
            Grille aleatoire = new Grille(_grille);
            Generateur generateur = new Generateur(aleatoire);
            aleatoire = generateur.Generer();
            return aleatoire;
        }
        public static Grille AlgoTraqueur(Grille _grille)
        {
            Grille? traque = new Grille(_grille);
            Traqueur traqueur = new Traqueur(traque);
            traque = traqueur.Resolution();
            if (traque != null)
            {
                return traque;
            }
            else
            {
                throw new InvalidDataException();
            }
        }
        public static string EtatGrilleApresTraitement(Grille _grille, string _result)
        {
            _grille.VerifierEtatGrille();
            string result = "";
            switch (_grille.EtatGrille)
            {
                case EnumEtatGrille.Incomplette:
                    result = "La grille n'est pas completé";
                    break;
                case EnumEtatGrille.Complette:
                    result = "Une solution a été trouvé";
                    break;
                case EnumEtatGrille.Invalide:
                    result = "La grille n'a pas de solution";
                    break;
                case EnumEtatGrille.Vierge:
                    result = "La grille est vierge";
                    break;
                default:
                    break;
            }
            return $"{result}\n{_result}";
        }
        public static string Serialisation(Grille _grille)
        {
            string jsonString = JsonSerializer.Serialize(_grille);
            return jsonString;
        }
        public static Grille Deserialiser(string _jsonGrille)
        {
            Grille? grille = JsonSerializer.Deserialize<Grille?>(_jsonGrille);
            return grille;
        }
        public static string SerialisationData(Grilles.Models.Grille _grille)
        {
            string jsonString = JsonSerializer.Serialize(_grille);
            return jsonString;
        }
        public static Grilles.Models.Grille DeserialiserData(string _jsonGrille)
        {
            Grilles.Models.Grille? grille = JsonSerializer.Deserialize<Grilles.Models.Grille?>(_jsonGrille);
            return grille;
        }
    }
}
