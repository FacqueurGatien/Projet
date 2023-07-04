using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{

    internal class Joueur
    {
        private string pseudo;
        private int victory;

        private int defeat;
        private List<Piece> pieces;
        private Color color;
        public Joueur(string _pseudo, Color _color)
        {
            pseudo = _pseudo;
            Victory = 0;
            Defeat = 0;
            pieces = new List<Piece>();
            this.color = _color;
        }
        public string Pseudo { get => pseudo; }
        public int Victory { get => victory; set => victory = value; }
        public int Defeat { get => defeat; set => defeat = value; }
        internal List<Piece> Pieces { get => pieces; set => pieces = value; }
    }
}
