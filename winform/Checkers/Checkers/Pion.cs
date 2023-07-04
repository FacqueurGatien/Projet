using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// Classe de la piece corespondant au Pion
    /// </summary>
    internal class Pion : Piece
    {
        /// <summary>
        /// Constructeur de la classe Pion
        /// </summary>
        /// <param name="_couleur"></param>
        public Pion(Color _couleur)
            : base(_couleur)
        {
            this.Name = "Pion";
            this.Color = _couleur;
        }
    }
}
