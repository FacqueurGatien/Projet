using System.Text.RegularExpressions;

namespace ECF_SPA_METIER
{
    public enum EnumRace
    {
        Abyssin = 1,
        Europeen = 2,
        MaineCoon = 3,
        Sphynx = 4
    }
    public class ChatM
    {
        private long numeroPuce;
        private string nom;
        private int? age;
        private EnumRace? race;

        public long NumeroPuce { get => numeroPuce;
            set 
            {
                if (Regex.Match(value.ToString(), "[2]{1}[5]{1}[0]{1}[2]{1}[6]{1}[0-9]{2}[0-9]{8}").Success)
                {
                    numeroPuce = value;
                }
                else
                {
                    numeroPuce = 0;
                }

            }
        }
        public string Nom { get => nom; 
            set 
            {
                if (Regex.Match(value,"^[a-zA-Z- ]{1,25}$").Success)
                {
                    nom = value;
                }
                else
                {
                    nom = "";
                }
            }
        }
        public int? Age { get => age; 
            set 
            {
                if (value > 0 && value <= 500)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public EnumRace? Race { get => race;
            set 
            {
                if (value.GetType().Name == "EnumRace")
                {
                    race = value;
                }
                else
                {
                    race = null;
                }
            } 
        }

        public ChatM(long _numPuce,string _nom,int _age,EnumRace? _race)
        {
            numeroPuce = _numPuce;
            nom = _nom;
            age = _age;
            race = _race;
        }
        public ChatM():this(0,"",0,null)
        {

        }
        public bool Valid()
        {
            if (numeroPuce > 0 && nom.Length > 0 && age > 0 && race != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Miauler()
        {
            return "Miaou";
        }
    }
}