using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int c = 33;
            string sr = System.Text.UTF8Encoding.UTF8.GetString(new byte[] {(byte)c});*/
            Console.WriteLine("Veuillez entrer le texte à compresser");
            string str = Console.ReadLine();

            HuffmanMessage msg = HuffmanEncyptor.Encrypt(str);




            JsonSerializerOptions jopt = new JsonSerializerOptions();
            jopt.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            //string strz = JsonSerializer.Serialize<HuffmanMessage>(msg);
            string strz = JsonSerializer.Serialize<HuffmanMessage>(msg,jopt);

            //File.WriteAllText("actual.txt", strz);
            HuffmanMessage msg2 = JsonSerializer.Deserialize<HuffmanMessage>(strz,jopt);
            Console.WriteLine("Deserialization + decompression\n" + msg2.Decompress());
        }
    }
}