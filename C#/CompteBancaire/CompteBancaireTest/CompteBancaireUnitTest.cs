using CompteBancaires;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace CompteBancaireTest
{
    [TestClass]
    public class CompteBancaireUnitTest
    {
        [TestMethod]
        public void CrediterNegatif()
        {
            double montant = -1500;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte;

            //Assert.ThrowsException<System.ArgumentException>(() => compteTest.Crediter(montant));
            compteTest.Crediter(montant);
            Assert.AreEqual(apres,compteTest.SoldeDuCompte,"Le montant en paramettre etant negatif le compte n'a pas �t� credit�");
        }
        [TestMethod]
        public void CrediterPositif()
        {
            double montant = 1500;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte + montant;


            compteTest.Crediter(montant);
            Assert.AreEqual(apres, compteTest.SoldeDuCompte, "Le montant en paramettre etant positif le compte a bien �t� credit�");
        }
        [TestMethod]
        public void CrediterPositifZero()
        {
            double montant = 0;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte;

            compteTest.Crediter(montant);
            Assert.AreEqual(apres, compteTest.SoldeDuCompte, "Le montant en paramettre etant de zero le credit n'opere pas");
        }
        [TestMethod]
        public void DebiterNegatif()
        {
            double montant = -1500;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte;

            Assert.AreEqual(apres, compteTest.SoldeDuCompte, "Le montant en paramettre etant negatif le compte n'a pas �t� d�bit�");
        }
        [TestMethod]
        public void DebiterPositifRetour()
        {
            double montant = 1500;
            CompteBancaire compteTest = new("test", 5000, 500);

            Assert.IsTrue(compteTest.Debiter(montant), "Le montant en paramettre etant positif et l'autorisation de decouvert le permettant le compte a bien �t� debit�");
        }
        [TestMethod]
        public void DebiterPositifValeur()
        {
            double montant = 1500;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte - montant;

            compteTest.Debiter(montant);
            Assert.AreEqual(apres, compteTest.SoldeDuCompte, "Le montant en paramettre etant positif et l'autorisation de decouvert le permettant le compte a bien �t� debit�");
        }
        [TestMethod]
        public void DebiterPositifTrop()
        {
            double montant = 6500;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte - montant;

            Assert.IsFalse(compteTest.Debiter(montant), "Le montant en paramettre etant trop elev� le compte n'a pas �t� d�bit�");
        }
        [TestMethod]
        public void DebiterPositifZero()
        {
            double montant = 0;
            CompteBancaire compteTest = new("test", 5000, 500);
            double apres = compteTest.SoldeDuCompte;

            compteTest.Debiter(montant);
            Assert.AreEqual(apres, compteTest.SoldeDuCompte, "Le montant en paramettre etant de 0 le debit n'opere pas");
        }
        [TestMethod]
        public void TransfererNegatif()
        {
            double montant = -500;
            CompteBancaire compteTest = new("test", 5000, 500);
            CompteBancaire compteTest2 = new("test2", 5000, 500);
            double apres = compteTest.SoldeDuCompte - montant;

            Assert.IsFalse(compteTest.Transferer(compteTest2,montant), "Le montant en paramettre etant n�gatif le transfert n'as pas op�r�");
        }
        [TestMethod]
        public void TransfererPositif()
        {
            double montant = 500;
            CompteBancaire compteTest = new("test", 5000, 500);
            CompteBancaire compteTest2 = new("test2", 5000, 500);
            double apres = compteTest.SoldeDuCompte - montant;

            Assert.IsTrue(compteTest.Transferer(compteTest2, montant), "Le montant en paramettre etant positif et l'autorisation de decouvert du compte a debit� suffisant le transfert as pas op�r�");
        }
        [TestMethod]
        public void TransfererPositifZero()
        {
            double montant = 0;
            CompteBancaire compteTest = new("test", 5000, 500);
            CompteBancaire compteTest2 = new("test2", 5000, 500);
            double apres = compteTest.SoldeDuCompte;

            Assert.IsFalse(compteTest.Transferer(compteTest2, montant), "Le montant en paramettre etant de zero le transfere n'a pas op�r�");
        }
        [TestMethod]
        public void TransfererPositifTrop()
        {
            double montant = 10000;
            CompteBancaire compteTest = new("test", 5000, 500);
            CompteBancaire compteTest2 = new("test2", 5000, 500);

            Assert.IsFalse(compteTest.Transferer(compteTest2, montant), "Le montant en paramettre etant trop �lev� pour l'autorisation de decouvert du compte le transfere n'a pas op�r�");
        }
        [TestMethod]
        public void TransfererPositifMemeCompte()
        {
            double montant = 100;
            CompteBancaire compteTest = new("test", 5000, 500);
            CompteBancaire compteTest2 = new("test2", 5000, 500);

            Assert.IsFalse(compteTest.Transferer(compteTest,montant), "Le compte de debit et de credit etant le meme, le trasfere n'a pas op�r�.");
        }
        [TestMethod]
        public void ComparerSuperieur()
        {
            CompteBancaire compteTest = new("test", 2000, 0);
            CompteBancaire compteTest2 = new("test2", 1000, 0);

            Assert.IsTrue(compteTest>compteTest2,"Le compte test� possede un solde plus elev� que le compte compar�");
            Assert.IsFalse(compteTest2>compteTest, "Le compte test� possede un solde moins elev� que le compte compar�");
        }
        [TestMethod]
        public void ComparerInferieur()
        {
            CompteBancaire compteTest = new("test", 1000, 0);
            CompteBancaire compteTest2 = new("test2", 2000, 0);

            Assert.IsTrue(compteTest<compteTest2, "Le compte test� possede un solde moins elev� que le compte compar�");
            Assert.IsFalse(compteTest2<compteTest, "Le compte test� possede un solde plus elev� que le compte compar�");
        }
        [TestMethod]
        public void ComparerEgale()
        {
            CompteBancaire compteTest = new("test", 1000, 0);
            CompteBancaire compteTest2 = new("test2", 1000, 0);

            Assert.IsFalse(compteTest>compteTest2, "Le compte test� possede un solde egale au compte compar�");
            Assert.IsFalse(compteTest<compteTest2, "Le compte test� possede un solde egale au compte compar�");
        }
        [TestMethod]
        public void CompteBancaireNumeroAutoGenerer()
        {
            CompteBancaire compteTest = new("test", 1000, 0);
            CompteBancaire compteTest2 = new("test2", 1000, 0);

            Assert.AreNotEqual(compteTest.NumeroCompteBancaire,compteTest2.NumeroCompteBancaire,"Les 2 comptes possede un numero de compte diferent");
        }
        [TestMethod]
        public void CloneCompteBancaireNumeroAutoGenerer()
        {
            CompteBancaire compteTest = new("test", 1000, 0);
            CompteBancaire compteTest2 = new(compteTest);

            Assert.AreEqual(compteTest.NumeroCompteBancaire, compteTest2.NumeroCompteBancaire, "Les 2 comptes possede un numero de compte identique");
        }
    }
}