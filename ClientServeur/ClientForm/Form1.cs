using Communications;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        private Client client;
        public Form1()
        {
            InitializeComponent();
            client = new Client();
            client.OnReceiveMessageEvent += new Client.OnReceiveMessage(OnReceiveMessage);
        }

        private void OnReceiveMessage(byte[] b)
        {
            // Reception
        }

        private void buttonEnvoi_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.EnvoyerMessage(textBoxEnvoi.Text);
            }
        }
    }
}