using SaisieUtilisateurModel;
using Operations;
using EEListBox2Model;
using System.Text.Json;
using GGSytheseEmpruntModel;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using HHPhase4Lib;

namespace TestClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationTest();
            SaisieUtilisateurTest();
            CreerDossier();
            OuvrirDossier();
            CreerEmprunt();
            OuvrirEmprunt();

            Console.WriteLine("_______________________");


            //Console.WriteLine(Decryptage("mdpLaura.txt", "ús­8ˆH\\fœ‡ wmƒÜ\\u0006\u0015Ì‡Ð:Û6èi\\u001a\\u001fƒà6·±ª"));

            /*string mdp = Authentification.Encrypt("Azerty1234.");
            Authentification.SerialisationUniqueBin("mdpAdminP", mdp);
*/
            /*string mdp2 = Authentification.DeserialisationUniqueBin("loginAdminP");
            Console.WriteLine((mdp2));
            Console.WriteLine(Authentification.Decrypt(mdp2));


            Cruptage("mpdKey.txt", "Fzaxf8mxfn.");
            Console.WriteLine(DecryptageFile("mpdKey.txt"));*/
            void OperationTest()
            {
                Operation operation = new Operation();
                operation.Ajouter(new List<int>() { 1, 2, 3, 4, 5 });
                int result = operation.ResultatAddition();
                string listeNum = "";
                foreach (int i in operation.NumList)
                {
                    listeNum += $" {i} +";
                }
                Console.WriteLine($"{listeNum.Remove(listeNum.Length - 1)} = {result}\n");
            }
            void SaisieUtilisateurTest()
            {
                Formulaire formulaire = new Formulaire("Pandora", new DateTime(2023, 12, 31), 500.50f, "88160");
                Formulaire formulaireS = new Formulaire("Pandora", "2023-12-31", "500,50", "88160");
                Console.WriteLine(formulaire.ToString());
                Console.WriteLine(formulaireS.ToString());
            }
            void CreerDossier()
            {
                Fichier france = new FichierPays("France", "Paris");
                Fichier italie = new FichierPays("Italie", "Rome");
                Fichier belgique = new FichierPays("Belgique", "Bruxelles");
                Fichier allemagne = new FichierPays("Allemagne", "Berlin");
                Fichier espagne = new FichierPays("Espagne", "Lisbone");
                Fichier royaumeUnis = new FichierPays("Royaume-Unis", "Londre");
                Fichier japon = new FichierPays("Japon", "Tokyo");

                List<Fichier> liste = new() { france, belgique, allemagne, espagne, royaumeUnis, japon, italie };

                Dossier source = new("Source");
                Dossier cible = new("Cible");
                source.AjouterDansDossier(liste);
                source.SerialisationDossierBin("Source");
                cible.SerialisationDossierBin("Cible");
            }
            void OuvrirDossier()
            {
                Dossier source = Dossier.DeserialisationDossierBin("Source");
                Dossier cible = Dossier.DeserialisationDossierBin("Cible");

                Console.WriteLine(source.ToString());
                Console.WriteLine(cible.ToString());
            }
            void CreerEmprunt()
            {
                Emprunt emprunt = new Emprunt("Pandora", 250000, 120, EnumTypePeriodicite.Trimestrielle, 8);
                {
                    string path = @"..\..\..\..\GGSytheseEmpruntModel\File\";
                    path += $"{emprunt.NomEmprunt}.emprunt";
                    if (!File.Exists(path))
                    {
                        emprunt.SerialisationUniqueBin(emprunt.NomEmprunt);
                    }
                }
            }
            void OuvrirEmprunt()
            {
                Emprunt emprunt = (Emprunt)Emprunt.DeserialisationUniqueBin("Pandora");
                Console.WriteLine(emprunt.afficher());
            }



        }

        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = DecryptageFile("mdpKey.txt").ToString();


            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = DecryptageFile("mdpKey.txt").ToString();


            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static void SerialisationUniqueBin(string _nomFichier, string _mdp)
        {
            string path = _nomFichier;
            path += $"{_nomFichier}.txt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _mdp);
                fs.Close();
            }
        }
        public static string DeserialisationUniqueBin(string _nomFichier)
        {
            string f = "";
            string filePath = _nomFichier;
            filePath += $"{_nomFichier}.txt";

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    f = (string)bf.Deserialize(fs);
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
            else
            {
                throw new NullReferenceException("Pas de fichier portant ce nom");
            }

            return f;
        }


        public static string DecryptageFile(string nom)
        {
            string decryptedMessage = "";
            try
            {
                using (FileStream fileStream = new(nom, FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }

                        byte[] key =
                        {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };

                        using (CryptoStream cryptoStream = new(
                           fileStream,
                           aes.CreateDecryptor(key, iv),
                           CryptoStreamMode.Read))
                        {
                            // By default, the StreamReader uses UTF-8 encoding.
                            // To change the text encoding, pass the desired encoding as the second parameter.
                            // For example, new StreamReader(cryptoStream, Encoding.Unicode).
                            using (StreamReader decryptReader = new(cryptoStream))
                            {
                                decryptedMessage = decryptReader.ReadLine();
                                //Console.WriteLine($"The decrypted original message: {decryptedMessage}");
                            }
                        }
                    }
                }
                return decryptedMessage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The decryption failed. {ex}");
                throw ex;
            }
        }




        public static string Cruptage(string nom, string mdp)
        {
            try
            {
                using (FileStream fileStream = new(nom, FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {
                    0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                    0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new(
                            fileStream,
                            aes.CreateEncryptor(),
                            CryptoStreamMode.Write))
                        {
                            // By default, the StreamWriter uses UTF-8 encoding.
                            // To change the text encoding, pass the desired encoding as the second parameter.
                            // For example, new StreamWriter(cryptoStream, Encoding.Unicode).
                            using (StreamWriter encryptWriter = new(cryptoStream))
                            {
                                encryptWriter.WriteLine(mdp);
                            }
                        }
                    }
                }

                Console.WriteLine("The file was encrypted.");
                return mdp;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The encryption failed. {ex}");
                throw ex;
            }

        }

        public static async Task<string> Decryptage(string nom, string test)
        {
            try
            {
                using (FileStream fileStream = new(nom, FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }

                        byte[] key =
                        {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };

                        using (CryptoStream cryptoStream = new(
                           fileStream,
                           aes.CreateDecryptor(key, iv),
                           CryptoStreamMode.Read))
                        {
                            // By default, the StreamReader uses UTF-8 encoding.
                            // To change the text encoding, pass the desired encoding as the second parameter.
                            // For example, new StreamReader(cryptoStream, Encoding.Unicode).
                            using (StreamReader decryptReader = new(cryptoStream))
                            {
                                test = await decryptReader.ReadLineAsync();
                            }
                        }
                    }
                }
                return test;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The decryption failed. {ex}");
                throw ex;
            }
        }
    }
}