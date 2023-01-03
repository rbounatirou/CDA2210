using System.Text.Json;
using System.Text.Json.Nodes;

namespace huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer le texte à compresser");
            string str = Console.ReadLine();

            HuffmanMessage msg = HuffmanEncyptor.Encrypt(str);
            Console.WriteLine("En format actuel " + str + " est constituée de " + str.Length + " chars, ce qui represente " + str.Length * 8 + " bits.");
            Console.WriteLine("En format huffman le message pèse " + msg.Message.Length + " bits.\n");

            Console.WriteLine("Format compressé: ");
            Console.WriteLine(msg);
            Console.WriteLine("Decompresse");
            Console.WriteLine(msg.Decompress());


            //string strz = JsonSerializer.Serialize<HuffmanMessage>(msg);

            /*Dictionary<bool[], string> dict = new Dictionary<bool[], string>();
            dict.Add(new bool[] { false, true, false }, "str");
            Console.WriteLine(dict[new bool[] {false, true, false}]);*/
        }
    }
}