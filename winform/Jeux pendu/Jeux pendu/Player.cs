using Newtonsoft.Json;
using System;

namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    internal class Player
    {
        /// <summary>Player name</summary>
        private string pseudo;
        /// <summary>
        /// Pseudo variable getter and setter
        /// </summary>
        public string Pseudo { get => pseudo; set => pseudo = value; }
        /// <summary>Player score</summary>
        private int score;
        /// <summary>
        /// Score variable getter and setter
        /// </summary>
        public int Score { get => score; set => score = value; }
        /// <summary>
        /// Player class constructor<br/>
        /// Generate a new instance of Player
        /// </summary>
        /// <param name="_pseudo">Player name choosen by player</param>
        /// <param name="_score">Player score sended by Form1 (0 or score containt in json file of player)</param>
        public Player(string _pseudo , int _score)
        {
            pseudo = _pseudo;
            score = _score;
        }
        /// <summary>
        /// Add parameter getted by function to score
        /// </summary>
        /// <param name="_toAddScore">Score to add in current score</param>
        public void AddScore(int _toAddScore)
        {
            score += _toAddScore;
        }
    }
}
