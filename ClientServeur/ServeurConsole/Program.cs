using Communications;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

internal class Program
{
    private static void Main(string[] args)
    {
        Server server = new Server();
        server.OnReceiveMessageEvent += new Server.OnReceiveMessage(Program.ReceiveMessage);
        server.Start();
    }

    private static void ReceiveMessage(Socket s, byte[] b)
    {
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream ms = new MemoryStream(b);
        Commande m = (Commande)bf.Deserialize(ms);
        Message(m);
    }

    private static void Message(Commande m) {
        Console.WriteLine(m.Type);
        for(int i = 0; i < m.Parametres.Count;i++){
            Console.WriteLine(m.Parametres.Keys.ElementAt(i) + "->"+ m.Parametres.Values.ElementAt(i));
        }
        
    }
}