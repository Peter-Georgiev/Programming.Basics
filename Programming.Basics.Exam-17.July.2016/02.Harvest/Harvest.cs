using System;
class Harvest
{
    static void Main()
    {
        int areaIn = int.Parse(Console.ReadLine());
        double grapesIn = double.Parse(Console.ReadLine());
        int wineLiter = int.Parse(Console.ReadLine());
        int workMan = int.Parse(Console.ReadLine());

        double grapesOll = areaIn * grapesIn;
        double wine = 0.4 * grapesOll / 2.5;
        double wineForMarket = Math.Abs(wine - wineLiter);
        double theRemainder = wineForMarket / workMan;

        if (wine < wineLiter)
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineForMarket)} liters wine needed.");
        }

        else
        {
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
            Console.WriteLine($"{Math.Ceiling(wineForMarket)} liters left -> {Math.Ceiling(theRemainder)} liters per person.");
        }
    }
}