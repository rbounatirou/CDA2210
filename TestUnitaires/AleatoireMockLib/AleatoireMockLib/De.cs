namespace AleatoireMockLib
{
    public class De
    {
        public De()
        {

        }
        public int LancerDe() => Alea.GetNumber(1, 10);

        public static string Coucou() => "Coucou";

        public string GetMessage() => GetMessage(LancerDe());
        private string GetMessage(int n) 
        {
            int val = LancerDe();

            if (val < 3) // VAL 1,2
                return "Poney";
            if (val < 5) // VAL 3 et 4
                return "Patate";
            if (val < 7)
                return "Licornet";
            if (val < 9)
                return "Pasteque";
            return "Jambon";
        }   
    }
}