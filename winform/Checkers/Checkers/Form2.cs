using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form2 : Form
    {
        PictureBox[] pictureBoxes;
        Jeu game;


        internal Jeu Game { get => game; set => game = value; }

        public Form2()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[50]
{
                A2 , A4 , A6 , A8 , A10,
                B1 , B3 , B5 , B7 , B9,
                C2 , C4 , C6 , C8 , C10,
                D1 , D3 , D5 , D7 , D9,
                E2 , E4 , E6 , E8 , E10,
                F1 , F3 , F5 , F7 , F9,
                G2 , G4 , G6 , G8 , G10,
                H1 , H3 , H5 , H7 , H9,
                I2 , I4 , I6 , I8 , I10,
                J1 , J3 , J5 , J7 , J9
};
            int compteurListe=0;
            foreach(PictureBox p in pictureBoxes)
            {
                p.Name = compteurListe+"";
                compteurListe++;
            }
            Game = new Jeu(new string[] { "Angelo", "Rodolphe" });
            Game.PlateauI = new Damier(Game.PlayerPseudo);
            Game.PlateauI.DisposerPieces();
            ActiveDesactiveCase();
            changeImage();
            NomJoueur();
        }
        private void Square_Click(object sender, EventArgs e)
        {
            int indexCaseSelect = RecupSquareIndex(sender as PictureBox);
            game.PlateauI.Tour(indexCaseSelect);
            changeImage();
            NomJoueur();
        }
        internal int RecupSquareIndex(PictureBox _pictureBox)
        {
            return int.Parse(_pictureBox.Name);
        }
        internal void ActiveDesactiveCase()
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                Case tmpSquare = Game.PlateauI.Cases[i];
                if (tmpSquare.Actif)
                {
                    pictureBoxes[i].Enabled = true;
                }
                else
                {
                    pictureBoxes[i].Enabled = false;
                }
            }
        }
        internal void changeImage()
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                Case tmpSquare = Game.PlateauI.Cases[i];
                if (tmpSquare.Actif)
                {
                    pictureBoxes[i].Enabled = true;
                }
                else
                {
                    pictureBoxes[i].Enabled = false;
                }
                if (tmpSquare.Libre)
                {
                    if(tmpSquare.CibleDeplace)
                    {
                        pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareCanMove;
                    }
                    else
                    {
                        pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquare;
                    }

                }
                else
                {
                    if (tmpSquare.Piece.Name == "Pion")
                    {
                        if (tmpSquare.Piece.Color == Color.Black)
                        {
                            if (tmpSquare.Piece.Cible)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackPawnCanEat;
                            }
                            else if (tmpSquare.Piece.Selection)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackPawnSelected;
                            }
                            else
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackPawn;
                            }
                        }
                        else
                        {
                            if (tmpSquare.Piece.Cible)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhitePawnCanEat;
                            }
                            else if (tmpSquare.Piece.Selection)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhitePawnSelected;
                            }
                            else
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhitePawn;
                            }
                        }
                    }
                    else if(tmpSquare.Piece.Name == "Reine")
                    {
                        if (tmpSquare.Piece.Color == Color.Black)
                        {
                            if (tmpSquare.Piece.Cible)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackQueenCanEat;
                            }
                            else if (tmpSquare.Piece.Selection)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackQueenSelected;
                            }
                            else
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheBlackQueen;
                            }
                        }
                        else
                        {
                            if (tmpSquare.Piece.Cible)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhiteQueenCanEat;
                            }
                            else if (tmpSquare.Piece.Selection)
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhiteQueenSelected;
                            }
                            else
                            {
                                pictureBoxes[i].BackgroundImage = Checkers.Properties.Resources.blackSquareWhitheWhiteQueen;
                            }
                        }
                    }

                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void NomJoueur()
        {
            Label labelJoueur = label1;
            if (Game.PlateauI.NbTour % 2 == 0)
            {
                labelJoueur.Text = "Joueur 1: " + Game.PlayerPseudo[0];
            }
            else
            {
                labelJoueur.Text = "Joueur 2: " + Game.PlayerPseudo[1];
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

