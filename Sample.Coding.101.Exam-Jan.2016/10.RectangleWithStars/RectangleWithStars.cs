using System;
class RectangleWithStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('%', n * 2));
        if (n % 2 == 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n - 2));
                if (i == (n - 1) / 2)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write(new string(' ', n - 2));
                Console.WriteLine("%");
            }
        }

        if (n % 2 == 1)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n - 2));
                if (i == (n - 1) / 2)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write(new string(' ', n - 2));
                Console.WriteLine("%");
            }
        }
        Console.WriteLine(new string('%', n * 2));
    }
}