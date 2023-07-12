using CompositeAddition;
using CompositeAddition.Binaires.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTestAddition
    {
        [TestMethod]
        public void Addition_Calculer_Expression1_Nombre33_Expression2_Nombre33_Retour66()
        {
            Addition a = new Addition(new Nombre(33), new Nombre(33));
            double n = a.Calculer();
            Assert.IsTrue(n==66, String.Format("Retour invalide ({0}) attendu {1}",n,20));
        }

        [TestMethod]
        public void Addition_Calculer_Expression1_Nombre33_Expression2_Addition33plus11_Retour77()
        {
            Addition a = new Addition(new Nombre(33), new Nombre(11));
            Addition b = new Addition( new Nombre(33), a);
            double n = b.Calculer();
            Assert.IsTrue(n== 77, String.Format("Retour invalide ({0}) attendu {1}", n, 77));
        }

        // RETOUR ATTENDU "(33+33)";
        [TestMethod]        
        public void Addition_GetShortString_Expression1_Nombre33_Expression2_Nombre33_RetourOK()
        {
            string expectedRt = "(33+33)";
            Addition a = new Addition(new Nombre(33), new Nombre(33));
            string rt = a.GetShortString();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

        // RETOUR ATTENDU "(33+33)=66";
        [TestMethod]
        public void Addition_Formate_Expression1_Nombre33_Expression2_Nombre33_RetourOK()
        {
            string expectedRt = "(33+33)=66";
            Addition a = new Addition(new Nombre(33), new Nombre(33));
            string rt = a.Formate();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

        // RETOUR ATTENDU "(33+(33+11))=77"
        [TestMethod]
        public void Addition_Formate_Expression1_Nombre33_Expression2_Addition33plus11_Retour77()
        {
            string expectedRt = "(33+(33+11))=77";
            Addition a = new Addition(new Nombre(33), new Nombre(11));
            Addition b = new Addition(new Nombre(33), a);
            string rt = b.Formate();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

        // RETOUR ATTENDU "(((5+1)+1)+1)=8"
        [TestMethod]
        public void Addition_Formate_TroisNiveaux_RetourOK()
        {
            string expectedRt = "(((5+1)+1)+1)=8";
            Addition a = new Addition(new Nombre(5), new Nombre(1));
            Addition b = new Addition(a, new Nombre(1));
            Addition c = new Addition(b, new Nombre(1));
            string rt = c.Formate();
            Assert.IsTrue(expectedRt.Equals(rt), String.Format("Retour invalide (\"{0}\") attendu : \"{1}\"", rt, expectedRt));
        }

    }
}