namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    internal class HangedMan
    {
        /// <summary>Word to find.</summary>
        private Word word;
        /// <summary>word variable getter</summary>
        internal Word Word { get => word; }
        /// <summary>Crypted word from HangedMan.Word.</summary>
        private string cryptedWord;
        /// <summary>cryptedWord variable getter.</summary>
        public string CryptedWord { get => cryptedWord; }
        /// <summary>Try left before GameOver</summary>
        private int tryNB;
        /// <summary>TryNB variable getter.</summary>
        public int TryNB { get => tryNB; }
        /// <summary>
        /// HangedMan constructor<br/>
        /// instanciate one party.
        /// </summary>
        public HangedMan()
        {
            word = new Word();
            cryptedWord = EncryptWord();
            tryNB = 9;
        }
        /// <summary>
        /// Encrypt the word to find and return the result by replacing letter by underscore.
        /// </summary>
        public string EncryptWord()
        {
            string cryptedWord = "";
            foreach(char c in word.RWord)
            {
                switch(c)
                {
                    case ' ':
                        cryptedWord += " " + " ";
                        break;
                    case '_':
                        cryptedWord += " " + " ";
                        break;
                    case '-':
                        cryptedWord += "-" + " ";
                        break;
                    case '\'':
                        cryptedWord += "'" + " ";
                        break;
                    default:
                        cryptedWord += "_" + " ";
                        break;
                }
            }
            return cryptedWord;
        }
        /// <summary>
        /// Check if letter in the word to find.
        /// </summary>
        /// <param name="_letter">Letter to check</param>
        public bool CheckLetter(char _letter)
        {
            return word.RWord.Contains(_letter) ? true : false;
        }
        /// <summary>
        /// Update the cryptedWord by adding the letter in it if HangedMan.CheckLetter return true.
        /// </summary>
        /// <param name="_letter">Letter to replace in HangedMan.CryptedWord.</param>
        public void DecryptWord(char _letter)
        {
            string newCryptedWord ="";

            int j = 0;
            for(int i = 0; i < word.RWord.Length; i++)
            {
                if (_letter == word.RWord.ToUpper()[i])
                {
                    newCryptedWord += _letter + " "; 
                }
                else
                {
                    newCryptedWord += cryptedWord[j]+" ";
                }
                j += 2;
            }
            cryptedWord = newCryptedWord;
            if(!cryptedWord.ToUpper().Contains(_letter))
            {
                tryNB--;
            }
        }
    }
}
