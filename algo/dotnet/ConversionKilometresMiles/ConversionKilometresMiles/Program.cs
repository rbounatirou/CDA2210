double distance;
String uniteConversion = "km";
bool wantExit = false;
do
{
    Console.WriteLine("Veuillez entrez une valeur à convertir suivie de son unite de mesure(km ou mi)  ou q pour quitter le programme(ex 12 mi)");
    String saisie = Console.ReadLine().ToLower();
    String[] split = saisie.Split(" ");
    if (split.Count() >= 1)
    {
        if (!split[0].Equals("q"))
        {
            try
            {
                double convertValue = convertir(split);
                Console.WriteLine((split.Count() == 2 && split[1].Equals("mi")) ? split[0] + " mi font " + convertValue + " km." :
                    split[0] + " km font " + convertValue + " mi.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } else
        {
            wantExit = true;
        }
    }

} while (!wantExit);


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
    } else
    {
        double[] minMax = { 0.01, 1000000 };
        if (!(distance >= minMax[0] && distance <= minMax[1]))
            throw new Exception("Distance invalide (elle doit etre comprise entre " + minMax[0] + " et " + minMax[1] + " km).");
        return distance / 1.609;
    }
    return 0; 
}