using Barnabe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarnabeTest
{
    [TestClass]
    public class TestBarnabe
    {
        [TestMethod]
        public void Given_120Euros_When_NbMagasinRealiseParBarnabe_Then_Retour6()
        {
            int nb = Program.NbMagasinRealisePArBarnabe(120);
            Assert.IsTrue(nb == 6, String.Format("Mauvais retour ({0}) attendu ({1})", nb, 6));
        }

        [TestMethod]
        public void Given_Negative120Euros_When_NbMagasinRealiseParBarnabe_Then_ArgumentOutOfRangeException()
        {
            Action act = () => Program.NbMagasinRealisePArBarnabe(-120);

            Assert.ThrowsException<ArgumentOutOfRangeException>(act,
                "Pas d'ArgumentOutOfRangeException levée");
        }

        [TestMethod]
        public void Given_1Euros_When_NbMagasinRealiseParBarnabe_Then_Retour1()
        {
            int nb = Program.NbMagasinRealisePArBarnabe((decimal)1);
            Assert.IsTrue(nb == 1, String.Format("Mauvais retour ({0}) attendu ({1})", nb, 1));
        }

        [TestMethod]
        public void Given_70CentimesEuros_When_NbMagasinRealiseParBarnabe_Then_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => Program.NbMagasinRealisePArBarnabe((decimal)0.7),
                 "Pas d'ArgumentException levée");
        }

        [TestMethod]
        public void Given_2Euros_When_NbMagasinRealiseParBarnabe_Then_Retour1()
        {
            int nb = Program.NbMagasinRealisePArBarnabe((decimal)2.0);
            Assert.IsTrue(nb == 1, String.Format("Mauvais retour ({0}) attendu ({1})", nb, 1));
        }
    }
}