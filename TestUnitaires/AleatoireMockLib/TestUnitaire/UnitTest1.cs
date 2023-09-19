using AleatoireMockLib;
using Moq;
using System.Reflection;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Donne_ValeuLancerDe1_Quand_AppelGetMessage_Alors_RetourPoney()
        {
            var mock = Mock.Of<De>();
            Mock.Get(mock).Setup(d => d.LancerDe()).Returns(()=>
            {
                return 1;
            });
            string msg = mock.GetMessage();
            string attendu = "Poney";
            Assert.AreEqual(msg, attendu, String.Format("Message retourne \"{0}\" attendu \"{1}\"", msg, attendu));
        }

        [TestMethod]
        public void Donne_ValeuLancerDe3_Quand_AppelGetMessage_Alors_RetourPatate()
        {
            var mock = Mock.Of<De>();
            Mock.Get(mock).Setup(d => d.LancerDe()).Returns(() =>
            {
                return 3;
            });
            string msg = mock.GetMessage();
            string attendu = "Patate";
            Assert.AreEqual(msg, attendu, String.Format("Message retourne \"{0}\" attendu \"{1}\"", msg, attendu));
        }

        [TestMethod]
        public void Donne_ValeuLancerDe6_Quand_AppelGetMessage_Alors_RetourLicornet()
        {
            var mock = Mock.Of<De>();
            Mock.Get(mock).Setup(d => d.LancerDe()).Returns(() =>
            {
                return 6;
            });
            string msg = mock.GetMessage();
            string attendu = "Licornet";
            Assert.AreEqual(msg, attendu, String.Format("Message retourne \"{0}\" attendu \"{1}\"", msg, attendu));
        }

        [TestMethod]
        public void Donne_ValeuLancerDe8_Quand_AppelGetMessage_Alors_RetourPasteque()
        {
            var mock = Mock.Of<De>();
            Mock.Get(mock).Setup(d => d.LancerDe()).Returns(() =>
            {
                return 8;
            });
            string msg = mock.GetMessage();
            string attendu = "Pasteque";
            Assert.AreEqual(msg, attendu, String.Format("Message retourne \"{0}\" attendu \"{1}\"", msg, attendu));
        }

        [TestMethod]
        public void Donne_ValeuLancerDe10_Quand_AppelGetMessage_Alors_RetourJambon()
        {
            var mock = Mock.Of<De>();
            Mock.Get(mock).Setup(d => d.LancerDe()).Returns(() =>
            {
                return 10;
            });
            string msg = mock.GetMessage();
            string attendu = "Jambon";
            Assert.AreEqual(msg, attendu, String.Format("Message retourne \"{0}\" attendu \"{1}\"", msg, attendu));
        }

        [TestMethod]
        public void TestPoneyAvecReflexion()
        {
            De d = new De();
            MethodInfo inf = d.GetType().GetMethod("LancerDe",BindingFlags.Instance | BindingFlags.Public);
            // TODO AVEC REFLEXION MODIFIER METHODE LANCER DE
        }
    }
}