namespace LabyrintheLibrary
{
    public class Labyrinthe
    {


        private bool[,] estUnMur;
        private int[,] valeur;

        public int W { get => estUnMur.GetLength(0); }
        public int H { get => estUnMur.GetLength(1); }

        public bool[,] Murs { get => estUnMur; }
        public int[,] Valeurs { get => valeur; }
        public Labyrinthe(int w, int h)
        {
            if ((w - 1) % 2 != 0 || (h - 1) % 2 != 0)
                throw new Exception("TAILLE INVALIDE La largeur et la hauteur doivent s'écrire sous la forme 2x+1");
            estUnMur = new bool[w, h];
            valeur = new int[(int)((w - 1) / 2), (int)((h - 1) / 2)];
            GenererMurDepart();
            GenererValeurDepart();

        }


        public Labyrinthe(Labyrinthe copie)
        {
            valeur = new int[copie.valeur.GetLength(0), copie.valeur.GetLength(1)];

            for (int i = 0; i < copie.valeur.GetLength(0); i++)
            {
                for (int j = 0; j < copie.valeur.GetLength(1); j++)
                {
                    valeur[i,j] = copie.valeur[i,j];
                }
            }

            estUnMur = new bool[copie.estUnMur.GetLength(0), copie.estUnMur.GetLength(1)];
            for (int i= 0; i < estUnMur.GetLength(0); i++)
            {
                for (int j = 0; j < estUnMur.GetLength(1); j++)
                {
                    estUnMur[i, j] = copie.estUnMur[i, j];
                }
            }

        }
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

        private void ReplaceAllValue(int oldV, int newV){
            for (int i = 0; i < valeur.GetLength(0); i++)
            {
                for (int j = 0; j < valeur.GetLength(1); j++)
                {
                    if (valeur[i, j] == oldV)
                        valeur[i, j] = newV;
                }
            }
        }

        private int[] SelectionnerCases()
        {
            int x, y;
            int m2_x, m2_y;
            Random rnd = Aleatoire.GetInstance();
            x = m2_x = rnd.Next(0, valeur.GetLength(0));
            y = m2_y = rnd.Next(0, valeur.GetLength(1));

            List<int> dirPossible = new();
            if (x > 0 && valeur[x-1,y] != valeur[x,y])
            {
                dirPossible.Add(0);
               
            } else if (x+1 < valeur.GetLength(0) && valeur[x + 1, y] != valeur[x, y])
            {
                dirPossible.Add(1);
            }

            if (y > 0 && valeur[x, y-1] != valeur[x, y])
            {
                dirPossible.Add(2);

            }
            else if (y+1 < valeur.GetLength(1) && valeur[x , y+1] != valeur[x, y])
            {
                dirPossible.Add(3);
            }
            if (dirPossible.Count > 0)
            {
                int direction = dirPossible[rnd.Next(0, dirPossible.Count)];
                m2_x += (direction < 2 ? (direction == 0 ? -1 : 1) : 0);
                m2_y += (direction >= 2 ? (direction == 2 ? -1 : 1) : 0);
            }
            return new int[] { x, y, m2_x, m2_y };
            
        }

        private bool Fusionner(int x1, int y1, int x2, int y2)
        {
            if ((x1 == x2 && y1 == y2) || valeur[x1, x2] == valeur[y1, y2])
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
            bool sameVal= true;
            int val = valeur[0, 0];
            int i, j;
            i = j = 0;
            while(i < valeur.GetLength(0) && sameVal)
            {
                j = 0;
                while (j < valeur.GetLength(1) && sameVal) {
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

            for (int i = 0; i < estUnMur.GetLength(0); i++)
            {
                str += (i > 0 ? Environment.NewLine : "");
                for (int j = 0; j < estUnMur.GetLength(1); j++)
                {
                    str += (estUnMur[i, j] ? 1 : 0) + " ";
                }

            }
            return str;
        }

    }
}