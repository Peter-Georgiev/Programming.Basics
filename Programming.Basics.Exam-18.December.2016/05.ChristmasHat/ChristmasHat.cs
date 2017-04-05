using System;
class ChristmasHat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dot = 2 * n - 1;

        Console.Write($"{new string('.', dot)}/|\\");
        Console.WriteLine($"{new string('.', dot)}");
        Console.Write($"{new string('.', dot)}\\|/");
        Console.WriteLine($"{new string('.', dot)}");

        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write($"{new string('.', dot)}");
            Console.Write($"*{new string('-', i)}*");
            Console.Write($"{new string('-', i)}*");
            Console.WriteLine($"{new string('.', dot)}");
            dot--;
        }

        Console.WriteLine(new string('*', 4 * n + 1));
        for (int i = 0; i < 4 * n + 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        Console.WriteLine(new string('*', 4 * n + 1));
    }
}