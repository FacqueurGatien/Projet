using CompteBancaires;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace CompteBancaireTest
{
    [TestClass]
    public class BanqUnitTest
    {
        [TestMethod]
        public void Banque_ConstructSimple()
        {
            Banque banqueTest = new("Credit Eponge","Bikini Bottom");

            Assert.AreEqual("Credit Eponge",banqueTest.NomBanque,"Le nom de la banque a été correctement instancié");
            Assert.AreEqual("Bikini Bottom",banqueTest.NomVille,"Le nom de la ville a été correctement instancié");
            Assert.IsNotNull(banqueTest.MesComptes,"La liste de comptte a été correctement instancié");
            Assert.IsInstanceOfType(banqueTest.MesComptes, typeof(List<CompteBancaire>),"Le type de la liste est bien celui attenduu");
            Assert.AreEqual(0, banqueTest.MesComptes.Count, "La liste instancié est bien vide");
        }
        [TestMethod]
        public void Banque_ConstructClone()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");

            Assert.AreEqual("Credit Eponge", banqueTest.NomBanque, "Le nom de la banque a été correctement instancié");
            Assert.AreEqual("Bikini Bottom", banqueTest.NomVille, "Le nom de la ville a été correctement instancié");
            Assert.IsNotNull(banqueTest.MesComptes, "La liste de comptte a été correctement instancié");
            Assert.IsInstanceOfType(banqueTest.MesComptes, typeof(List<CompteBancaire>), "Le type de la liste est bien celui attenduu");
            Assert.AreEqual(0, banqueTest.MesComptes.Count, "La liste instancié est bien vide");
        }
        [TestMethod]
        public void AjoutCompte_DejaCree()
        {
            CompteBancaire.NumeroGenerer = 0;
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire compteTest = new("Bob",1000,500);
            banqueTest.AjoutCompte(compteTest);

            Assert.AreEqual("Bob", banqueTest.MesComptes[0].NomProprietaireDuCompte,"Le nom du proprietaire du compte est bien celui attendu");
            Assert.AreEqual(1000, banqueTest.MesComptes[0].SoldeDuCompte,"Le montan du solde du compte est bien celui attendu");
            Assert.AreEqual(500, banqueTest.MesComptes[0].DecouvertAutoriserDuCompte,"Le découvert autorisé pour le compte est bien celui attendu");
            Assert.AreEqual(1, banqueTest.MesComptes[0].NumeroCompteBancaire,"Le numero de compte est bien celui attendu");
            Assert.AreEqual(1,banqueTest.MesComptes.Count(),"Le nombre de compte dans la liste est bien celui attendu");
        }
        [TestMethod]
        public void AjoutCompte_PasEncoreCree()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));


            Assert.AreEqual("Bob", banqueTest.MesComptes[0].NomProprietaireDuCompte, "Le nom du proprietaire du compte est bien celui attendu");
            Assert.AreEqual(1000, banqueTest.MesComptes[0].SoldeDuCompte, "Le montan du solde du compte est bien celui attendu");
            Assert.AreEqual(500, banqueTest.MesComptes[0].DecouvertAutoriserDuCompte, "Le découvert autorisé pour le compte est bien celui attendu");
            Assert.AreEqual(1, banqueTest.MesComptes[0].NumeroCompteBancaire, "Le numero de compte est bien celui attendu");
            Assert.AreEqual(1, banqueTest.MesComptes.Count(), "Le nombre de compte dans la liste est bien celui attendu");
        }
        [TestMethod]
        public void AjoutCompte_NombreDeCmpteActualisation()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 5000, 500));
            banqueTest.AjoutCompte(new("Sandy", 2000, 500));
            banqueTest.AjoutCompte(new("Patrick", 20, 500));

            Assert.AreEqual(4, banqueTest.MesComptes.Count(), "Le nombre de compte dans la liste est bien celui attendu");

        }
        [TestMethod]
        public void CompteSup_ListeVide()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire compteTest = banqueTest.CompteSup();

            Assert.IsNull(compteTest,"La liste de compte etant vide aucun compte n'ea été renvoyé");
        }
        [TestMethod]
        public void CompteSup_RenvoieCorrecte()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));
            banqueTest.AjoutCompte(new("Sandy", 3000, 500));
            banqueTest.AjoutCompte(new("Carlo", 500, 500));
            CompteBancaire compteTest = banqueTest.CompteSup();

            Assert.AreEqual("Eugene",compteTest.NomProprietaireDuCompte,"Le nom du proprietaire du compte est bien celui atttendu");
            Assert.AreEqual(10000,compteTest.SoldeDuCompte,"Le solde du compte est bien celui attendu");
            Assert.AreEqual(500,compteTest.DecouvertAutoriserDuCompte,"Le decouvert autorisé du compte est bien celui attendu");
            Assert.AreEqual(2,compteTest.NumeroCompteBancaire,"Le numero de compte est bien celui attendu");
        }
        [TestMethod]
        public void RendCompte_ListeVide()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");

            CompteBancaire compteTest = banqueTest.RendCompte(1);

            Assert.IsNull(compteTest,"La liste etant vide aucun compte n'a été renvoyé");
        }
        [TestMethod]
        public void RendCompte_NumeroPasDansListe()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));

            CompteBancaire compteTest = banqueTest.RendCompte(7);

            Assert.IsNull(compteTest, "Le compte correspondant au numero de compte voulu ne figurant pas dans la liste, aucun compte n'a été renvoyé");
        }
        [TestMethod]
        public void RendCompte_NumeroDansListe()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));

            CompteBancaire compteTest = banqueTest.RendCompte(3);

            Assert.IsNotNull(compteTest, "Le compte correspondant au numero de compte voulu figurant dans la liste, un compte a été renvoyé");
            Assert.AreEqual("Patrick",compteTest.NomProprietaireDuCompte,"Le nom du proprietaire du compte est bien celui attendu");
            Assert.AreEqual(10,compteTest.SoldeDuCompte,"Le solde du compte est bien celui attendu");
            Assert.AreEqual(500, compteTest.DecouvertAutoriserDuCompte, "Le decouvert autorisé du compte est bien celui attendu");
            Assert.AreEqual(3,compteTest.NumeroCompteBancaire,"Le numero de compte est bien celui attendu");
        }
        [TestMethod]
        public void Transferer_listeVide()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");

            Assert.IsFalse(banqueTest.Transferer(1, 2, 500),"La liste etant vide, aucun compte ne peut faire de transfert");
        }
        [TestMethod]
        public void Transferer_NumeroPasDansListe()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));

            Assert.IsFalse(banqueTest.Transferer(1, 7, 500), "Les 2 numero ne se trouvant pas dans la liste, le transfert n'as pas pu opérer");
            Assert.AreEqual(1000, banqueTest.RendCompte(1).SoldeDuCompte,"Le tranfert n'ayant pas opéré le solde n'as pas changé");
        }
        [TestMethod]
        public void Transferer_NumeroDansListeFondInsuffisant()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));

            Assert.IsFalse(banqueTest.Transferer(1, 3, 10000), "Les 2 compte correspondant aux numeros se trouvant dans la liste, le transfert a pu opérer");
            Assert.AreEqual(1000, banqueTest.RendCompte(1).SoldeDuCompte, "Le tranfert n'ayant pas opéré le solde n'as pas changé");
            Assert.AreEqual(10, banqueTest.RendCompte(3).SoldeDuCompte, "Le tranfert n'ayant pas opéré le solde n'as pas changé");
        }
        [TestMethod]
        public void Transferer_NumeroDansListeFondSuffisant()
        {
            Banque banqueTest = new("Credit Eponge", "Bikini Bottom");
            CompteBancaire.NumeroGenerer = 0;
            banqueTest.AjoutCompte(new("Bob", 1000, 500));
            banqueTest.AjoutCompte(new("Eugene", 10000, 500));
            banqueTest.AjoutCompte(new("Patrick", 10, 500));

            Assert.IsTrue(banqueTest.Transferer(1, 3, 200), "Les 2 compte correspondant aux numeros se trouvant dans la liste, le transfert a pu opérer");
            Assert.AreEqual(800, banqueTest.RendCompte(1).SoldeDuCompte, "Le tranfert ayant opéré le solde a changé");
            Assert.AreEqual(210, banqueTest.RendCompte(3).SoldeDuCompte, "Le tranfert ayant opéré le solde a changé");
        }
    }
}
