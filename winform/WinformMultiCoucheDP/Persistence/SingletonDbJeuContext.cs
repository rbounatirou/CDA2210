using Persistence.Models;

namespace IHMDP
{
    public class SingletonDbJeuContext
    {
        private static DbJeuContext context;
        private SingletonDbJeuContext()
        {
            context = new DbJeuContext();
        }

        public static DbJeuContext GetInstance()
        {
            if (context == null)
                new SingletonDbJeuContext();
            return context;
        }
    }
}
