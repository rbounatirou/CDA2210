Console.WriteLine("Veuillez entrez deux nombre afin de calculer leur PGCD");
Console.WriteLine("Entrez le premier nombre");
int nb1 = gererSaisieNombre();
Console.WriteLine("Entrez le deuxième nombre");
int nb2 = gererSaisieNombre();
Console.WriteLine("Le PGCD des 2 nombres est " + calculerPGCDparEuclide(nb1, nb2));

int gererSaisieNombre()
{
    bool saisieOk = false;
    String saisie;
    int rt = 0;
    do
    {
        
        saisie = Console.ReadLine().Trim();
        try
        {
            rt = int.Parse(saisie);
            if (rt >= 0)
                saisieOk = true;
            else
                Console.WriteLine("Saisie invalide veuillez entrez un nombre entier strictement positif ");
        } catch (Exception e)
        {
            Console.WriteLine("Saisie invalide veuillez entrez un nombre entier strictement positif ");
        }
    } while (!saisieOk);
    return rt;
}

int calculerPGCDparEuclide(int a, int b)
{
    int r;
    while (b != 0)
    {
        r = a % b;
        a = b;
        b = r;
    }
    return a;
}