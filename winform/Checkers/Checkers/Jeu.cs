using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// Classe d'initialisation du jeu
    /// </summary>
    internal class Jeu
    {
        /// <summary>
        /// Instance de la classe Plateau
        /// </summary>
        private Plateau plateau;
        /// <summary>
        /// Accesseur de l'instance de Plateau
        /// </summary>
        internal Plateau PlateauI { get => plateau; set => plateau = value; }
        /// <summary>
        /// Liste de string contenant le pseudo des joueurs
        /// </summary>
        private string[] playerPseudo;
        /// <summary>
        /// Accesseur de la liste de pseudo
        /// </summary>
        public string[] PlayerPseudo { get => playerPseudo; set => playerPseudo = value; }
        /// <summary>
        /// Constructeur de la classe Jeu
        /// </summary>
        /// <param name="_PlayersPseudo"></param>
        public Jeu(string[] _PlayersPseudo)
        {
            this.playerPseudo = _PlayersPseudo;
        }


    }
}
