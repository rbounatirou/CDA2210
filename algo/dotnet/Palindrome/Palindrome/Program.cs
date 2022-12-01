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


bool verifierPalindrome(string saisie)
{
    bool estUnPalindrome = saisie.Length >= 2;
    if (!estUnPalindrome)
        return false;
    saisie = saisie.Replace(" ", "");
    
    int i = 0;
    int maxRange = saisie.Length / 2;
    while (estUnPalindrome && i < maxRange)
    {
        estUnPalindrome = (saisie[i] == saisie[saisie.Length - (1 + i)]);
        i++;
    }
    return estUnPalindrome;
}