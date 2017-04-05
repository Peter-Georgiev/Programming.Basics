using System;
class MaxCombination
{
    static void Main()
    {
        int startN = int.Parse(Console.ReadLine());
        int endN = int.Parse(Console.ReadLine());
        int stopN = int.Parse(Console.ReadLine());

        int stop = 0;
        for (int i1 = startN; i1 <= endN; i1++)
        {
            for (int i2 = startN; i2 <= endN; i2++)
            {
                stop++;
                if (stop > stopN)
                {
                    break;
                }
                Console.Write($"<{i1}-{i2}>");
            }
        }
        Console.WriteLine();
    }
}