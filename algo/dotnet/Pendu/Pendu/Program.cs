using System.Text.RegularExpressions;

String saisie = "";
String motJ1 = "";
int erreurs = 0;
bool isCorrect = false;
do
{
    Console.WriteLine("Veuillez entrez le mot que vous souhaitez faire devinner (5 lettres minimum)");
    saisie = Console.ReadLine().Trim().ToUpper();
    if (saisie.Split(' ').Count() == 1)
    {
        if (saisie.Length >= 5)
        {
            Regex reg = new Regex("^[A-Z]{5,}$");
            if (reg.IsMatch(saisie))
                isCorrect = true;
            else
                Console.WriteLine("La saisie ne doit avoir que des lettres");
        } else
        {
            Console.WriteLine("Le mot doit faire au moins 5 caractères");
        }
    } else
    {
        Console.WriteLine("Un seul mot à la fois");
    }

} while (!isCorrect);
motJ1 = saisie;
// PARTIE DEVINER
Console.Clear();
String motJ2 = "";
// PREPARATION DE LA DEVINETTE
for (int i = 0; i < saisie.Length; i++)
{
    motJ2 += '-';
}
//--- BOUCLE PRINCIPALE
do
{

    Console.WriteLine("Le mot est de la forme: " + motJ2 + "\n au total " + motJ1.Length + " lettres. " + "saisissez une lettre");
    
    saisie = Console.ReadLine().Trim().ToUpper();
    Console.Clear();
    if (saisie.Length == 1 && saisie[0] >= (int)'A' && saisie[0] <= (int)'Z')
    {
        if (charIsOn(saisie[0],motJ1,ref motJ2))
        {
            Console.WriteLine("Bravo, la lettre " + saisie[0] + " est belle et biern présente dans le mot");
        } else
        {
            erreurs++;
            Console.WriteLine("La lettre " + saisie[0] + " n'est pas présente, vous perdez une vie, il vous en reste : " + (6-erreurs));
           
        }
    } else
    {
        Console.WriteLine("saisie incorrecte, veuillez n'entrer qu'une lettre");
    }
    
} while (!motJ2.Equals(motJ1) && erreurs < 6);
Console.WriteLine(erreurs == 6 ? "Vous n'avez pas deviner le mot " + motJ1  : "Bravo, le mot était bien " + motJ1 + " et vous avez commis " + erreurs + " erreur(s)");





bool charIsOn(char searchFor, String from, ref String to){
    bool rt = false;
    System.Text.StringBuilder sb = new System.Text.StringBuilder(to);

    for (int i = 0; i < from.Length; i++)
    {
        if (from[i] == searchFor)
        {
            sb[i] = searchFor;
            rt = true;
        }
    }
    to = sb.ToString();
    return rt;
}