using System;

class Fishland
{
    static void Main()
    {
        decimal mackerel = decimal.Parse(Console.ReadLine());
        decimal sprat = decimal.Parse(Console.ReadLine());
        decimal beltedBonito = decimal.Parse(Console.ReadLine());
        decimal scad = decimal.Parse(Console.ReadLine());
        int clams = int.Parse(Console.ReadLine());

        decimal mackerelPrice = mackerel + (mackerel * 0.60m);
        decimal spratPrice = beltedBonito * mackerelPrice;
        decimal beltedBonitoPrice = sprat + (sprat * 0.80m);
        decimal scadPrice = scad * beltedBonitoPrice;
        decimal clamsPrice = clams * 7.50m;
		
        decimal result = Math.Round(spratPrice + scadPrice + clamsPrice, 2);

        Console.WriteLine($"{result:F2}");
    }
}