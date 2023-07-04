using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EEListBox2Model
{
    [Serializable]
    public class Dossier
    {
        private string nom;
        private List<Fichier> dossierListe;

        public string Nom { get => nom; }
        public List<Fichier> DossierListe { get => dossierListe; }

        public Dossier(string _nom)
        {
            nom = _nom;
            dossierListe = new List<Fichier>();
        }

        public void AjouterDansDossier(Fichier fichier)
        {
            dossierListe.Add(fichier);
        }
        public void AjouterDansDossier(List<Fichier> fichiers)
        {
            foreach (Fichier fichier in fichiers)
            {
                dossierListe.Add(fichier);
            }
        }
        public void EnvoyerFichier(Fichier fichier, Dossier dossier)
        {
            fichier.EnvoyerFichier(dossier);
            dossierListe.Remove(fichier);
        }
        public void EnvoyerFichier(Dossier dossier)
        {
            foreach (Fichier fichier in this.DossierListe)
            {
                fichier.EnvoyerFichier(dossier);
            }
            dossierListe.Clear();
        }
        public void RecupererFichier(Dossier dossier, string fichierNom)
        {
            Fichier? temp = null;
            foreach (Fichier fichier in dossier.DossierListe)
            {
                if (fichier.Nom == fichierNom)
                {
                    temp = fichier;
                }
            }
            if (temp != null)
            {
                dossier.EnvoyerFichier(temp, this);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public void RecupererFichier(Dossier dossier, int indexFichier)
        {
            if (dossier.dossierListe.Count > indexFichier)
            {
                dossier.EnvoyerFichier(dossier.dossierListe[indexFichier], this);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void RecupererFichier(Dossier dossier, Fichier fichier)
        {
            if (dossier.dossierListe.Contains(fichier))
            {
                dossier.EnvoyerFichier(fichier, this);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void RecupererFichier(Dossier dossier)
        {
            if (dossier.dossierListe.Count > 0)
            {
                foreach (Fichier fichier in dossier.dossierListe)
                {
                    fichier.EnvoyerFichier(this);
                }
                dossier.dossierListe.Clear();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public override string ToString()
        {
            string temp = $"\nNom du dossier: {this.Nom}\n\n";
            if (this.dossierListe.Count > 0)
            {
                int indexTmp = 0;
                foreach (Fichier fichier in dossierListe)
                {
                    temp += string.Format("{0,-5}{1,0}\n", indexTmp++, $"{fichier.Nom}");
                }
            }
            else
            {
                temp += "Dossier vide\n";
            }
            return $"_____________________________{temp}_____________________________\n";
        }

        public void RemplacerListeFichier(List<Fichier> _lf)
        {
            dossierListe = _lf;
        }
        public void SerialisationBin(string _nomFichier)
        {
            string path = @"..\..\..\..\EEListBox2Model\File\";
            path += $"{_nomFichier}.bin";
            FileStream fs = File.Create(path);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dossierListe);
            fs.Close();
        }
        public static List<Fichier> DeserialisationBin(string _nomFichier)
        {
            List<Fichier> lf = new List<Fichier>();
            string filePath = @"..\..\..\..\EEListBox2Model\File\";
            filePath += $"{_nomFichier}.bin";

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    lf = (List<Fichier>)bf.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    fs.Close();
                }
            }

            return lf;
        }

        public void SerialisationDossierBin(string _nomFichier)
        {
            string path = @"..\..\..\..\EEListBox2Model\File\";
            path += $"{_nomFichier}.bin";
            FileStream fs = File.Create(path);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
        public static Dossier DeserialisationDossierBin(string _nomFichier)
        {
            Dossier dos = null;
            string filePath = @"..\..\..\..\EEListBox2Model\File\";
            filePath += $"{_nomFichier}.bin";

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    dos = (Dossier)bf.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    fs.Close();
                }
            }
            if (dos!=null)
            {
                return dos;
            }
            else
            {
                throw new NullReferenceException("Aucun dossier n'as etait deserialisé");
            }
        }

        /*        public void Serialisation(string _nomFichier)
                {
                    string jsonString = "";
                    string nomFichier = $"{_nomFichier}.json";
                    foreach (Fichier item in dossierListe)
                    {
                        jsonString += JsonSerializer.Serialize(item);
                    }
                    jsonString += JsonSerializer.Serialize(dossierListe);
                    File.WriteAllText("C:\\laragon\\www\\repos_laragon\\CDA\\Winform\\Exercice\\Serie_exo_winform\\EEListBox2Model\\File\\" + nomFichier, jsonString);
                }
                public List<Fichier> Deserialisation(string _nomFichier)
                {
                    string jsonString = File.ReadAllText("C:\\laragon\\www\\repos_laragon\\CDA\\Winform\\Exercice\\Serie_exo_winform\\EEListBox2Model\\File\\" + $"{_nomFichier}.json");
                    return JsonSerializer.Deserialize<List<Fichier>>(jsonString); 
                }
                public void DeserialisationIntern(string _nomFichier)
                {
                    string jsonString = File.ReadAllText("C:\\laragon\\www\\repos_laragon\\CDA\\Winform\\Exercice\\Serie_exo_winform\\EEListBox2Model\\File\\" + $"{_nomFichier}.json");
                    this.dossierListe = JsonSerializer.Deserialize<List<Fichier>>(jsonString);
                }

        public void SerialisationXml(string _nameFile)
        {
            string path = @"..\..\..\..\EEListBox2Model\File\";
            StreamWriter writer = File.CreateText(path + _nameFile + ".xml");
            XmlSerializer x = new XmlSerializer(typeof(List<Fichier>));
            x.Serialize(writer, dossierListe);
            writer.Close();
        }
        public void SerialisationJson(string _nomFichier)
        {
            string path = @"..\..\..\..\EEListBox2Model\File\";
            string jsonString = JsonSerializer.Serialize(dossierListe);
            File.WriteAllText(path + _nomFichier + ".json", jsonString);
        }

        public void DeserialisationJson(string _nomFichier)
        {
            List<Fichier> temp = new List<Fichier>();
            string path = @"..\..\..\..\EEListBox2Model\File\";
            string jsonString = File.ReadAllText(path + _nomFichier + ".json");
            temp = JsonSerializer.Deserialize<List<Fichier>>(jsonString);
        }
        public List<Fichier> DeserialisationJson2(string _nomFichier)
        {
            string path = @"..\..\..\..\EEListBox2Model\File\";
            string jsonString = File.ReadAllText(path + _nomFichier + ".json");
            return JsonSerializer.Deserialize<List<Fichier>>(jsonString);
        }

                public List<Object> DeserialisationJson(string _nomFichier)
                {
                    string path = @"..\..\..\..\EEListBox2Model\File\";
                    //string jss = File.ReadAllText(path + _nomFichier + ".json");
                    string jss = path + _nomFichier + ".json";
                    List<object> list = new List<object>();
                    string json = new StreamReader(jss).ReadToEnd();
                    Dictionary<string, string> sData = JsonSerializer.Deserialize<Dictionary<string, string>>(jss);

                    foreach(KeyValuePair<string, string> item in sData)
                    {
                        string _nomPays = sData["nomPays"].ToString();
                        string _capital = sData["Capital"].ToString();
                        string _nom = sData["Nom"].ToString();
                        list.Add(new List<string>() {_nom,_nomPays,_capital });
                    }
                    return list;
                }*/

    }
}
