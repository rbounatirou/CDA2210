using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBouteille;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        // LE DERNIER TEST EST TRES IMPORTANT !!!!!
        [TestMethod]
        public void Lorsque_InstanciationBouteille_Avec_ParametreCorrect_Alors_InstanciationOKetAttributInitialise()
        {
            Bouteille b = new Bouteille(0.0f, 1.5f,false);
            Assert.IsFalse(b.EstOuverte, "La bouteille à été initialisé ouverte");
            Assert.IsTrue(b.ContenanceMaximale == 1.5f, "L'instanciation de la capacité maximale n'a pas été correctement éfféctuée");
            Assert.IsTrue(b.ContenanceActuelle == 0.0f, "L'instanciation de la capacité actuelle n'a pas été correctemebt éfféctuée");
        }

        [TestMethod]
        public void Lorsque_InstanciationBouteille_Avec_ParametreCapaciteActuelleNegative_Alors_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(()=> new Bouteille(-15.0f, 1.5f, false), "Pas d'exception ArgumentException");

        }

        [TestMethod]
        public void Lorsque_InstanciationBouteille_Avec_ParametreCapaciteMaximaleNegative_Alors_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Bouteille(1.50f, -1.5f, false), "Pas d'exception ArgumentException");

        }

        [TestMethod]
        public void Lorsque_InstanciationBouteille_Avec_ParametreCapaciteActuelleSuperieurCapaciteMaximale_Alors_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Bouteille(1.50f, 1.2f, false), "Pas d'exception ArgumentException");

        }

        [TestMethod]
        public void Lorsque_InstanciationParDefaut_Attributs_ParDefaut()
        {
            Bouteille b = new Bouteille();
            Assert.IsFalse(b.EstOuverte, "La bouteille à été initialisé ouverte");
            Assert.IsTrue(b.ContenanceMaximale == 1.5f, "L'instanciation de la capacité maximale n'a pas été correctement éfféctuée");
            Assert.IsTrue(b.ContenanceActuelle == 1.5f, "L'instanciation de la capacité actuelle n'a pas été correctemebt éfféctuée");
        }

        [TestMethod]
        public void EtantDonne_BouteilleFerme_Lorsque_Ouvrir_Alors_RetourTrueEtBouteilleOuverte()
        {
            //Arrange
            Bouteille b = new Bouteille();
            bool retour;
            //Act
            retour = b.Ouvrir();
            //Assert
            Assert.IsTrue(retour, "L'opération d'ouverture a retourné false au lieu de true");
            Assert.IsTrue(b.EstOuverte, "La bouteille est fermée au lieu d'être ouverte");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Ouvrir_Alors_RetourFalseEtBouteilleOuverte()
        {
            //Arrange
            Bouteille b = new Bouteille(1.5f,1.5f,true);
            bool retour;
            //Act
            retour = b.Ouvrir();
            //Assert
            Assert.IsFalse(retour, "L'opération d'ouverture a retourné true au lieu de false");
            Assert.IsTrue(b.EstOuverte, "La bouteille est fermée au lieu d'être ouverte");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Fermer_Alors_RetourTrueEtBouteilleFerme()
        {
            //Arrange
            Bouteille b = new Bouteille(1.5f, 1.5f, true);
            bool retour;
            //Act
            retour = b.Fermer();
            // Assert
            Assert.IsTrue(retour, "Le test du retour reçu de l'opperation Fermer d'une bouteille ouverte (true) à échoué");
            Assert.IsFalse(b.EstOuverte, "La bouteille est ouverte malgre l'appel à la fonction Fermer");
        }
        [TestMethod]
        public void EtantDonne_BouteilleFermee_Lorsque_Fermer_Alors_RetourFalseEtBouteilleFerme()
        {
            //Arrange
            Bouteille b = new Bouteille(1.5f, 1.5f, false);
            bool retour;
            //Act
            retour = b.Fermer();
            // Assert
            Assert.IsFalse(retour, "Le test du retour reçu de l'opperation Fermer d'une bouteille fermee (false) à échoué");
            Assert.IsFalse(b.EstOuverte, "La bouteille est ouverte malgre l'appel à la fonction Fermer");
        }

        [TestMethod]
        public void EtantDonne_BouteilleFerme_Lorsque_Vider_Alors_BottleClosedExceptionEtQuantiteEauInchangee()
        {
            //Arrange
            Bouteille b = new Bouteille(1.5f,1.5f,false);
            //Assert
            Assert.ThrowsException<BottleClosedException>(() => b.Vider(0.01f), "No BottleClosedException are thrown by the Vider function when the bottle is closed");
            Assert.IsTrue(b.ContenanceActuelle == 1.5f, "The quantity has changed when Vider function has been called, although the bottle has been initialized as a closed one");
        }
        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_ViderAvecQuantitePlusPetiteQueContenanceActuelle_Alors_QuantiteFinaleOk()
        {
            //Arrange
            Bouteille b = new Bouteille(1.5f,1.5f,true);
            //Act
            b.Vider(1.0f);
            //Assert
            Assert.IsTrue(b.ContenanceActuelle == 0.5f,"The expected quantity is not equal to the current quantity");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_ViderAvecQuantitePlusGrandeQueContenanceActuelle_Alors_QuantiteActuelleNegativeException()
        {
            //Arrange
            Bouteille b = new Bouteille(0.5f, 1.5f, true);
            //Act

            //Assert
            Assert.ThrowsException<QuantiteActuelleNegativeException>(() => b.Vider(1.0f), "Pas d'ArgumentException levé lorsque la fonction Vider est appeler avec un parametre de contenance > contenanceActuelle");
            Assert.IsTrue(b.ContenanceActuelle == 0.5f, "La quantite a change alors qu'elle devait reste la meme");
        }
        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_ViderAvecQuantiteNegative_Alors_ArgumentException()
        {
            //Arrange
            Bouteille b = new Bouteille(0.5f, 1.5f, true);
            //Act

            //Assert
            Assert.ThrowsException<ArgumentException>(() => b.Vider(-0.5f), "La contenance est négative");
            Assert.IsTrue(b.ContenanceActuelle == 0.5f, "La quantite a change alors qu'elle devait reste la meme");
        }

        [TestMethod]
        public void EtantDonne_BouteilleFerme_Lorsque_Remplir_Alors_BottleClosedExceptionEtContenanceActuelleInchangee()
        {
            Bouteille b = new Bouteille(0.5f,1.5f,false);

            Assert.ThrowsException<BottleClosedException>(() => b.Remplir(0.5f), "No BottleClosedException received after called Remplir function with a closed bottle");
            Assert.IsTrue(b.ContenanceActuelle == 0.5f, "Quantity of liquid have changed on the bottle, it should not be");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Remplir_Avec_QuantitePositiveEtQuantiteFinaleInferieurQuantiteMaximale_Alors_QuantiteActuelleChangee()
        {
            // Arrange
            Bouteille b = new Bouteille(0.5f, 1.5f, true);
            // Act
            b.Remplir(0.5f);
            // Assert
            Assert.IsTrue(b.ContenanceActuelle == 1.0f, "Quantity of liquid have changed on the bottle, it should not be");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Remplir_Avec_QuantiteInitiale0clQuantitePositive50clEtQuantiteMaximale100cl_Alors_QuantiteActuelleChangee50cl()
        {
            // Arrange
            Bouteille b = new Bouteille(0.0f, 1.5f, true);
            // Act
            b.Remplir(0.5f);
            // Assert
            Assert.IsTrue(b.ContenanceActuelle == 0.5f, "Quantity of liquid have changed on the bottle, it should not be");
        }


        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Remplir_Avec_QuantiteNegative_Alors_ArgumentExceptionEtQuantiteInchangee()
        {
            // Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, true);
            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => b.Remplir(-0.5f), "When the bottle is filled with negative quantity it must throw an ArgumentException");
            Assert.IsTrue(b.ContenanceActuelle == 1.0f, "Quantity of liquid have changed on the bottle, it should not be");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_Remplir_Avec_QuantitePositiveEtDeborde_Alors_DebordeExceptionEtQuantiteInchangee()
        {
            // Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, true);
            // Act

            // Assert
            Assert.ThrowsException<DebordeException>(() => b.Remplir(2f), "Quand on remplit au dela de la quantite maximale, it throws a DebordeException");
            Assert.IsTrue(b.ContenanceActuelle == 1.0f, "Quantity of liquid have changed on the bottle, it should not be");
        }
        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Lorsque_RemplirTout_Alors_QuantiteActuelle_Egale_QuantiteMaximale()
        {
            // Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, true);
            // Act
            b.RemplirTout();
            // Assert
            
            Assert.IsTrue(b.ContenanceActuelle == b.ContenanceMaximale, "Quantity of liquid have changed on the bottle, it should not be");
        }

        [TestMethod]
        public void EtantDonne_BouteilleFerme_Lorsque_RemplirTout_Alors_BouteilleClosedExceptionQuantiteInchange()
        {
            // Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, false);
            // Act
            Assert.ThrowsException<BottleClosedException>(() => b.RemplirTout(), "The RemplirTout function must throw a BottleClosedException");
            // Assert

            Assert.IsTrue(b.ContenanceActuelle == 1.0f, "Quantity of liquid have changed on the bottle, it should not be");
        }
        
        [TestMethod]
        public void EtantDonne_BouteilleFerme_Lorsque_ViderTout_Alors_BouteilleClosedExceptionQuantiteInchange()
        {
            // Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, false);
            // Act
            Assert.ThrowsException<BottleClosedException>(() => b.ViderTout(), "The RemplirTout function must throw a BottleClosedException");
            // Assert

            Assert.IsTrue(b.ContenanceActuelle == 1.0f, "Quantity of liquid have changed on the bottle, it should not be");
        }

        [TestMethod]
        public void EtantDonne_BouteilleOuverte_LorsqueViderTout_Alors_QuantiteActuelleZero()
        {
            //Arrange
            Bouteille b = new Bouteille(1.0f, 1.5f, true);
            //Act
            b.ViderTout();
            //Assert
            Assert.IsTrue(b.ContenanceActuelle == 0f, "La quantité doit être égale à zéro");
        }

        [TestMethod]
        public void EtantDonne_BouteilleInstanciee_Alors_Bouteille_Type_Bouteille()
        {
            //Arrange
            Bouteille b = new Bouteille();
            //Act
            //Assert
            Assert.IsTrue(b.GetType() == typeof(Bouteille), "La bouteille doit être de type bouteille");
        }
    }
}