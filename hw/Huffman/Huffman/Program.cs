namespace huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Huffman test = new Huffman("Ceci est un test de l'algo de huffman");
            /*HuffmanMessage msg = HuffmanEncyptor.Encrypt("Il était une fois, une chaine de caractere qui se" +
                " sentait fortement perturbé, elle n'arrivait pas à savoir si elle était formatté correctement" +
                " selon certains critéres, un jour elle rencontra une amie nommé regex, regex était douée pour" +
                " juger les chaines de caractéres selon certains critères, elle scruta attentivement son amie la chaine" +
                " de caractère et parvint à trouver ce qui matchait ou non en elle.");*/

            /*HuffmanMessage msg = new HuffmanMessage(null, new Branch(
                new Branch(new Letter('s', 1), new Letter('n', 1)),
                new Letter('t', 3)));*/
            Dictionary<char, int> test = new Dictionary<char, int>();
            test.Add('c', 6);
            test.Add('d', 2);
          
            foreach(int c in test.Values)
            {
                Console.WriteLine(c);
            }            
            HuffmanMessage msg =  HuffmanEncyptor.Encrypt("Ceci est un test");
            Console.WriteLine(msg.generateHTML("huffman.html") ? "Ok" : "Nok");
        }
    }
}