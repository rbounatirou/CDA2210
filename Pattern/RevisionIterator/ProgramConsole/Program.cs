using BibliIterator;

namespace ProgramConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCollection<string> collection = new CCollection<string>();
            collection.Add("A");
            collection.Add("B");
            collection.Add("C");
            collection.Add("D");
            collection.Add("E");
            collection.Add("F");
            collection.Add("G");
            collection.Add("H");
            collection.Add("I");
            CEnumerator2<string> moniterator = new CEnumerator2<string>(collection);
            while(moniterator.MoveNext())
            {
                Console.WriteLine(moniterator.Current);
            }
            Console.WriteLine("---------foreach--------");
            foreach(string item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}