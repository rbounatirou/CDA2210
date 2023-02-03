using System.Text.Json;

namespace Dirctionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] split = "3 2 1 2 1 1".Split(' ');
            string line;
            List<int> entier = new();

            
            List<int> nombres = new();
            List<int> occurences = new();
            int maxOccurence = 0;
            int minOccurence = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < split.Length; i++)
            {
                int cnv = Convert.ToInt32(split[i]);
                /*int ind = nombres.FindIndex(x => x == cnv);
                if (ind >= 0)
                {
                    occurences[ind]++;
                }
                else
                {
                    nombres.Add(cnv);
                    occurences.Add(1);
                    
                }*/
                try
                {
                    map[cnv]++;
                } catch
                {
                    map.Add(cnv, 1);
                }
            }
            
            // CHERCHE MIN ET MAX OCCURENCE
         


            Console.WriteLine(nombres[maxOccurence] - nombres[minOccurence]);


            // Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
        }

    }
}
