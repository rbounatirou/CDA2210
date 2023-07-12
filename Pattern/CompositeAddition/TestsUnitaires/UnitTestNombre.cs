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
    public class UnitTestNombre
    {
        [TestMethod]
        public void Nombre_Calculer_Value10_Retour10()
        {
            Nombre nb = new Nombre(10);
            double n = nb.Calculer();
            Assert.IsTrue(n == 10, String.Format("Retour invalide ({0}) attendu {1}", n, 10));
        }

        // RETOUR ATTENDU = "7"
        [TestMethod]
        public void Nombre_GetShortString_Valeur7_RetourOk()
        {
            string expected = "7";
            Nombre n = new Nombre(7);
            string rt = n.GetShortString();
            Assert.IsTrue(expected.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu \"{1}\"", rt, expected));
        }

        // RETOUR ATTENDU = "7=7"
        [TestMethod]
        public void Nombre_Formate_Valeur7_RetourOk()
        {
            string expected = "7=7";
            Nombre n = new Nombre(7);
            string rt = n.Formate();
            Assert.IsTrue(expected.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu \"{1}\"", rt, expected));
        }

        
    }
}