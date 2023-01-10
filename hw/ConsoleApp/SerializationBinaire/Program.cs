using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using SerializableElements;

namespace SerializationBinaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "dataStuff.myData";

            // Use a BinaryFormatter or SoapFormatter.
            IFormatter formatter = new BinaryFormatter();
            //IFormatter formatter = new SoapFormatter();

            string tmp = SerializeItem(formatter); // Serialize an instance of the class.
            DeserializeItem(tmp, formatter); // Deserialize the instance.
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public static string SerializeItem(IFormatter formatter)
        {
            // Create an instance of the type and serialize it.
            SerializableElement t = new SerializableElement("rody","bou",29,"rody");

            MemoryStream s = new MemoryStream();
            formatter.Serialize(s, t);
            string rt = System.Text.Encoding.Unicode.GetString(s.ToArray());
            s.Close();
            return rt;
        }

        public static void DeserializeItem(string file,IFormatter formatter)
        {
            MemoryStream s = new MemoryStream(System.Text.Encoding.Unicode.GetBytes(file));
            SerializableElement t = (SerializableElement)formatter.Deserialize(s);
            Console.WriteLine(t.Age + " ans");
        }
    }
}