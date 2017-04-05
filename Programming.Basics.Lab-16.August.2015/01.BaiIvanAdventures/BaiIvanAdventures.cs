using System;
class BaiIvanAdventures
{
    static void Main(string[] args)
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        decimal availableMoney = decimal.Parse(Console.ReadLine());
        decimal desiredAmountOfAlcohol = decimal.Parse(Console.ReadLine());

        decimal boughtAlcohol = 0m;
        switch (dayOfWeek)
        {
            case 0: boughtAlcohol = availableMoney / 25.0m; break;
            case 1: boughtAlcohol = availableMoney / 21.0m; break;
            case 2: boughtAlcohol = availableMoney / 14.0m; break;
            case 3: boughtAlcohol = availableMoney / 17.0m; break;
            case 4: boughtAlcohol = availableMoney / 45.0m; break;
            case 5: boughtAlcohol = availableMoney / 59.0m; break;
            case 6: boughtAlcohol = availableMoney / 42.0m; break;
            default:
                break;
        }

        string status = "sober";
        if (boughtAlcohol > 1.5m)
        {
            status = "very drunk";
        }
        else if (boughtAlcohol >= 1.0m)
        {
            status = "drunk";
        }

        if (desiredAmountOfAlcohol < boughtAlcohol)
        {
            Console.WriteLine($"Bai Ivan is {status} and very happy and he shared {boughtAlcohol - desiredAmountOfAlcohol:F2} l. of alcohol with his friends");
        }
        else if (desiredAmountOfAlcohol == boughtAlcohol)
        {
            Console.WriteLine($"Bai Ivan is {status} and happy. He is as drunk as he wanted");
        }
        else
        {
            Console.WriteLine($"Bai Ivan is {status} and quite sad. He wanted to drink another {desiredAmountOfAlcohol - boughtAlcohol:F2} l. of alcohol");
        }
    }
}