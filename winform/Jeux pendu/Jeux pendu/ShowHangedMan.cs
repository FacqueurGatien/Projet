using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Jeux_pendu
{
    /// <summary>
    /// Author: FACQUEUR Gatien facqueur.gatien@gmail.com <br/>
    /// Licence: MIT
    /// </summary>
    internal static class ShowHangedMan
    {
        /// <summary>
        /// Returns a string which announce the party is lose and show the hiden word
        /// </summary>
        /// <param name="_word">word that musted found</param>
        public static string GameOver(string _word)
        {
            return "Vous etes pendu ! Le mot été: " + _word;
        }
        /// <summary>
        /// Returns a string which announce the party is win.
        /// </summary>
        public static string Win()
        {
            return "Vous avez trouvé le mot !";
        }
        /// <summary>
        /// Show variable text on label.
        /// </summary> 
        /// <param name="_label">Label target by function</param>        
        /// <param name="_text">Text to display</param>
        public static void TextLabelValue(Label _label , string _text)
        {
            _label.Text = _text;
        }
        /// <summary>
        /// Check if there is a folder at the specified path and create folder if not.
        /// </summary> 
        /// <param name="_path">folder path to check</param>        
        public static void CheckFolder(string _path)
        {
            if(!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }
        /// <summary>
        /// Check if there is a file at the specified path.
        /// </summary> 
        /// <param name="_path">file path to check</param>       
        public static bool CheckFile(string _path)
        {
            if (File.Exists(_path))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Load and return the Json file in a Player object.
        /// </summary> 
        /// <param name="_path">path of json file</param>       
        public static Player LoadFilePlayer(string _path)
        {
            string jsonStringDeserialize = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<Player>(jsonStringDeserialize);
        }
        /// <summary>
        /// Load and return the Json file in a string List.
        /// </summary> 
        /// <param name="_path">path of json file</param>       
        public static List<string> LoadFileStringList(string _path)
        {
            string jsonStringDeserialize = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<List<string>>(jsonStringDeserialize);
        }
        /// <summary>
        /// Save object in a Json file from path.
        /// </summary> 
        /// <param name="_path">path of json file</param>          
        /// <param name="_param">the object to save</param>  
        public static void SaveFile(string _path , object _param)
        {
            string jsonStringSerialize = JsonConvert.SerializeObject(_param, Formatting.Indented);
            File.WriteAllText(_path , jsonStringSerialize);
        }
    }
}
