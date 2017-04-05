using System;

class SumOfTwoNumbers
{
    static void Main()
    {
        int starNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine()); ;
        int magicNumber = int.Parse(Console.ReadLine()); ;

        bool isCombinations = false;
        int countOne = 0;
        int countTwo = 0;
        int combinationsAll = 0, combinations = 0;

        for (int i = starNumber; i <= endNumber; i++)
        {
            for (int i2 = starNumber; i2 <= endNumber; i2++)
            {
                combinationsAll++;
                if (i + i2 == magicNumber)
                {
                    isCombinations = true;
                    countOne = i;
                    countTwo = i2;
                    combinations = combinationsAll;
                    break;
                }
            }

            if (isCombinations)
            {
                break;
            }
        }

        if (isCombinations)
        {
            Console.WriteLine($"Combination N:{combinations} ({countOne} + {countTwo} = {countOne + countTwo})");
        }
        else
        {
            Console.WriteLine($"{combinationsAll} combinations - neither equals {magicNumber}");
        }
    }
}