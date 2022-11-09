using System.Text.Json;
using Yaourts;

Yogurts? yg = loadFromFile("example.json");
Console.WriteLine(AppRun(yg.results.ToList()));


static string AppRun(List<string> results)
{

    List<string> possiblesColor = new List<string>();
    List<int> nbColor = new List<int>();
    for (int i = 0; i < results.Count; i++)
    {
        bool colorFinded = false;
        int j = 0;
        while (!colorFinded && j < possiblesColor.Count)
        {
            if (results[i].Equals(possiblesColor[j]))
            {
                colorFinded = true;
                nbColor[j]++;
            }

            j++;
        }
        if (!colorFinded)
        {
            possiblesColor.Add(results[i]);
            nbColor.Add(1);
        }
    }
    int[] orderOfId = getOrder(nbColor.ToArray());

    return possiblesColor[orderOfId[orderOfId.Length-1]]+" " + possiblesColor[orderOfId[orderOfId.Length - 2]];
}


static int[] getOrder(int[] datas)
{
    int[] rt = new int[datas.Length];  
    for (int i = 0; i < datas.Length; i++)
    {
        rt[i] = i;
    }
    for (int i = 0; i < datas.Length-1; i++)
    {
        for (int j = i+1; j < datas.Length; j++)
        {
            
            if (datas[j] < datas[i])
            {
                int tmpData = datas[i];
                int tmpDataRt = rt[i];
                datas[i] = datas[j];
                datas[j] = tmpData;
                rt[i] = rt[j];
                rt[j] = tmpDataRt;
            }
        }
    }
    return rt;
}


/*static List<string> genererData(int nbData)
{
    List<string> rt = new List<string>();
    string[] color = { "rouge", "jaune", "bleu" };
    // ON GENERE LES COULEUR
    for (int i = 0; i < nbData; i++)
    {
        rt.Add(color[genererAleatoire(0, color.Length - 1)]);
    }
    return rt;
}*/

/*static int genererAleatoire(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max+1);
}*/

/*static int[] countData(string[] possiblesData, List<string> datas)
{
    int[] rt = new int[possiblesData.Length];
    bool finded;
    for (int i = 0; i < datas.Count; i++)
    {
        finded = false;
        int j = 0;
        while (!finded)
        {
            if (datas[i].Equals(possiblesData[j]))
            {
                rt[j]++;
                finded = true;
            }
            j++;
        }
        if (!finded)
            throw new Exception("Non compris dans le jeu d'essai");
    }
    return rt;
}*/

Yogurts? loadFromFile(string filePath)
{
    string text;
    text = File.ReadAllText(filePath);
    Yogurts loadFrom = JsonSerializer.Deserialize<Yogurts>(text);

    return loadFrom;
}
