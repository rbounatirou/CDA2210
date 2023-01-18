using JeuClass;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaires
{
    [TestClass]
    public class UnitTest_Manche
    {
        [TestMethod]
        public void EstGagne_DesVals421_RetourTrue()
        {
            var fausseManche = Mock.Of<Manche>();
            Mock.Get(fausseManche).Setup(x => x.GetValeur(0)).Returns(4);
            Mock.Get(fausseManche).Setup(x => x.GetValeur(1)).Returns(2);
            Mock.Get(fausseManche).Setup(x => x.GetValeur(2)).Returns(1);

            Assert.IsTrue(fausseManche.EstGagne(), "Erreur resultat attendu");
            
        }


        [TestMethod]
        public void EstGagne_DesVals422_RetourFalse()
        {
            var fausseManche = Mock.Of<Manche>();
            var f2 = Mock.Of<Manche>();
            Mock.Get(fausseManche).Setup(x => x.GetValeur(0)).Returns(4);
            Mock.Get(fausseManche).Setup(x => x.GetValeur(1)).Returns(2);
            Mock.Get(fausseManche).Setup(x => x.GetValeur(2)).Returns(2);

            Assert.IsFalse(fausseManche.EstGagne(), "Erreur resultat attendu");

        }

        [TestMethod]
        public void Trier_DesOrdreCroissant()
        {
            Manche mc = new Manche();
            mc.Trier();
            Assert.IsTrue(mc.Des[0] <= mc.Des[1], "Erreur");
            Assert.IsTrue(mc.Des[1] <= mc.Des[2], "Erreur");
            
        }

        [TestMethod]
        public void Relancer_100Essais_EtatDesChangeAuMoinsUnefois()
        {

            Manche mc = new Manche();
            byte[] valInit = new byte[] { mc.Des[0].GetValeur(), mc.Des[1].GetValeur(), mc.Des[2].GetValeur() };
            bool[] etatAChange = new bool[] { false, false, false };
            int i = 0;
            while ((!etatAChange[0] ||
                !etatAChange[1] ||
                !etatAChange[2]) &&
                i < 100)
            {

                mc.Relancer();
                for (int j = 0; j < valInit.Length; j++)
                {
                    if (!etatAChange[j])
                    {
                        etatAChange[j] = mc.Des[j].GetValeur() != valInit[j];
                    }
                }

                i++;

            }
            Assert.IsTrue(etatAChange[0], "de0 ne change pas " + mc.Des[0].GetValeur() + " == " + valInit[0]);
            Assert.IsTrue(etatAChange[1], "de1 ne change pas " + mc.Des[1].GetValeur() + " == " + valInit[1]);
            Assert.IsTrue(etatAChange[2], "de2 ne change pas " + mc.Des[2].GetValeur() + " == " + valInit[2]);


        }

        [TestMethod]
        public void RelancerDes1Et2_100Essais_EtatDes1Et2ChangeAuMoinsUnefoisDes0NonChange()
        {
            Manche mc = new Manche();
            byte[] valInit = new byte[] { mc.Des[0].GetValeur(), mc.Des[1].GetValeur(), mc.Des[2].GetValeur() };
            bool[] etatAChange = new bool[] { false, false, false };
            
            int i = 0;
            while ((!etatAChange[0] ||
               !etatAChange[1] ||
               !etatAChange[2]) &&
               i < 100)
            {

                mc.Relancer(new byte[] { 1, 2 });
                for (int j = 0; j < valInit.Length; j++)
                {
                    if (!etatAChange[j])
                    {
                        etatAChange[j] = mc.Des[j].GetValeur() != valInit[j];
                    }
                }
                i++;

            }
            Assert.IsTrue(!etatAChange[0], "de0 ne devrait pas changer");
            Assert.IsTrue(etatAChange[1], "de1 ne change pas");
            Assert.IsTrue(etatAChange[2], "de2 ne change pas");

        }

        [TestMethod]
        public void RelancerDes1Et4_ExceptionEtatInchange()
        {
            Manche mc = new Manche();
            byte[] valInit = new byte[] { mc.Des[0].GetValeur(), mc.Des[1].GetValeur(), mc.Des[2].GetValeur() };
            Assert.ThrowsException<Exception>(()=>mc.Relancer(new byte[] { 1, 4 }),"Err");
            Assert.IsTrue(mc.Des[0].GetValeur() == valInit[0], "de0 ne devrait pas changer");
            Assert.IsTrue(mc.Des[1].GetValeur() == valInit[1], "de0 ne devrait pas changer");
            Assert.IsTrue(mc.Des[2].GetValeur() == valInit[2], "de0 ne devrait pas changer");

        }
    }
}
