using System;
class Flowers
{
    static void Main()
    {
        int chrysanthemums = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int tulips = int.Parse(Console.ReadLine());
        string seoson = Console.ReadLine();
        string holidayOrWork = Console.ReadLine();

        double flowersSum = 0;
        switch (seoson)
        {
            case "Spring":
            case "Summer":
                flowersSum += chrysanthemums * 2.00d;
                flowersSum += roses * 4.10d;
                flowersSum += tulips * 2.50;
                break;
            case "Autumn":
            case "Winter":
                flowersSum += chrysanthemums * 3.75d;
                flowersSum += roses * 4.50d;
                flowersSum += tulips * 4.15d;
                break;
            default:
                break;
        }

        if (holidayOrWork == "Y")
        {
            flowersSum = flowersSum * 1.15d;
        }

        if (tulips > 7 && seoson == "Spring")
        {
            flowersSum = flowersSum - (flowersSum * 5 / 100);
        }

        if (roses >= 10 && seoson == "Winter")
        {
            flowersSum = flowersSum - (flowersSum * 10 / 100);
        }

        if (chrysanthemums + roses + tulips > 20)
        {
            flowersSum = flowersSum - (flowersSum * 20 / 100);
        }

        flowersSum += 2;

        Console.WriteLine($"{flowersSum:F2}");
    }
}