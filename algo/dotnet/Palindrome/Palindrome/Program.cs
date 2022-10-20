String saisie = "";

// ---
Console.WriteLine("Veuillez saisir une chaine afin de déterminer si elle est ou non un palindrome");
saisie = Console.ReadLine().Trim();
if (saisie.Count() > 0)
{
    Console.WriteLine(verifierPalindrome(saisie) ? "La chaine est un palindrome" :
        "La chaine n'est pas un palindrome");
}
else
{
    Console.WriteLine("LA CHAINE EST VIDE");
}


bool verifierPalindrome(String saisie)
{
    saisie = saisie.Replace(" ", "");
    bool estUnPalindrome = true;
    int i = 0;
    while (estUnPalindrome && i <( saisie.Length/2))
    {
        estUnPalindrome = (saisie[i] == saisie[saisie.Length - (1 + i)]);
        i++;
    }
    return estUnPalindrome;
}