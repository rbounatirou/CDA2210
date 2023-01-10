
using BanqueClass;
using ExoCompte;

namespace Unit_CompteBancaire
{
    [TestClass]
    public class UnitTest_BanqueClass
    {
        [TestMethod]
        public void AjouterCompte_CompteNonExistant_RetourTrueEtCompteSupplementaire()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            Assert.IsTrue(b.AjouteCompte(123, "k", 0, 0), "Erreur retour ajout de compte non existant");
            Assert.IsTrue(b.AccountNumber == 1, "Erreur ajout du compte non pris en compte");
            
        }

        [TestMethod]
        public void AjouteCompte_CompteExistant_RetourFalseNombreCompteInchange()
        {

            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "a", 200, -200);
            Assert.IsFalse(b.AjouteCompte(123, "k", 0, 0), "Erreur retour ajout de compte non existant");
            Assert.IsTrue(b.AccountNumber == 1, "Erreur ajout du compte non pris en compte");
        }

        [TestMethod]
        public void RendCompte_CompteNonExistant_RetourNull()
        {

            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 0, 0);
            Assert.IsNull(b.RendCompte(423), "Erreur ajout du compte non pris en compte");
        }

        [TestMethod]
        public void RendCompte_CompteExistant_RetourNonNull()
        {

            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 0, 0);
            Assert.IsNotNull(b.RendCompte(123), "Erreur ajout du compte non pris en compte");
        }

        [TestMethod]
        public void CompteSup_BanqueSansCompte_RetourNull()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            Assert.IsNull(b.CompteSup(), "Erreur : La fonction CompteSup ne renvoie pas une valeur null dans le cas d'une banque sans compte");
        }

        [TestMethod]
        public void CompteSup_BanqueAvecPlusieursCompte_RetourCompteSoldePlusEleve()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 100, 0);
            b.AjouteCompte(423, "k", 300, 0);
            b.AjouteCompte(122, "k",250,0);
            Assert.IsTrue(b.CompteSup().Solde == 300, "Erreur, le retour du compte n'est pas celui possédant le plus grand solde");
        }

        [TestMethod]
        public void CompteSup_TransfererMontantNegatifC1ETC2ValideSoldeOK_NegativeAmountExceptionAucunChangement()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 100, 0);
            b.AjouteCompte(423, "k", 300, 0);
            
            Assert.ThrowsException<NegativeAmountException>(() => b.Transferer( 123, 423, -100),
                "Erreur il devrait être impossible de transferer un montant négatif ");
            Assert.IsTrue(b.RendCompte(123).Solde == 100, "Probleme changement etat compte expediteur lors d'un transfert de montant négatif");
            Assert.IsTrue(b.RendCompte(423).Solde == 300, "Probleme changement etat compte destinataire lors d'un transfert de montant négatif");
        }

        [TestMethod]
        public void CompteSup_TransfererMontant1000_C1Solde100Decouvert0_C2Solde200_RetourFaux_EtatC1EtC2Inchange()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 100, 0);
            b.AjouteCompte(423, "k", 200, 0);
            Assert.IsFalse(b.Transferer(123, 423, 1000), "Erreur de transfert d'un montant non autorisé par le découvert du compte destinataire via Banque.Transferer");
            Assert.IsTrue(b.RendCompte(123).Solde == 100, "Probleme changement etat compte expediteur lors d'un transfert de montant non autorisé par le découvert");
            Assert.IsTrue(b.RendCompte(423).Solde == 200, "Probleme changement etat compte destinataire lors d'un transfert de montant non autorisé par le découvert de l'expediteur");
        }

        [TestMethod]
        public void CompteSup_TransfererMontant100_C1Solde100Decouvert0_C2Solde200_RetourTrue_EtatC1Solde0EtC2Solde300()
        {
            Banque b = new Banque("Caisse epargne", "Mulhouse");
            b.AjouteCompte(123, "k", 100, 0);
            b.AjouteCompte(423, "k", 200, 0);
            Assert.IsTrue(b.Transferer(123, 423, 100), "Erreur de transfert d'un montant non autorisé par le découvert du compte destinataire via Banque.Transferer");
            Assert.IsTrue(b.RendCompte(123).Solde == 0, "Probleme changement etat compte expediteur lors d'un transfert de montant autorisé par le découvert");
            Assert.IsTrue(b.RendCompte(423).Solde == 300, "Probleme changement etat compte destinataire lors d'un transfert de montant autorisé par le découvert de l'expediteur");
        }
    }
}
