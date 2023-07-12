using CompositeAddition;
using CompositeAddition.Binaires.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTestSoustraction
    {
        [TestMethod]
        public void Soustraction_Calculer_Expression1_Nombre33_Expression2_Nombre33_Retour0()
        {
            Soustraction a = new Soustraction(new Nombre(33), new Nombre(33));
            double n = a.Calculer();
            Assert.IsTrue(n == 0, String.Format("Retour invalide ({0}) attendu {1}", n, 20));
        }

        [TestMethod]
        public void Soustraction_Calculer_Expression1_Nombre33_Expression2_Soustraction33moins11_Retour11()
        {
            Soustraction a = new Soustraction(new Nombre(33), new Nombre(11));
            Soustraction b = new Soustraction(new Nombre(33), a);
            double n = b.Calculer();
            Assert.IsTrue(n == 11, String.Format("Retour invalide ({0}) attendu {1}", n, 77));
        }

        // RETOUR ATTENDU "(33-33)"
        [TestMethod]
        public void Soustraction_GetShortString_Expression1_Nombre33_Expression2_Nombre33_RetourOK()
        {
            string expectedRt = "(33-33)";
            Soustraction a = new Soustraction(new Nombre(33), new Nombre(33));
            string rt = a.GetShortString();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

        // RETOUR ATTENDU "(33-33)=0"
        [TestMethod]
        public void Soustraction_Formate_Expression1_Nombre33_Expression2_Nombre33_RetourOK()
        {
            string expectedRt = "(33-33)=0";
            Soustraction a = new Soustraction(new Nombre(33), new Nombre(33));
            string rt = a.Formate();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

        // RETOUR ATTENDU "(((5-1)-1)-1)=2"
        [TestMethod]
        public void Soustraction_Formate_TroisNiveaux_RetourOK()
        {
            string expectedRt = "(((5-1)-1)-1)=2";
            Soustraction a = new Soustraction(new Nombre(5), new Nombre(1));
            Soustraction b = new Soustraction(a, new Nombre(1));
            Soustraction c = new Soustraction(b, new Nombre(1));
            string rt = c.Formate();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }
    }
}
