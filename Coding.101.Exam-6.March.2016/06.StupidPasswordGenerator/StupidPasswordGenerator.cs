using System;
class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            for (int k = 1; k < n; k++)
            {
                for (int j = 'a'; j < 'a' + l; j++)
                {
                    for (int m = 'a'; m < 'a' + l; m++)
                    {
                        for (int p = Math.Max(i, k) + 1; p <= n; p++)
                        {
                            Console.Write($"{i}{k}{(char)j}{(char)m}{p} ");
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}