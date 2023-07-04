using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    internal class Damier : Plateau
    {
        /// <summary>
        /// Instance de piece corespondant a la piece selectionné par le joueur
        /// </summary>
        Piece? pieceSelection;
        /// <summary>
        /// Accesseur de la piece selectionné
        /// </summary>
        internal Piece? PieceSelection { get => pieceSelection; set => pieceSelection = value; }
        /// <summary>
        /// Booléen qui definit si la piece peut reverifier la prochaine case dans la diagonale qu'il test actuelement
        /// </summary>
        private bool rejouer;
        /// <summary>
        /// Accesseur de la variable de verification Rejouer
        /// </summary>
        public bool Rejouer { get => rejouer; set => rejouer = value; }
        /// <summary>
        /// Booléen qui permet de continuer les teste de verification apres qu'une piece est été designer comme cible par le pion séléctioné
        /// </summary>
        private bool sauteMouton;
        /// <summary>
        /// Accesseur de la variable de verification SauteMouton
        /// </summary>
        public bool SauteMouton { get => sauteMouton; set => sauteMouton = value; }
        /// <summary>
        /// Constructeur de la classe Damier<br/>
        /// Chaque cases sera créer avec certains paramettre en fonction de leur position<br/>
        /// Les cases seront sur une ligne impaire ou paire, seront actif ou non, libre ou non, seront sur un bord ou non
        /// </summary>
        /// <param name="_pseudoJoueur">Liste de string corespondant le pseudo des joueurs</param>
        internal Damier(string[] _pseudoJoueur)
            : base(_pseudoJoueur)
        {
            /// <summary>Nouvelle liste de Case </summary>
            Cases = new List<Case>();
            ///<summary>Boolean qui definit si la rangée sur la quel la case est est Paire ou Impaire</summary>
            bool rangePaire;
            ///<summary>Création des cases</summary>
            for (int i = 1; i != 51; i++)
            {            
                if ((i - 1 >= 0 && i - 1 <= 4) || (i - 1 >= 10 && i - 1 <= 14) || (i - 1 >= 20 && i - 1 <= 24) || (i - 1 >= 30 && i - 1 <= 34) || (i - 1 >= 40 && i - 1 <= 44))
                {
                    rangePaire = false;
                }
                else
                {
                    rangePaire = true;
                }
                if (i - 1 >= 0 && i - 1 <= 4)
                {
                    Cases.Add(new Case(i - 1, "haut", true, false, rangePaire));
                }
                else if (i - 1 >= 45 && i - 1 <= 49)
                {
                    Cases.Add(new Case(i - 1, "bas", true, false, rangePaire));
                }
                else if (i - 1 == 5 || i - 1 == 15 || i - 1 == 25 || i - 1 == 35)
                {
                    Cases.Add(new Case(i - 1, "coteG", true, false, rangePaire));
                }
                else if (i - 1 == 14 || i - 1 == 24 || i - 1 == 34 || i - 1 == 44)
                {
                    Cases.Add(new Case(i - 1, "coteD", true, false, rangePaire));
                }
                else
                {
                    Cases.Add(new Case(i - 1, "", true, false, rangePaire));
                }
            }
            this.rejouer = false;
            this.SauteMouton = false;
        }
        /// <summary>
        /// Fonction qui dispose les pieces sur le plateau en fonction de leur couleurs
        /// </summary>
        internal override void DisposerPieces()
        {
            PiecesBlanche();
            PiecesNoir();
            DesactiveJoueurCase();
        }
        /// <summary>
        /// Disposition des pieces blanche
        /// </summary>
        internal void PiecesBlanche()
        {
            for (int i = 0; i < 20; i++)
            {
                Cases[i].Actif = true;
                Cases[i].Libre = false;
                Cases[i].Piece = new Pion(Color.White);
            }
        }
        /// <summary>
        /// Disposition des pieces noir
        /// </summary>
        internal void PiecesNoir()
        {
            for (int i = 30; i < 50; i++)
            {
                Cases[i].Actif = true;
                Cases[i].Libre = false;
                Cases[i].Piece = new Pion(Color.Black);
            }
        }
        /// <summary>
        /// Si<br/> 
        /// l'instance de PieceSelection est null<br/>
        /// Lancement de la fonction PieceSelectionNull<br/><br/>
        /// 
        /// Sinon si<br/>
        /// l'instance de PieceSelection est egal la copie de la piece sur la case séléctionné par le joueur <br/>
        /// Lancement de la fonction PieceSelectionNonNull<br/><br/>
        /// 
        /// Sinon<br/>
        /// Lancement de la fonction CaseSelectionPieceNull<br/><br/>
        /// 
        /// Puis Lancement de la fonction DesactiveJoueurCase
        /// 
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        internal override void Tour(int _indexCase)
        {
            if (PieceSelection == null)
            {
                PieceSelectionNull(_indexCase);
            }
            else if (Cases[_indexCase].Piece == PieceSelection)
            {
                PieceSelectionNonNull();
            }
            else if (Cases[_indexCase].Piece == null)
            { 
                CaseSelectionPieceNull(_indexCase);   
            }
            DesactiveJoueurCase();
        }
        /// <summary>
        /// L'instance de PieceSelection prend le pion de la case séléctionné par le joueur en copie<br/>
        /// Le booléen Selection de la case séléctionné par le joueur devient true<br/>
        /// Lancement de la fonction PeutBougerCibler <br/>
        /// Lancement de la fonction DesactiveCaseSelection<br/> 
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        public void PieceSelectionNull(int _indexCase)
        {
            PieceSelection = Cases[_indexCase].Piece;
            Cases[_indexCase].Piece.Selection = true;
            PeutBougerCibler(_indexCase);
            DesactiveCaseSelection();
        }
        /// <summary>
        /// Si<br/>
        /// le booléen Rejouer est est sur true:<br/> 
        /// il devient false<br/>
        /// la variable NbTour est incrementé de 1<br/><br/>
        /// 
        /// Puis<br/>
        /// L'instance de PieceSelection devient null<br/>
        /// Lancement de la fonction ResetAllPiece
        /// </summary>
        public void PieceSelectionNonNull()
        {
            if (Rejouer)
            {
                Rejouer = false;
                NbTour++;
            }
            PieceSelection = null;
            ResetAllPiece();
        }
        /// <summary>
        /// La variable SauteMouton devient true<br/>
        /// Lancement de la fonction DeplacerManger(Mange le pion cible et deplace le pion sur la case selectionné par le joueur)<br/>
        /// l'instance de PieceSelection devient null <br/>
        /// Lancement de la fonction PieceSelectionNonNull<br/>
        /// toute les pieces sont reinitialiser apres les changement effectué<br/><br/>
        /// 
        /// Si <br/>
        /// le booléen Rejoueur est false<br/>
        /// la variable NbTour est incrementé de 1<br/>
        /// le booléen piece fantome devient false<br/><br/>
        /// 
        /// Sinon<br/>
        /// L'instance PieceSelection prend la piece de la case séléctionné par le joueur<br/>
        /// Le booléen Selection de la case séléctionné par le joueur devient true<br/>
        /// Lancement de la fonction PeutBougerCibler (qui va verifier les déplacements possible)<br/>
        /// Lancement de la fonction DesactiveCaseSelection<br/>
        /// Lancement de la fonction DesactiveDeplacementNonCible<br/><br/>
        /// 
        /// Puis le booléen SauteMouton devient false
        /// 
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        public void CaseSelectionPieceNull(int _indexCase)
        {
            SauteMouton = true;
            DeplacerManger(_indexCase);
            PieceSelection = null;
            ResetAllPiece();
            if (!Rejouer)
            {
                NbTour++;
                ResetFantome();
            }
            else
            {
                PieceSelection = Cases[_indexCase].Piece;
                Cases[_indexCase].Piece.Selection = true;
                PeutBougerCibler(_indexCase);
                DesactiveCaseSelection();
                DesactiveDeplacementNonCible(_indexCase);
            }

            SauteMouton = false;
        }
        /// <summary>
        /// Parcours toute les cases du plateau passe le booléen PieceFantome en false
        /// </summary>
        public void ResetFantome()
        {
            foreach(Case s in Cases)
            {
                s.PieceFantome = false;
            }
        }
        /// <summary>
        /// Si<br/>
        /// Lancement de la fonction PeutBougerCiblerPion<br/><br/>
        /// Sinon<br/>
        /// Lancement de la fonction PeutBougerCiblerReine<br/><br/>
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        public void PeutBougerCibler(int _indexCase)
        {
            if (PieceSelection.Name == "Pion")
            {
                PeutBougerCiblerPion(_indexCase);
            }
            else
            {
                PeutBougerCiblerReine(_indexCase);
            }
        }
        /// <summary>
        /// Initialisation des incrementation et decrementation permettant les deplacement diagonal<br/>
        /// a et aP = deplacement nord ouest<br/>
        /// b et bP = deplacement nord est<br/>
        /// c et cP = deplacement sud ouest<br/>
        /// d et dP = deplacement sud est<br/><br/>
        /// P corespond a un saut de 2 cases
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        /// <returns></returns>
        public int[] Coordonner(int _indexCase)
        {
            int a; //Corespond a la premiere case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int b; //Corespond a la deuxieme case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int c; //Corespond a la premiere case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int d; //Corespond a la deuxieme case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int aP; //Corespond a la premiere case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int bP; //Corespond a la deuxieme case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int cP; //Corespond a la premiere case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            int dP; //Corespond a la deuxieme case que le pion selectionné va cibler si celui ci n'est pas sur un bord
            if (!Cases[_indexCase].RangePaire)
            {
                a = -5;
                b = -4;
                c = 5;
                d = 6;
                aP = -6;
                bP = -5;
                cP = 4;
                dP = 5;
            }
            else
            {
                a = -6;
                b = -5;
                c = 4;
                d = 5;
                aP = -5;
                bP = -4;
                cP = 5;
                dP = 6;
            }
            return new int[] { a, b, c, d, aP, bP, cP, dP };
        }
        /// <summary>
        /// Lancement de la fonction Deplacement Simple avec des parametre diferent en fonction de la case séléctionné par le joueur<br/> 
        /// (Depend de la couleur du pion et de la valeur de la variable bord)
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        public void PeutBougerCiblerPion(int _indexCase)
        {
            int[] coordonner = Coordonner(_indexCase);
            if (Cases[_indexCase].Index == 4)
            {
                if (Cases[_indexCase].Piece.Color == Color.White)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4] });
                }
            }
            else if (Cases[_indexCase].Index == 45)
            {
                if (Cases[_indexCase].Piece.Color == Color.Black)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[1], coordonner[1 + 4] });
                }
            }
            else if (Cases[_indexCase].Bord == "bas")
            {
                if (Cases[_indexCase].Piece.Color == Color.Black)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4], coordonner[1], coordonner[1 + 4] });
                }
            }
            else if (Cases[_indexCase].Bord == "haut")
            {
                if (Cases[_indexCase].Piece.Color == Color.White)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4], coordonner[3], coordonner[3 + 4] });
                }
            }
            else if (Cases[_indexCase].Bord == "coteG")
            {
                if (Cases[_indexCase].Piece.Color == Color.White)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[3], coordonner[3 + 4] });
                }
                else
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[1], coordonner[1 + 4] });
                }
            }
            else if (Cases[_indexCase].Bord == "coteD")
            {

                if (Cases[_indexCase].Piece.Color == Color.White)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4] });
                }
                else
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4] });
                }
            }
            else
            {
                if (Cases[_indexCase].Piece.Color == Color.White)
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4], coordonner[3], coordonner[3 + 4] });
                }
                else
                {
                    DeplacementSimple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4], coordonner[1], coordonner[1 + 4] });
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_indexCase">Case selectionner par le joueur sur l'interface graphique</param>
        /// <param name="_coordonner">Coordonné necessaire au deplacement du pion</param>
        public void DeplacementSimple(int _indexCase, int[] _coordonner)
        {
            //pour chaque coordonné du tableau
            for (int i = 0; i < _coordonner.Length; i += 2)
            {
                //Si il y a une piece sur la case cible
                if (Cases[_indexCase + _coordonner[i]].Piece != null && !Cases[_indexCase].IndexAPourCible.Contains(_indexCase + _coordonner[i]))
                {
                    if (Cases[_indexCase + _coordonner[i]].Bord == "")
                    {
                        if (Cases[_indexCase + _coordonner[i] + _coordonner[i + 1]].Piece == null && Cases[_indexCase + _coordonner[i]].Piece.Color != Cases[_indexCase].Piece.Color)
                        {
                            Cases[_indexCase + _coordonner[i]].Piece.Cible = true;
                            Cases[_indexCase + _coordonner[i] + _coordonner[i + 1]].Libre = true;
                            Cases[_indexCase + _coordonner[i] + _coordonner[i + 1]].CibleDeplace = true;
                            Cases[_indexCase + _coordonner[i] + _coordonner[i + 1]].IndexAPourCible.Add(_indexCase + _coordonner[i]);
                            Cases[_indexCase + _coordonner[i] + _coordonner[i + 1]].IndexPionSelection = _indexCase;
                            Cases[_indexCase].IndexPionDeplacement.Add(_indexCase + _coordonner[i] + _coordonner[i + 1]);
                            SauteMouton = true;
                        }
                    }
                }
                else
                {

                    Cases[_indexCase + _coordonner[i]].Libre = true;
                    Cases[_indexCase + _coordonner[i]].CibleDeplace = true;
                    Cases[_indexCase + _coordonner[i]].IndexPionSelection = _indexCase;
                    Cases[_indexCase].IndexPionDeplacement.Add(_indexCase + _coordonner[i]);
                }
            }
        }
        public void PeutBougerCiblerReine(int _indexCase)
        {
            int[] coordonner = Coordonner(_indexCase);
            if (Cases[_indexCase].Index == 4)
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4] });
            }
            else if (Cases[_indexCase].Index == 45)
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[1], coordonner[1 + 4] });
            }
            else if (Cases[_indexCase].Bord == "bas")
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4], coordonner[1], coordonner[1 + 4] });
            }
            else if (Cases[_indexCase].Bord == "haut")
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[2], coordonner[2 + 4], coordonner[3], coordonner[3 + 4] });
            }
            else if (Cases[_indexCase].Bord == "coteG")
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[1], coordonner[1 + 4], coordonner[3], coordonner[3 + 4] });
            }
            else if (Cases[_indexCase].Bord == "coteD")
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4], coordonner[2], coordonner[2 + 4] });
            }
            else
            {
                DeplacementMultiple(_indexCase, new int[] { coordonner[0], coordonner[0 + 4], coordonner[1], coordonner[1 + 4], coordonner[2], coordonner[2 + 4], coordonner[3], coordonner[3 + 4] });
            }
        }
        public void DeplacementMultiple(int _indexCase, int[] _coordonner)
        {
            for (int i = 0; i < _coordonner.Length; i += 2)
            {
                Rejouer = true;
                int compteur = 0;
                int cible = _indexCase + _coordonner[i];
                int derrierecible = _indexCase + _coordonner[i] + _coordonner[i + 1];
                int tmpIndex = _indexCase;
                int increment = 0;
                List<int> tmpListeCible = new List<int>();
                while (Rejouer)
                {
                    //Coordonnée selection
                    if (compteur % 2 == 0)
                    {
                        increment = _coordonner[i];
                        cible = tmpIndex + _coordonner[i];
                        derrierecible = tmpIndex + _coordonner[i] + _coordonner[i + 1];
                    }
                    else
                    {
                        increment = _coordonner[i + 1];
                        cible = tmpIndex + _coordonner[i + 1];
                        derrierecible = tmpIndex + _coordonner[i + 1] + _coordonner[i];
                    }
                    //Si la cible est hors du damier
                    if (cible < 0 && cible > 50)
                    {
                        //la fonction ne s'execute plus
                        Rejouer = false;
                    }
                    //Si la cible est sur le damier
                    if (cible >= 0 && cible < 50)
                    {
                        //Pour chaque index dans la liste d'index cible
                        foreach (int j in tmpListeCible)
                        {
                            //Si la case cible n'a pas pour index l'index de la liste de cible 
                            if (!Cases[cible].IndexAPourCible.Contains(j))
                            {
                                //Ajout de l'index contenue dans la liste d'index cible sur la case cible
                                Cases[cible].IndexAPourCible.Add(j);
                            }
                        }
                        //si il y a une piece sur la cible
                        if (Cases[cible].Piece != null)
                        {
                            //Si la case cible n'est pas un bord
                            if (Cases[cible].Bord == "" && !Cases[_indexCase].IndexAPourCible.Contains(_indexCase + _coordonner[i]) && Cases[cible].Index != Cases[_indexCase].IndexPionSelection)
                            {
                                //Si la case derriere la cible est null
                                if (Cases[derrierecible].Piece == null)
                                {
                                    //Si la piece sur la case cible est d'une couleure diferente de la piece sur la case selectionné 
                                    if (Cases[cible].Piece.Color != Cases[_indexCase].Piece.Color)
                                    {
                                        //Le booleen cible de la piece contenue sur la case cible devient true
                                        Cases[cible].Piece.Cible = true;
                                        //Le booleen Libre de la case derriere la case cible deviens true
                                        Cases[derrierecible].Libre = true;
                                        //Le boleen CibleDeplace de la case derriere la case cible deviens true
                                        Cases[derrierecible].CibleDeplace = true;
                                        //L'index de la cible est ajouter a la liste d'index cible
                                        tmpListeCible.Add(cible);
                                        //Pour chaque index dans la liste d'index cible
                                        foreach (int j in tmpListeCible)
                                        {
                                            //Ajout de l'index contenue dans la liste d'index cible sur la case derriere la cible
                                            Cases[derrierecible].IndexAPourCible.Add(j);
                                        }
                                        //L'Index
                                        Cases[derrierecible].IndexPionSelection = _indexCase;
                                        Cases[_indexCase].IndexPionDeplacement.Add(derrierecible);
                                        sauteMouton = true;
                                    }
                                    else
                                    {
                                        Rejouer = false;
                                    }
                                }
                                else
                                {
                                    Cases[cible].PieceFantome = false;
                                    Rejouer = false;
                                }
                            }
                            else
                            {
                                Cases[cible].PieceFantome = false;
                                Rejouer = false;
                            }
                        }
                        else
                        {
                            if (Cases[cible].Bord == "" && !Cases[cible].PieceFantome)
                            {
                                Rejouer = true;
                            }
                            else
                            {
                                Rejouer = false;
                            }
                            Cases[cible].Libre = true;
                            Cases[cible].CibleDeplace = true;
                            Cases[cible].IndexPionSelection = _indexCase;
                            Cases[_indexCase].IndexPionDeplacement.Add(cible);
                        }
                        tmpIndex += increment;
                        compteur++;
                    }
                    if (cible == 0 || cible == 50)
                    {
                        Rejouer = false;
                    }
                }
            }
        }
        public void DeplacerManger(int _indexCase)
        {
            //la case selectionné prend le pion de la case garder en selection
            Cases[_indexCase].Piece = PieceSelection.Clone();
            //la case selectionné devient actif
            //Cases[Cases[_indexCase].IndexPionSelection].Piece = PieceSelection.Clone();

            Cases[_indexCase].PieceFantome = true;
            
            Cases[_indexCase].Actif = true;
            //La case selectionné n'est plus libre
            Cases[_indexCase].Libre = false;

            //La case garder en selection perd sa piece
            PieceSelection.Vie = false;

            //la case selectionné a un pion ciblé en memoire
            if (Cases[_indexCase].IndexAPourCible.Count > 0)
            {
                //La cible perd sa piece
                foreach (int i in Cases[_indexCase].IndexAPourCible)
                {
                    Cases[i].Piece.Vie = false;
                    //La ciblé devient inactive
                    Joueurs[NbTour % 2].Pieces.Add(Cases[i].Piece.Clone());
                }
                PeutBougerCibler(_indexCase);
                if (PeutManger(_indexCase))
                {
                    Rejouer = true;
                    SauteMouton = true;
                }
                else
                {
                    Rejouer = false;
                    SauteMouton = false;
                }
            }
        }
        public bool PeutManger(int _indexCase)
        {
            foreach (int i in Cases[_indexCase].IndexPionDeplacement)
            {
                if (Cases[i].IndexAPourCible.Count > 0)
                {
                    foreach (int j in Cases[i].IndexAPourCible)
                    {
                        if (Cases[j].Piece.Vie)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void DesactiveCaseSelection()
        {
            foreach (Case s in Cases)
            {
                if (s.Piece != null)
                {
                    if (s.Piece.Selection)
                    {
                        s.Actif = true;
                    }
                    else
                    {
                        s.Actif = false;
                    }
                }
                else if (s.CibleDeplace)
                {
                    s.Actif = true;
                }
                else
                {
                    s.Actif = false;
                }
            }
        }
        public void DesactiveJoueurCase()
        {
            foreach (Case s in Cases)
            {
                if (s.Piece != null)
                {
                    if (s.Piece.Color == Color.White && NbTour % 2 == 0)
                    {
                        s.Actif = true;
                    }
                    else if (s.Piece.Color == Color.Black && NbTour % 2 == 1)
                    {
                        s.Actif = true;
                    }
                    else
                    {
                        s.Actif = false;
                    }
                }
            }
        }
        public void ResetAllPiece()
        {
            foreach (Case s in Cases)
            {
                if (s.Piece != null)
                {
                    s.Piece.Selection = false;
                    s.Actif = true;
                    s.Libre = false;
                    s.Piece.Cible = false;
                    if (s.Piece.Name == "Pion" && s.Bord == "haut" && s.Piece.Color == Color.Black)
                    {
                        s.Piece = new Reine(Color.Black);

                    }
                    else if (s.Piece.Name == "Pion" && s.Bord == "bas" && s.Piece.Color == Color.White)
                    {
                        s.Piece = new Reine(Color.White);
                    }
                    if (!s.Piece.Vie)
                    {
                        s.Piece = null;
                        s.Actif = false;
                        s.Libre = true;
                    }
                }
                else
                {
                    s.Actif = false;
                    s.Libre = true;
                }
                s.CibleDeplace = false;
                s.IndexPionSelection = -1;
                s.IndexAPourCible.Clear();
                s.IndexPionDeplacement.Clear();
            }
        }
        public void DesactiveDeplacementNonCible(int _indexCase)
        {
            foreach (int i in Cases[_indexCase].IndexPionDeplacement)
            {
                if (Cases[i].IndexAPourCible.Count == 0)
                {
                    Cases[i].Actif = false;
                    Cases[i].CibleDeplace = false;
                }
            }
        }
    }
}
