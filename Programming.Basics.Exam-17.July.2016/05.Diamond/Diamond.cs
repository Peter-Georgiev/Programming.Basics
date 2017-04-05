using System;
class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write(new string('*', n * 5 - n * 2));
        Console.WriteLine(new string('.', n));

        for (int i = n - 1; i > 0; i--)
        {
            Console.Write(new string('.', i) + "*");
            Console.Write(new string('.', n * 5 - i * 2 - 2));
            Console.WriteLine("*" + new string('.', i));
        }

        Console.WriteLine(new string('*', n * 5));

        for (int i = 1; i <= 2 * n + 1; i++)
        {
            Console.Write(new string('.', i) + "*");
            if (i == 2 * n + 1)
            {
                Console.Write(new string('*', n * 5 - i * 2 - 2));
            }
            else
            {
                Console.Write(new string('.', n * 5 - i * 2 - 2));
            }

            Console.WriteLine("*" + new string('.', i));

        }
    }
}