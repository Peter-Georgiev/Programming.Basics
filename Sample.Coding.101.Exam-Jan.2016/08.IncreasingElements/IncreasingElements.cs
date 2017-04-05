using System;
class IncreasingElements
{
    static void Main()
    {
        int countN = int.Parse(Console.ReadLine());
        int temp = 0, min = 0, maxSum = 0;

        for (int i = 0; i < countN; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > min)
            {
                temp = temp + 1;
            }
            else if (n <= min)
            {
                temp = 1;
            }
            if (temp > maxSum)
            {
                maxSum = temp;
            }
            min = n;
        }

        Console.WriteLine(maxSum);
    }
}