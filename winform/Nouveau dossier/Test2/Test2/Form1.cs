namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();

            g.FillRectangle(sb, new Rectangle(0, 0, 100, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();

            g.FillRectangle(sb, new Rectangle(25, 25, 50, 50));
        }
    }
}