namespace CommunicationEntreForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEnvoi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textboxInfoSent);
            f2.Show();
        }
    }
}