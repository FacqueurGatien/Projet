using System;
using System.Numerics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>Buttons list of alphabet</summary>
        List<Button> buttonListAlphabet;
        /// <summary>List containing all button</summary>        
        List<Button> buttonListAll;
        /*@param Game game */
        /// <summary>Instance of Game.</summary>
        Game game;
        /// <summary>Message stored on pressing the quit button.</summary>
        string messageBeforeClickNo;
        /// <summary>pseudo of player.</summary>
        string playerPseudo;
        /// <summary>Score of player.</summary>
        int playerScore;
        /// <summary>
        /// Form1 class constructor<br/>
        /// Generate a new instance of Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            messageBeforeClickNo = "";
            buttonListAlphabet = new List<Button>()
            {
                buttonA,buttonB,buttonC,buttonD,buttonE,buttonF,buttonG,buttonH,buttonI,buttonJ,buttonK,buttonL,buttonM,
                buttonN,buttonO,buttonP,buttonQ,buttonR,buttonS,buttonT,buttonU,buttonV,buttonW,buttonX,buttonY,buttonZ
            };
            buttonListAll = new List<Button>()
            {
                buttonA,buttonB,buttonC,buttonD,buttonE,buttonF,buttonG,buttonH,buttonI,buttonJ,buttonK,buttonL,buttonM,
                buttonN,buttonO,buttonP,buttonQ,buttonR,buttonS,buttonT,buttonU,buttonV,buttonW,buttonX,buttonY,buttonZ,
                buttonYes,buttonNo,buttonValidPseudo,buttonQuit,buttonStart,buttonDel
            };
        }
        /// <summary>
        /// Allows to makes the buttons visible or invisible.
        /// </summary>
        /// <param name="_buttonList">List containing the buttons that will be affected by the function.</param>
        /// <param name="_param">Parameter which defined if buttons will be visible or invisible.</param>
        public void Visibility(List<Button> _buttonList, bool _param)
        {
            foreach (Button button in _buttonList)
            {
                button.Visible = _param;
            }
        }
        /// <summary>
        /// Allows to makes the buttons Enable or Disable.
        /// </summary>
        /// <param name="_buttonList">List containing the buttons that will be affected by the function.</param>
        /// <param name="_param">Parameter which defined if buttons will be Enable or Disable.</param>
        public void Activable(List<Button> _buttonList, bool _param)
        {
            foreach (Button button in _buttonList)
            {
                button.Enabled = _param;
            }
        }
        /// <summary>
        /// Allows to makes the buttons Enable and Visible or Disable and invisible.
        /// </summary>
        /// <param name="_buttonList">List containing the buttons that will be affected by the function.</param>
        /// <param name="_param">Parameter which defined if buttons will be Enable and Visible or Disable and invisible.</param>
        public void VisibilityAndActivable(List<Button> _buttonList, bool _param)
        {
            Visibility(_buttonList, _param);
            Activable(_buttonList, _param);
        }
        /// <summary>
        /// Allows to change the buttons color.
        /// </summary>
        /// <param name="_buttonList">List containing the buttons that will be affected by the function.</param>
        /// <param name="_param">Parameter which defined the new color of button.</param>
        public void ChangeColor(List<Button> _buttonList, Color _color)
        {
            foreach (Button button in _buttonList)
            {
                button.BackColor = _color;
            }
        }
        /// <summary>
        /// Allows to change the Flat Style in Flat.
        /// </summary>
        /// <param name="_buttonList">List containing the buttons that will be affected by the function.</param>
        public void ChangeFlatStyle(List<Button> _buttonList)
        {
            foreach (Button button in _buttonList)
            {
                button.FlatStyle = FlatStyle.Flat;
            }
        }
        /// <summary>
        /// Show an image (hanged stick man) in terms of try left.
        /// </summary>
        /// <param name="_try">Try left before GameOver.</param>
        public void updateImg(int _try)
        {
            pictureBox1.BackgroundImage = Jeux_pendu.Properties.Resources.ResourceManager.GetObject("_" +( Properties.Settings.Default.nbTry - _try)) as Bitmap;
        }
        /// <summary>
        /// Look if a letter is in the masked word <br/>
        /// -lunch fonction DecryptWord(compare and update crypted word and game.GetHangedMan().GetTryNB() point reamening in function of the letter choosen) <br/>
        /// -if game.GetHangedMan().GetTryNB() point == 0 : GameOver <br/>
        /// -if masked word == crypted word : Win <br/>
        /// </summary>
        /// <param name="_button">Button on which the function will be used.</param>
        public void ChooseLetter(Button _button)
        {
            if (playerLabel.Text != "Joueur: ")
            {
                _button.Enabled = false;
                _button.BackColor = Color.LightGray;
                game.HangedMan.DecryptWord(_button.Text[0]);
                textBoxShow.Text = game.HangedMan.CryptedWord;
                updateImg(game.HangedMan.TryNB);
                if (game.HangedMan.TryNB == 0)
                {
                    Activable(buttonListAlphabet , false);
                    MessageParty.Text = ShowHangedMan.GameOver(game.HangedMan.Word.RWord);
                    buttonStart.Enabled = true;
                }
                else if(game.HangedMan.CryptedWord.Replace(" ", "").Replace("_", "") == game.HangedMan.Word.RWord.ToUpper().Replace(" ", ""))
                {
                    Activable(buttonListAlphabet, false);
                    Activable(new List<Button>() { buttonStart } , true);
                    MessageParty.Text = ShowHangedMan.Win();
                    game.Player.AddScore(game.HangedMan.TryNB * 10);
                    ScoreUpdate();

                }
                else
                {
                    ShowHangedMan.TextLabelValue(MessageParty , "Vie restante: " + game.HangedMan.TryNB);
                }
            }
        }
        /// <summary>
        /// Update score of game.
        /// </summary>
        public void ScoreUpdate ()
        {
            ShowHangedMan.TextLabelValue(scoreLabel , "Score: " + game.Player.Score);
        }
        /// <summary>
        /// Get the letter of button.
        /// </summary>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxShow.Text += button.Text;
            ChooseLetter(button);
        }
        /// <summary>
        /// Alows to select a random word et start the game.
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            VisibilityAndActivable(buttonListAlphabet , true);
            ChangeColor(buttonListAll , Color.LightPink);
            Activable(new List<Button>() { buttonStart },false);
            game.NewGame();
            textBoxShow.Clear();
            textBoxShow.Text = game.HangedMan.CryptedWord;
            updateImg(game.HangedMan.TryNB);
            ShowHangedMan.TextLabelValue(MessageParty, "Vie restante: " + game.HangedMan.TryNB);

        }
        /// <summary>
        /// Makes invisible the alphabet button and show two buttons (yes and no) witch alows to choose if the game will close or not.
        /// </summary>
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            messageBeforeClickNo = MessageParty.Text;
            ShowHangedMan.TextLabelValue(MessageParty , "Etes-vous sur de vouloir quitter?");
            Visibility(buttonListAlphabet, false);
            Visibility(new List<Button>{buttonStart , buttonQuit , buttonDel} , false);
            Visibility(new List<Button> { buttonYes, buttonNo }, true);
        }
        /// <summary>
        /// Allows to confirm the pseudo choosen by the player.
        /// Check if player exist and create a json file for him if not.
        /// If player exist load his json file and get his pseudo and his score.
        /// </summary>
        private void buttonValidPseudo_Click(object sender, EventArgs e)
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            file += "/Jeux_pendu/Player/Player" + textBoxShow.Text + ".json";
            if (ShowHangedMan.CheckFile(file))
            {
                Player GetPlayer = ShowHangedMan.LoadFilePlayer(file);
                playerScore = GetPlayer.Score;
                playerPseudo = GetPlayer.Pseudo;
                game = new Game(playerPseudo, playerScore);
            }
            else
            {
                game = new Game(textBoxShow.Text, 0);
                ShowHangedMan.SaveFile(file, game.Player);
            }

            if (textBoxShow.Text.Length==0)
            {
                ShowHangedMan.TextLabelValue(MessageParty , "Entrer au moins un charactere pour le pseudo");
            }
            else
            {
                ShowHangedMan.TextLabelValue(playerLabel , "Joueur: " + playerPseudo);
                scoreLabel.Text += playerScore;
                textBoxShow.Clear();
                VisibilityAndActivable(new List<Button>() { buttonStart } , true);
                Visibility(new List<Button> { buttonValidPseudo, buttonDel }, false);
                Visibility(buttonListAlphabet , false);
                ShowHangedMan.TextLabelValue(MessageParty , " Appuyer sur <<Start>> pour commencer!");
            }
        }
        /// <summary>
        /// Allows to erase the last letter choosen for the pseudo selection.
        /// </summary>
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(textBoxShow.Text.Length > 0)
            {
                textBoxShow.Text = textBoxShow.Text.Substring(0, textBoxShow.Text.Length - 1);
            }
        }
        /// <summary>
        /// If it has been decided to quit the game, the game will close.
        /// </summary>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text != "Joueur: ")
            {
                Player SetPlayer = game.Player;
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                file += "/Jeux_pendu/Player/Player" + SetPlayer.Pseudo + ".json";
                ShowHangedMan.SaveFile(file , SetPlayer);
            }
            Close();
        }
        /// <summary>
        /// If it has been decided to don't quit the game, many button become visible again.
        /// </summary>
        private void buttonNo_Click(object sender, EventArgs e)
        {
            Visibility(buttonListAlphabet , true);
            Visibility(new List<Button>() { buttonStart , buttonQuit } , true);
            Visibility(new List<Button>() { buttonNo, buttonYes }, false);
            if(playerLabel.Text == "Joueur: ")
            {
                Visibility(new List<Button>() { buttonDel } , true);
            }
            else
            {
                Visibility(new List<Button>() { buttonDel }, false);
            }
            MessageParty.Text = messageBeforeClickNo;
        }
        /// <summary>
        /// Operation launched when the Form1 is loaded.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeColor(buttonListAll, Color.LightPink);
            ChangeFlatStyle(buttonListAll);
            BackColor = Color.LightCyan;
        }
    }
}