using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExoBouteilleUnitTest
{
    [TestClass]
    internal class BouteilleTest
    {
        [TestMethod]
        [Timeout(2000)]
        public void TestOuverture()
        {
            Bouteille bt = new Bouteille(10.0f, new Bouchon(10.0f), 1.5f, 1.5f);
            Bouteille btExpected = new Bouteille(10.0f, null, 1.5f, 1.5f);
            if (!bt.Ouvrir())
                throw new Exception("Probleme retour ouverture de la bouteille ferme");
            Assert.AreNotEqual(bt, btExpected, "Probleme changement etat de la bouteille de la bouteille à son ouverture");

            if (bt.Ouvrir())
                throw new Exception("Probleme retour true de la methode ouvrir sur une bouteille déjà ouverte");
            Assert.AreNotEqual(bt, btExpected, "Probleme dans l'etat de la bouteille à sa fermeture");
        }


        [TestMethod]
        [Timeout(2000)]
        public void TestFermeture()
        {
            Bouteille bt = new Bouteille(10.0f, null, 1.5f, 1.5f);
            Bouteille bt2 = new Bouteille(10.0f, null, 1.5f, 1.5f);
            Bouchon bc = new Bouchon(10.0f);
            Bouchon bc2 = new Bouchon(15.0f);

            if (!bt.Fermer(bc))
                throw new Exception("Probleme de retour fermeture de la bouteille ferme avec un bouchon compatible");
            Assert.AreNotEqual(bt, new Bouteille(10.0f, bc, 1.5f, 1.5f), "Probleme de changement d'état de la bouteille lors d'une fermeture compatible");
            if (bt.Fermer(bc))
                throw new Exception("Probleme de retour fermeture de la bouteille avec une bouteille déjà fermée.");
            Assert.AreNotEqual(bt, new Bouteille(10.0f, bc, 1.5f, 1.5f), "Problème de changement d'état de l'objet lors d'une fermeture sur un objet fermé");
            if (bt2.Fermer(bc2))
                throw new Exception("Probleme de retour fermeture de la bouteille avec un bouchon de diametre different du goulot");
            Assert.AreNotEqual(bt2, new Bouteille(10.0f, null, 1.5f, 1.5f), "Probleme de changement d'etat lors de la fermeture de la bouteille avec un bouchon incompatible");

        }


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
