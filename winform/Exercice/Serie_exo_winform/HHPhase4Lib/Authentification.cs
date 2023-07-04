using System.Text.Json;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace HHPhase4Lib
{
    public  static class Authentification
    {
        //public string path = @"..\..\..\File\";
        public static bool ConnectionPassword(string mdp)
        {
            string mdp1 = Encrypt(mdp);
            //SerialisationUniqueBin("mdpAdminP",mdp1);
            string mdp2 = DeserialisationUniqueBin("mdpAdminP");
            return mdp1==mdp2;
        }
        public static bool ConnectionLogin(string login)
        {
            string login1 = Encrypt(login);
            string login2 = DeserialisationUniqueBin("loginAdminP");
            return login1 == login2;
        }

        public static bool Connection(string login,string mdp)
        {
            if (ConnectionLogin(login))
            {
                if (ConnectionPassword(mdp))
                {
                    return true;
                }
                return false;
            }
            else
            {
                    return false;
            }
        }

        public static string Encrypt(string encryptString, string path = @"..\..\..\..\HHPhase4Lib\File\")
        {
            string EncryptionKey = DecryptageFile(path + "mpdKey").ToString();


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
        public static string Decrypt(string cipherText, string path = @"..\..\..\..\HHPhase4Lib\File\")
        {
            string EncryptionKey = DecryptageFile(path + "mpdKey").ToString();


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
        public static void SerialisationUniqueBin(string _nomFichier, string _mdp, string path = @"..\..\..\..\HHPhase4Lib\File\")
        {
            string f = "";
            string filePath = path;
            filePath += $"{_nomFichier}.bin";
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _mdp);
                fs.Close();
            }
        }
        public static string DeserialisationUniqueBin(string _nomFichier,string path = @"..\..\..\..\HHPhase4Lib\File\")
        {
            string f = "";
            string filePath = path;
            filePath += $"{_nomFichier}.bin";

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
        public static string DecryptageFile(string nom, string path = @"..\..\HHPhase4Lib\File\")
        {
            string decryptedMessage = "";
            try
            {
                using (FileStream fileStream = new(path+nom+".txt", FileMode.Open))
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
        public static void Cruptage(string nom, string mdp, string path = @"..\..\..\..\HHPhase4Lib\File\")
        {
            try
            {
                using (FileStream fileStream = new(path+nom+".txt", FileMode.OpenOrCreate))
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The encryption failed. {ex}");
                throw ex;
            }

        }

    }
}