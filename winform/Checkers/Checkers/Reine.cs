using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// Classe de la piece corespondant à la Reine
    /// </summary>
    internal class Reine : Piece
    {
        /// <summary>
        /// Constructeur de la classe Reine
        /// </summary>
        /// <param name="_couleur"></param>
        public Reine(Color _couleur)
            : base(_couleur)
        {
            this.Name = "Reine";
            this.Color = _couleur;
        }
    }
}
