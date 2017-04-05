using System;
class BikeRace
{
    static void Main()
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string layout = Console.ReadLine();

        double sum = 0;
        if (layout == "trail")
        {
            sum = juniors * 5.50 + seniors * 7;
            sum = sum - (sum * 0.05);
        }
        else if (layout == "cross-country")
        {
            sum = juniors * 8 + seniors * 9.50;
            sum = sum - (sum * 0.05);
            if (juniors + seniors >= 50)
            {
                sum = sum - (sum * 0.25);
            }
        }
        else if (layout == "downhill")
        {
            sum = juniors * 12.25 + seniors * 13.75;
            sum = sum - (sum * 0.05);
        }
        else if (layout == "road")
        {
            sum = juniors * 20 + seniors * 21.50;
            sum = sum - (sum * 0.05);
        }

        Console.WriteLine($"{sum:F2}");

    }
}