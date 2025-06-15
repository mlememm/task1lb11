using System;

class BinaryInverter
{
    public static void Run()
    {
        Console.Write("Введiть бiтовий рядок (0 та 1): ");
        string input = Console.ReadLine();

        Console.Write("З якої позицiї починати замiну (від 0): ");
        int start = int.Parse(Console.ReadLine());

        char[] chars = input.ToCharArray();
        for (int i = start; i < chars.Length; i++)
        {
            if (chars[i] == '0') chars[i] = '1';
            else if (chars[i] == '1') chars[i] = '0';
        }

        Console.WriteLine("Результат: " + new string(chars));
    }
}
class Program
{
    static void Main()
    {
        BinaryInverter.Run();
    }
}