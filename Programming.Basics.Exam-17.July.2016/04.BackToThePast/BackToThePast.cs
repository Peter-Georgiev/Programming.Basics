using System;
class BackToThePast
{
    static void Main()
    {
        double inheritedMoney = double.Parse(Console.ReadLine());
        int yearsLive = int.Parse(Console.ReadLine());

        int yearsEven = 0;
        int yearsOdd = 0;
        int yearsIvan = 18;
        for (int i = 1800; i <= yearsLive; i++)
        {
            if (i % 2 == 0)
            {
                yearsEven += 12000;
            }
            else
            {
                yearsOdd += 12000 + 50 * yearsIvan;
            }
            yearsIvan++;
        }
        double yearsMony = Math.Abs(inheritedMoney - yearsEven - yearsOdd);
        if (yearsEven + yearsOdd <= inheritedMoney)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {yearsMony:F2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {yearsMony:F2} dollars to survive.");
        }
    }
}