using System;

class Battles
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int numberOfBattles = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int i2 = 1; i2 <= secondPlayer; i2++)
            {
                Console.Write($"({i} <-> {i2}) ");

                count++;

                if (numberOfBattles.Equals(count))
                {
                    return;
                }
            }
        }
    }
}