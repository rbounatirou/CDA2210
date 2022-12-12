using ExoBouteille;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExoBouteilleTest
{
    [TestClass]
    public class ExoBouteilleTestUnitaire
    {
       


        // TEST DE LA METHODE FERMER
        [TestMethod]
        public void Fermer_BouteilleOuverteBouchonCompatatible_BouteilleFermeeAvecBouchonCompatible()
        {
            Bouteille bt = new Bouteille(10.0f, null, 1.5f, 1.5f);
            Bouchon bc = new Bouchon(10.0f);
            if (!bt.Fermer(bc))
                throw new Exception("Probleme de retour methode Fermer de la classe Bouteille: fermeture avec bouchon compatible");
            Assert.AreNotEqual(bt.bouchon, new Bouchon(bc), "Probleme de changement d'état de la bouteille lors d'une fermeture avec bouchon compatible");
        }

        [TestMethod]
        public void Fermer_BouteilleOuverteBouchonIncompatible_BouteilleOuverte()
        {
            Bouteille bt = new Bouteille(10.0f, null, 1.5f, 1.5f);
            Bouchon bc = new Bouchon(12.0f);
            if (bt.Fermer(bc))
                throw new Exception("Probleme de retour fonction Femer de la classe Bouteille ferme avec un bouchon incompatible");
            Assert.AreNotEqual(bt, new Bouteille(10.0f,null,1.5f,1.5f), "Probleme de changement d'état de la bouteille lors d'une fermeture compatible");
        }

        [TestMethod]
        public void Fermer_BouteilleFermeBouchonCompatible_RetourFalseBouteilleFerme()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 1.5f);
            Bouteille bt2 = new Bouteille(bt);
            if (bt.Fermer(new Bouchon(10.0f)))
                throw new Exception("Probleme de retour fonction Femer de la classe Bouteille avec bouchon compatible lorsque la bouteille est déjà fermée");
            Assert.AreNotEqual(bt, bt2, "Probleme changement etat innatendu de la fonction Fermer de la classe Bouteille avec un bouchon compatible sur bouteille déjà fermé");
        }

        // TEST DE LA METHODE OUVERTE
        [TestMethod]
        public void Ouvrir_BouteilleFerme_BouteilleOuverte()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 1.5f);
            Bouteille bt2 = new Bouteille(10.0f, null, 1.5f, 1.5f);
            if (!bt.Ouvrir())
                throw new Exception("Probleme de retour Ouvrir de la classe Bouteille lorsque bouteille ferme");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat de la methode Ouvrir de la classe Bouteille lorsque bouteille Ferme");
        }

        [TestMethod]
        public void Ouvrir_BouteilleOuverte_RetourFalseBouteilleOuverte()
        {
            Bouteille bt = new Bouteille(10.0f, null, 1.5f, 1.5f);
            Bouteille bt2 = new Bouteille(10.0f, null, 1.5f, 1.5f);
            if (bt.Ouvrir())
                throw new Exception("Probleme de retour Ouvrir de la classe Bouteille lorsque bouteille ouverte");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat de la methode Ouvrir de la classe Bouteille lorsque bouteille Ferme");
        }

        // TEST DE LA METHODE VIDER

        // Bouteille Ferme
        
        // Bouteille Ouverte Quantite ok

        // Bouteille Ouverte Quantite trop eleve

        // Bouteille Ouverte Quantite negative

        // TEST DE LA METHODE REMPLIR



        // TEST DE LA METHODE VIDER TOUT



        // TEST DE LA METHODE REMPLIR TOUT


        [TestMethod]
        [Timeout(2000)]
        public void TestVider()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 1.5f);
            Bouteille bt2 = new Bouteille(bt);
            // Bouteille ferme on essaie de vider OK
            if (bt.Vider(0.2f))
                throw new Exception("Probleme de retour de la fonction vider lorsque l'on veut vider une bouteille ferme");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat lorque l'on vide une bouteille ferme");
            // Bouteille ouverte on essaie de vider quantite OK
            bt = new Bouteille(10.0f, null, 1.5f, 1.5f);

            bt2 = new Bouteille(10.0f, null, 1.5f, 1.3f);
            if (!bt.Vider(0.2f))
                throw new Exception("Probleme de retour de la fonction vider lorsque l'on cheche à vider une bouteille ouverte d'une quantite valide");
            Assert.AreNotEqual(bt, bt2, "Probleme changement d'etat lorsque l'on vide une bouteille ouverte d'une quantite valide");
            // Bouteille ouverte on essaie de vider quantite NonOK
            if (bt.Vider(1.4f))
                throw new Exception("Probleme de retour de la fonction vider sur bouteille ouverte lorsque l'on cherche à vider une quantite invalide");
            Assert.AreNotEqual(bt, bt2, "Probleme changement d'etat de la fonction vider sur une bouteille ouverte avec une quantite invalide");
            // Bouteille ouverte on essaie de vider quantite negative
            bt = new Bouteille(10.0f, null, 1.5f, 1.1f);
            bt2 = new Bouteille(10.0f, null, 1.5f, 1.1f);
            if (bt.Vider(-0.2f))
                throw new Exception("Probleme de retour lorsque l'on vide une bouteille ouverte d'une quantite negative");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'état lorsque l'on vide une bouteille ouverte d'un montant négatif");
        }

        [TestMethod]
        [Timeout(2000)]
        public void TestRemplir()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 0.0f);
            Bouteille bt2 = new Bouteille(bt);
            // Bouteille ferme on essaie de remplir qte OK
            if (bt.Remplir(0.5f))
                throw new Exception("Probleme de retour lorsque l'on remplis une bouteille ferme");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat lorsque l'on remplis une bouteille ferme");
            // Bouteille ouverte on essaie de remplir quantite OK

            bt = new Bouteille(10.0f, null, 1.5f, 0.0f);
            bt2 = new Bouteille(10.0f, null, 1.5f, 0.2f);
            if (!bt.Remplir(0.2f))
                throw new Exception("Probleme de retour lorsque l'on remplis une bouteille ouverte d'une valeur OK");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat lorsque l'on remplis une bouteille ouverte d'une valeur OK");
            // Bouteille ouverte on essaie de remplir quantite NonOK
            if (bt.Remplir(1.4f))
                throw new Exception("Probleme de retour lorsque l'on remplis une bouteille ouverte au dela de ce qu'elle doit accepte");
            Assert.AreNotEqual(bt, bt2, "Probleme de changement d'etat lorsque l'on remplis une bouteille ouverte au dela de ce qu'elle doit accepte");
            // Bouteille ouverte on essaie de remplir quantite negative
            bt = new Bouteille(10.0f, null, 1.5f, 0.5f);
            bt2 = new Bouteille(bt);
            if (bt.Remplir(-0.5f))
                throw new Exception("Probleme de retour lorsque l'on remplis une bouteille ouverte d'une quantite negative");
            Assert.AreNotEqual(bt, bt2, "Probleme changement d'etat lorsque l'on remplis une bouteille ouverte d'une quantite negative");
        }

        [TestMethod]
        [Timeout(2000)]
        public void TestViderTout()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 0.5f);
            Bouteille bt2 = new Bouteille(bt);
            if (bt.ViderTout())
                throw new Exception("Pb retour sur la fonction ViderTout sur une bouteille ferme");
            Assert.AreNotEqual(bt, bt2, "Pb changement d'etat de la fonction ViderTout sur une bouteille ferme");
            bt = new Bouteille(10.0f, null, 1.5f, 0.5f);
            bt2 = new Bouteille(10.0f, null, 1.5f, 0.0f);
            if (!bt.ViderTout())
                throw new Exception("Pb retour de la fonction ViderTout sur une bouteille ouverte");
            Assert.AreNotEqual(bt, bt2, "Pb changement d'etat de la fonction ViderTout sur une bouteille ouverte");

        }

        [TestMethod]
        [Timeout(2000)]
        public void TestRemplirTout()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 0.5f);
            Bouteille bt2 = new Bouteille(bt);
            if (bt.ViderTout())
                throw new Exception("Pb retour sur la fonction RemplirTout sur une bouteille ferme");
            Assert.AreNotEqual(bt, bt2, "Pb changement d'etat de la fonction RemplirTout sur une bouteille ferme");
            bt = new Bouteille(10.0f, null, 1.5f, 0.5f);
            bt2 = new Bouteille(10.0f, null, 1.5f, 1.5f);
            if (!bt.ViderTout())
                throw new Exception("Pb retour de la fonction RemplirTout sur une bouteille ouverte");
            Assert.AreNotEqual(bt, bt2, "Pb changement d'etat de la fonction RemplirTout sur une bouteille ouverte");
        }
    }
}