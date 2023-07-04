using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Echequier : Plateau
    {

        internal Echequier(string[] _pseudoJoueur)
            : base(_pseudoJoueur)
        {
        }
        internal override void DisposerPieces()
        {

        }
        internal Piece[] PiecesBlanche()
        {
            return new Piece[20];
        }
        internal Piece[] PiecesNoir()
        {
            return new Piece[20];
        }

        internal override void Tour(int _indexCase)
        {
        }
    }
}
