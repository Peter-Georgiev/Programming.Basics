using System;
class ImpressTheGirlfriend
{
    static void Main()
    {
        uint inRubles = uint.Parse(Console.ReadLine());
        uint inDollars = uint.Parse(Console.ReadLine());
        uint inEuro = uint.Parse(Console.ReadLine());
        uint inLevaB = uint.Parse(Console.ReadLine());
        uint inLevaM = uint.Parse(Console.ReadLine());

        decimal rublesToLeva = Math.Ceiling(inRubles / 100m * 3.5m);
        decimal dollarsToLeva = Math.Ceiling(inDollars * 1.5m);
        decimal euroToLeva = Math.Ceiling(inEuro * 1.95m);
        decimal levaB = Math.Ceiling(inLevaB / 2m);
        decimal levaM = inLevaM;
        decimal[] testExpensive = new decimal[] { rublesToLeva, dollarsToLeva, euroToLeva, levaB, levaM };

        decimal expensiveMin = decimal.MinValue;

        for (int i = 0; i < testExpensive.Length; i++)
        {
            if (testExpensive[i] > expensiveMin)
            {
                expensiveMin = testExpensive[i];
            }
        }

        Console.WriteLine($"{expensiveMin:F2}");
    }
}