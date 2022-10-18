bool isCorrect = true;
int saisie = 0;
do
{
    Console.WriteLine((isCorrect ? "Bonjour, veuillez entrer un nombre de nombre parfaits à obtenir (au moins 1)" :
        "Nombre incorrect,veuillez entrer un nombre de nombre parfaits à obtenir (au moins 1)"));
    try
    {
        saisie = int.Parse(Console.ReadLine());
        isCorrect = (saisie > 0);
    }
    catch (Exception e)
    {
        isCorrect = false;
    }
} while (!isCorrect);
afficherNombreDeParfait(saisie);


//---------------------

void afficherNombreDeParfait(int nombreDeParfaitDesire)
{
    int i = 0;
    int n = 1;
    while (i < nombreDeParfaitDesire)
    {
        if (estParfait(n)) 
        {
            Console.WriteLine(n + " est un nombre parfait.");
            i++;
        }
        n++;
    }
}

bool estParfait(int n) // teste si le nombre n envoye en parametre est parfait
{
    int sommeDiviseur = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
            sommeDiviseur += i;
    }
    return sommeDiviseur == n;
}