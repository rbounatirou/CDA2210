int[] fibonnacci = fibonacci(20);
foreach(int i in fibonnacci)
{
    Console.WriteLine(i);
}

static int[] fibonacci(int n, int[]? args = null)
{
    List<int> values = (args == null ? new List<int>() : args.ToList());
    if (n == 1)
        return new int[] { 1, 2 };
    else
    {
        
        int[] lastStep = fibonacci(n - 1);
        values.AddRange(lastStep);
        int somme = lastStep[lastStep.Length-1] + lastStep[lastStep.Length-2];
        values.Add(somme);
        return values.ToArray();
    }
   
}