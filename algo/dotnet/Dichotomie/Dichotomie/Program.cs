String[] nom = {"Agathe",
"Berthe",
"Chloé",
"Cunégonde",
"Olga",
"Raymonde",
"Sidonie"};

int median = nom.Length;
bool more = false;
bool finded = false;
bool ended = false;
int[] intervalle = { 0, nom.Length };
Console.WriteLine("Quel nom cherchez vous?");
String saisie = Console.ReadLine();
while (!finded && !ended)
{
    int delta = (intervalle[1] - intervalle[0]) / 2;
    if (delta != 0)
    {
        median = intervalle[0] + delta;
        if (nom[median].CompareTo(saisie) > 0)
        {
            intervalle[1] = median;
        }
        else if (nom[median].CompareTo(saisie) < 0)
        {
            intervalle[0] = median;
        }
        else
        {
            finded = true;
        }
    }
    else
        ended = true;
} 
Console.WriteLine(finded ? "trouvé à l'indice " + median : "element non trouvé");