using System;

class MasterHerbalist
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());
        string information = Console.ReadLine();

        int totalMoney = 0;
        int day = 0;

        while (information != "Season Over")
        {
            string[] infSplit = information.Split();
            string path = infSplit[1];
            int herb = 0;

            for (int i = 0; i < int.Parse(infSplit[0]); i++)
            {
                if (path[i % path.Length] == 'H')
                {
                    herb++;
                }
            }
            day++;
            totalMoney += herb * int.Parse(infSplit[2]);
            information = Console.ReadLine();
        }

        decimal perDay = (decimal)totalMoney / day;

        if (perDay >= dailyExpenses)
        {
            perDay = perDay - dailyExpenses;
            Console.WriteLine($"Times are good. Extra money per day: {perDay:F2}.");
        }
        else
        {
            int moneyNeeded = dailyExpenses * day;
            moneyNeeded = moneyNeeded - totalMoney;
            Console.WriteLine($"We are in the red. Money needed: {moneyNeeded}.");
        }
    }
}