using System.Text.RegularExpressions;

bool wrongInput = false;
String userInput = "";
double area = 0;
Console.WriteLine("Please enter the radius with a coma if necessary followed by the angle here is an example: 5,5 3,5");
do
{
    try
    {
        userInput = Console.ReadLine();
        /*
        int[] numbers = Regex.Matches(userInput, @"\d+").Select(m => int.Parse(m.Value)).ToArray();
        */
        MatchCollection mc = Regex.Matches(userInput, "[0-9]+[,]*[0-9]*");
        String[] arr = mc.Cast<String>().ToArray();
        double[] numbers = mc.Select(m => double.Parse(m.Value)).ToArray();
        area = (Math.PI * Math.Pow(numbers[0], 2) * numbers[1]) / 360;
        wrongInput = true;
    }
    catch
    {
        wrongInput = false;
        Console.WriteLine("Wrong input, please retry");
    }
} while (!wrongInput);
Console.WriteLine("the area is equal to: " + area);