namespace Dirctionnaire
{
    internal class Program
    {

        enum PneuPosition
        {
            Avant_gauche,
            Avant_droit,
            Arriere_gauche,
            Arriere_droit
        };

        static void Main(string[] args)
        {
            

            Dictionary<PneuPosition,string> myDic= new Dictionary<PneuPosition, string>();
            myDic.Add(PneuPosition.Avant_gauche, "testAG");
            myDic.Add(PneuPosition.Avant_droit, "testAD");
            myDic.Add(PneuPosition.Arriere_gauche, "testRG");
            myDic.Add(PneuPosition.Arriere_droit, "testRD");
            Console.WriteLine(myDic[PneuPosition.Arriere_droit]);

        }
    }
}