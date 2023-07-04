namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    internal class Game
    {
        /// <summary>Player object containing a pseudo and a score</summary>
        private Player player;
        /// <summary>player variable getter</summary>
        internal Player Player { get => player; }
        /// <summary>Instance of one party</summary>
        private HangedMan hangedMan;
        /// <summary>hangedMan variable getter.</summary>
        internal HangedMan HangedMan { get => hangedMan; }
        /// <summary>
        /// Game constructor<br/>
        /// instanciate one game.
        /// </summary>
        /// <param name="_pseudo">Name of player</param>
        /// <param name="_score">Score of player</param>
        public Game(string _pseudo , int _score)
        {
            player = new Player(_pseudo , _score);
        }
        /// <summary>
        /// Create a new instance of the HangedMan class
        /// </summary>
        public void NewGame()
        {
            hangedMan = new HangedMan();
        }
    }
}
