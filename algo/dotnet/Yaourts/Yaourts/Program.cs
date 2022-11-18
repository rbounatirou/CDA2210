using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Yaourts;


/* CONFIGURATION DU CLIENT HTTP */
HttpClient client = new HttpClient();

client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json"));
var content = await client.GetStringAsync("https://api.devoldere.net/polls/yoghurts/");
string flux = Convert.ToString(content);
Yogurts loadFrom = JsonSerializer.Deserialize<Yogurts>(flux);
Console.WriteLine(AppRun(loadFrom.results.ToList()));

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



Yogurts? loadFromFile(string filePath)
{
    string text;
    text = File.ReadAllText(filePath);
    Yogurts loadFrom = JsonSerializer.Deserialize<Yogurts>(text);

    return loadFrom;
}
