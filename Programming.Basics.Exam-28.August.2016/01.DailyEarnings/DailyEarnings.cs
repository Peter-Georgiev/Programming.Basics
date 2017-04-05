using System;
class DailyEarnings
{
    static void Main()
    {
        int workDayMonth = int.Parse(Console.ReadLine());
        double dayMoney = double.Parse(Console.ReadLine());
        double usdToBGN = double.Parse(Console.ReadLine());

        double monthMoney = workDayMonth * dayMoney;
        double yearMoney = (monthMoney * 12) + (monthMoney * 2.5);
        double moneyVAT = yearMoney - (yearMoney * 25 / 100);
        double yearBGN = (moneyVAT * usdToBGN) / 365;

        Console.WriteLine(Math.Round(yearBGN, 2));
    }
}