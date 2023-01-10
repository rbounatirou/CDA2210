
using ExoCompte;

namespace TestUnitaireCompteBancaire
{
    [TestClass]
    public class UnitTest1
    {
        // Pour lancer le test faire ctrl e puis faire touche t.
        [TestMethod]
        public void Constructeur_DecouvertNegatif_InstanciationOK()
        {
            Compte monCompteDeTest = new Compte(1234, "Juju", 500, -1000);
            Assert.IsNotNull(monCompteDeTest);
        }
        [TestMethod]
        public void Constructeur_DecouvertAZero_InstanciationOk()
        {
            Compte monCompteDeTest = new Compte(1234, "Juju", 500, 0);
            Assert.IsNotNull(monCompteDeTest);
        }
        [TestMethod]
        public void Constructeur_DecouvertPositif_ExceptionInstanciationNull()
        {
            Compte? monCompteDeTest = null;
            Assert.ThrowsException<CreateAccountException>(() => monCompteDeTest = new Compte(1234, "Bertrant", 500, 500), "");
            Assert.IsNull(monCompteDeTest, "Probleme d'etat lors de l'instanciation d'un compte bancaire avec un decouvert autoris� positif, r�sultat attendu = refus d'instanciation + exception");
        }
        [TestMethod]
        public void Crediter200_CompteSolde200_AucuneExceptionSolde400()
        {
            Compte c = new Compte(12354, "Rody", 200, 0);
            c.Crediter(200);
            Assert.IsTrue(c.Solde == 400, "Echec du test: Le solde n'est pas celui attendu.");
        }
        [TestMethod]
        public void CrediterMoins200_CompteSolde200_NegativeAmountExceptionSoldeInchange()
        {
            Compte c = new Compte(12354, "Rody", 200, 0);
            Assert.ThrowsException<NegativeAmountException>(()=>c.Crediter(-200), "Echec du test: il ne devrait pas �tre possible de cr�diter un compte avec une montant n�gative.");
            Assert.IsTrue(c.Solde == 200, "Echec du test: Le solde ne devrait pas avoir chang�.");
        }
        [TestMethod]
        public void DebiterMoins100_CompteSolde200_NegativeAmmountException_EtatSoldeInchange()
        {
            Compte c = new Compte(12354, "Rody", 200, 0);
            Assert.ThrowsException<NegativeAmountException>(()=>c.Debiter(-100), "Echec du test : Il ne devrait pas �tre possible de d�biter un montant n�gatif");
            Assert.IsTrue(c.Solde == 200, "Echec du test: Le solde ne devrait pas avoir chang�.");
        }
        [TestMethod]
        public void Debiter200_CompteSolde50DecouvertMoins500_RetourOKSoldeMoins150()
        {
            Compte c = new Compte(12354, "Rody",  50, -500);
            Assert.IsTrue(c.Debiter(200), "Echec de test: Le d�bit n'a p� �tre efffectu�.");
            Assert.IsTrue(c.Solde == -150, "Echec du test : Le solde attendu apr�s d�bit n'est pas celui attendu.");
        }
        [TestMethod]
        public void Debiter500_CompteSolde50_DecouvertMoins200_RetourFalseSoldeInchange()
        {
            Compte c = new Compte(12354, "Rody", 50, -200);
            Assert.IsFalse(c.Debiter(500), "Echec du test : On ne devrait pas pouvoir d�biter un montant qui fait passer le solde en dessous du d�couvert autoris�.");
            Assert.IsTrue(c.Solde == 50, "Echec du test : Le solde doit rester inchang� apr�s un d�bit non-autoris� " +
                "dans le cas d'un d�bit qui ferait passer le solde en dessous du d�couvert autoris�.");
        }
        [TestMethod]
        public void Transferer500C1AC2_C1Solde100DecouvertAutoriseMoins500_C2Solde500_RetourTrue_C1SoldeMoins400C2Solde1000()
        {
            Compte c1 = new Compte(12354, "Rody", 100, -500);
            Compte c2 = new Compte(12354, "Rody",  500, -500);
            Assert.IsTrue(c1.Transferer(500, c2), "Echec du test : Le transfere d'un montant autoris� par le d�couvert devrait renvoyer true.");
            Assert.IsTrue(c1.Solde == -400, "Echec du test : Le montant du transfert n'a pas �t� d�bit� avec succes.");
            Assert.IsTrue(c2.Solde == 1000, "Echec du test : Le montant du transfert n'a pas �t� cr�dit� au destinataire.");
        }
        [TestMethod]
        public void TransfererMoins100_C1aC2_NegativeAmountException_EtatC1etC2Inchanges()
        {
            Compte c1 = new Compte(12354, "Rody", 100, -500);
            Compte c2 = new Compte(12354, "Rody",  500, -500);
            Assert.ThrowsException<NegativeAmountException>(()=>c1.Transferer(-100, c2), "Echec du test : Devrait �tre impossible de transferer un montant n�gatif.");
            Assert.IsTrue(c1.Solde == 100, "Echec du test : Le solde ne devrait pas changer pour le compte expediteur lors d'un transfert d'un montant n�gatif");
            Assert.IsTrue(c2.Solde == 500, "Echec du test : Le solde ne devrait pas changer pour le compte destinataire lors d'un transfert d'un montant n�gatif");
        }
        [TestMethod]
        public void Transferer500_c1Solde100DecouvertAutoriseMoins200_C2Solde200_RetourFalseEtatC1etC2Inchange()
        {
            Compte c1 = new Compte(12354, "Rody", 100, -200);
            Compte c2 = new Compte(12354, "Rody", 200, -500);
            Assert.IsFalse(c1.Transferer(500, c2), "Echec du test : Le montant du transfert ne devrait pas �tre possible si il d�passe le montant du d�couvert autoris� du compte d�biteur");
            Assert.IsTrue(c1.Solde == 100, "Echec du test : Le solde ne devrait pas changer pour le compte expediteur lors d'un transfert d'un montant non autoris� par le d�couvert autoris�.");
            Assert.IsTrue(c2.Solde == 200, "Echec du test : Le solde ne devrait pas changer pour le compte destinataire lors d'un transfert d'un montant non autoris� par le d�couvert autoris� du compte exp�diteur");
        }
        [TestMethod]
        public void Superieur_C1Solde500_C2solde400_RetourTrue()
        {
            Compte c1 = new Compte(12354, "Rody", 500, -500);
            Compte c2 = new Compte(12354, "Rody", 400, -500);
            Assert.IsTrue(c1.Superieur(c2), "Echec du test : Le compte c1 a un solde superieur a c2 mais le retour Sup�rieur de c1 est faux pourquoi?");
        }
        [TestMethod]
        public void Superieur_C1Solde500_C2solde500_RetourFalse()
        {
            Compte c1 = new Compte(12354, "Rody",  500, -500);
            Compte c2 = new Compte(12354, "Rody",  500, -500);
            Assert.IsFalse(c1.Superieur(c2), "Echec du test : c1 et c2 ont un solde �gal, mais la fonction Superieur renvoie True.");
        }
        [TestMethod]
        public void Superieur_C1Solde500_C2solde600_RetourFalse()
        {
            Compte c1 = new Compte(12354, "Rody", 500, -500);
            Compte c2 = new Compte(12354, "Rody",  600, -500);
            Assert.IsFalse(c1.Superieur(c2), "Echec du test : c2 a un solde superieur � c1, mais la m�thode Superieur de c1 renvoie true.");
        }
    }
}