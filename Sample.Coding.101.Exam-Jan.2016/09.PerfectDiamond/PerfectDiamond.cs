using System;
class PerfectDiamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int k = 1; k < n - i; k++)
            {
                Console.Write(" ");
            }
            for (int y = 0; y < i; y++)
            {
                Console.Write("*");
                for (int p = 0; p < 1; p++)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("*");
        }

        int tempN = n - 2;
        for (int i = 0; i < n - 1; i++, tempN--)
        {
            for (int k = 0; k < i + 1; k++)
            {
                Console.Write(" ");
            }
            for (int y = tempN; y > 0; y--)
            {
                Console.Write("*");
                for (int p = 0; p < 1; p++)
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine("*");
        }
    }
}