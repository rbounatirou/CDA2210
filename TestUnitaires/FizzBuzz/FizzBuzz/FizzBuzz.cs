namespace FizzBuzzNamespace
{
    
    public class FizzBuzz
    {
        private int nombre;
        #region constantes
        private const int Premier_Multiple = 3;
        private const int Second_Multipe = 5;
        private const string Premier_Multiple_Message = "Fizz";
        private const string Second_Multiple_Message = "Buzz";
        #endregion
        public FizzBuzz(int _nombre)
        {
            nombre = _nombre;
        }        

        #region Multiples
        private bool EstPremierMultipe() => EstPremierMultipe(this.nombre);
        private static bool EstPremierMultipe(int n) => EstMultiple(n, Premier_Multiple);
        private bool EstSecondMultiple() => EstSecondMultiple(this.nombre);
        private static bool EstSecondMultiple(int n) => EstMultiple(n, Second_Multipe);
        private bool EstMultiple(int diviseur) => EstMultiple(this.nombre, diviseur);
        private static bool EstMultiple(int n, int diviseur) => n % diviseur == 0;
        #endregion

        public string GetMessage() => GetMessage(this.nombre);

        public static string GetMessage(int n)
        {
            if (n == 0)
                return n.ToString();
            if (EstPremierMultipe(n) && EstSecondMultiple(n))
                return Premier_Multiple_Message + Second_Multiple_Message;
            if (EstPremierMultipe(n))
                return Premier_Multiple_Message;
            if (EstSecondMultiple(n))
                return Premier_Multiple_Message;
            return n.ToString();

        }

        public static void TesterFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(FizzBuzz.GetMessage(i));
        }

    }

    
}