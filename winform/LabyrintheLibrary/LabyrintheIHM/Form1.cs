using LabyrintheLibrary;

namespace LabyrintheIHM
{
    public partial class Form1 : Form
    {
        private Labyrinthe labyrinthe;
        private List<Labyrinthe> saves;
        public Form1()
        {
            InitializeComponent();
            saves = new();
            labyrinthe = new Labyrinthe(11,11);
            while (!labyrinthe.EstTermine() ||saves.Count> labyrinthe.W * labyrinthe.H)
            {
                saves.Add(new Labyrinthe(labyrinthe));
                labyrinthe.GenererUneAction();

            }
            hScrollBar1.Maximum = saves.Count();
            saves.Add(new Labyrinthe(labyrinthe));
            DessinerLabyrinthe(labyrinthe);
        }

        public void DessinerLabyrinthe(Labyrinthe l)
        {
            Graphics g = panelLabyrinthe.CreateGraphics();

            Color mur = Color.Black;
            Color sol = Color.White;
            // -----------------
            int tileW = panelLabyrinthe.Width / labyrinthe.W;
            int tileH = panelLabyrinthe.Height / labyrinthe.H;
            bool[,] murs = labyrinthe.Murs;
            // ---------------------
            SolidBrush brushMur = new SolidBrush(mur);
            SolidBrush brushSol = new SolidBrush(sol);
            SolidBrush brushText = new SolidBrush(Color.Red);
            Rectangle rectangle = new();
            for (int i = 0; i < murs.GetLength(0); i++)
            {
                for (int j = 0; j < murs.GetLength(1); j++)
                {
                    rectangle.X = i * tileW;
                    rectangle.Y = j * tileH;
                    rectangle.Width = tileW;
                    rectangle.Height = tileH;
                    g.FillRectangle((murs[i, j] ? brushMur : brushSol), rectangle);
                }
                
            }
            int[,] valeur = labyrinthe.Valeurs;
            Font ft = new Font("Helvetica", 14, FontStyle.Bold);
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    g.DrawString(valeur[i, j].ToString(), ft, brushText, new PointF(tileW + 2 * i*tileW, tileH + 2 * j*tileH));
                }
            }
           // panelLabyrinthe.Refresh();

        }

        private void panelLabyrinthe_Paint(object sender, PaintEventArgs e) => DessinerLabyrinthe(labyrinthe);

        private void GenererAction(object sender, EventArgs e)
        {
            labyrinthe.GenererUneAction();
            panelLabyrinthe.Refresh();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            labyrinthe = saves[hScrollBar1.Value];
            panelLabyrinthe.Refresh();
            labelSlide.Text = hScrollBar1.Value + " / " + hScrollBar1.Maximum;
        }
    }
}