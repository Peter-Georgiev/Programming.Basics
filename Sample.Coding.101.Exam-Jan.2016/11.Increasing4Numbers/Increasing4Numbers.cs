using System;
class Increasing4Numbers
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());
        if (numberB - numberA < 3)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = numberA; i <= numberB; i++)
            {
                for (int k = i + 1; k <= numberB; k++)
                {
                    for (int l = k + 1; l <= numberB; l++)
                    {
                        for (int m = l + 1; m <= numberB; m++)
                        {
                            Console.WriteLine($"{i} {k} {l} {m}");
                        }
                    }
                }
            }
        }
    }
}