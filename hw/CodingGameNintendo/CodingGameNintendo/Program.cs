namespace CodingGameNintendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            uint[] a = convertFromString(Console.ReadLine());
            uint[] b = new uint[a.Length];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    b[(i + j) / 32] ^= ((a[i / 32] >> (i % 32)) & (a[j / 32 + size / 32] >> (j % 32)) & 1) << ((i + j) % 32);
                }
            }
            for (int i = 0; i < size / 16; i++)
            {
                if (i > 0)
                {
                    Console.Write(' ');
                }
                Console.Write("{0:x8}", b[i]);
            }
            Console.WriteLine();
        }

        static uint[] convertFromString(string str)
        {
            string[] split = str.Split(' ');
            uint[] rt  = new uint[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                rt[i] = Convert.ToUInt32(split[i], 16);
            }
            return rt;
        }
    }
}