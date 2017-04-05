using System;
class HungryGarfield
{
    static void Main()
    {
        double moneyDollars = double.Parse(Console.ReadLine());
        double dollarExchangeRate = double.Parse(Console.ReadLine());
        int pizzaPrice = int.Parse(Console.ReadLine());
        int lasagnaPrice = int.Parse(Console.ReadLine());
        int sandwichPrice = int.Parse(Console.ReadLine());
        int pizzaQuantity = int.Parse(Console.ReadLine());
        int lasagnaQuantity = int.Parse(Console.ReadLine());
        int sandwichQuantity = int.Parse(Console.ReadLine());

        double sum = (pizzaPrice / dollarExchangeRate) * pizzaQuantity
            + (lasagnaPrice / dollarExchangeRate) * lasagnaQuantity
            + (sandwichPrice / dollarExchangeRate) * sandwichQuantity;
        string message = "";
        if (sum <= moneyDollars)
        {
            sum = moneyDollars - sum;
            message = "Garfield is well fed, John is awesome. Money left: $";
        }
        else
        {
            sum -= moneyDollars;
            message = "Garfield is hungry. John is a badass. Money needed: $";
        }
        Console.WriteLine($"{message}{sum:F2}.");
    }
}