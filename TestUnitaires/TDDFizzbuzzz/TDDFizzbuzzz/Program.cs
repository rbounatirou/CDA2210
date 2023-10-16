namespace TDDFizzbuzz
{
    public class Program
    {

        private static readonly int PremierDiviseur = 3;
        private static readonly int DeuxiemeDiviseur = 5;
        private static readonly string PremierDiviseur_Message = "Fizz";
        private static readonly string DeuxiemeDiviseur_Message = "Buzz";
        public static string FizzBuzzPourUnNombre(int nombre)
        {
            if (nombre % (PremierDiviseur * DeuxiemeDiviseur) == 0)
                return PremierDiviseur_Message + DeuxiemeDiviseur_Message;
            if (nombre % PremierDiviseur == 0)
                return PremierDiviseur_Message;
            if (nombre % DeuxiemeDiviseur == 0)
                return DeuxiemeDiviseur_Message;
            return nombre.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}