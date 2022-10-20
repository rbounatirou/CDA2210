
String saisie = "";
// Analyse de la chaine
String[] split;
byte[] age = new byte[20];
bool saisieCorrecte = false;
do
{
    Console.WriteLine("Veuillez saisir l'age des 20 personnes separes par un espace");
    saisie = Console.ReadLine().Trim();
    split = saisie.Split(' ');
    if (split.Length == 20)
    {
        try
        {
            for (int i = 0; i < 20; i++)
            {
                age[i] = Convert.ToByte(split[i]);
            }
            saisieCorrecte=true;
        } catch (Exception e)
        {
            Console.WriteLine("Une donnée n'a pas été entrée correctement");
        }
    } else
    {
        Console.WriteLine("nombre de donées incorrect");
    }
} while (!saisieCorrecte);
afficherParCategorie(age);


void afficherParCategorie(byte[] age)
{
    
    byte[,] ages = new byte[3, 20];
    const int LESS_THAN_20 = 0;
    const int HAVE_20 = 1;
    const int MORE_THAN_20 = 2;


    byte[] nbRecord = new byte[3];


    for (int i = 0; i < age.Length; i++)
    {
        if (age[i] < 20)
        {
            ages[LESS_THAN_20, nbRecord[LESS_THAN_20]] = age[i];
            nbRecord[LESS_THAN_20]++;
        }            
        else if (age[i] > 20)
        {
            ages[MORE_THAN_20, nbRecord[MORE_THAN_20]] = age[i];
            nbRecord[MORE_THAN_20]++;
        }
        else
        {
            ages[HAVE_20, nbRecord[HAVE_20]] = age[i];
            nbRecord[HAVE_20]++;
        }            
    }
    if (nbRecord[LESS_THAN_20] == age.Length)
        Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
    else if (nbRecord[MORE_THAN_20] == age.Length)
        Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
    else if (nbRecord[HAVE_20] == age.Length)
        Console.WriteLine("TOUTES LES PERSONNES ONT 20 ANS");
    else
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Le nombre de " + (i > 0 ? (i == 1 ? "personnes de 20 ans" : "personnes de + 20 ans") : "personnes de - 20 ans"));
            for (int j = 0; j < nbRecord[i]; j++)
            {
                Console.Write(ages[i, j] + " ");
            }
            if (nbRecord[i] > 0)
                Console.Write('\n');
        }
    }

}