using System;
class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"/{new string('^', n / 2)}\\{new string('_', n * 2 - ((n / 2) * 2) - 4)}/{new string('^', n / 2)}\\");
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write("|");
            if (i == n - 2)
            {
                Console.Write($"{new string(' ', n / 2 + 1)}");
                for (int j = 0; j < n * 2 - ((n / 2) * 2) - 4; j++)
                {
                    Console.Write("_");
                }
                Console.Write($"{new string(' ', n / 2 + 1)}");
            }
            else
            {
                for (int k = 0; k < n * 2 - 2; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("|");
        }
        Console.WriteLine($"\\{new string('_', n / 2)}/{new string(' ', n * 2 - ((n / 2) * 2) - 4)}\\{new string('_', n / 2)}/");
    }
}