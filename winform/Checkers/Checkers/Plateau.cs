using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// Classe de création du plateau
    /// </summary>
    abstract internal class Plateau
    {
        /// <szmmary>
        /// Nombre de tour depuis le commencement du jeu <br/>
        /// permet egalement de definir quel joueur doit jouer
        /// </summary>
        private int nbTour;    
        /// <summary>
        /// Accesseur de la variable NbTour
        /// </summary>
        internal int NbTour { get => nbTour; set => nbTour = value; }
        /// <summary>
        /// Liste des cases corespondant aux cases du plateau
        /// </summary>
        private List<Case> cases;
        /// <summary>
        /// Accesseur de la liste de cases
        /// </summary>
        internal List<Case> Cases { get => cases; set => cases = value; }
        /// <summary>
        /// Liste (tableau) contenant les joueur participant a la partie
        /// </summary>
        private Joueur[] joueurs;
        /// <summary>
        /// Accesseur de la liste des joueurs
        /// </summary>
        internal Joueur[] Joueurs { get => joueurs; set => joueurs = value; }

        /// <summary>
        /// Constructeur de la classe Plateau
        /// </summary>
        /// <param name="_pseudoJoueur">Pseudo des joueurs fournis dans une liste de string</param>
        public Plateau(string[] _pseudoJoueur)
        {
            this.joueurs = new Joueur[2];
            this.cases = new List<Case>();
            for (int i = 0; i < _pseudoJoueur.Length; i++)
            {
                if (i % 2 == 0)
                {
                    joueurs[i] = new Joueur(_pseudoJoueur[i], Color.White);
                }
                else
                {
                    joueurs[i] = new Joueur(_pseudoJoueur[i], Color.Black);
                }
            }
            this.nbTour = 0;
        }
        /// <summary>
        /// Fonction qui dispose le diferente piece sur leur position de depart sur le plateau
        /// </summary>
        abstract internal void DisposerPieces();
        /// <summary>
        /// Fonction qui commande le deroulement d'un tour de joueur
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        abstract internal void Tour(int _indexCase);
    }
}
