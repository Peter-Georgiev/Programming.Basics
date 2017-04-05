using System;
class StopNumber
{
    static void Main()
    {
        int endN = int.Parse(Console.ReadLine());
        int startM = int.Parse(Console.ReadLine());
        int stopS = int.Parse(Console.ReadLine());

        for (int i = startM; i >= endN; i--)
        {
            bool stopCount = i == stopS && stopS % 2 == 0 && stopS % 3 == 0;
            if (stopCount)
            {
                break;
            }
            else if (i % 2 == 0 && i % 3 == 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}