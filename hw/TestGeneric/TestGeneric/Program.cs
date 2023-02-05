namespace TestGeneric
{
    internal class Program
    {
        public abstract class A
        {
            protected int attr;

            public A() { attr = 0; }
        }

        public  class B : A
        {
            public B() { attr = 1; }
        }

        public class C : A
        {
            public C() { attr = 2; }
        }

        public class Paquet<T> where T : A
        {
            List<T> list;
            public Paquet(){
                list = new List<T>();
            }

            public void Add(T type)
            {
                list.Add(type);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Paquet<C> paquet = new Paquet<C>();
            A a = new B();
            B b = new B();
            C c = new C();
            /*paquet.Add(a);
            paquet.Add(b);*/

            paquet.Add(c);
            
        }
    }
}