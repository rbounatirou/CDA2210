bool isCorrect = true;
int saisie=0;
do
{
    Console.WriteLine((isCorrect ? "Bonjour, veuillez entrer un nombre entier positif suppérieur à 2 pour verifier si il est premier" : "Saisie incorrecte, veuillez entrez un nombre entier strictement positif"));
    try
    {
        saisie = int.Parse(Console.ReadLine());
        isCorrect = (saisie > 1);
    }
    catch (Exception e)
    {
        isCorrect = false;
    }
} while (!isCorrect);
// SI LA SAISIE EST CORRECTE ON VERIFIE
int sqrt = (int)Math.Sqrt(saisie);
bool isPrimary = (saisie == 2 || saisie%2!=0);
if (saisie%2 != 0) {
    int i = 3;
    while (isPrimary && i<= sqrt)
    {
        isPrimary = saisie % i != 0;
        i+=2;// on ne teste pas les nombres pairs
    }
}
Console.WriteLine(isPrimary ? "Le nombre est premier" : "Le nombre n'est pas premier");