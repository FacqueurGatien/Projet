using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BBErrorPersonalise;

namespace BBSaisieUtilisateur
{
    public static class SaisieUtilisateur
    {
        public static string ControleSaisieStringLimite(string _saisie, int _limite)
        {
            if (_saisie.Length <= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new StringLimitException($"La saisie entrée depasse la limite de caractere autorisé qui est de {_limite} caracters");
            }
        }
        public static string ControleSaisieStringLimiteMin(string _saisie, int _limite)
        {
            if (_saisie.Length >= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new StringLimitMinException($"La saisie doit au moin faire {_limite} caracters");
            }
        }
        public static int ControleIntegerAbsolute(int? _nb)
        {
            if (_nb != null)
            {
                if (_nb >= 0)
                {
                    return (int)_nb;
                }
                else
                {
                    throw new IntegerAbsoluteException("le nombre doit etre strictement positif");
                }
            }
            else
            {
                throw new NullReferenceException("Champ vide");
            }
        }
        public static float ControleDecimalAbsolute(float? _nb)
        {
            if (_nb != null)
            {
                if (_nb >= 0)
                {
                    return (float)_nb;
                }
                else
                {
                    throw new DecimalAbsoluteException("le nombre doit etre strictement positif");
                }
            }
            else
            {
                throw new NullReferenceException("Champ vide");
            }
        }
        public static int ControleIntegerLimite(int _nb, int _limite)
        {
            if (_nb.ToString().Length <= _limite)
            {
                return _nb;
            }
            else
            {
                throw new IntegerlLimitException($"La limite de l'entier ne doit pas depassé {_limite} caracteres");
            }
        }
        public static string ControleIntegerLimite(string _saisie, int _limite)
        {
            if (_saisie.Length <= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new IntegerlLimitException($"La limite de l'entier ne doit pas depassé {_limite} caracteres");
            }
        }
        public static float ControleFloatLimite(float _nb, int _limite)
        {
            if (_nb.ToString().Length <= _limite)
            {
                return _nb;
            }
            else
            {
                throw new DecimalLimitException($"La limite de la partie decimale du nombre ne doit pas depassé {_limite} caracteres");
            }
        }
        public static string ControleFloatLimite(string _saisie, int _limite)
        {
            if (_saisie.Length <= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new DecimalLimitException($"La limite du nombre ne doit pas depassé {_limite} caracteres");
            }
        }
        public static string ControleIntDecimaleLimite(string _nb, string _limite)
        {
            string temp = _limite;
            if (temp == "")
            {
                temp = _nb.Length.ToString();
            }
            if (_nb.Length <= int.Parse(temp))
            {
                return _nb;
            }
            else
            {
                throw new IntegerlLimitException($"La partie avant la virgule ne doit pas depassé {_limite} caracteres");
            }
        }
        public static string ControleFloatDecimaleLimite(string _nb, string _limite)
        {
            string temp = _limite;
            if (temp == "")
            {
                temp = _nb.Length.ToString();
            }
            if (_nb.Length <= int.Parse(temp))
            {
                return _nb;
            }
            else
            {
                throw new IntegerlLimitException($"La partie réelle apres la virgule ne doit pas depassé {_limite} caracteres");
            }
        }
        public static string ControleSaisieStringNumericDecimalInt(string _saisie)
        {
            string pattern = "^[0-9]*$";
            if (Regex.Match(_saisie, pattern).Success)
            {
                return _saisie;
            }
            else
            {
                throw new NumericFormatException("La Partie avant la virgule de la decimal n'est pas un format numerique");
            }
        }
        public static string ControleSaisieStringNumericDecimalFloat(string _saisie)
        {
            string pattern = "^[0-9]*$";
            if (Regex.Match(_saisie, pattern).Success)
            {
                return _saisie;
            }
            else
            {
                throw new NumericFormatException("La Partie apres la virgule de la decimal n'est pas un format numerique");
            }
        }


        public static string ControleSaisieStringNomPrenom(string _saisie)
        {
            string pattern = "^([\\p{L}]{0,}?([-]{0,1}[\\p{L}]{1,}))$";
            if (Regex.Match(_saisie, pattern).Success)
            {
                return _saisie;
            }
            else
            {
                throw new NameFormatException("La saisie entrée doit etre uniquement Alphabetique (un tiret en separateur est autorisé ex: Marie-line)");
            }
        }
        public static string ControleSaisieStringNomPrenom(string _saisie, int _limite)
        {
            if (ControleSaisieStringNomPrenom(_saisie).Length <= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new NameLimitException($"La saisie entrée depasse la limite de caractere autorisé qui est de {_limite} caracters");
            }
        }


        public static string ControleSaisieStringNumeric(string _saisie)
        {
            string pattern = "^[0-9]*$";
            if (Regex.Match(_saisie, pattern).Success)
            {
                return _saisie;
            }
            else
            {
                throw new NumericFormatException("La saisie entrée doit etre uniquement Numerique");
            }
        }
        public static string ControleSaisieStringNumeric(string _saisie, int _limite)
        {
            if (ControleSaisieStringNumeric(_saisie).Length <= _limite)
            {
                return _saisie;
            }
            else
            {
                throw new NumericLimitMaxException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }
        public static string ControleSaisieStringNumeric(string _saisie, int _limMin, int _limMax)
        {
            if (ControleSaisieStringNumeric(_saisie).Length <= _limMax && _saisie.Length >= _limMin)
            {
                return _saisie;
            }
            else
            {
                throw new NumericLimitMinException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }

        public static int ControleSaisieInt(int _nb, int _limite, bool _abs = false)
        {
            if (_nb.ToString().Length <= _limite)
            {
                return ControleSaisieInt(_nb, _abs);
            }
            else
            {
                throw new IntegerlLimitException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }
        public static int ControleSaisieInt(int _nb, bool _abs = false)
        {
            string pattern = "^[+,-]?[0-9]*$";
            if (!Regex.Match(_nb.ToString(), pattern).Success)
            {
                throw new IntegerFormatException("La saisie ne corespond pas à un entier");
            }
            if (_abs && _nb >= 0)
            {
                return _nb;
            }
            else
            {
                throw new IntegerAbsoluteException("La saisie ne corespont pas un un nombre positif");
            }
        }
        public static int ControleSaisieInt(string _saisie, int _limite, bool _abs = false)
        {
            if (_saisie.Length <= _limite)
            {
                return ControleSaisieInt(_saisie, _abs);
            }
            else
            {
                throw new StringLimitException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }
        public static int ControleSaisieInt(string _saisie, bool _abs = false)
        {
            string pattern = "^[+,-]?[0-9]*$";
            int itemp;
            if (Regex.Match(_saisie, pattern).Success)
            {
                itemp = int.Parse(_saisie);
            }
            else
            {
                throw new StringIntegerFormatException("La saisie ne corespond pas à un entier");
            }
            if (_abs && itemp >= 0)
            {
                return itemp;
            }
            else
            {
                throw new IntegerAbsoluteException("La saisie ne corespont pas un un nombre positif");
            }
        }

        public static float ControleSaisieFloat(float _nb, int _limite, string _limI, string _limD, bool _abs = false)
        {
            if (_nb.ToString().Length <= _limite)
            {
                return ControleSaisieFloat(_nb, _limI, _limD, _abs);
            }
            else
            {
                throw new DecimalFormatException($"le nombre decimale ne respecte pas la limite total du nombre autorisé qui est de {_limite} chiffres");
            }
        }
        public static float ControleSaisieFloat(float _nb, string _limI, string _limD, bool _abs = false)
        {
            string pattern = "^[-,+]?[0-9]{0," + _limI + "}[,]{0,1}[0-9]{1," + _limD + "}$";
            if (_abs && _nb < 0)
            {
                throw new DecimalAbsoluteException($"le nombre decimale doit etre strictement positif");
            }
            else if (Regex.Match(_nb.ToString(), pattern).Success)
            {
                return _nb;
            }
            else
            {
                string[] array = _nb.ToString().Split(',');
                if (array.Length > 0 && _limI != "")
                {
                    if (array[0].Length > int.Parse(_limI))
                    {
                        throw new IntegerlLimitException($"La saisie ne respecte pas la limitation des entiers du nombre ({_limI} chiffre avant la virgule");
                    }
                    else
                    {
                        if (array.Length > 1 && _limD != "" && array[1].Length > int.Parse(_limD))
                        {
                            throw new DecimalLimitException($"La saisie ne respecte pas la limitation de la partie decimale du nombre ({_limD} chiffre apres la virgule");
                        }
                        else
                        {
                            throw new DecimalFormatException("La saisie ne respecte pas le format d'un nombre decimale");
                        }
                    }
                }
                else
                {
                    throw new DecimalFormatException("La saisie ne respecte pas le format d'un nombre decimale");
                }
            }
        }
        public static float ControleSaisieFloat(float _nb, int _limite, bool _abs = false)
        {
            if (_nb.ToString().Length <= _limite)
            {
                return ControleSaisieFloat(_nb, "", "", _abs);
            }
            else
            {
                throw new DecimalLimitException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }
        public static float ControleSaisieFloat(float _nb, bool _abs = false)
        {
            return ControleSaisieFloat(_nb, "", "", _abs);
        }
        public static float ControleSaisieFloat(string _saisie, int _limite, string _limI, string _limD, bool _abs = false)
        {
            if (_saisie.Length <= _limite)
            {
                return ControleSaisieFloat(_saisie, _limI, _limD, _abs);
            }
            else
            {
                throw new StringLimitException($"le nombre decimale ne respecte pas la limite total du nombre autorisé qui est de {_limite} chiffres");
            }
        }
        public static float ControleSaisieFloat(string _saisie, string _limI, string _limD, bool _abs = false)
        {
            string pattern = "^[-,+]?[0-9]{0," + _limI + "}[,]{0,1}[0-9]{1," + _limD + "}$";
            if (_abs && float.Parse(_saisie) < 0)
            {
                throw new DecimalLimitException($"le nombre decimale doit etre strictement positif");
            }
            else if (Regex.Match(_saisie.ToString(), pattern).Success)
            {
                return float.Parse(_saisie);
            }
            else
            {
                string[] array = _saisie.Split(',');
                if (array.Length > 0 && _limI != "")
                {
                    if (array[0].Length > int.Parse(_limI))
                    {
                        throw new IntegerlLimitException($"La saisie ne respecte pas la limitation des entiers du nombre ({_limI} chiffre avant la virgule");
                    }
                    else
                    {
                        if (array.Length > 1 && _limD != "" && array[1].Length > int.Parse(_limD))
                        {
                            throw new DecimalLimitException($"La saisie ne respecte pas la limitation de la partie decimale du nombre ({_limD} chiffre apres la virgule");
                        }
                        else
                        {
                            throw new DecimalFormatException("La saisie ne respecte pas le format d'un nombre decimale");
                        }
                    }
                }
                else
                {
                    throw new DecimalFormatException("La saisie ne respecte pas le format d'un nombre decimale");
                }
            }
        }
        public static float ControleSaisieFloat(string _saisie, int _limite, bool _abs = false)
        {
            if (_saisie.Length <= _limite)
            {
                return ControleSaisieFloat(_saisie, "", "", _abs);
            }
            else
            {
                throw new ArgumentOutOfRangeException("La saisie entrée depasse la limite de caractere autorisé");
            }
        }
        public static float ControleSaisieFloat(string _saisie, bool _abs = false)
        {
            return ControleSaisieFloat(_saisie, "", "", _abs);
        }

        public static DateTime ControleSaisieDate(string _saisie)
        {
            DateTime date = new DateTime();
            if (DateTime.TryParse(_saisie, out date))
            {
                return date;
            }
            else
            {
                throw new DateFormatException("Le format de la date est invalide");
            }
        }
        public static DateTime ControleSaisieDateFutur(DateTime? _date)
        {
            if (_date == null)
            {
                throw new NullReferenceException("Aucune date saisie");
            }
            else
            {
                if (_date > DateTime.Today)
                {
                    return (DateTime)_date;
                }
                else
                {
                    throw new DateWasNotFuturException("Le Date entré doit etre superieur a la date du jour");
                }
            }
        }
        public static DateTime ControleSaisieDatePasse(DateTime? _date)
        {
            if (_date == null)
            {
                throw new NullReferenceException("Aucune date saisie");
            }
            else
            {
                if (_date < DateTime.Today)
                {
                    return (DateTime)_date;
                }
                else
                {
                    throw new DateWasNotPastException("Le Date entré doit etre superieur a la date du jour");
                }
            }
        }
        public static DateTime ControleSaisieDatePresent(DateTime? _date)
        {
            if (_date == null)
            {
                throw new NullReferenceException("Aucune date saisie");
            }
            else
            {
                if (_date == DateTime.Today)
                {
                    return (DateTime)_date;
                }
                else
                {
                    throw new DateWasNotTodayException("Le Date entré doit etre superieur a la date du jour");
                }
            }
        }
    }
}

