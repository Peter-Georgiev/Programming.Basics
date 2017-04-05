using System;

class CarToGo
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        decimal price = 0;
        string messagesClass = "";
        string messagesCar = "";

        if (budget > 500)
        {
            switch (season)
            {
                case "Summer":
                case "Winter":
                    price = budget * 0.90m;
                    messagesClass = "Luxury class";
                    messagesCar = "Jeep";
                    break;
                default:
                    break;
            }
        }
        else if (budget > 100)
        {
            switch (season)
            {
                case "Summer":
                    price = budget * 0.45m;
                    messagesClass = "Compact class";
                    messagesCar = "Cabrio";
                    break;
                case "Winter":
                    price = budget * 0.80m;
                    messagesClass = "Compact class";
                    messagesCar = "Jeep";
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (season)
            {
                case "Summer":
                    price = budget * 0.35m;
                    messagesClass = "Economy class";
                    messagesCar = "Cabrio";
                    break;
                case "Winter":
                    price = budget * 0.65m;
                    messagesClass = "Economy class";
                    messagesCar = "Jeep";
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"{messagesClass}");
        Console.WriteLine($"{messagesCar} - {price:F2}");
    }
}