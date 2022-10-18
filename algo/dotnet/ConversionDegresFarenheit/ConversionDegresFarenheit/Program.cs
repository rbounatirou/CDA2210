bool wantExit = false;

bool correctUnit;
double minVal = 0, maxVal = 0;
String saisie;
char convertUnit;
do
{
    correctUnit = false;
    do
    {
        Console.WriteLine("Veuillez entrez le type d'unite de mesure depuis lequel vous souhaiter lancer la conversion (C ou F) ou quit pour quitter");
        saisie = Console.ReadLine().ToUpper();
        if (saisie.Equals("quit"))
        {
            wantExit = true;
        }
        else
        {
            if (saisie.Length == 1)
            {
                convertUnit = saisie[0];
                if (convertUnit == 'C' || convertUnit == 'F')
                {
                    correctUnit = true;
                }
                else
                {
                    Console.WriteLine("Veuillez entrer l'unite de conversion C ou F uniquement");
                }
            }
            else
            {
                Console.WriteLine("Veuillez entrer l'unite de conversion C ou F uniquement");
            }
        }
    } while (!correctUnit && !wantExit);
    if (correctUnit)
    {
        Console.WriteLine("Veuillez entrer une plage de valeur dont les valeurs doivent etre comprise entre -459.67 et 50000000 separes par un tiret(ex 12-14)");
        //---
        bool allowedVal = false;
        String[] split;
        do
        {
            saisie = Console.ReadLine().ToLower();
            if (saisie.Equals("quit"))
            {
                wantExit = true;
            }
            else
            {
                split = saisie.Split("-");
                if (split.Count() != 2)
                {
                    Console.WriteLine("Seul deux valeurs peuvent etre entrées");
                   
                }
                try
                {
                    minVal = double.Parse(split[0]);
                    maxVal = double.Parse(split[1]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("une valeur est incorrecte veuillez resaisir");
                }
                double lcMin, lcMax;
                lcMin = (minVal < maxVal ? minVal : maxVal);
                lcMax = (maxVal > minVal ? maxVal : minVal);
            }
        } while (!allowedVal && !wantExit);
        allowedVal = false;
    }
} while (!wantExit);


void lancerConversion(double min, double max, char unite)
{
    if (unite != 'C' && unite != 'F')
        throw new Exception("Unite invalide pour la conversion (C et F) uniquement");
    char uniteTo = (unite == 'C' ? 'F' : 'C');
    if (!valeurAutorisee(min) || !valeurAutorisee(max))
        throw new Exception("La plage de valeur doit etre comprise entre -459.67 et 5000000");
    for (double i = min; i <= max; i++)
    {
        Console.WriteLine(i + unite + " font " + (uniteTo == 'C' ? convertirEnCelsius(i) : convertirEnFarenheit(i)) + uniteTo);
    }
}

bool valeurAutorisee(double val)
{
    return (val >= -459.67 && val <= 5000000);
}



double convertirEnFarenheit(double val)
{
    return 9 * val / 5 + 32;
}

double convertirEnCelsius(double val)
{
    return (val - 32) * 5 / 9;
}
/*double convertir(String saisie)
{
    char lastChar = saisie[saisie.Length - 1];
    double valeur = double.Parse(saisie.Substring(0, saisie.Length - 2));
    double valeurConvertie;
    if (valeur < -459.67 && valeur > 5000000)
    {
        if (lastChar == 'C')
        {
            return 9 * valeur / 5 + 32;
        }
        else if (lastChar == 'F')
        {
            return (valeur - 32) * 5 / 9;
        }
        else
        {
            throw new Exception("Format de saisie incorrect");
        }
    }
    return 0;
}
*/