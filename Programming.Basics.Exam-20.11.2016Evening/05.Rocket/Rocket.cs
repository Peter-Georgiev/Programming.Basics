using System;
class Rocket
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', (3 * n) / 2 - i - 1));
            Console.Write("/" + new string(' ', i * 2) + "\\");
            Console.WriteLine(new string('.', (3 * n) / 2 - i - 1));
        }

        Console.Write(new string('.', ((3 * n) - (n * 2)) / 2));
        Console.Write(new string('*', n * 2));
        Console.WriteLine(new string('.', ((3 * n) - (n * 2)) / 2));

        for (int i = 0; i < n * 2; i++)
        {
            Console.Write(new string('.', ((3 * n) - (n * 2)) / 2));
            Console.Write("|" + new string('\\', n * 2 - 2) + "|");
            Console.WriteLine(new string('.', ((3 * n) - (n * 2)) / 2));
        }

        for (int p = 0, i = n / 2; i >= 1; i--, p++)
        {
            Console.Write(new string('.', i));
            Console.Write("/" + new string('*', n * 2 - 2 + p * 2) + "\\");
            Console.WriteLine(new string('.', i));
        }
    }
}