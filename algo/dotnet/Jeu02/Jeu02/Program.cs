bool wantExit = false;
int scoreJoueur, scoreOrdi;
scoreJoueur = scoreOrdi = 0;
bool saisieCorrecte = false;
String saisie;
int valSaisie = 0;
do
{
    do
    {
        Console.WriteLine("Veuillez rentrez une valeur entière entre 0 et 2 (ou un nombre négatif pour quitter)");
        saisie = Console.ReadLine().ToLower();
        try
        {
            valSaisie = getSaisie(saisie);
            if (valSaisie < 0)
                wantExit = true;
            else
                saisieCorrecte = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (!saisieCorrecte && !wantExit);
    if (saisieCorrecte)
    {
        gererJeu(ref scoreJoueur,ref scoreOrdi, valSaisie);
        saisieCorrecte = false;
    }
} while (!wantExit && scoreJoueur < 10 && scoreOrdi < 10);
if (!wantExit)
{
    Console.WriteLine(scoreJoueur == 10 ? "Vous avez gagné" : "L'IA a gagné");
}

// -------------------------

int genererAleatoire(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

int getSaisie(String saisie)
{
    int valeur = 0;
    try
    {
        valeur = int.Parse(saisie);
        if (valeur > 2)
        {
            throw new Exception("Valeur incompatible (max 2).");
        }
    }
    catch (Exception ex)
    {
        throw new Exception("Valeur non compatible", ex);
    }

    return valeur;
}


void gererJeu(ref int scoreJoueur, ref int scoreIA, int valJoueur)
{
    int valIA = genererAleatoire(0, 2);
    int difference = Math.Abs(valIA - valJoueur);
    Console.WriteLine("L'IA a choisi " + valIA);
    if (difference == 2)
    {
        if (valIA > valJoueur)
        {
            scoreIA++;
            Console.WriteLine("La difference de 2 est en faveur de l'IA elle gagne 1 point");
        }
        else
        {
            scoreJoueur++;
            Console.WriteLine("La difference de 2 est en votre faveur, vous gagnezs 1 point");

        }
    }
    else if (difference == 1)
    {
        if (valIA < valJoueur)
        {
            scoreIA++;
            Console.WriteLine("La difference de 1 est en faveur de l'IA elle gagne 1 point");
        }
        else
        {
            scoreJoueur++;
            Console.WriteLine("La difference de 1 est en votre faveur, vous gagnezs 1 point");

        }
    }
    else
    {
        Console.WriteLine("Vous avez choisi le meme nombre le score n'a pas changer");
    }
    Console.WriteLine("Le score est de " + scoreJoueur + "(Vous) à " + scoreIA + "(IA)");
}