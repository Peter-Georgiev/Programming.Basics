using System;
class Digits
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int hundredN = numberN / 100;
        int tenN = (numberN / 10) % 10;
        int unitN = numberN % 10;
        for (int column = 1; column <= hundredN + tenN; column++)
        {
            for (int row = 1; row <= hundredN + unitN; row++)
            {
                if (numberN % 5 == 0)
                {
                    numberN = numberN - hundredN;
                }
                else if (numberN % 3 == 0)
                {
                    numberN = numberN - tenN;
                }
                else if (numberN % 5 != 0 && numberN % 3 != 0)
                {
                    numberN = numberN + unitN;
                }
                Console.Write($"{numberN} ");
            }
            Console.WriteLine();
        }
    }
}