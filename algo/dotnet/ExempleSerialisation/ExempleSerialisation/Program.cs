using ExempleSerialisation;
using System.Text;
using System.Text.Json;

CRM CRM = new CRM();
CRM.addPersonne(new Personnel("Nakamura","Aya","01",2000));;
CRM.addPersonne(new Personnel("Rognogne", "Gerard", "01", 40000));
CRM.addPersonne(new Personnel("Aknouche", "Mathieu", "01", 40000));
CRM.addPersonne(new Personnel("Devoldere", "Mikael", "01",40001));

string val = JsonSerializer.Serialize(CRM);
Console.WriteLine(val);

CRM? centre = deserializeFrom("output.json");
Personne? aya = Pers_deserializeFrom("tempTest.json");

try
{
    File.WriteAllText("output.json", val);

}
catch (Exception ex)
{
    Console.WriteLine("err" + ex.Message);
}
Console.WriteLine("end");
static CRM? deserializeFrom(string fp)
{
    String text = File.ReadAllText(fp);

    CRM? rt = JsonSerializer.Deserialize<CRM?>(text);
    return rt;
}


static Personne Pers_deserializeFrom(string fp)
{
    string text = File.ReadAllText(fp);

    Personne rt = JsonSerializer.Deserialize<Personne>(text);
    return rt;
}