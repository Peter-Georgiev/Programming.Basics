using System;
class FlowerShop
{
    static void Main()
    {
        int numberMagnolias = int.Parse(Console.ReadLine());
        int numberHyacinths = int.Parse(Console.ReadLine());
        int numberRoses = int.Parse(Console.ReadLine());
        int numberCactuses = int.Parse(Console.ReadLine());
        double pricesGift = double.Parse(Console.ReadLine());

        double sum = numberMagnolias * 3.25 + numberHyacinths * 4 +
            numberRoses * 3.50 + numberCactuses * 8;
        double vat = sum * 0.05;
        double profit = sum - vat;
        double result;

        if (profit >= pricesGift)
        {
            result = Math.Floor(profit - pricesGift);
            Console.WriteLine($"She is left with {result} leva.");
        }
        else
        {
            result = Math.Ceiling(pricesGift - profit);
            Console.WriteLine($"She will have to borrow {result} leva.");
        }
    }
}