namespace JeuClass
{
    public class Alea : Random
    {
        private static Alea aleaUnique;

        private Alea()
        {
            
        }

        public static Alea GetInstance()
        {
            if (aleaUnique == null)
            {
                aleaUnique= new Alea();
            }
            return aleaUnique;
        }

        public byte DonneNombreAleatoire(byte valeurMinInclue, byte valeurMaxInclue)
        {
            return (byte)this.Next(valeurMinInclue, valeurMaxInclue + 1);
        }
    }
}