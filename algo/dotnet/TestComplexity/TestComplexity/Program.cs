internal class Program
{
    private static void Main(string[] args)
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int j = 0;
        for (int k = 1; k <= i; k++)
        {
            for (int l = 1; l <= i; l *= 2)
            {
                j++;
            }
        }
        Console.WriteLine(String.Format("Find: {0}, Expected: {1}", j, (int)(i * (int)(Math.Log2(i)+1))));
    }
}