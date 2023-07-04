using EEListBox2Model;
using NPOI.SS.Util;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;

namespace GGSytheseEmpruntModel
{
    [Serializable]
    public enum EnumTypePeriodicite
    {
        Mensuelle = 1,
        Bimestrielle = 2,
        Trimestrielle = 3,
        Semestrielle = 6,
        Anuelle = 12
    }
    [Serializable]
    public class Emprunt : Fichier
    {
        private string nom;
        private Int64 capitalEmprunte;
        private int dureeEnMoisRemboursement;
        private EnumTypePeriodicite periodicite;
        private int tauxInteret;
        private string nomEmprunt;

        public string Nom { get => nom; set => nom = value; }
        public Int64 CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }
        public int DureeEnMoisRemboursement { get => dureeEnMoisRemboursement; set => dureeEnMoisRemboursement = value; }
        public EnumTypePeriodicite Periodicite { get => periodicite; set => periodicite = value; }
        public int TauxInteret { get => tauxInteret; set => tauxInteret = value; }
        public string NomEmprunt { get => nomEmprunt; set => nomEmprunt = value; }

        public Emprunt(string _nom, Int64 _capitalEmprunte, int _dureeEnMoisRemboursement, EnumTypePeriodicite _periodicite, int _tauxInteret)
        {
            nom = _nom;
            capitalEmprunte = _capitalEmprunte;
            dureeEnMoisRemboursement = _dureeEnMoisRemboursement;
            periodicite = _periodicite;
            tauxInteret = _tauxInteret;
            nomEmprunt = Nom;
            base.Nom = nomEmprunt;
        }
        public Emprunt(Int64 _capitalEmprunte, int _dureeEnMoisRemboursement, EnumTypePeriodicite _periodicite, int _tauxInteret)
            : this("", _capitalEmprunte, _dureeEnMoisRemboursement, _periodicite, _tauxInteret)
        {
        }

        public void UpdateNomEmprunt()
        {
            nomEmprunt = Nom;
            base.Nom = nomEmprunt;
        }
        public int NombreRemboursement()
        {
            return dureeEnMoisRemboursement / (int)periodicite;
        }
        private double MontantRemboursementCalcul()
        {
            Int64 K = capitalEmprunte;
            double t = TauxAnnuelle();
            int n = NombreRemboursement();

            double result = K * (t / (1 - Math.Pow((1 + t), (-n))));
            DecimalFormat df = new DecimalFormat("0.000");
            return Double.Parse(df.Format(result));
        }
        private double TauxAnnuelle()
        {
            return (tauxInteret / 100d) / 12 * (int)((int)periodicite);
        }
        public string MontantRemboursement()
        {
            return MontantRemboursementCalcul().ToString();
        }

        public void SerialisationUniqueBin(string _nomFichier)
        {
            string path = @"..\..\..\..\GGSytheseEmpruntModel\File\";
            path += $"{_nomFichier}.emprunt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
                fs.Close();
            }
        }
        public static Fichier DeserialisationUniqueBin(string _nomFichier)
        {
            Fichier f = null;
            string filePath = @"..\..\..\..\GGSytheseEmpruntModel\File\";
            filePath += $"{_nomFichier}.emprunt";

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    f = (Fichier)bf.Deserialize(fs);
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

        public override string afficher()
        {
            string result = "";
            result += $"Nom du fichier: {this.nomEmprunt}.emprunt\n";
            result += $"Nom Client: {this.nom}\n";
            result += $"Montant emprunté: {this.capitalEmprunte}\n";
            result += $"Durée de remboursement: {this.dureeEnMoisRemboursement} mois\n";
            result += $"Taux d'interet: {this.tauxInteret}\n";
            result += $"Periodicité de rembourcement: {this.periodicite.ToString()}\n";
            result += $"nombre de remboursement: {NombreRemboursement()}\n";
            result += $"Montant d'1 remboursement: {MontantRemboursementCalcul()}\n";
            return result;
        }
    }
}