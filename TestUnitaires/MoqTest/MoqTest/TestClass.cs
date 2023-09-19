namespace MoqTest
{
    public class TestClass
    {
        private int prop;

        public TestClass() : this(2) { }

        public TestClass(int p)
        {
            prop = p;
        }

        public int Prop { get => prop; set => prop = value; }
        public virtual int LancerAleatoire()
        {
            return Alea.GetInstance().Next(0,11);
        }

        public virtual string DireCoucou()
        {
            int des = LancerAleatoire();
            return (des % 2 == 0 ? "Bonjour" : "Coucou");
        }
    }
}