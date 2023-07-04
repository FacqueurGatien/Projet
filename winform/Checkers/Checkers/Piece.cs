using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    abstract internal class Piece
    {
        private string name;
        private Color color;
        private bool selection;
        private bool cible;
        private bool vie;

        public Piece(Color _color)
        {
            this.name = "";
            this.color = Color.Transparent;
            this.selection=false;
            this.cible = false;
            this.vie = true;
        }

        public string Name { get => name; set => name = value; }
        public Color Color { get => color; set => color = value; }
        public bool Selection { get => selection; set => selection = value; }
        public bool Cible { get => cible; set => cible = value; }
        public bool Vie { get => vie; set => vie = value; }
        public Piece Clone()
        {
            Piece piece = new Pion(this.Color);
            piece.Selection = this.Selection;
            piece.Cible = this.Cible;
            piece.Name = this.Name;
            piece.Vie = this.Vie;
            return piece;
        }
    }
}
