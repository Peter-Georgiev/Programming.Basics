using System;
class Histogram
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayN = new int[numberN];
        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }

        double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
        for (int i = 0; i < arrayN.Length; i++)
        {
            if (arrayN[i] < 200)
            {
                p1++;
            }
            if (arrayN[i] >= 200 && arrayN[i] <= 399)
            {
                p2++;
            }
            if (arrayN[i] >= 400 && arrayN[i] <= 599)
            {
                p3++;
            }
            if (arrayN[i] >= 600 && arrayN[i] <= 799)
            {
                p4++;
            }
            if (arrayN[i] >= 800)
            {
                p5++;
            }

        }

        Console.WriteLine($"{p1 / numberN * 100:F2}%");
        Console.WriteLine($"{p2 / numberN * 100:F2}%");
        Console.WriteLine($"{p3 / numberN * 100:F2}%");
        Console.WriteLine($"{p4 / numberN * 100:F2}%");
        Console.WriteLine($"{p5 / numberN * 100:F2}%");
    }
}