
String saisie = "";
// Analyse de la chaine
String[] split;
bool saisieCorrecte = false;
do
{
    Console.WriteLine("Veuillez saisir l'age des 20 personnes separes par un espace");
    saisie = Console.ReadLine().Trim();
    split = saisie.Split(' ');
} while (!saisieCorrecte);