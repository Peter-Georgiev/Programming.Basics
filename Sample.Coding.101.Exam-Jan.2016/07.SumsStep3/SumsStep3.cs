using System;
class SumsStep3
{
    static void Main()
    {
        int countN = int.Parse(Console.ReadLine());

        int sum1 = 0, sum2 = 0, sum3 = 0;
        int sum1Count = 1, sum2Count = 2, sum3Count = 3;
        for (int j = 1; j <= countN; j++)
        {
            int n = int.Parse(Console.ReadLine());

            if (j == sum1Count)
            {
                for (int i = n; i <= n; i += 3)
                {
                    if (i == n)
                    {
                        sum1 += i;
                    }
                }
                sum1Count += 3;
            }

            if (j == sum2Count)
            {
                for (int i = n; i <= n; i += 3)
                {
                    if (i == n)
                    {
                        sum2 += i;
                    }
                }
                sum2Count += 3;
            }

            if (j == sum3Count)
            {
                for (int i = n; i <= n; i += 3)
                {
                    if (i == n)
                    {
                        sum3 += i;
                    }
                }
                sum3Count += 3;
            }
        }

        Console.WriteLine($"sum1 = {sum1}");
        Console.WriteLine($"sum2 = {sum2}");
        Console.WriteLine($"sum3 = {sum3}");
    }
}