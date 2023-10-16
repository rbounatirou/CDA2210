using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_nombre_When_FizzBuzzPourUnNombre_Then_Return_nombre_string()
        {
            int nombre = 1;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual(nombre.ToString(), retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, nombre.ToString()));
        }

        [TestMethod]
        public void Given_nombre3_When_FizzBuzzPourUnNombre_Then_Return_Fizz()
        {
            int nombre = 3;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("Fizz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "Fizz"));
        }

        [TestMethod]
        public void Given_nombre6_When_FizzBuzzPourUnNombre_Then_Return_Fizz()
        {
            int nombre = 6;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("Fizz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "Fizz"));
        }

        [TestMethod]
        public void Given_nombre5_When_FizzBuzzPourUnNombre_Then_Return_Buzz()
        {
            int nombre = 5;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("Buzz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "Buzz"));
        }

        [TestMethod]
        public void Given_nombre10_When_FizzBuzzPourUnNombre_Then_Return_Buzz()
        {
            int nombre = 10;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("Buzz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "Buzz"));
        }

        [TestMethod]
        public void Given_nombre15_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz()
        {
            int nombre = 15;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("FizzBuzz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "FizzBuzz"));
        }

        [TestMethod]
        public void Given_nombre30_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz()
        {
            int nombre = 30;
            string retour = TDDFizzbuzz.Program.FizzBuzzPourUnNombre(nombre);
            Assert.AreEqual("FizzBuzz", retour, String.Format("Erreur, reçu : \"{0}\", attendu : \"{1}\"", retour, "FizzBuzz"));
        }
    }
}