namespace huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = "1000110100110101111100110011110110101110011001100".Length;
            int test2 = "Ceci est un test".Length * 8;
            HuffmanMessage msg =  HuffmanEncyptor.Encrypt("Ceci est un test");
            Console.WriteLine(msg.generateHTML("huffman.html") ? "Ok" : "Nok");
        }
    }
}