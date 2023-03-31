using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Communications
{
    public class Client
    {

        private const int PORT_SERVEUR = 8085;
        private const string IP_SERVEUR = "127.0.0.1";

        private Socket socket;
        private Thread listenThread;

        public delegate void OnReceiveMessage(byte[] b);
        public event OnReceiveMessage OnReceiveMessageEvent;
        public Client()
        {
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP_SERVEUR), PORT_SERVEUR));
            listenThread = new Thread(new ThreadStart(EcouterMessage));
        }

        ~Client()
        {
            lock (socket)
            {
                socket.Close();
            }
        }

        private void SendCommande(Commande c)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            formatter.Serialize(memoryStream, c);
            memoryStream.Position = 0;
            byte[] b = new byte[memoryStream.Length + 10];
            int nbByteToRead = (int)memoryStream.Length;
            int nbByteRead = 0;
            do
            {
                int n = memoryStream.Read(b, 0, b.Length);
                nbByteRead += n;
                nbByteToRead -= n;
            } while (nbByteToRead > 0);
            lock (socket)
            {
                socket.Send(b);
            }
        }
        
        
        public void EnvoyerMessage(string msg)
        {
            Commande c = new Commande(EnumTypeCommande.MESSAGE);
            c.AddCommande("contenu", msg);
            SendCommande(c);
        }

        public void EnvoyerMessagePrive(string msg, string dest)
        {
            Commande c = new Commande(EnumTypeCommande.MESSAGE_PRIVE);
            c.AddCommande("contenu", msg);
            c.AddCommande("destinataire", dest);
            SendCommande(c);
        }


        public void Authentifier(string pseudo)
        {
            Commande c = new Commande(EnumTypeCommande.AUTHENTIFICATION);
            c.AddCommande("pseudo", pseudo);
            SendCommande(c);
        }


        private void EcouterMessage()
        {
            while (true)
            {
                lock (socket)
                {
                    byte[] b = new byte[1000];
                    socket.Receive(b);
                    if (OnReceiveMessageEvent != null)
                        OnReceiveMessageEvent(b);
                    
                }
                Thread.Sleep(120);
            }
        }

       
    }
}