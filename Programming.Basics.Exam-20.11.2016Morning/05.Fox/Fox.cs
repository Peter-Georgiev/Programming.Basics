using System;

class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string('*', i) + "\\");
            Console.Write(new string('-', (2 * n + 3) - (2 * i) - 2));
            Console.WriteLine("/" + new string('*', i));
        }

        int lefrOrRight = n / 2;
        for (int i = 0; i < n / 3; i++)
        {
            Console.Write("|" + new string('*', lefrOrRight) + "\\");
            Console.Write(new string('*', (2 * n + 3) - (2 * lefrOrRight) - 4));
            Console.WriteLine("/" + new string('*', lefrOrRight) + "|");
            lefrOrRight++;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string('-', i) + "\\");
            Console.Write(new string('*', (2 * n + 3) - (2 * i) - 2));
            Console.WriteLine("/" + new string('-', i));
        }
    }
}