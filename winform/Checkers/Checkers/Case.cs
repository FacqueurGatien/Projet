using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// Class Case
    /// </summary>
    internal class Case
    {
        private Piece? piece;
        private bool libre;
        private string bord;
        private bool actif;
        private bool cibleDeplace;
        private List<int> indexAPourCible;
        private int indexPionSelection;
        private List<int> indexPionDeplacement;
        private bool pieceFantome;
        private bool rangePaire;
        private int index;

        public Case(int _index, string _bord , bool _caseLibre , bool _actif, bool _rangePaire)
        {
            this.index = _index;
            this.Piece = null;
            this.Bord = _bord;
            this.Libre = _caseLibre;
            this.Actif = _actif;
            this.CibleDeplace = false;
            this.RangePaire = _rangePaire;
            this.IndexAPourCible = new List<int>();
            this.IndexPionSelection = -1;
            this.IndexPionDeplacement = new List<int>();
            this.pieceFantome = false;
        }
        public bool Libre { get => libre; set => libre = value; }
        public string Bord { get => bord; set => bord = value; }
        public bool Actif { get => actif; set => actif = value; }
        public bool CibleDeplace { get => cibleDeplace; set => cibleDeplace = value; }
        public bool RangePaire { get => rangePaire; set => rangePaire = value; }
        public List<int> IndexAPourCible { get => indexAPourCible; set => indexAPourCible = value; }
        public int IndexPionSelection { get => indexPionSelection; set => indexPionSelection = value; }
        public List<int> IndexPionDeplacement { get => indexPionDeplacement; set => indexPionDeplacement = value; }
        public int Index { get => index; set => index = value; }
        public bool PieceFantome { get => pieceFantome; set => pieceFantome = value; }
        internal Piece? Piece { get => piece; set => piece = value; }

    }

}
