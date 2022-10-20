float[] price = new float[100];
String[] productName = new String[100];
byte recordNumber = 0;
bool wantExit = false;
bool wantList = false;
String saisie;
//
do
{
    Console.WriteLine("Veuillez rentrez la liste des produits à enregistrer(max 100), pour les lister tapez go, pour quitter tapez quit");
    do
    {

        saisie = Console.ReadLine().ToLower();
        String[] split = saisie.Split(" ");
        if (split.Count() >= 2) // POMME DE TERRE
        {
            try
            {
                float tmpPrice = float.Parse(split[split.Count()-1]);
                price[recordNumber] = tmpPrice;
                productName[recordNumber] = saisie.Substring(0,saisie.Length-(split[split.Count()-1].Length+1));
                recordNumber++;
            } catch (Exception ex)
            {
                Console.WriteLine("Problème avec le prix du produit, le prix n'a pas pu etre enregistré");
                if (split[1].Split('.').Count() == 2)
                    Console.WriteLine("peut etre voulez vous utiliser la ',' et non pas le '.'");
            }
        } else if (split.Count() == 1)
        {
            if (split[0].Equals("quit"))
                wantExit = true;
            else if (split[0].Equals("go"))
                wantList = true;
        } 
    } while (!wantExit && !wantList);
    if (wantList)
    {
        list(productName, price, recordNumber);
        wantList = false;
        recordNumber = 0;
    }
} while (!wantExit);


byte getMin(float[] prices, byte maxIterator)
{
    byte actualMin = 0;
    for (byte i = 1; i < maxIterator; i++)
    {
        if (prices[i] < prices[actualMin])
            actualMin = i;
    }
    return actualMin;
}

void list(String[] product, float[] price, byte num)
{
    for (byte i = 0; i < num; i++)
    {
        Console.WriteLine(product[i] + " vaut " + price[i]);
    }
    byte min = getMin(price, num);
    Console.WriteLine(product[min] + " est le produit le moins cher au prix de " + price[min]);

}