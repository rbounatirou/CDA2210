String saisie = "";
do
{
    Console.WriteLine("Veuillez saisir un texte d'au moins 120 caracteres");
    saisie= Console.ReadLine().Trim().ToLower();
    if (saisie.Length < 120)
        Console.WriteLine("Le nombre de caracteres de la saisie doit etre d'au moins 120 après retrait des espaces inutiles");
} while (saisie.Length < 120);
countEachLetters(saisie);


void countEachLetters(string saisie)
{
    int occurence;
    String saisieTmp = saisie.Replace(" ", "");// REMOVE SPACES FOR HAVING LESS LOOP TURN
    for (int i = (int)'a'; i < (int)'z'; i++) // USE ASCII VALUE FOR COUNT EACH OCCURENCE
    {
        occurence = 0;
        for (int j = 0; j < saisieTmp.Length; j++)
        {
            if (saisieTmp[j] == (char)i)
                occurence++;
        }
        if (occurence > 0)
            Console.WriteLine("Il y'a " + occurence + " fois la lettre '" + (char)i + "' dans la saisie");
    }
}

