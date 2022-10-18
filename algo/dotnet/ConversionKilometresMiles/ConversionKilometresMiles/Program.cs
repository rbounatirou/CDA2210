/*bool isCorrect = true;
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
*/

double distance;
String uniteConversion = "km";
bool isCorrect = false;
do
{
    Console.WriteLine("Veuillez entrez une valeur à convertir suivie de l'unite de mesure (km ou mi)  ou q pour quitter le programme (ex 12 mi).");
    String saisie = Console.ReadLine().ToLower();
    String[] split = saisie.Split(" ");
    if (split.Count() >= 1)
    {
        if (!split[0].Equals("q"))
        {
            try
            {
                convertir(split);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } else
        {

        }
    } else
    {
        try
        {
            distance = double.Parse(split[0]);
            if (distance > 0)
            {
                if (split[1].Equals("km") || split[1].Equals("mi"))
                {
                    if (split[1] != "km")
                    {
                        uniteConversion = split[1];
                        isCorrect = true;
                    }
                    else
                    {
                        uniteConversion = split[1];
                        isCorrect = true;
                    }
                }
                else
                {
                    Console.WriteLine("Mauvaise unite de conversion, les unites acceptes sont km ou mi");
                }
            }
        } catch (Exception e)
        {
            Console.WriteLine("");
        }
    }

} while (!isCorrect);


double convertir(String[] split)
{
    double distance = 0;
    try
    {
        distance = double.Parse(split[0]);
    } catch (Exception e)
    {
        throw new Exception("La donee de distance est incorrecte");
    }
    if (distance <= 0)
        throw new Exception("Distance invalide(<=0)");
    if (split.Count() == 2)
    {
        if (split[1].Equals("km"))
        {
            double[] minMax = { 0.01, 1000000 };
            if (!(distance >= minMax[0] && distance <= minMax[1]))
                throw new Exception("Distance invalide (elle doit etre comprise entre " + minMax[0] + " et " + minMax[1] + " km).");
            return distance / 1.609;
        }
        else if (split[1].Equals("mi"))
        {
            double[] minMax = { 0.01 / 1.609, 1000000 / 1.609 };
            if (!(distance >= minMax[0] && distance <= minMax[1]))
                throw new Exception("Distance invalide (elle doit etre comprise entre " + minMax[0] + " et " + minMax[1] + " mi).");
            return distance * 1.609;
        }
        else
        {
            throw new Exception("Unite de mesure invalide (km ou mi seulement)");
        }
    }
    return 0; 
}