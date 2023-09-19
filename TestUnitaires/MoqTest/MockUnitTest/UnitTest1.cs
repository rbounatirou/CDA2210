using Moq;
using MoqTest;

namespace MockUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var mock = Mock.Of<TestClass>();
            Mock.Get(mock).Setup(m => m.LancerAleatoire()).Returns(1);

            Assert.AreEqual(mock.DireCoucou(), "Coucou");

        }

        [TestMethod]
        public void TestMethod2()
        {

            var mock = new Mock<TestClass>();
            mock.Setup(m => m.LancerAleatoire()).Returns(1);

            Assert.AreEqual(mock.Object.DireCoucou(), "Coucou");

        }
    }
}