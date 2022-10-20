bool ilFaitBeauDemain = controlerSaisie("Fait-il beau demain?");
if (ilFaitBeauDemain)
{
    bool etatBicyclette = controlerSaisie("J'aimerais donc me balader en bicyclette mais cela fait un moment qu'elle n'a pas servie, sera elle fonctionnelle?");
    if (etatBicyclette)
    {
        Console.WriteLine("Je pourrais donc me balader à vélo");
    } else
    {
        bool reparationImmediate = controlerSaisie("J'emmenerais donc ma bicyclette chez le garagiste, sera il en mesure de la réparer immédiatement?");
        Console.WriteLine(reparationImmediate ? "Je pourrais me balader à bicyclette après le garagiste" :
            "J'irais à pieds jusqu'à l'étang cueillir des joncs");
    }
} else
{
    bool avoirGameOfThrone = controlerSaisie("Je prévois donc de lire le tome 1 de Game Of Throne, est ce qu'il est dans ma bibliothéque ?");
    if (avoirGameOfThrone)
    {

    } else
    {
        bool livreDispo = controlerSaisie("Je pense donc aller à la bibliothéque municipale le chercher, serait il disponnible?");
        Console.WriteLine("Je rentrerais, m'installerais dans un fauteuil et lirais " +
            (livreDispo ? "Game of Throne t1" : "Les aventures du detective Conan") +
            " que j'aurais emprunté à la bibliothéque");  ;

    }
}

bool controlerSaisie(String question)
{
    bool saisieCorrecte = false;
    String saisie = "";
    do
    {
        Console.WriteLine(question);
        saisie = Console.ReadLine().Trim().ToLower();
        if (!(saisie.Equals("oui") || saisie.Equals("non")))
            Console.WriteLine("Saisie incorrecte, veuillez répondre uniquement par oui ou non");
        else
            saisieCorrecte = true;
    } while (!saisieCorrecte);
    return saisie.Equals("oui");
}