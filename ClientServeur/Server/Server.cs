using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.NetworkInformation;

namespace Communications
{
    public class Server
    {
        public const int PORT = 8085;
        public const string IP = "127.0.0.1";
        Dictionary<Socket, string> users;
        //public bool okConnection { get; private set; }
        private Socket tcpLi { get; set; }
        private Thread threadEcoute;

        public delegate void OnReceiveMessage(Socket s, byte[] b);
        public delegate void OnAcceptNewUser(Socket s);
        public event OnReceiveMessage OnReceiveMessageEvent;
        public event OnAcceptNewUser OnAcceptNewUserEvent;

        public Server() 
        {
            tcpLi = new Socket(SocketType.Stream, ProtocolType.Tcp) ;
            tcpLi.Bind(new IPEndPoint(IPAddress.Parse(IP), PORT));
            users = new Dictionary<Socket, string>();
            tcpLi.Listen();
            
        }
        public void Start()
        {
            while (true)
            {
                Socket s = tcpLi.Accept();
                if (users.Keys.ToList().Find(x => x.RemoteEndPoint == s.RemoteEndPoint) == null)
                {
                    if (OnAcceptNewUserEvent != null)
                        OnAcceptNewUserEvent(s);
                }
                byte[] b = new byte[20000];
                int c = s.Receive(b);
                
                Array.Resize(ref b, c);
                if (OnReceiveMessageEvent != null)
                {
                    OnReceiveMessageEvent(s, b);
                }

            }
            tcpLi.Close();
        }

       
    }
}