/*int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
int[] rt = test.OrderByDescending(x => x).ToArray();

foreach (int i in rt)
{
    Console.WriteLine(i);
}*/


using StackTest;

List<Personne> pers = new List<Personne>();
pers.Add(new Personne("Colonel"));
pers.Add(new Personne("Colone"));
pers.Add(new Personne("Colonelle"));
pers.Add(new Personne("Adrien butterfly"));


foreach(Personne person in pers.OrderBy(x => x).ToArray())
{
    Console.WriteLine(person.Nom);
}