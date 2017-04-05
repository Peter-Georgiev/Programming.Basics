using System;

class Pets
{
    static void Main()
    {
        int numberOfDays = int.Parse(Console.ReadLine());
        int foodInKilograms = int.Parse(Console.ReadLine());
        decimal foodDayForDog = decimal.Parse(Console.ReadLine());
        decimal foodDayForCat = decimal.Parse(Console.ReadLine());
        decimal foodDayForTurtle = decimal.Parse(Console.ReadLine());

        decimal foodForDog = numberOfDays * foodDayForDog;
        decimal foodForCat = numberOfDays * foodDayForCat;
        decimal foodForTurtle = numberOfDays * (foodDayForTurtle / 1000.00m);
        decimal foodAll = foodForDog + foodForCat + foodForTurtle;

        string messages = "";
        decimal result = 0.0m;

        if (foodAll <= foodInKilograms)
        {
            messages = "kilos of food left.";
            result = Math.Truncate((decimal)foodInKilograms - foodAll);
        }
        else
        {
            messages = "more kilos of food are needed.";
            result = Math.Ceiling(foodAll - (decimal)foodInKilograms);
        }

        Console.WriteLine($"{result} {messages}");
    }
}