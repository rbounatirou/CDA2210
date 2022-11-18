using ExempleSerialisation;
using System.Text;
using System.Text.Json;

List<Personnel> list = new List<Personnel>();
list.Add(new Personnel("Nakamura","Aya",2000));
list.Add(new Personnel("Rognogne", "Gerard", 40000));
list.Add(new Personnel("Aknouche", "Mathieu", 40000));
list.Add(new Personnel("Devoldere", "Mikael", 40001));

string val = JsonSerializer.Serialize(list);
Console.WriteLine(val);

try
{
    File.WriteAllText("output.json", val);

}
catch (Exception ex)
{
    Console.WriteLine("err" + ex.Message);
}
