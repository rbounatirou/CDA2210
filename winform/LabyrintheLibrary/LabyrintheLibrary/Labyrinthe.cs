using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LabyrintheLibrary
{
    [Serializable]
    public class Labyrinthe
    {


        private bool[,] estUnMur;
        private int[,] valeur;
        /// <summary>
        /// indique combien on doit faire de pas pour se rendre a cette cellule depuis une cellule adjascente
        /// </summary>
        private int[,] poids;

        public int W { get => estUnMur.GetLength(0); }
        public int H { get => estUnMur.GetLength(1); }

        public bool[,] Murs { get => estUnMur; }
        public int[,] Valeurs { get => valeur; }

        public int[,] Poids { get => poids; }
        public Labyrinthe(int w, int h)
        {
            if ((w - 1) % 2 != 0 || (h - 1) % 2 != 0)
                throw new Exception("TAILLE INVALIDE La largeur et la hauteur doivent s'écrire sous la forme 2x+1");
            estUnMur = new bool[w, h];
            valeur = new int[(int)((w - 1) / 2), (int)((h - 1) / 2)];
            poids = new int[w,h];
            GenererMurDepart();
            GenererValeurDepart();
            GenererPoids();

        }
        public Labyrinthe(bool[,] Murs, int[,] Valeurs, int[,] Poids)
        {
            valeur = new int[Valeurs.GetLength(0), Valeurs.GetLength(1)];

            for (int i = 0; i < Valeurs.GetLength(0); i++)
            {
                for (int j = 0; j < Valeurs.GetLength(1); j++)
                {
                    valeur[i, j] = Valeurs[i, j];
                }
            }

            estUnMur = new bool[Murs.GetLength(0), Murs.GetLength(1)];
            for (int i = 0; i < Murs.GetLength(0); i++)
            {
                for (int j = 0; j < Murs.GetLength(1); j++)
                {
                    estUnMur[i, j] = Murs[i, j];
                }
            }

            poids = new int[Poids.GetLength(0), Poids.GetLength(1)];
            for (int i = 0; i < Poids.GetLength(0); i++)
            {
                for (int j = 0; j < Poids.GetLength(1); j++)
                {
                    poids[i, j] = Poids[i, j];
                }
            }
        }

        private void GenererPoids()
        {
            for (int i = 0; i < poids.GetLength(0); i++)
            {
                for (int j = 0; j < poids.GetLength(1); j++)
                {

                    poids[i, j] = 1;
                }
            }
        }

        public Labyrinthe(Labyrinthe copie) : this(copie.Murs, copie.Valeurs, copie.Poids) { }

        private void GenererMurDepart()
        {

            for (int i = 0; i < estUnMur.GetLength(0); i++)
            {
                for (int j = 0; j < estUnMur.GetLength(1); j++)
                {
                    estUnMur[i, j] = (i % 2 == 0 || j % 2 == 0);


                }
            }
            estUnMur[0, 1] = false;
            estUnMur[estUnMur.GetLength(0) - 1, estUnMur.GetLength(1) - 2] = false;

        }

        private void ReplaceAllValue(int oldV, int newV)
        {
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    if (valeur[i, j] == oldV)
                        valeur[i, j] = newV;
                }
            }
        }

        private List<Point> GetPossibleCoord()
        {
            List<Point> rt = new();
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    if (GetDirections(i, j).Count > 0)
                        rt.Add(new Point(i, j));

                }
            }
            return rt;
        }

        private int[] SelectionnerCases()
        {
            int x, y;
            int m2_x, m2_y;
            Random rnd = Aleatoire.GetInstance();
            List<Point> possiblesCoord = GetPossibleCoord();
            int rndNum = rnd.Next(0, possiblesCoord.Count);
            x = m2_x = possiblesCoord[rndNum].X;
            y = m2_y = possiblesCoord[rndNum].Y;

            List<int> dirPossible = GetDirections(x, y);
            if (dirPossible.Count > 0)
            {
                int direction = dirPossible[rnd.Next(0, dirPossible.Count)];
                m2_x += (direction < 2 ? (direction == 0 ? -1 : 1) : 0);
                m2_y += (direction >= 2 ? (direction == 2 ? -1 : 1) : 0);
            }
            return new int[] { x, y, m2_x, m2_y };

        }

        
        private List<int> GetDirections(int x, int y)
        {
            List<int> dirPossible = new();
            if (x > 0 && valeur[x - 1, y] != valeur[x, y])
            {
                dirPossible.Add(0);

            }
            if (x + 1 < valeur.GetLength(0) && valeur[x + 1, y] != valeur[x, y])
            {
                dirPossible.Add(1);
            }

            if (y > 0 && valeur[x, y - 1] != valeur[x, y])
            {
                dirPossible.Add(2);

            }
            if (y + 1 < valeur.GetLength(1) && valeur[x, y + 1] != valeur[x, y])
            {
                dirPossible.Add(3);
            }
            return dirPossible;
        }

        public List<int> GetDirectionsPossibles(int x, int y)
        {
            List<int> dirPossible = new();
            if (x > 0 && !estUnMur[x - 1, y])
            {
                dirPossible.Add(0);

            }
            if (x + 1 < estUnMur.GetLength(0) && !estUnMur[x + 1, y])
            {
                dirPossible.Add(1);
            }

            if (y > 0 && !estUnMur[x, y - 1])
            {
                dirPossible.Add(2);

            }
            if (y + 1 < estUnMur.GetLength(1) && !estUnMur[x, y + 1])
            {
                dirPossible.Add(3);
            }
            return dirPossible;
        }
        private bool Fusionner(int x1, int y1, int x2, int y2)
        {
            if ((x1 == x2 && y1 == y2) || valeur[x1, y1] == valeur[x2, y2])
                return false;
            int vecDirX = x2 - x1;
            int vecDirY = y2 - y1;
            int cMurX = (x1 * 2 + 1) + vecDirX;
            int cMurY = (y1 * 2 + 1) + vecDirY;
            estUnMur[cMurX, cMurY] = false;
            ReplaceAllValue(valeur[x2, y2], valeur[x1, y1]);
            return true;
        }

        public void Generer()
        {
            while (!EstTermine())
            {
                int[] cases = SelectionnerCases();
                Fusionner(cases[0], cases[1], cases[2], cases[3]);

            }
        }

        public void GenererUneAction()
        {
            bool uneAction = false;
            int[] cases;
            while (!uneAction)
            {
                cases = SelectionnerCases();
                uneAction = Fusionner(cases[0], cases[1], cases[2], cases[3]);
            }
        }

        public bool EstTermine()
        {
            bool sameVal = true;
            int val = valeur[0, 0];
            int i, j;
            i = j = 0;
            while (i < valeur.GetLength(0) && sameVal)
            {
                j = 0;
                while (j < valeur.GetLength(1) && sameVal)
                {
                    sameVal = valeur[i, j] == val;
                    j++;
                }
                i++;
            }
            return sameVal;
        }

        private void GenererValeurDepart()
        {
            int num = 1;
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    valeur[i, j] = num;
                    num++;
                }

            }
        }


        public override string ToString()
        {

            string str = "";
            for (int i = 0; i < H; i++)
            {
                str += (i > 0 ? Environment.NewLine : "");
                for (int j = 0; j < W; j++)
                {
                    str += (estUnMur[j, i] ? 1 : 0) + " ";
                }
            }
            return str;
        }




        public void Serialize(string path)
        {
            BinaryFormatter b = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Create);
            b.Serialize(fs, this);
            fs.Close();
        }

        public static Labyrinthe Deserialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            Labyrinthe lab = (Labyrinthe)b.Deserialize(fs);
            fs.Close();
            return lab;
        }

    }
}