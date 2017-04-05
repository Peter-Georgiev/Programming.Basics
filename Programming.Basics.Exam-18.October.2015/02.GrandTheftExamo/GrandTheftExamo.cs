using System;

class GrandTheftExamo
{
    static void Main()
    {
        int attempts = int.Parse(Console.ReadLine());
        
        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long totalBeers = 0;
        
        for (int i = 0; i < attempts; i++)
        {
            int thieves = int.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());

            if (thieves > 5)
            {
                thievesEscaped += thieves - 5;
                thievesSlapped += 5;
                totalBeers += beers;
            }
            else
            {
                thievesSlapped += thieves;
                totalBeers += beers;
            }
        }
        Console.WriteLine($"{thievesSlapped} thieves slapped.");
        Console.WriteLine($"{thievesEscaped} thieves escaped.");
        Console.WriteLine($"{totalBeers / 6} packs, {totalBeers % 6} bottles.");
    }
}