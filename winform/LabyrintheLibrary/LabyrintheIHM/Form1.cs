using LabyrintheLibrary;
using System.Drawing;

namespace LabyrintheIHM
{
    public partial class Form1 : Form
    {
        private Labyrinthe labyrinthe;
        private List<Labyrinthe> saves;
        Bitmap bmp;
        Point[] pointsDjikstra;
        public Form1()
        {
            InitializeComponent();
            saves = new();
            labyrinthe = new Labyrinthe(21, 21);
            numericUpDownDepX.Maximum = numericUpDownEndX.Maximum = labyrinthe.W - 1;
            numericUpDownDepY.Maximum = numericUpDownEndY.Maximum = labyrinthe.H - 1;
            while (!labyrinthe.EstTermine() || saves.Count > labyrinthe.W * labyrinthe.H)
            {
                saves.Add(new Labyrinthe(labyrinthe));
                labyrinthe.GenererUneAction();

            }
            bmp = new Bitmap(panelLabyrinthe.Width, panelLabyrinthe.Height);
            hScrollBar1.Maximum = saves.Count();
            saves.Add(new Labyrinthe(labyrinthe));
            hScrollBar1.Value = hScrollBar1.Maximum;
            DessinerLabyrinthe(labyrinthe);
            pointsDjikstra = new Point[] { new Point(0, 1), new Point(labyrinthe.W - 1, labyrinthe.H - 2) };
            numericUpDownDepX.Value = pointsDjikstra[0].X;
            numericUpDownDepY.Value = pointsDjikstra[0].Y;
            numericUpDownEndX.Value = pointsDjikstra[1].X;
            numericUpDownEndY.Value = pointsDjikstra[1].Y;
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
            SolidBrush brushGrid = new SolidBrush(Color.FromArgb(64, 255, 0, 0));
            Pen pen = new Pen(brushGrid, 5);
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
            DessinerLigne(g, pen, tileW, tileH);
            int size = Math.Max((2 * Math.Max(tileW, tileH)) / 4, 5);
            Font ft = new Font("Helvetica", size, FontStyle.Bold);
            if (radioButtonValeur.Checked)
            {
                DessinerValeur(g, ft, brushText, tileW, tileH);
            }
            else if (radioButtonPoids.Checked)
            {
                DessinerPoids(g, ft, brushText, tileW, tileH);

            }
            else if (radioButtonDjikstra.Checked && labyrinthe.EstTermine())
            {
                DessinerDjikstra(g, ft, brushText, tileW, tileH);

            }
            else if (radioButtonCoordonees.Checked)
            {
                DessinerCoordonees(g, brushText, tileW, tileH);
            }
            //g.DrawImage(bmp, 0, 0, panelLabyrinthe.Width, panelLabyrinthe.Height);
            // panelLabyrinthe.Refresh();

        }

        private void DessinerLigne(Graphics g, Pen pen, int tileW, int tileH)
        {

            for (int i = 0; i < labyrinthe.W; i++)
            {
                g.DrawLine(pen, new Point(i * tileW, 0), new Point(i * tileW, panelLabyrinthe.Height));
            }
            for (int i = 0; i < labyrinthe.H; i++)
            {
                g.DrawLine(pen, new Point(0, i * tileH), new Point(panelLabyrinthe.Width, i * tileH));
            }
        }

        private void DessinerValeur(Graphics g, Font ft, Brush b, int tileW, int tileH)
        {
            int[,] valeur = labyrinthe.Valeurs;
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    g.DrawString(valeur[i, j].ToString(), ft, b, new PointF(tileW + 2 * i * tileW, tileH + 2 * j * tileH));
                }
            }
        }

        private void DessinerDjikstra(Graphics g, Font ft, Brush b, int tileW, int tileH)
        {
            if (!labyrinthe.EstTermine())
                return;
            Djikstra djikstra = new Djikstra(labyrinthe, pointsDjikstra[0].X, pointsDjikstra[0].Y, pointsDjikstra[1].X, pointsDjikstra[1].Y);
            SolidBrush bi = new SolidBrush(Color.FromArgb(128, 0, 255, 0));
            SolidBrush bo = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
            g.FillRectangle(bi, new Rectangle(pointsDjikstra[0].X * tileW, pointsDjikstra[0].Y * tileH, tileW, tileH));
            g.FillRectangle(bo, new Rectangle(pointsDjikstra[1].X * tileW, pointsDjikstra[1].Y * tileH, tileW, tileH));
            if (djikstra.Pattern != null)
            {
                foreach (EtapeDjikstra et in djikstra.Pattern)
                {
                    g.DrawString(et.DistanceTotale.ToString(), ft, b, new PointF(et.PointArrivee.X * tileW, et.PointArrivee.Y * tileH));
                }
            }
        }

        private void DessinerPoids(Graphics g, Font ft, Brush b, int tileW, int tileH)
        {
            int[,] poids = labyrinthe.Poids;
            for (int i = 0; i < poids.GetLength(0); i++)
            {
                for (int j = 0; j < poids.GetLength(1); j++)
                {
                    if (!labyrinthe.Murs[i, j])
                        g.DrawString(poids[i, j].ToString(), ft, b, new PointF(tileW * i, tileH * j));
                }
            }
        }
        private void DessinerCoordonees(Graphics g, Brush b, int tileW, int tileH)
        {
            int size = Math.Max((2 * Math.Max(tileW, tileH)) / 8, 5);
            Font ft = new Font("Helvetica", size, FontStyle.Bold);
            for (int i = 0; i < labyrinthe.W; i++)
            {
                for (int j = 0; j < labyrinthe.H; j++)
                {
                    g.DrawString(String.Format("{0};{1}", i, j), ft, b, new PointF(tileW * i, tileH * j));
                }
            }
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

        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            Bitmap bmploc = new Bitmap(panelLabyrinthe.Width, panelLabyrinthe.Height);

            //panelLabyrinthe.DrawToBitmap(bmp, new Rectangle(0, 0, panelLabyrinthe.Width, panelLabyrinthe.Height));

            panelLabyrinthe.CreateGraphics().DrawImage(bmploc, new Rectangle(0, 0, bmp.Width, bmp.Height));
            Clipboard.SetData(DataFormats.Bitmap, (object)bmploc);
        }

        private void btSerialize_Click(object sender, EventArgs e)
        {
            labyrinthe.Serialize("obj.bin");
        }

        private void radioButtonCheckedChanged(object sender, EventArgs e)
        {
            panelLabyrinthe.Refresh();
        }

        private void buttonChangerDjikstra_Click(object sender, EventArgs e)
        {
            if (!labyrinthe.Murs[(int)numericUpDownDepX.Value, (int)numericUpDownDepY.Value] &&
                !labyrinthe.Murs[(int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value])
            {
                pointsDjikstra[0] = new Point((int)numericUpDownDepX.Value, (int)numericUpDownDepY.Value);
                pointsDjikstra[1] = new Point((int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value);
                panelLabyrinthe.Refresh();
            }
        }
    }
}