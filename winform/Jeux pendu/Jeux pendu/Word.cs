namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    internal class Word
    {
        /// <summary>public static Random random</summary>
        static Random random = new Random();
        /// <summary>private string word</summary>
        private string word;
        /// <summary>
        /// Word variable getter
        /// </summary>
        public string RWord { get => word; }
        /// <summary>
        /// class constructor<br/>
        /// Generate and get a random word from WordListS
        /// </summary>
        public Word()
        {
            word = GenerateRandomWord();
        }
        /// <summary>
        /// Get a random word from WordListS
        /// </summary>
        public string GenerateRandomWord()
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            file += "/Jeux_pendu/WordList/WorldList.json";
            if (ShowHangedMan.CheckFile(file))
            {
                WordListS SetWordList = new WordListS();
                ShowHangedMan.SaveFile(file , SetWordList.WordList);
            }
            List<string> GetWordList = ShowHangedMan.LoadFileStringList(file);
            return GetWordList[random.Next(GetWordList.Count)].Replace("_", " ");
        }
    }
}
