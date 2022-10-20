int[] tab = { 1, 2, 5, 6, 4, 2, 3, 1 };
trier(tab);

//
int[] trier(int[] tab)
{
    int[] rt = tab;
    for(int i = 0; i < tab.Length-1; i++)
    {
        for (int j=i+1; j < tab.Length; j++)
        {
            if (tab[j] < tab[i])
            {
                int tmp = tab[i];
                tab[i] = tab[j];
                tab[j] = tmp;
            }
        }
    }

    return rt;
}