using System;

class GameOfIntervals
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] forEveryMove = new int[number];
        for (int i = 0; i < forEveryMove.Length; i++)
        {
            forEveryMove[i] = int.Parse(Console.ReadLine());
        }

        double countResult = 0;
        double invalidNumber = 0.00;
        double countOne = 0.00, countTwo = 0.00, countThree = 0.00, countFour = 0.00, countFive = 0.00;
        

        for (int i = 0; i < forEveryMove.Length; i++)
        {
            bool isInvalidNum = forEveryMove[i] > 50 || forEveryMove[i] < 0;
            if (isInvalidNum)
            {
                invalidNumber += 1.00;
                countResult /= 2;
            }
            else if (forEveryMove[i] >= 40)
            {
                countFive += 1.00;
                countResult += 100;
            }
            else if (forEveryMove[i] >= 30)
            {
                countFour += 1.00;
                countResult += 50;
            }
            else if(forEveryMove[i] >= 20)
            {
                countThree += 1.00;
                countResult += forEveryMove[i] * 0.40;
            }
            else if (forEveryMove[i] >= 10)
            {
                countTwo += 1.00;
                countResult += forEveryMove[i] * 0.30;
            }
            else if (forEveryMove[i] >= 0)
            {
                countOne += 1.00;
                countResult += forEveryMove[i] * 0.20;
            }
        }

        Console.WriteLine($"{countResult:F2}");
        Console.WriteLine($"From 0 to 9: {(countOne / (double)forEveryMove.Length) * 100:F2}%");
        Console.WriteLine($"From 10 to 19: {(countTwo / (double)forEveryMove.Length) * 100:F2}%");
        Console.WriteLine($"From 20 to 29: {(countThree / (double)forEveryMove.Length) * 100:F2}%");
        Console.WriteLine($"From 30 to 39: {(countFour / (double)forEveryMove.Length) * 100:F2}%");
        Console.WriteLine($"From 40 to 50: {(countFive / (double)forEveryMove.Length) * 100:F2}%");
        Console.WriteLine($"Invalid numbers: {(invalidNumber / (double)forEveryMove.Length) * 100:F2}%");
    }
}