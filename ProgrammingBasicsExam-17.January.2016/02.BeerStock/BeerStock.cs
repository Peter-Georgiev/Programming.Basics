using System;
class BeerStock
{
    static void Main()
    {
        int reservedBeers = int.Parse(Console.ReadLine());

        string shipmentOrEnd = " ";
        long allBeers = 0;

        while (shipmentOrEnd != "Exam Over")
        {
            string[] amountOrType = shipmentOrEnd.Split(' ');
            switch (amountOrType[1])
            {
                case "cases":
                    allBeers += long.Parse(amountOrType[0]) * 24;
                    break;
                case "sixpacks":
                    allBeers += long.Parse(amountOrType[0]) * 6;
                    break;
                case "beers":
                    allBeers += long.Parse(amountOrType[0]);
                    break;
                default:
                    break;
            }
            shipmentOrEnd = Console.ReadLine();
        }

        allBeers = allBeers - (allBeers / 100);

        if (allBeers >= reservedBeers)
        {
            long moreBeers = allBeers - reservedBeers;
            long totalCases = moreBeers / 24;
            long totalBeer = moreBeers % 24;
            long totalSixpack = totalBeer / 6;
            totalBeer = totalBeer % 6;
            Console.WriteLine($"Cheers! Beer left: {totalCases} cases, {totalSixpack} sixpacks and {totalBeer} beers.");
        }
        else
        {
            long moreBeers = reservedBeers - allBeers;
            long totalCases = moreBeers / 24;
            long totalBeer = moreBeers % 24;
            long totalSixpack = totalBeer / 6;
            totalBeer = totalBeer % 6;
            Console.WriteLine($"Not enough beer. Beer needed: {totalCases} cases, {totalSixpack} sixpacks and {totalBeer} beers.");
        }
    }
}